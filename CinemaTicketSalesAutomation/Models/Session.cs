﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Models
{
    public class Session
    {
        public Session()              //constructor oluşturduk başlangıç değerlerini atamak için
        {
            SetDefaultChairs();
        }
        public string date { get; set; }
        public string time { get; set; }
        public List<Chair> chairs { get; set; }

        private void SetDefaultChairs()
        {
            chairs = new List<Chair>();
            string[] rows = { "a", "b", "c", "d" };
            string[] numbers = { "1", "2", "3", "4", "5", "6"};
            foreach (string row in rows)
            {
                foreach (string number in numbers)
                {
                    Chair chair = new Chair(row, number);
                    chairs.Add(chair);
                }
            }
        }

    }
}
