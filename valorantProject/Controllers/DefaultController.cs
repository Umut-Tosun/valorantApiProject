using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using valorantProject.Models;
using valorantProject.Models.Class;

namespace valorantProject.Controllers
{
    public class DefaultController : Controller
    {
       
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialMaps()
        {
            var values = c.Maps.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialStreamers()
        {

            var values = c.Streamers.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAgent()
        {
            WebClient client = new WebClient();

            var json = client.DownloadString("https://valorant-api.com/v1/agents");
            ValorantAgent agentList = JsonConvert.DeserializeObject<ValorantAgent>(json);

            return PartialView(agentList);
        }
        public PartialViewResult PartialTier()
        {
            WebClient client = new WebClient();

            var json = client.DownloadString("https://valorant-api.com/v1/competitivetiers");
            Root tierList = JsonConvert.DeserializeObject<Root>(json);

            return PartialView(tierList);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialContact(Contact contact)
        {

            contact.date = DateTime.Now;
            c.Contacts.Add(contact);
            c.SaveChanges();
            return PartialView();
        }

      
        public PartialViewResult PartialHead()
        {
           
            return PartialView();
        }
        public PartialViewResult PartialDashboard()
        {
            return PartialView();
        }
        public PartialViewResult PartialWelcome()
        {
            return PartialView();
        }
    }
}
