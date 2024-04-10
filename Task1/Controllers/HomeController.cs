using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        static int usersNumber = 0;
        static List<string> currentSessionIds = new();



        //[HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("key", usersNumber++);
            string currentSessionId = HttpContext.Session.Id;
            if (!currentSessionIds.Contains(currentSessionId))
            {
                currentSessionIds.Add(currentSessionId);
            }
            /*var test = HttpContext.Session;
            if (!currentSessions.Contains(test))
            {
                currentSessions.Add(HttpContext.Session);
            }
            var def = default(ISession);
            var res = currentSessions.Find(s => !s.IsAvailable);
            //if (currentSessions.Find(s => !s.IsAvailable) == default(ISession))
            if (res != def)
            {
                foreach (var session in currentSessions)
                {
                    if (!session.IsAvailable)
                    {
                        currentSessions.Remove(session);
                    }
                }
            }*/
            //return View(_userCounter.UserCount);
            return View(currentSessionIds.Count);
            //return View(usersNumber);
        }
        public IActionResult Privacy()
        {
            return View();
        }

/*
        public void IncrementOnlineUsersCount()
        {
            usersNumber++;
        }

        public void DecrementOnlineUsersCount()
        {
            usersNumber--;
        }*/
    }
}
