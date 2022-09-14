using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using valorantProject.Models.Class;

namespace valorantProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Streamers.ToList();
            return View(values);
        }
        public ActionResult DeleteStreamer(int id)
        {
            var streamer = c.Streamers.Find(id);
            if (streamer.status == true)
                c.Streamers.Find(id).status = false;
            else
                c.Streamers.Find(id).status = true;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetStreamer(int id)
        {
            var streamer = c.Streamers.Find(id);
            return View("GetStreamer", streamer);
        }
        public ActionResult UpdateStreamer(Streamers streamers)
        {
            var strm = c.Streamers.Find(streamers.ID);
            strm.Description = streamers.Description;
            strm.Name = streamers.Name;
            strm.Image = streamers.Image;
            strm.YoutubeUrl = streamers.YoutubeUrl;
            strm.TwitchUrl = streamers.TwitchUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddStreamer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStreamer(Streamers streamers)
        {
            streamers.status = true;
            c.Streamers.Add(streamers);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ListContact()
        {
            var values = c.Contacts.ToList();
            return View(values);
        }
        public ActionResult GetContact(int id)
        {
            var contact = c.Contacts.Find(id);
            return View("GetContact", contact);
        }
        public ActionResult UpdateContact(Contact contact)
        {
            contact.isRead = true;
            var strm = c.Contacts.Find(contact.ID);
            strm.isRead = contact.isRead;
            c.SaveChanges();
            return RedirectToAction("ListContact");
        }
    }
}