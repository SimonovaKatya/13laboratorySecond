namespace _13laboratorySecond
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_Param = new System.Windows.Forms.TextBox();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.textBox_Average = new System.Windows.Forms.TextBox();
            this.textBox_Varience = new System.Windows.Forms.TextBox();
            this.textBox_Average_Error = new System.Windows.Forms.TextBox();
            this.textBox_Varience_Error = new System.Windows.Forms.TextBox();
            this.textBox_Chi_Squared = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(378, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(762, 598);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox_Param
            // 
            this.textBox_Param.Location = new System.Drawing.Point(234, 23);
            this.textBox_Param.Name = "textBox_Param";
            this.textBox_Param.Size = new System.Drawing.Size(123, 20);
            this.textBox_Param.TabIndex = 1;
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(234, 68);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(123, 20);
            this.textBox_Num.TabIndex = 2;
            // 
            // textBox_Average
            // 
            this.textBox_Average.Location = new System.Drawing.Point(234, 122);
            this.textBox_Average.Name = "textBox_Average";
            this.textBox_Average.Size = new System.Drawing.Size(123, 20);
            this.textBox_Average.TabIndex = 3;
            // 
            // textBox_Varience
            // 
            this.textBox_Varience.Location = new System.Drawing.Point(234, 171);
            this.textBox_Varience.Name = "textBox_Varience";
            this.textBox_Varience.Size = new System.Drawing.Size(123, 20);
            this.textBox_Varience.TabIndex = 4;
            // 
            // textBox_Average_Error
            // 
            this.textBox_Average_Error.Location = new System.Drawing.Point(234, 229);
            this.textBox_Average_Error.Name = "textBox_Average_Error";
            this.textBox_Average_Error.Size = new System.Drawing.Size(123, 20);
            this.textBox_Average_Error.TabIndex = 5;
            // 
            // textBox_Varience_Error
            // 
            this.textBox_Varience_Error.Location = new System.Drawing.Point(234, 284);
            this.textBox_Varience_Error.Name = "textBox_Varience_Error";
            this.textBox_Varience_Error.Size = new System.Drawing.Size(123, 20);
            this.textBox_Varience_Error.TabIndex = 6;
            // 
            // textBox_Chi_Squared
            // 
            this.textBox_Chi_Squared.Location = new System.Drawing.Point(141, 334);
            this.textBox_Chi_Squared.Name = "textBox_Chi_Squared";
            this.textBox_Chi_Squared.Size = new System.Drawing.Size(216, 20);
            this.textBox_Chi_Squared.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вероятность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество эксперементов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Среднее значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дисперсия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ошибка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ошибка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кси-квадрат";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(127, 469);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(190, 110);
            this.button_Generate.TabIndex = 15;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 646);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Chi_Squared);
            this.Controls.Add(this.textBox_Varience_Error);
            this.Controls.Add(this.textBox_Average_Error);
            this.Controls.Add(this.textBox_Varience);
            this.Controls.Add(this.textBox_Average);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.textBox_Param);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox_Param;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.TextBox textBox_Average;
        private System.Windows.Forms.TextBox textBox_Varience;
        private System.Windows.Forms.TextBox textBox_Average_Error;
        private System.Windows.Forms.TextBox textBox_Varience_Error;
        private System.Windows.Forms.TextBox textBox_Chi_Squared;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Generate;
    }
}

