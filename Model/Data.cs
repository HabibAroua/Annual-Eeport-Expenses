using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        public string Month
        {
            get;
            set;
        }

        public List<Line> Reports
        {
            get;
            set;
        }

        public Data(string Month)
        {
            this.Month = Month;
            Reports = new List<Line>();
        }

        public Data()
        {
            Reports = new List<Line>();
        }

    }
}
