using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13laboratorySecond
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox_Num.Text);
            Double Average = 0;
            Double AverageReal = 0;
            Double Varience = 0;
            Double VarienceReal = 0;
            Double Chi = 0;
            int m = 1;
            List<Double> prob = new List<Double>(1000);
            chart1.Series["Series1"].Points.Clear();
            prob.Add(double.Parse(textBox_Param.Text));
            Double sum = prob[0];
            Double min = prob[0];

            for (; m < 3; m++)
            {
                prob.Add(prob[0] * Math.Pow((1 - prob[0]), m));
                sum += prob[m];
                if (prob[m] < min)
                    min = prob[m];
            }
            while (true)
            {
                Double ost = 1 - sum;
                if (ost < min)
                {
                    prob.Add(ost);
                    break;
                }
                prob.Add(prob[0] * Math.Pow((1 - prob[0]), m));
                sum += prob[m];
                if (prob[m] < min)
                    min = prob[m];
                m++;
            }


            int[] Statistic = new int[m + 1];
            for (int i = 0; i <= m; i++)
            {
                Statistic[i] = 0;
            }
            double[] Frequency = new double[m + 1];//получившаяся вероятность


            for (int i = 0; i < num; i++)
            {
                Statistic[Event(rnd.NextDouble(), prob)]++;
            }

            for (int i = 0; i <= m; i++)
            {
                Frequency[i] = Statistic[i] / (double)num;
                chart1.Series["Series1"].Points.AddY(Frequency[i]);
            }

            for (int i = 0; i <= m; i++)//мат. ожидание полученное
            {
                Average += (i + 1) * Frequency[i];
            }
            textBox_Average.Text = Average.ToString();

            for (int i = 0; i <= m; i++)//мат. ожидание реальное
            {
                AverageReal += (i + 1) * prob[i];
            }
            double mistAv = (Math.Abs(AverageReal - Average) / AverageReal) * 100;

            textBox_Average_Error.Text = (Math.Round(mistAv)).ToString() + " %";

            for (int i = 0; i <= m; i++)//дисперсия полученная
            {
                Varience += (i + 1) * (i + 1) * Frequency[i];
            }
            Varience -= Average * Average;
            textBox_Varience.Text = Varience.ToString();

            for (int i = 0; i <= m; i++)//дисперсия реальная
            {
                VarienceReal += (i + 1) * (i + 1) * prob[i];
            }
            VarienceReal -= AverageReal * AverageReal;

            double mistVa = Math.Abs(((VarienceReal - Varience) / VarienceReal) * 100);
            textBox_Varience_Error.Text = (Math.Round(mistVa)).ToString() + " %";

            for (int i = 0; i <= m; i++)//Хи квадрат
            {
                Chi += ((Statistic[i] * Statistic[i]) / (num * prob[i]));
            }
            Chi -= num;
            bool k = false;
            if (Chi < 11.07)
                k = true;
            textBox_Chi_Squared.Text = Math.Round(Chi, 4).ToString() + "  " + k;

            int Event(double random, List<Double> Prob)
            {
                int j = 0;

                //double r = random;

                random -= Prob[j];
                while (random > 0 && j <= m)
                {
                    j++;
                    random -= Prob[j];
                }

                return j;
            }
        }
    }
}
