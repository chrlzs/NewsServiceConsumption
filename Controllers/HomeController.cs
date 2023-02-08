using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Covid.Models;
using System.Net.Mail;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Covid.Controllers
{
    public class HomeController : Controller
    {
        private const string NEWS = @"news.json";
        private const string URL = @"https://[ YOUR SUBDOMAIN ].cognitiveservices.azure.com/bing/v7.0/news";
        private const string API_KEY = @"TODO: Get API KEY FROM AZURE";
        private const string SUBSCRIPTION_LABEL = @"Ocp-Apim-Subscription-Key";
        private string urlParameters = "?count=20";
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;

        public async Task GetNews()
        {

            var webRoot = _env.WebRootPath;
            var newsFile = webRoot + NEWS;
            //get the file.
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add(SUBSCRIPTION_LABEL, API_KEY);

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var json = await JsonSerializer.DeserializeAsync<object>(await response.Content.ReadAsStreamAsync());

                Debug.WriteLine("{0}", json.ToString());
                System.IO.File.WriteAllText(newsFile, json.ToString());
            }
            else
            {
                ViewBag.Message = "Error " + (int)response.StatusCode + ": " + response.ReasonPhrase;
                Debug.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();
            ProcessNews();
        }

        public void ProcessNews()
        {
            var webRoot = _env.WebRootPath;
            var newsFile = webRoot + NEWS;
            Debug.WriteLine("Processing the news");
            if (System.IO.File.Exists(newsFile))
            {
                using System.IO.StreamReader file = System.IO.File.OpenText(newsFile);
                using JsonTextReader reader = new JsonTextReader(file);
                JObject jObject = (JObject)JToken.ReadFrom(reader);
                JArray stories = (JArray)jObject["value"];
                List<NewsItemViewModel> news = new List<NewsItemViewModel>();
                foreach (var story in stories)
                {
                    JObject jNewsStory = story as JObject;
                    NewsItemViewModel newsItem = jNewsStory.ToObject<NewsItemViewModel>();
                    news.Add(newsItem);
                }
                ViewData["News"] = news;
            }
        }

        public async Task<IActionResult> IndexAsync()
        {
            var webRoot = _env.WebRootPath;
            var newsFile = webRoot + NEWS;
            //check if the news file exists
            if (!System.IO.File.Exists(newsFile))
            {
                await GetNews();
            }
            else
            {
                //check the time-stamp of the file
                //if it is older than today, get a new file
                DateTime creationTime = System.IO.File.GetCreationTime(newsFile);
                if (DateTime.Today != creationTime.Date)
                {
                    //fetch a new file
                    await GetNews();
                }
                else
                {
                    //process the news
                    ProcessNews();
                }
            }
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(contact.Email);
                    msg.To.Add("cbronson@gmail.com");
                    msg.Subject = contact.Subject;
                    msg.Body = contact.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "localhost";

                    //smtp.Port = 587;
                    //smtp.Credentials = new System.Net.NetworkCredential("youremail@contoso.com", "password");
                    //smtp.EnableSsl = true;

                    smtp.Send(msg);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $"Error {ex.Message}";
                }
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
