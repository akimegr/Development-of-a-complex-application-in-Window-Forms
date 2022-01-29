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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;


namespace Lab13
{
    public partial class Form3 : Form
    {
        public MainForm form1;

        public Form3(MainForm mainForm)
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(176, 0, 0);
            button2.BackColor = Color.FromArgb(176, 0, 0);
            form1 = mainForm;
            string[] lines = { "Пунктирная", "Сплошная", "Точечная" };
            string[] types = { "Тип диаграммы с областями", "Линейчатая", "Сплайн" };
            string[] colours = { "Розовый", "Зелёный", "Красный", "Жёлтый", "Синий" };
            comboBox1.Items.AddRange(lines);
            comboBox2.Items.AddRange(types);
            listBox1.Items.AddRange(colours);
            listBox2.Items.AddRange(colours);
        }

        public void lines(ComboBox comboBox1)
        {
            if (form1.chart == null)
            {
                MessageBox.Show("Вы не нарисовали график!");
                return;
            }

            string str = Convert.ToString(comboBox1.SelectedItem);
            switch (str)
            {
                case "Пунктирная":
                    form1.chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                    form1.chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                    break;
                case "Сплошная":
                    form1.chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                    form1.chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                    break;
                case "Точечная":
                    form1.chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                    form1.chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                    break;
            } 
        }

        public void graphic(ComboBox comboBox2)
        {
            if (form1.chart == null)
            {
                MessageBox.Show("Вы не нарисовали график!");
                return;
            }

            string str = Convert.ToString(comboBox2.SelectedItem);
            switch (str)
            {
                case "Сплайн":
                    form1.chart.Series[0].ChartType = SeriesChartType.Spline;
                    form1.chart.Series[1].ChartType = SeriesChartType.Spline;
                    break;
                case "Тип диаграммы с областями":
                    form1.chart.Series[0].ChartType = SeriesChartType.Area;
                    form1.chart.Series[1].ChartType = SeriesChartType.Area;
                    break;
                case "Линейчатая":
                    form1.chart.Series[0].ChartType = SeriesChartType.Bar;
                    form1.chart.Series[1].ChartType = SeriesChartType.Bar;
                    break;
            }
        }

        public void colours(ListBox listBox1)
        {
            if (form1.chart == null)
            {
                MessageBox.Show("Вы не нарисовали график!");
                return;
            } 

            string str = Convert.ToString(listBox1.SelectedItem);
            switch (str)
            {
                case "Розовый":
                    form1.chart.Series[0].Color = Color.DeepPink;
                    break;
                case "Зелёный":
                    form1.chart.Series[0].Color = Color.LightGreen;
                    break;
                case "Красный":
                    form1.chart.Series[0].Color = Color.IndianRed;
                    break;
                case "Жёлтый":
                    form1.chart.Series[0].Color = Color.Yellow;
                    break;
                case "Синий":
                    form1.chart.Series[0].Color = Color.Blue;
                    break;
            }
        }

        public void colours1(ListBox listBox2)
        {
            if (form1.chart == null)
            {
                MessageBox.Show("Вы не нарисовали график!");
                return;
            }

            string str = Convert.ToString(listBox2.SelectedItem);
            switch (str)
            {
                case "Розовый":
                    form1.chart.Series[1].Color = Color.DeepPink;
                    break;
                case "Зелёный":
                    form1.chart.Series[1].Color = Color.LightGreen;
                    break;
                case "Красный":
                    form1.chart.Series[1].Color = Color.IndianRed;
                    break;
                case "Жёлтый":
                    form1.chart.Series[1].Color = Color.Yellow;
                    break;
                case "Синий":
                    form1.chart.Series[1].Color = Color.Blue;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphic(comboBox2);
            colours(listBox1);
            colours1(listBox2);
            lines(comboBox1);
            if (textBox1.Text.Length > 0)
            {
                form1.chart.Series[0].BorderWidth = Convert.ToInt32(textBox1.Text);
                form1.chart.Series[1].BorderWidth = Convert.ToInt32(textBox1.Text);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.chart.Series[0].Color = Color.IndianRed;
            form1.chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            form1.chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            form1.chart.Series[0].ChartType = SeriesChartType.Spline;
            form1.chart.Series[1].ChartType = SeriesChartType.Spline;
            form1.chart.Series[0].BorderWidth = 2;
            form1.chart.Series[1].BorderWidth = 2;
            form1.chart.Series[0].Color = Color.IndianRed;
            form1.chart.Series[1].Color = Color.Blue;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На данной форме Вы можете изменить основные параметры по интерфейсной части графика. Если Вас всё устраивает в текущем графике, нажмите кнопку 'По умолчанию'", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }


}
