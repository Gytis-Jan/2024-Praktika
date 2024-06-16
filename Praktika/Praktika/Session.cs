using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class Session
    {
        public static class UserSession
        {
            public static int UserId { get; set; }
            public static string Vardas { get; set; }
            public static string Pavarde { get; set; }
            public static string TelNr { get; set; }
            public static string AK { get; set; }
        }
    }
}
