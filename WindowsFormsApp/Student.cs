using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Serializable] //attribute
    public class Student
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public int StudFee { get; set; }
        public string SDepartment { get; set; }
    }
}
