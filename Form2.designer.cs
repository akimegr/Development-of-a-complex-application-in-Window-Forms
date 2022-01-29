namespace Lab13
{
    partial class ColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScrollRed = new System.Windows.Forms.VScrollBar();
            this.ScrollGreen = new System.Windows.Forms.VScrollBar();
            this.ScrollBlue = new System.Windows.Forms.VScrollBar();
            this.colorPreview = new System.Windows.Forms.Panel();
            this.preview = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.RValue = new System.Windows.Forms.Label();
            this.GValue = new System.Windows.Forms.Label();
            this.BValue = new System.Windows.Forms.Label();
            this.RPreview = new System.Windows.Forms.Panel();
            this.GPreview = new System.Windows.Forms.Panel();
            this.BPreview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ScrollRed
            // 
            this.ScrollRed.LargeChange = 1;
            this.ScrollRed.Location = new System.Drawing.Point(45, 23);
            this.ScrollRed.Maximum = 255;
            this.ScrollRed.Name = "ScrollRed";
            this.ScrollRed.Size = new System.Drawing.Size(30, 325);
            this.ScrollRed.TabIndex = 0;
            this.ScrollRed.Value = 255;
            this.ScrollRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollRed_Scroll);
            // 
            // ScrollGreen
            // 
            this.ScrollGreen.LargeChange = 1;
            this.ScrollGreen.Location = new System.Drawing.Point(129, 23);
            this.ScrollGreen.Maximum = 255;
            this.ScrollGreen.Name = "ScrollGreen";
            this.ScrollGreen.Size = new System.Drawing.Size(30, 325);
            this.ScrollGreen.TabIndex = 1;
            this.ScrollGreen.Value = 246;
            this.ScrollGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollGreen_Scroll);
            // 
            // ScrollBlue
            // 
            this.ScrollBlue.LargeChange = 1;
            this.ScrollBlue.Location = new System.Drawing.Point(215, 23);
            this.ScrollBlue.Maximum = 255;
            this.ScrollBlue.Name = "ScrollBlue";
            this.ScrollBlue.Size = new System.Drawing.Size(30, 325);
            this.ScrollBlue.TabIndex = 2;
            this.ScrollBlue.Value = 255;
            this.ScrollBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBlue_Scroll);
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.Color.White;
            this.colorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreview.Location = new System.Drawing.Point(45, 478);
            this.colorPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(186, 68);
            this.colorPreview.TabIndex = 3;
            // 
            // preview
            // 
            this.preview.AutoSize = true;
            this.preview.Location = new System.Drawing.Point(75, 458);
            this.preview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(125, 17);
            this.preview.TabIndex = 4;
            this.preview.Text = "Полученный цвет";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R.ForeColor = System.Drawing.Color.Red;
            this.R.Location = new System.Drawing.Point(55, 348);
            this.R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(30, 29);
            this.R.TabIndex = 5;
            this.R.Text = "R";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.ForeColor = System.Drawing.Color.Blue;
            this.B.Location = new System.Drawing.Point(225, 348);
            this.B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 29);
            this.B.TabIndex = 6;
            this.B.Text = "B";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.G.ForeColor = System.Drawing.Color.Lime;
            this.G.Location = new System.Drawing.Point(137, 348);
            this.G.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(31, 29);
            this.G.TabIndex = 7;
            this.G.Text = "G";
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.Location = new System.Drawing.Point(171, 554);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(100, 28);
            this.ChangeColorButton.TabIndex = 8;
            this.ChangeColorButton.Text = "Применить";
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(31, 554);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 28);
            this.Close.TabIndex = 9;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(12, 332);
            this.max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(32, 17);
            this.max.TabIndex = 10;
            this.max.Text = "255";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(28, 23);
            this.min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(16, 17);
            this.min.TabIndex = 11;
            this.min.Text = "0";
            // 
            // RValue
            // 
            this.RValue.AutoSize = true;
            this.RValue.Location = new System.Drawing.Point(12, 169);
            this.RValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RValue.Name = "RValue";
            this.RValue.Size = new System.Drawing.Size(32, 17);
            this.RValue.TabIndex = 12;
            this.RValue.Text = "255";
            // 
            // GValue
            // 
            this.GValue.AutoSize = true;
            this.GValue.Location = new System.Drawing.Point(92, 169);
            this.GValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GValue.Name = "GValue";
            this.GValue.Size = new System.Drawing.Size(32, 17);
            this.GValue.TabIndex = 13;
            this.GValue.Text = "255";
            // 
            // BValue
            // 
            this.BValue.AutoSize = true;
            this.BValue.Location = new System.Drawing.Point(177, 169);
            this.BValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(32, 17);
            this.BValue.TabIndex = 14;
            this.BValue.Text = "255";
            // 
            // RPreview
            // 
            this.RPreview.BackColor = System.Drawing.Color.White;
            this.RPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPreview.Location = new System.Drawing.Point(53, 382);
            this.RPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RPreview.Name = "RPreview";
            this.RPreview.Size = new System.Drawing.Size(31, 28);
            this.RPreview.TabIndex = 4;
            // 
            // GPreview
            // 
            this.GPreview.BackColor = System.Drawing.Color.White;
            this.GPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPreview.Location = new System.Drawing.Point(137, 382);
            this.GPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPreview.Name = "GPreview";
            this.GPreview.Size = new System.Drawing.Size(31, 28);
            this.GPreview.TabIndex = 5;
            // 
            // BPreview
            // 
            this.BPreview.BackColor = System.Drawing.Color.White;
            this.BPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BPreview.Location = new System.Drawing.Point(223, 382);
            this.BPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BPreview.Name = "BPreview";
            this.BPreview.Size = new System.Drawing.Size(31, 28);
            this.BPreview.TabIndex = 5;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 597);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.BPreview);
            this.Controls.Add(this.GPreview);
            this.Controls.Add(this.RPreview);
            this.Controls.Add(this.BValue);
            this.Controls.Add(this.GValue);
            this.Controls.Add(this.RValue);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.G);
            this.Controls.Add(this.B);
            this.Controls.Add(this.R);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.colorPreview);
            this.Controls.Add(this.ScrollBlue);
            this.Controls.Add(this.ScrollGreen);
            this.Controls.Add(this.ScrollRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColorForm";
            this.Text = "Фон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar ScrollRed;
        private System.Windows.Forms.VScrollBar ScrollGreen;
        private System.Windows.Forms.VScrollBar ScrollBlue;
        private System.Windows.Forms.Panel colorPreview;
        private System.Windows.Forms.Label preview;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label RValue;
        private System.Windows.Forms.Label GValue;
        private System.Windows.Forms.Label BValue;
        private System.Windows.Forms.Panel RPreview;
        private System.Windows.Forms.Panel GPreview;
        private System.Windows.Forms.Panel BPreview;
    }
}