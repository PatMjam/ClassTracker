using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTracker.Entities
{
    public class TafeClass
    {
        public int TafeClassId { get; set; }
        public string TafeClassName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? dateTime { get; set; }
        public int? DurationMinutes { get; set; }

        //Foreign Key

        public int TeacherId { get; set; }

        //Navigation Properties
        public  Teacher Teacher { get; set; }// it belongs to a single teacher one to many one to many

        public  ICollection<Unit> Units { get; set; }



    }
}
