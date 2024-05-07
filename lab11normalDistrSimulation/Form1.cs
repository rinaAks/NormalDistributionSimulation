using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;

namespace lab11normalDistrSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public List<int> statistics = new List<int>();
        public List<double> normalDistrValues = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            statistics.Clear(); normalDistrValues.Clear();
            chart1.Series[0].Points.Clear();

            lbMean.Text = "Матожидание: ";
            lbVar.Text = "Дисперсия: ";
            lbHiSqv.Text = "Критерий хи квадрат: ";

            int sampleSize = (int)numSize.Value;
            double meanTheor = (double)numMean.Value;
            double varTheor = (double)numVariance.Value;

            normalDistrValues = new List<double>(new double[sampleSize]);

            for (int i = 0; i < sampleSize; i++)
            {
                double value = (double)rnd.NextDouble();
                double value2 = (double)rnd.NextDouble();
                value = Math.Sqrt(-2.0 * Math.Log10(value)) * Math.Cos(2.0 * Math.PI * value2); // Generator based on Box-Muller transform
                normalDistrValues[i] = varTheor * value + meanTheor;
                
            }
            double sampleMin, sampleMax, binsWidth;
            int binsN;
            //binsN = (int)Math.Sqrt(sampleSize);
            binsN = (int)Math.Log(sampleSize, 2) + 1; // Sturges' formula
            tbDebug.Text = binsN.ToString();
            statistics = new List<int>(new int[binsN]);

            sampleMin = normalDistrValues.Min();
            sampleMax = normalDistrValues.Max();
            binsWidth = Math.Abs(sampleMax - sampleMin) / binsN; 

            for (int i = 0; i < sampleSize; i++)
            {
                //normalDistrValues[i] = varTheor * normalDistrValues[i] + meanTheor;
                for (int j = 0; j < binsN; j++)
                {
                    if (normalDistrValues[i] < sampleMin + binsWidth * j)
                    {
                        statistics[j] += 1;
                        break;
                    }
                }
            }

            double mean = 0, disp = 0, hi_sqv = 0;
            for (int i = 0; i < binsN; i++)
            {
                chart1.Series[0].Points.AddXY(sampleMin+binsWidth*i, statistics[i]/(double)sampleSize);

            }
            mean = normalDistrValues.Sum();
            mean /= sampleSize;

            for (int i = 0; i < sampleSize; i++)
            {
                disp += normalDistrValues[i] * normalDistrValues[i];
            }

            disp = disp / sampleSize;
            disp -= mean * mean;
            for (int i = 0; i < binsN; i++)
            {
                double a = sampleMin + i * binsWidth;
                double b = a + binsWidth;
                var distribution = new Normal(mean, Math.Sqrt(disp));
                double probability = distribution.CumulativeDistribution(b) - distribution.CumulativeDistribution(a);

                hi_sqv += (statistics[i] * statistics[i])
                    / (probability * sampleSize);
                //hi_sqv += (double)statistics[i] * (double)statistics[i] / ((double)sampleSize * normalDistrValues[i]);
            }


            hi_sqv -= sampleSize;

            lbMean.Text += mean + " (погрешность: " + Math.Round((mean * 100 / meanTheor - 100), 2) + "% )";
            lbVar.Text += disp + " (погрешность: " + Math.Round((disp * 100 / varTheor - 100), 2) + "% )";
            lbHiSqv.Text += Math.Round(hi_sqv, 2);

            //так как size = 5, берём  из таблички значение для size-1, т.е. 9.488
            if (hi_sqv > ChiSquared.InvCDF(binsN, 0.95))
            {
                lbHiSqv.Text += " > "+ ChiSquared.InvCDF(binsN, 0.95) + ", плохо!";
            }
            else
            {
                lbHiSqv.Text += " <= " + ChiSquared.InvCDF(binsN, 0.95) + ", хорошо!";
            }
        }

    }

    

}
