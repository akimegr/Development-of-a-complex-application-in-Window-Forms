namespace Lab13
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Меню = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSpreadsheet = new System.Windows.Forms.TabPage();
            this.cosLabel = new System.Windows.Forms.Label();
            this.sinLabel = new System.Windows.Forms.Label();
            this.CosMatrix = new System.Windows.Forms.DataGridView();
            this.SinMatrix = new System.Windows.Forms.DataGridView();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.Меню.SuspendLayout();
            this.tabPageSpreadsheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CosMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinMatrix)).BeginInit();
            this.tabPageChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Меню);
            this.TabControl.Controls.Add(this.tabPageSpreadsheet);
            this.TabControl.Controls.Add(this.tabPageChart);
            this.TabControl.Location = new System.Drawing.Point(13, 40);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(972, 708);
            this.TabControl.TabIndex = 2;
            this.TabControl.Tag = "Graph";
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Меню
            // 
            this.Меню.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Меню.Controls.Add(this.label4);
            this.Меню.Controls.Add(this.textBox1);
            this.Меню.Controls.Add(this.label3);
            this.Меню.Controls.Add(this.Max);
            this.Меню.Controls.Add(this.label2);
            this.Меню.Controls.Add(this.Min);
            this.Меню.Controls.Add(this.label1);
            this.Меню.Location = new System.Drawing.Point(4, 25);
            this.Меню.Name = "Меню";
            this.Меню.Size = new System.Drawing.Size(964, 679);
            this.Меню.TabIndex = 2;
            this.Меню.Text = "Меню";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(232, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(507, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите данные для графиков";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(480, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(324, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "H_STEP";
            // 
            // Max
            // 
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Max.Location = new System.Drawing.Point(480, 302);
            this.Max.Margin = new System.Windows.Forms.Padding(4);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(112, 36);
            this.Max.TabIndex = 8;
            this.Max.Text = "6,014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(324, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "X_MAX";
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Min.Location = new System.Drawing.Point(480, 193);
            this.Min.Margin = new System.Windows.Forms.Padding(4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(112, 36);
            this.Min.TabIndex = 7;
            this.Min.Text = "-6,014";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(324, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "X_MIN";
            // 
            // tabPageSpreadsheet
            // 
            this.tabPageSpreadsheet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPageSpreadsheet.Controls.Add(this.cosLabel);
            this.tabPageSpreadsheet.Controls.Add(this.sinLabel);
            this.tabPageSpreadsheet.Controls.Add(this.CosMatrix);
            this.tabPageSpreadsheet.Controls.Add(this.SinMatrix);
            this.tabPageSpreadsheet.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpreadsheet.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSpreadsheet.Name = "tabPageSpreadsheet";
            this.tabPageSpreadsheet.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSpreadsheet.Size = new System.Drawing.Size(964, 679);
            this.tabPageSpreadsheet.TabIndex = 1;
            this.tabPageSpreadsheet.Text = "Таблица";
            // 
            // cosLabel
            // 
            this.cosLabel.AutoSize = true;
            this.cosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cosLabel.ForeColor = System.Drawing.Color.Blue;
            this.cosLabel.Location = new System.Drawing.Point(563, 23);
            this.cosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cosLabel.Name = "cosLabel";
            this.cosLabel.Size = new System.Drawing.Size(106, 25);
            this.cosLabel.TabIndex = 30;
            this.cosLabel.Text = "Y = cos(X)";
            this.cosLabel.Visible = false;
            // 
            // sinLabel
            // 
            this.sinLabel.AutoSize = true;
            this.sinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sinLabel.ForeColor = System.Drawing.Color.Red;
            this.sinLabel.Location = new System.Drawing.Point(263, 23);
            this.sinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sinLabel.Name = "sinLabel";
            this.sinLabel.Size = new System.Drawing.Size(100, 25);
            this.sinLabel.TabIndex = 29;
            this.sinLabel.Text = "Y = sin(X)";
            this.sinLabel.Visible = false;
            // 
            // CosMatrix
            // 
            this.CosMatrix.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.CosMatrix.AllowUserToAddRows = false;
            this.CosMatrix.AllowUserToDeleteRows = false;
            this.CosMatrix.AllowUserToResizeColumns = false;
            this.CosMatrix.AllowUserToResizeRows = false;
            this.CosMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CosMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CosMatrix.CausesValidation = false;
            this.CosMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.CosMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CosMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CosMatrix.ColumnHeadersHeight = 29;
            this.CosMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CosMatrix.EnableHeadersVisualStyles = false;
            this.CosMatrix.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CosMatrix.Location = new System.Drawing.Point(521, 64);
            this.CosMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.CosMatrix.MultiSelect = false;
            this.CosMatrix.Name = "CosMatrix";
            this.CosMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CosMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CosMatrix.RowHeadersVisible = false;
            this.CosMatrix.RowHeadersWidth = 58;
            this.CosMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.CosMatrix.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CosMatrix.RowTemplate.ReadOnly = true;
            this.CosMatrix.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CosMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CosMatrix.ShowEditingIcon = false;
            this.CosMatrix.Size = new System.Drawing.Size(295, 561);
            this.CosMatrix.TabIndex = 28;
            this.CosMatrix.TabStop = false;
            // 
            // SinMatrix
            // 
            this.SinMatrix.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.SinMatrix.AllowUserToAddRows = false;
            this.SinMatrix.AllowUserToDeleteRows = false;
            this.SinMatrix.AllowUserToResizeColumns = false;
            this.SinMatrix.AllowUserToResizeRows = false;
            this.SinMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SinMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SinMatrix.CausesValidation = false;
            this.SinMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.SinMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SinMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SinMatrix.ColumnHeadersHeight = 29;
            this.SinMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SinMatrix.EnableHeadersVisualStyles = false;
            this.SinMatrix.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SinMatrix.Location = new System.Drawing.Point(175, 64);
            this.SinMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.SinMatrix.MultiSelect = false;
            this.SinMatrix.Name = "SinMatrix";
            this.SinMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SinMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SinMatrix.RowHeadersVisible = false;
            this.SinMatrix.RowHeadersWidth = 58;
            this.SinMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.SinMatrix.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.SinMatrix.RowTemplate.ReadOnly = true;
            this.SinMatrix.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SinMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SinMatrix.ShowEditingIcon = false;
            this.SinMatrix.Size = new System.Drawing.Size(295, 561);
            this.SinMatrix.TabIndex = 27;
            this.SinMatrix.TabStop = false;
            // 
            // tabPageChart
            // 
            this.tabPageChart.BackColor = System.Drawing.Color.White;
            this.tabPageChart.Controls.Add(this.Graph);
            this.tabPageChart.Location = new System.Drawing.Point(4, 25);
            this.tabPageChart.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageChart.Size = new System.Drawing.Size(964, 679);
            this.tabPageChart.TabIndex = 0;
            this.tabPageChart.Text = "График";
            this.tabPageChart.Click += new System.EventHandler(this.tabPageChart_Click);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(25, 27);
            this.Graph.Margin = new System.Windows.Forms.Padding(4);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Graph.Size = new System.Drawing.Size(912, 630);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem6.Text = "Возможности:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.toolStripMenuItem1.Text = "Настройки графиков";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem2.Text = "Config";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 26);
            this.toolStripMenuItem3.Text = "Записать в файл";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 26);
            this.toolStripMenuItem4.Text = "Считать из файла";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(54, 24);
            this.toolStripMenuItem5.Text = "Фон";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem7.Text = "Закрыть";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 942);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.TabControl.ResumeLayout(false);
            this.Меню.ResumeLayout(false);
            this.Меню.PerformLayout();
            this.tabPageSpreadsheet.ResumeLayout(false);
            this.tabPageSpreadsheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CosMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinMatrix)).EndInit();
            this.tabPageChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.TabPage tabPageSpreadsheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.DataGridView SinMatrix;
        private System.Windows.Forms.Label cosLabel;
        private System.Windows.Forms.Label sinLabel;
        private System.Windows.Forms.DataGridView CosMatrix;
        private System.Windows.Forms.TabPage Меню;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

