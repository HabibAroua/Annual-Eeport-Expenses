using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        public Report [] Reports
        {
            get;
            set;
        }

        public Data()
        {
            Reports = new Report[12];
        }

    }
}
