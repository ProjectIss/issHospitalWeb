﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issHospital_Utility.DTOs
{
   public class ItemSetupDTO
    {
        public int Id { get; set; }
        public int Reorder { get; set; }
        public int Tax { get; set; }
        public int price { get; set; }
        public string Menu { get; set; }
        public string Commcode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
