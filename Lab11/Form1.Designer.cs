
namespace Lab11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.param1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.lable7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.TextBox();
            this.variance = new System.Windows.Forms.TextBox();
            this.chi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.TextBox();
            this.error2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // param1
            // 
            this.param1.DecimalPlaces = 2;
            this.param1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.param1.Location = new System.Drawing.Point(89, 52);
            this.param1.Margin = new System.Windows.Forms.Padding(2);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(90, 20);
            this.param1.TabIndex = 5;
            this.param1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 156);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(657, 306);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "N";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(89, 85);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(90, 20);
            this.number.TabIndex = 12;
            this.number.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Location = new System.Drawing.Point(208, 54);
            this.lable7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(47, 13);
            this.lable7.TabIndex = 13;
            this.lable7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Variance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chi-squared";
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(273, 52);
            this.average.Margin = new System.Windows.Forms.Padding(2);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(76, 20);
            this.average.TabIndex = 16;
            // 
            // variance
            // 
            this.variance.Location = new System.Drawing.Point(273, 84);
            this.variance.Margin = new System.Windows.Forms.Padding(2);
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(76, 20);
            this.variance.TabIndex = 17;
            // 
            // chi
            // 
            this.chi.Location = new System.Drawing.Point(273, 119);
            this.chi.Margin = new System.Windows.Forms.Padding(2);
            this.chi.Name = "chi";
            this.chi.Size = new System.Drawing.Size(76, 20);
            this.chi.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(379, 122);
            this.state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(32, 13);
            this.state.TabIndex = 20;
            this.state.Text = "State";
            // 
            // error1
            // 
            this.error1.Location = new System.Drawing.Point(436, 52);
            this.error1.Margin = new System.Windows.Forms.Padding(2);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(76, 20);
            this.error1.TabIndex = 21;
            // 
            // error2
            // 
            this.error2.Location = new System.Drawing.Point(436, 84);
            this.error2.Margin = new System.Windows.Forms.Padding(2);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(76, 20);
            this.error2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Error,%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Error,%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Geometric distribution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chi);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.param1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown param1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.TextBox variance;
        private System.Windows.Forms.TextBox chi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox error1;
        private System.Windows.Forms.TextBox error2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}

