namespace lab11normalDistrSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbVar = new System.Windows.Forms.Label();
            this.lbHiSqv = new System.Windows.Forms.Label();
            this.numMean = new System.Windows.Forms.NumericUpDown();
            this.numVariance = new System.Windows.Forms.NumericUpDown();
            this.tbDebug = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(126, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sample size";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(154, 224);
            this.numSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(71, 22);
            this.numSize.TabIndex = 13;
            this.numSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(288, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(576, 364);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMean.Location = new System.Drawing.Point(285, 447);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(60, 25);
            this.lbMean.TabIndex = 18;
            this.lbMean.Text = "Mean:";
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVar.Location = new System.Drawing.Point(285, 488);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(81, 25);
            this.lbVar.TabIndex = 19;
            this.lbVar.Text = "Variance:";
            // 
            // lbHiSqv
            // 
            this.lbHiSqv.AutoSize = true;
            this.lbHiSqv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHiSqv.Location = new System.Drawing.Point(285, 531);
            this.lbHiSqv.Name = "lbHiSqv";
            this.lbHiSqv.Size = new System.Drawing.Size(150, 25);
            this.lbHiSqv.TabIndex = 20;
            this.lbHiSqv.Text = "Chi-squared test::";
            // 
            // numMean
            // 
            this.numMean.Location = new System.Drawing.Point(154, 122);
            this.numMean.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMean.Name = "numMean";
            this.numMean.Size = new System.Drawing.Size(71, 22);
            this.numMean.TabIndex = 21;
            this.numMean.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numVariance
            // 
            this.numVariance.Location = new System.Drawing.Point(154, 173);
            this.numVariance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVariance.Name = "numVariance";
            this.numVariance.Size = new System.Drawing.Size(71, 22);
            this.numVariance.TabIndex = 22;
            this.numVariance.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(12, 417);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(213, 96);
            this.tbDebug.TabIndex = 23;
            this.tbDebug.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 589);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.numVariance);
            this.Controls.Add(this.numMean);
            this.Controls.Add(this.lbHiSqv);
            this.Controls.Add(this.lbVar);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Normal Distribution";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbVar;
        private System.Windows.Forms.Label lbHiSqv;
        private System.Windows.Forms.NumericUpDown numMean;
        private System.Windows.Forms.NumericUpDown numVariance;
        private System.Windows.Forms.RichTextBox tbDebug;
    }
}

