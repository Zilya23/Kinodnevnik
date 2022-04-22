using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Film
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public System.DateTime Date_Issue { get; set; }
    }
}
