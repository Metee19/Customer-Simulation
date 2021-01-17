using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer:CustomerManager
    {
        public int id { get; set; }
        public string name  { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public double moneyInBank { get; set; }
        

    }
}
