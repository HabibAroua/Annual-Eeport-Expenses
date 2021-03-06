﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Line
    {

        public Line(string Activity , string Benefit , double Cost , double Cost_with_foreign_currency , string Date)
        {
            this.Activity = Activity;
            this.Benefit = Benefit;
            this.Cost = Cost;
            this.Cost_with_foreign_currency = Cost_with_foreign_currency;
            this.Date = Date;
        }

        public Line()
        {
            //Nothing
        }

        public string Activity
        {
            get;
            set;
        }

        public string Benefit
        {
            get;
            set;
        }

        public double Cost
        {
            get;
            set;
        }

        public double Cost_with_foreign_currency
        {
            get;
            set;
        }

        public string Date
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString()+
                "Activity : "+this.Activity+", " +
                "Benefit : "+this.Benefit+", " +
                "Cost : "+this.Cost+", " +
                "Cost With Foregin Currency : "+this.Cost_with_foreign_currency+", "+
                "Date : "+this.Date;
        }
    }
}
