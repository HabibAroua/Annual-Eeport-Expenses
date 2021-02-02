using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operations;

namespace Report.Collection
{
    class Operation
    {
        DataGridView Data =new DataGridView();
        Analyzer analyzer ;

        public Operation(DataGridView Data)
        {
            this.Data = Data;
            this.analyzer = new Analyzer();
        }

        public double SumCost()
        {
            return 0;
        }

        public void AddLine(string month)
        {
            try
            {
                this.analyzer.MyData.Month = month;
                for (int i = 0; i < (Data.RowCount-1); i++)
                {
                    Model.Line R = new Model.Line();
                    R.Activity = Data.Rows[i].Cells[0].Value.ToString();
                    R.Benefit = Data.Rows[i].Cells[1].Value.ToString();
                    R.Cost = double.Parse(Data.Rows[i].Cells[2].Value.ToString());
                    R.Cost_with_foreign_currency = double.Parse(Data.Rows[i].Cells[3].Value.ToString());
                    R.Date = Data.Rows[i].Cells[4].Value.ToString();
                    this.analyzer.MyData.Reports.Add(R);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("You should enter a number value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
