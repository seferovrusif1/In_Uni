﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_init_record.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public int[] Result { get; set; }

    }
}
