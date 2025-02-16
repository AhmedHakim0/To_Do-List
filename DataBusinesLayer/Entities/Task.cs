using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinesLayer
{
    public class Task
    {
        public  int id { get; set; }
        public  string Title { get; set; }

        public  string T_State { get; set; }

        public  DateTime Dur_From { get; set; }

        public  DateTime Dur_To { get; set; }
        public  string  T_Description { get; set; }


    }
}
