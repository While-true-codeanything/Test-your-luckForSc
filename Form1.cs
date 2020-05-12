using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_your_luck
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int numbertr;
        private double right;
        private static Random r = new Random();
        public Form()
        {
            numbertr = 0;
            right = 0;
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Data.Text))
            {
                try { 
                int cur = r.Next(0,10);
                    if (cur == int.Parse(Data.Text))
                    {
                        Result.Text = "You guessed";
                        right++;
                    }
                    else
                    {
                        Result.Text = "You did not guess";
                    }
                    Result.Visible = true;
                    Hidden.Visible = true;
                    Hidden.Text = ""+cur;
                    numbertr++;
                    CurCol.Text = numbertr%10 + "/10";
                    if (numbertr % 10==0)
                    {
                        Info3.Visible = true;
                        Cof.Visible = true;
                        Cof.Text =""+ Math.Round(right / 10.0,2);
                        right = 0;
                    }
                    else
                    {
                        Info3.Visible = false;
                        Cof.Visible = false;
                    }
                }
                catch
                {
                    Result.Text = "Enter numeric data";
                    Result.Visible = true;
                }
            }
        }
    }
}
