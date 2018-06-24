using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSoulBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "GSoulBot_bot";

        public static string Key { get; set; } = "575091797:AAG8LC113beaklD0RpAg9Cr1IdNlqm8D36w";
    }
}