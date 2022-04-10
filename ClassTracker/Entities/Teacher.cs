using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTracker.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhone { get; set; }


        //Navigation Properties
        public ICollection<TafeClass> TafeClasses { get; set; }


    }
}
