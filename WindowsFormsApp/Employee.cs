﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Serializable]
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public  int EmpSalary { get; set; }
    }
}
