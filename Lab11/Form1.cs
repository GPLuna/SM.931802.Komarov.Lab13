using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        Statistic_count SC = new Statistic_count();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p1 = (double)param1.Value;
            double p2 = p1 * (1 - p1);
            double p3 = p2 * (1 - p1);
            double p4 = p3 * (1 - p1);
            double[] prob = new double[4] { p1, p2, p3, p4 };
            double N = (double)number.Value;
            double[] freq = new double[4] { 0, 0, 0, 0 };
            double[] stat = new double[4] { 0, 0, 0, 0 };
            for (int i = 1; i <= (int)N; i++)
            {
                double value = SC.GetData(p1);
                if (value == 0)
                {
                    stat[0]++;
                }
                if (value == 1)
                {
                    stat[1]++;
                }
                if (value == 2)
                {
                    stat[2]++;
                }
                if (value > 2)
                {
                    stat[3]++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                freq[i] = stat[i] / (double)number.Value;
            }

            int[] X = new int[4] { 0, 1, 2, 3 };
            chart1.Series["Series1"].Points.DataBindXY(X, freq);

            double math_av = 0;
            double av = 0;

            double[] events = new double[4] { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                math_av += (double)prob[i] * events[i];
                av += (double)freq[i] * events[i];
            }

            double math_var = 0;
            double var = 0;
            for (int i = 0; i < 4; i++)
            {
                math_var += (double)prob[i] * Math.Pow((events[i] - math_av), 2);
                var += (double)freq[i] * Math.Pow((events[i] - av), 2);
            }

            double error_av = Math.Abs(((math_av - av) / math_av) * 100);
            double error_var = Math.Abs(((math_var - var) / math_var) * 100);

            average.Text = Math.Round(av, 3).ToString();
            variance.Text = Math.Round(var, 3).ToString();
            error1.Text = Convert.ToString(error_av);
            error2.Text = Convert.ToString(error_var);
            double chi_square = 0;
            double chi_square_norm = 9.488;

            for (int i = 0; i < 3; i++)
            {
                chi_square += Math.Pow(stat[i] - N * prob[i], 2) / (N * prob[i]);
            }

            if (chi_square > chi_square_norm)
            {
                chi.Text = Math.Round(chi_square, 3).ToString() + " > " + chi_square_norm.ToString();
                state.Text = "Is false";
            }
            else
            {

                chi.Text = Math.Round(chi_square, 3).ToString() + " <= " + chi_square_norm.ToString();
                state.Text = "Is true";
            }
        }
    }
    public class Statistic_count
    {
        Random r = new Random();
        public int GetData(double p)
        {
            double alpha = r.NextDouble();
            double x = Math.Log(alpha) / Math.Log(1 - p);
            return (int)x;
        }
    }
}
