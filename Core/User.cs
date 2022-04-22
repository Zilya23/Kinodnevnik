using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class User
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int User_Level { get; set; }
        public byte[] Photo { get; set; }
        public int Count_XP { get; set; }
    }
}
