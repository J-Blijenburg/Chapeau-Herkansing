﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public int TableId { get; set; }
        public int Number { get; set; }
        public TableStatus Status { get; set; }
        public int UndeliveredOrdersCount { get; set; }

        public int GetNumber()
        {
            return Number;
        }   
    }
}
