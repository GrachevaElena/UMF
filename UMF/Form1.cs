using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMF
{
    public partial class Form1 : Form
    {
        public enum FuncType
        {
            Function,
            Series
        }

        Random random = new Random();

        double a = 0, b = 2;
        int NIter = 10, index = -1, grUsl = -1;
        List<Function> funcs=new List<Function>();
        double yMin = Double.MaxValue, yMax = Double.MinValue;
        
        public Form1()
        {
            InitializeComponent();
            funcs.Add(new FunctionS01());
            funcs.Add(new FunctionC01());
            funcs.Add(new FunctionD01());
            textBox1.Text = NIter.ToString();
        }

        private void radioButtonS01_CheckedChanged(object sender, EventArgs e)
        {
            index = 0;
        }

        private void radioButtonC01_CheckedChanged(object sender, EventArgs e)
        {
            index = 1;
        }

        private void radioButtonD01_CheckedChanged(object sender, EventArgs e)
        {
            index = 2;
        }

        private void radioButtonNU1_CheckedChanged(object sender, EventArgs e)
        {
            grUsl = 1;
        }

        private void radioButtonNU2_CheckedChanged(object sender, EventArgs e)
        {
            grUsl = 2;
        }

        private void radioButtonNU3_CheckedChanged(object sender, EventArgs e)
        {
            grUsl = 3;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (!NParse()) return;
            if (radioButtonNone.Checked) ShowF(funcs[index], FuncType.Function);
            else ShowF(funcs[index], FuncType.Series);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

        private bool NParse()
        {
            if (Int32.TryParse(textBox1.Text, out NIter) && NIter > 0)
                return true;
            else MessageBox.Show("Неверное число N");
            return false;
        }

        void ClearChart()
        {
            chart1.Series.Clear();
            yMin = Double.MaxValue;
            yMax = Double.MinValue;
        }

        public void ShowF(Function f, FuncType type)
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series s1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            int N = 1000;
            double eps = 0.00005;
            double[] x = new double[N], x1 = new double[N];
            double[] y = new double[N], y1 = new double[N];
            for (int i = 0; i < N; i++)
            {
                x[i] = (1.0 - eps) / (N - 1) * i;
                x1[i] = x[i] + 1;
                if (type == FuncType.Function)
                {
                    y[i] = f.Calc(x[i]);
                    y1[i] = f.Calc(x1[i]);
                }
                else
                {
                    y[i]= f.Calc(x[i], grUsl, NIter);
                    y1[i] = f.Calc(x1[i], grUsl, NIter);
                }
            }

            yMax = Math.Max(Math.Max(yMax, y.Max()), y1.Max());
            yMin = Math.Min(Math.Min(yMin, y.Min()), y1.Min());

            s1.Color = s.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            s.Points.DataBindXY(x, y);
            s1.Points.DataBindXY(x1, y1);
            s.BorderWidth = s1.BorderWidth = 2;

            chart1.Series.Add(s);
            chart1.Series.Add(s1);
            chart1.ChartAreas[0].AxisX.Minimum = a;
            chart1.ChartAreas[0].AxisX.Maximum = b;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.###";
            chart1.ChartAreas[0].AxisY.Minimum = yMin;
            chart1.ChartAreas[0].AxisY.Maximum = yMax;
        }
    }
}
