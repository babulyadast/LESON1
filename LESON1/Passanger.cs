﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESON1
{
    internal class Passanger
    {
        [Key]
        public int IdPassanger { get; set; }  
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
