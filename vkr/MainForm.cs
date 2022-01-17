using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace vkr
{
    public partial class MainForm : Form
    {
        private Random rnd;

        private int A, // Входящий поток
                    D, // Поток обслуженных заявок
                    N, // Кол-во обрабатывающих приборов в системе
                    n, // Кол-во обрабатывающих приборов в момент t
                    KSi, // Кол-во заявок в системе в момент t
                    F; // Поток ушедших заявок

        private double lya, // Интенсивность входящего потока 
                        mu, // Интенсивность обслуживания  
                        delta, // Шаг времени  
                        tV, // Максимальное время ожидания в очереди
                        T; // Время моделирования

        private Series LineA, LineD, LineF, LineKSi, LineN; // Линии отображения на графике

        private List<double> moment; // Список времени поступления заявки
        private List<double> wait; // Список ожидания заявки (если -1 то ожидания нет и заявка сразу обслуживается)

        public MainForm()
        {
            InitializeComponent();
            FunVisible(false);
        }

        // Выполнение программы
        private void FunExec()
        {
            FunInit();
            labelTau.Text = "";
            labelSigma.Text = "";
            labelSum.Text = "";
            if (checkBoxLineClear.Checked)
            {
                FunRemSeries();
            }
            FunAddSeries();

            for (double t = .0; t < T + delta; t += delta)
            {
                LineA.Points.AddXY(t, A);
                LineD.Points.AddXY(t, D);
                LineF.Points.AddXY(t, F);
                LineKSi.Points.AddXY(t, KSi);
                LineN.Points.AddXY(t, n);

                if (FunUp(lya) == 1)
                {
                    A++;
                    moment.Add(t);
                    if (KSi >= N)
                    {
                        double temp = rnd.NextDouble() * tV;
                        wait.Add(temp);
                        labelTau.Text += Convert.ToString(Math.Round(temp, 2)) + "  ";
                        labelSigma.Text += Convert.ToString(Math.Round(t, 2)) + "  ";
                        labelSum.Text += Convert.ToString(Math.Round(temp + t, 2)) + " ";
                    }
                    else
                    {
                        wait.Add(-1);
                    }
                }
                KSi = A - D - F;

                // n 
                n = (Math.Min(KSi, N));

                // D
                int tempD = FunUp(n * mu);
                D += tempD;
                if ((tempD == 1) && (moment.Count() > 0))
                {
                    moment.RemoveAt(0);
                    wait.RemoveAt(0);
                }

                // F
                for (int i = 0; i < moment.Count(); i++)
                {
                    if (((moment[i] + wait[i]) <= t) && (wait[i] != -1) && (i + 1 > N))
                    {
                        moment.RemoveAt(i);
                        wait.RemoveAt(i);
                        F++;
                    }
                }
                KSi = A - D - F;

                LineA.Points.AddXY(t, A);
                LineD.Points.AddXY(t, D);
                LineF.Points.AddXY(t, F);
                LineKSi.Points.AddXY(t, KSi);
                LineN.Points.AddXY(t, n);
            }
        }

        // Отображение объектов в форме
        private void FunVisible(bool isVisible)
        {
            chartA.Visible = isVisible;
            chartD.Visible = isVisible;
            chartF.Visible = isVisible;
            chartKSi.Visible = isVisible;
            chartN.Visible = isVisible;
            groupBoxInfo.Visible = isVisible;
        }

        // Функция скачка
        private int FunUp(double intensity)
        {
            double h = rnd.NextDouble();
            return ((h >= (0.5 - delta * intensity)) && (h < 0.5)) ? 1 : 0;
        }

        // Cчитывания значений с формы
        private void FunInit()
        {
            A = 0;
            D = 0;
            F = 0;
            KSi = 0;
            n = 0;

            moment = new List<double>();
            wait = new List<double>();

            rnd = new Random();

            N = Convert.ToInt32(textBoxN.Text);
            T = Convert.ToDouble(textBoxT.Text.Replace('.', ','));
            delta = Convert.ToDouble(textBoxDelta.Text.Replace('.', ','));
            lya = Convert.ToDouble(textBoxLya.Text.Replace('.', ','));
            mu = Convert.ToDouble(textBoxMu.Text.Replace('.', ','));
            tV = Convert.ToDouble(textBoxTV.Text.Replace('.', ','));

            // проверка на введенные корректные данные
            // сравниваем с погрешностью, а не с 0 из-за особенностей хранения дробных чисел
            double time = 0.000000001;
            if ((T < time) || (N < 0) || (delta < time) || (lya < time) || (mu < time))
            {
                throw new Exception();
            }
        }

        // Добавление и настройка серий
        private void FunAddSeries()
        {
            // A
            LineA = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = Convert.ToInt32(textBoxSizeLine.Text)
            };
            chartA.Series.Add(LineA);
            chartA.ChartAreas[0].AxisX.Minimum = 0;
            chartA.ChartAreas[0].AxisX.Maximum = T;
            chartA.ChartAreas[0].AxisY.Minimum = 0;
            if (Convert.ToInt32(textBoxYMaxA.Text) <= 0)
            {
                throw new Exception();
            }
            chartA.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(textBoxYMaxA.Text);

            // D
            LineD = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = Convert.ToInt32(textBoxSizeLine.Text)
            };
            chartD.Series.Add(LineD);
            chartD.ChartAreas[0].AxisX.Minimum = 0;
            chartD.ChartAreas[0].AxisX.Maximum = T;
            chartD.ChartAreas[0].AxisY.Minimum = 0;
            if (Convert.ToInt32(textBoxYMaxD.Text) <= 0)
            {
                throw new Exception();
            }
            chartD.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(textBoxYMaxD.Text);

            // F
            LineF = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = Convert.ToInt32(textBoxSizeLine.Text)
            };
            chartF.Series.Add(LineF);
            chartF.ChartAreas[0].AxisX.Minimum = 0;
            chartF.ChartAreas[0].AxisX.Maximum = T;
            chartF.ChartAreas[0].AxisY.Minimum = 0;
            if (Convert.ToInt32(textBoxYMaxF.Text) <= 0)
            {
                throw new Exception();
            }
            chartF.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(textBoxYMaxF.Text);

            // KSi
            LineKSi = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = Convert.ToInt32(textBoxSizeLine.Text)
            };
            chartKSi.Series.Add(LineKSi);
            chartKSi.ChartAreas[0].AxisX.Minimum = 0;
            chartKSi.ChartAreas[0].AxisX.Maximum = T;
            chartKSi.ChartAreas[0].AxisY.Minimum = 0;
            if (Convert.ToInt32(textBoxYMaxKSi.Text) <= 0)
            {
                throw new Exception();
            }
            chartKSi.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(textBoxYMaxKSi.Text);

            // n
            LineN = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = Convert.ToInt32(textBoxSizeLine.Text)
            };
            chartN.Series.Add(LineN);
            chartN.ChartAreas[0].AxisX.Minimum = 0;
            chartN.ChartAreas[0].AxisX.Maximum = T;
            chartN.ChartAreas[0].AxisY.Minimum = 0;
            if (Convert.ToInt32(textBoxYMaxN.Text) <= 0) throw new Exception();
            chartN.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(textBoxYMaxN.Text);
        }

        // Очистка серий
        private void FunRemSeries()
        {
            chartA.Series.Clear();
            chartD.Series.Clear();
            chartF.Series.Clear();
            chartKSi.Series.Clear();
            chartN.Series.Clear();
        }
        private void ButtonExec_Click(object sender, EventArgs e)
        {
            try
            {
                FunExec();
                FunVisible(true);
            }
            catch (Exception)
            {
                FunVisible(false);
                MessageBox.Show("Не коррекнто указаны входные данные");
            }
        }
    }
}
