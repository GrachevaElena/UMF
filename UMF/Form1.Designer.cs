namespace UMF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNU2 = new System.Windows.Forms.RadioButton();
            this.radioButtonNU3 = new System.Windows.Forms.RadioButton();
            this.radioButtonNU1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonC01 = new System.Windows.Forms.RadioButton();
            this.radioButtonD01 = new System.Windows.Forms.RadioButton();
            this.radioButtonS01 = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDraw);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 474);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N=";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(11, 422);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 37);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNone);
            this.groupBox2.Controls.Add(this.radioButtonNU2);
            this.groupBox2.Controls.Add(this.radioButtonNU3);
            this.groupBox2.Controls.Add(this.radioButtonNU1);
            this.groupBox2.Location = new System.Drawing.Point(11, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Граничные условия";
            // 
            // radioButtonNU2
            // 
            this.radioButtonNU2.AutoSize = true;
            this.radioButtonNU2.Location = new System.Drawing.Point(31, 62);
            this.radioButtonNU2.Name = "radioButtonNU2";
            this.radioButtonNU2.Size = new System.Drawing.Size(43, 17);
            this.radioButtonNU2.TabIndex = 2;
            this.radioButtonNU2.TabStop = true;
            this.radioButtonNU2.Text = "II, II";
            this.radioButtonNU2.UseVisualStyleBackColor = true;
            this.radioButtonNU2.CheckedChanged += new System.EventHandler(this.radioButtonNU2_CheckedChanged);
            // 
            // radioButtonNU3
            // 
            this.radioButtonNU3.AutoSize = true;
            this.radioButtonNU3.Location = new System.Drawing.Point(31, 96);
            this.radioButtonNU3.Name = "radioButtonNU3";
            this.radioButtonNU3.Size = new System.Drawing.Size(43, 17);
            this.radioButtonNU3.TabIndex = 1;
            this.radioButtonNU3.TabStop = true;
            this.radioButtonNU3.Text = "I, III";
            this.radioButtonNU3.UseVisualStyleBackColor = true;
            this.radioButtonNU3.CheckedChanged += new System.EventHandler(this.radioButtonNU3_CheckedChanged);
            // 
            // radioButtonNU1
            // 
            this.radioButtonNU1.AutoSize = true;
            this.radioButtonNU1.Location = new System.Drawing.Point(31, 30);
            this.radioButtonNU1.Name = "radioButtonNU1";
            this.radioButtonNU1.Size = new System.Drawing.Size(37, 17);
            this.radioButtonNU1.TabIndex = 0;
            this.radioButtonNU1.TabStop = true;
            this.radioButtonNU1.Text = "I, I";
            this.radioButtonNU1.UseVisualStyleBackColor = true;
            this.radioButtonNU1.CheckedChanged += new System.EventHandler(this.radioButtonNU1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonC01);
            this.groupBox1.Controls.Add(this.radioButtonD01);
            this.groupBox1.Controls.Add(this.radioButtonS01);
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функция";
            // 
            // radioButtonC01
            // 
            this.radioButtonC01.AutoSize = true;
            this.radioButtonC01.Location = new System.Drawing.Point(31, 62);
            this.radioButtonC01.Name = "radioButtonC01";
            this.radioButtonC01.Size = new System.Drawing.Size(44, 17);
            this.radioButtonC01.TabIndex = 2;
            this.radioButtonC01.TabStop = true;
            this.radioButtonC01.Text = "C01";
            this.radioButtonC01.UseVisualStyleBackColor = true;
            this.radioButtonC01.CheckedChanged += new System.EventHandler(this.radioButtonC01_CheckedChanged);
            // 
            // radioButtonD01
            // 
            this.radioButtonD01.AutoSize = true;
            this.radioButtonD01.Location = new System.Drawing.Point(31, 96);
            this.radioButtonD01.Name = "radioButtonD01";
            this.radioButtonD01.Size = new System.Drawing.Size(45, 17);
            this.radioButtonD01.TabIndex = 1;
            this.radioButtonD01.TabStop = true;
            this.radioButtonD01.Text = "D01";
            this.radioButtonD01.UseVisualStyleBackColor = true;
            this.radioButtonD01.CheckedChanged += new System.EventHandler(this.radioButtonD01_CheckedChanged);
            // 
            // radioButtonS01
            // 
            this.radioButtonS01.AutoSize = true;
            this.radioButtonS01.Location = new System.Drawing.Point(31, 30);
            this.radioButtonS01.Name = "radioButtonS01";
            this.radioButtonS01.Size = new System.Drawing.Size(44, 17);
            this.radioButtonS01.TabIndex = 0;
            this.radioButtonS01.TabStop = true;
            this.radioButtonS01.Text = "S01";
            this.radioButtonS01.UseVisualStyleBackColor = true;
            this.radioButtonS01.CheckedChanged += new System.EventHandler(this.radioButtonS01_CheckedChanged);
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(193, 7);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(601, 472);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 379);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(157, 37);
            this.buttonDraw.TabIndex = 7;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(31, 128);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNone.TabIndex = 3;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "Нет";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonNU2;
        private System.Windows.Forms.RadioButton radioButtonNU3;
        private System.Windows.Forms.RadioButton radioButtonNU1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonC01;
        private System.Windows.Forms.RadioButton radioButtonD01;
        private System.Windows.Forms.RadioButton radioButtonS01;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.RadioButton radioButtonNone;
    }
}

