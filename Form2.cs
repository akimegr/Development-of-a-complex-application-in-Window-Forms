using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class ColorForm : Form
    {
        MainForm parentForm;
        ColorForm settingsForm;
        bool wasChanged = false;


        public ColorForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            settingsForm = this;

            ChangeSettingsColor(parentForm);
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            parentForm.BackColor = colorPreview.BackColor;
            //settingsForm.Visible = false;
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (!wasChanged)
                ChangeSettingsColor(parentForm);
            
            this.Close();
            //settingsForm.Visible = false;
        }

        private void ChangeSettingsColor(MainForm parent)
        {
            ScrollRed.Value = parent.BackColor.R;
            ScrollGreen.Value = parent.BackColor.G;
            ScrollBlue.Value = parent.BackColor.B;

            RValue.Text = ScrollRed.Value.ToString();
            GValue.Text = ScrollGreen.Value.ToString();
            BValue.Text = ScrollBlue.Value.ToString();

            RPreview.BackColor = Color.FromArgb(ScrollRed.Value, 0, 0);
            GPreview.BackColor = Color.FromArgb(0, ScrollGreen.Value, 0);
            BPreview.BackColor = Color.FromArgb(0, 0, ScrollBlue.Value);

            colorPreview.BackColor = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);
        }

        private void ScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            RValue.Text = ScrollRed.Value.ToString() ;
            RPreview.BackColor = Color.FromArgb(ScrollRed.Value, 0, 0);
            colorPreview.BackColor = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);
        }

        private void ScrollGreen_Scroll(object sender, ScrollEventArgs e)
        {
            GValue.Text = ScrollGreen.Value.ToString();
            GPreview.BackColor = Color.FromArgb(0, ScrollGreen.Value, 0);
            colorPreview.BackColor = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);
        }

        private void ScrollBlue_Scroll(object sender, ScrollEventArgs e)
        {
            BValue.Text = ScrollBlue.Value.ToString();
            BPreview.BackColor = Color.FromArgb(0, 0, ScrollBlue.Value);
            colorPreview.BackColor = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);
        }
    }
}
