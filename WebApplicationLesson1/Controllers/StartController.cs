using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace WebApplicationLesson1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            var hour = DateTime.Now.Hour;
            if (hour < 6)
            {
                return "Доброй ночи";
            }
            if (hour < 12)
            {
                return "Доброе утро";
            }
            if (hour < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }
    }
}
