using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class MainForm : Form
    {
        Class1 INI = new Class1("config.ini");
        ColorForm colorSettingsForm;
        Form3 form3;

        int[] size = { 19, 12 };

        private double XMin;
        private double XMax;
        private double H;

        public int tableCalculations;

        private double[] x;
        private double[] y1;
        private double[] y2;

        public Chart chart;

        public MainForm()
        {
            InitializeComponent();
            tableCalculations = Convert.ToInt32((Convert.ToDouble(Max.Text) - Convert.ToDouble(Min.Text)) / Convert.ToDouble(textBox1.Text));
        }

        private void BuildGraph()

        {
            int count = (int)Math.Ceiling((XMax - XMin) / H) + 1; //точность (плавность) графика

            x = new double[count];
            y1 = new double[count];
            y2 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = Math.Round((XMin + H * i), 2);
                y1[i] = Math.Round(Math.Sin(x[i]), 2);
                y2[i] = Math.Round(Math.Cos(x[i]), 2);
            }
        }
        private void CreateChart()
        {
            chart = Graph;    // Создание окна для графиков

            chart.SetBounds(size[0], size[1], 711, 547);  // размеры окна

            Series seriesSIN = new Series(); // Создаём объект для первого графика
            seriesSIN.ChartArea = "Functions";
            seriesSIN.ChartType = SeriesChartType.Spline;
            seriesSIN.BorderWidth = 3;
            seriesSIN.Color = Color.Red;
            seriesSIN.LegendText = "sin(x)"; // Название графика для отображения в легенде
            chart.Series.Add(seriesSIN); // Добавляем график в окно

            Series seriesCOS = new Series();
            seriesCOS.ChartArea = "Functions";
            seriesCOS.ChartType = SeriesChartType.Spline;
            seriesCOS.BorderWidth = 3;
            seriesCOS.Color = Color.Blue;
            seriesCOS.LegendText = "cos(x)";
            chart.Series.Add(seriesCOS);

            Legend legend = new Legend(); // объект для названий
            chart.Legends.Add(legend);
        }

        private void CreateMatrix()
        {
            if (!sinLabel.Visible && !cosLabel.Visible)
            {
                sinLabel.Visible = true;
                cosLabel.Visible = true;
            }

            SinMatrix.Rows.Clear();          //remove all rows
            SinMatrix.Columns.Clear();       //remove all columns

            CosMatrix.Rows.Clear();
            CosMatrix.Columns.Clear();

            double delta = (XMax - XMin) / tableCalculations;
            double x = XMin;

            SinMatrix.Columns.Add("column", "X");
            SinMatrix.Columns.Add("column", "Y");
            SinMatrix.Rows.Add(tableCalculations + 1);

            CosMatrix.Columns.Add("column", "X");
            CosMatrix.Columns.Add("column", "Y");
            CosMatrix.Rows.Add(tableCalculations + 1);

            for (int i = 0; i <= tableCalculations; i++)
            {
                SinMatrix.Rows[i].Cells[0].Value = x;
                SinMatrix.Rows[i].Cells[1].Value = Math.Round(Math.Sin(x), 2);

                CosMatrix.Rows[i].Cells[0].Value = x;
                CosMatrix.Rows[i].Cells[1].Value = Math.Round(Math.Cos(x), 2);

                x += delta;
                x = Math.Round(x, 3);
            }
        }
       
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0 || TabControl.SelectedIndex == 2)
            {
                TextBox[] InputFields = { Min, Max, textBox1 };

                for (int i = 0; i < InputFields.Length; i++)
                {
                    if (InputFields[i].Text == "" || !checkDigitInput(InputFields[i]))
                    {
                        MessageBox.Show("Error, invalid input!" + Environment.NewLine +
                            "Can't create a graph, error values!" + Environment.NewLine);
                        return;
                    }
                }

                if (chart is null)
                    CreateChart();

                if (XMin > XMax)
                {
                    MessageBox.Show("Xmin must be < Xmax!");
                    return;
                }

                XMin = Math.Round(Convert.ToDouble(Min.Text), 3);
                XMax = Math.Round(Convert.ToDouble(Max.Text), 3);
                H = Math.Round(Convert.ToDouble(textBox1.Text), 3);

                BuildGraph();
                chart.Series[0].Points.DataBindXY(x, y1); // рисуем 1-ый график
                chart.Series[1].Points.DataBindXY(x, y2); // рисуем 2-ой график

                ChartArea area = new ChartArea();
                area.Name = "Functions";
                area.AxisX.Minimum = XMin;  // Задаём левую и 
                area.AxisX.Maximum = XMax;  // правую границы оси X
                area.AxisX.MajorGrid.Interval = H; // Определяем шаг сетки
                area.AxisX.Title = "Ось X";//подписи осей
                area.AxisY.Title = "Ось Y";//подписи осей

                chart.ChartAreas.Clear();
                chart.ChartAreas.Add(area); // Добавляем область в окно
            }
            else
            {
                TextBox[] InputFields = { Min, Max };

                for (int i = 0; i < InputFields.Length; i++)
                {
                    if (InputFields[i].Text == "" || !checkDigitInput(InputFields[i]))
                    {
                        MessageBox.Show("Error, invalid input!" + Environment.NewLine +
                            "Xmin and Xmax must be numbers!" + Environment.NewLine);
                        return;
                    }
                }

                XMin = Math.Round(Convert.ToDouble(Min.Text), 2);
                XMax = Math.Round(Convert.ToDouble(Max.Text), 2);

                if (XMin > XMax)
                {
                    MessageBox.Show("Xmin must be < Xmax!");
                    return;
                }

                CreateMatrix();
            }
        }


        bool checkDigitInput(TextBox inputField)
        {
            if (inputField is null || inputField.Text == "")
                return false;

            if (!Char.IsDigit(inputField.Text[0]) && inputField.Text[0] != '-')
                return false;

            int count = 0;

            for (int i = 1; i < inputField.Text.Length; i++)
            {
                if (!Char.IsDigit(inputField.Text[i]))
                {
                    if ((inputField.Text[i] == ',' || inputField.Text[i] == '.') && count == 0)
                        count++;
                    else
                        return false;
                }
            }
            return true;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            INI.WriteINI("Parameter of X_MIN", "String", Min.Text);
            INI.WriteINI("Parameter of X_MAX", "String", Max.Text);
            INI.WriteINI("Parameter of H", "String", textBox1.Text);
            MessageBox.Show("Настройки Parameters сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            auto_read();
        }

        private void auto_read()
        {
            Min.Text = INI.ReadINI("Parameter of X_MIN", "String");
            Max.Text = INI.ReadINI("Parameter of X_MAX", "String");
            textBox1.Text = INI.ReadINI("Parameter of H", "String");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            colorSettingsForm = new ColorForm(this);
            colorSettingsForm.ShowDialog();
        }

        private void tabPageChart_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
