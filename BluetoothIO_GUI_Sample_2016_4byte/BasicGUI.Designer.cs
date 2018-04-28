namespace BluetoothGUISample
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bluetooth = new System.IO.Ports.SerialPort(this.components);
            this.getIOtimer = new System.Windows.Forms.Timer(this.components);
            this.InputBox1 = new System.Windows.Forms.TextBox();
            this.OutputBox1 = new System.Windows.Forms.NumericUpDown();
            this.Send1 = new System.Windows.Forms.Button();
            this.Send2 = new System.Windows.Forms.Button();
            this.Get1 = new System.Windows.Forms.Button();
            this.Get2 = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.InputBox2 = new System.Windows.Forms.TextBox();
            this.OutputBox2 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Ki_button = new System.Windows.Forms.Button();
            this.Ki = new System.Windows.Forms.NumericUpDown();
            this.Kd_button = new System.Windows.Forms.Button();
            this.Kd = new System.Windows.Forms.NumericUpDown();
            this.Kp_button = new System.Windows.Forms.Button();
            this.Kp = new System.Windows.Forms.NumericUpDown();
            this.Velocity_button = new System.Windows.Forms.Button();
            this.Velocity = new System.Windows.Forms.NumericUpDown();
            this.Position_Button = new System.Windows.Forms.Button();
            this.Position_output = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Deadband_testing = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.ACC_BOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Velocity_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Degree_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Count_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Velocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_output)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // bluetooth
            // 
            this.bluetooth.PortName = "COM60";
            // 
            // getIOtimer
            // 
            this.getIOtimer.Enabled = true;
            this.getIOtimer.Interval = 10;
            this.getIOtimer.Tick += new System.EventHandler(this.getIOtimer_Tick);
            // 
            // InputBox1
            // 
            this.InputBox1.Location = new System.Drawing.Point(18, 541);
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(126, 20);
            this.InputBox1.TabIndex = 0;
            this.InputBox1.Text = "0";
            // 
            // OutputBox1
            // 
            this.OutputBox1.DecimalPlaces = 2;
            this.OutputBox1.Location = new System.Drawing.Point(12, 95);
            this.OutputBox1.Maximum = new decimal(new int[] {
            148,
            0,
            0,
            65536});
            this.OutputBox1.Minimum = new decimal(new int[] {
            148,
            0,
            0,
            -2147418112});
            this.OutputBox1.Name = "OutputBox1";
            this.OutputBox1.Size = new System.Drawing.Size(68, 20);
            this.OutputBox1.TabIndex = 3;
            this.OutputBox1.ValueChanged += new System.EventHandler(this.OutputBox1_ValueChanged);
            // 
            // Send1
            // 
            this.Send1.Location = new System.Drawing.Point(86, 95);
            this.Send1.Name = "Send1";
            this.Send1.Size = new System.Drawing.Size(126, 23);
            this.Send1.TabIndex = 4;
            this.Send1.Text = "Voltage (-15-15)";
            this.Send1.UseVisualStyleBackColor = true;
            this.Send1.Click += new System.EventHandler(this.Send1_Click);
            // 
            // Send2
            // 
            this.Send2.Location = new System.Drawing.Point(159, 203);
            this.Send2.Name = "Send2";
            this.Send2.Size = new System.Drawing.Size(75, 23);
            this.Send2.TabIndex = 4;
            this.Send2.Text = "Output 2";
            this.Send2.UseVisualStyleBackColor = true;
            this.Send2.Click += new System.EventHandler(this.Send2_Click);
            // 
            // Get1
            // 
            this.Get1.Location = new System.Drawing.Point(192, 562);
            this.Get1.Name = "Get1";
            this.Get1.Size = new System.Drawing.Size(75, 23);
            this.Get1.TabIndex = 4;
            this.Get1.Text = "Input 1";
            this.Get1.UseVisualStyleBackColor = true;
            this.Get1.Click += new System.EventHandler(this.Get1_Click);
            // 
            // Get2
            // 
            this.Get2.Location = new System.Drawing.Point(199, 590);
            this.Get2.Name = "Get2";
            this.Get2.Size = new System.Drawing.Size(75, 23);
            this.Get2.TabIndex = 4;
            this.Get2.Text = "Input 2";
            this.Get2.UseVisualStyleBackColor = true;
            this.Get2.Click += new System.EventHandler(this.Get2_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(18, 175);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(176, 20);
            this.statusBox.TabIndex = 5;
            this.statusBox.TextChanged += new System.EventHandler(this.statusBox_TextChanged);
            // 
            // InputBox2
            // 
            this.InputBox2.Location = new System.Drawing.Point(18, 593);
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(126, 20);
            this.InputBox2.TabIndex = 0;
            this.InputBox2.Text = "0";
            // 
            // OutputBox2
            // 
            this.OutputBox2.Location = new System.Drawing.Point(11, 203);
            this.OutputBox2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OutputBox2.Name = "OutputBox2";
            this.OutputBox2.Size = new System.Drawing.Size(125, 20);
            this.OutputBox2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OutputBox1);
            this.panel1.Controls.Add(this.Send1);
            this.panel1.Controls.Add(this.OutputBox2);
            this.panel1.Controls.Add(this.Send2);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 270);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Deadband Removal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Open Loop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(136)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ki_button);
            this.panel2.Controls.Add(this.Ki);
            this.panel2.Controls.Add(this.Kd_button);
            this.panel2.Controls.Add(this.Kd);
            this.panel2.Controls.Add(this.Kp_button);
            this.panel2.Controls.Add(this.Kp);
            this.panel2.Controls.Add(this.Velocity_button);
            this.panel2.Controls.Add(this.Velocity);
            this.panel2.Controls.Add(this.Position_Button);
            this.panel2.Controls.Add(this.Position_output);
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 625);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Close Loop";
            // 
            // Ki_button
            // 
            this.Ki_button.Location = new System.Drawing.Point(46, 302);
            this.Ki_button.Name = "Ki_button";
            this.Ki_button.Size = new System.Drawing.Size(42, 23);
            this.Ki_button.TabIndex = 14;
            this.Ki_button.Text = "Ki";
            this.Ki_button.UseVisualStyleBackColor = true;
            // 
            // Ki
            // 
            this.Ki.Location = new System.Drawing.Point(3, 302);
            this.Ki.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Ki.Name = "Ki";
            this.Ki.Size = new System.Drawing.Size(38, 20);
            this.Ki.TabIndex = 13;
            // 
            // Kd_button
            // 
            this.Kd_button.Location = new System.Drawing.Point(46, 265);
            this.Kd_button.Name = "Kd_button";
            this.Kd_button.Size = new System.Drawing.Size(42, 23);
            this.Kd_button.TabIndex = 12;
            this.Kd_button.Text = "Kd";
            this.Kd_button.UseVisualStyleBackColor = true;
            // 
            // Kd
            // 
            this.Kd.Location = new System.Drawing.Point(3, 267);
            this.Kd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(38, 20);
            this.Kd.TabIndex = 11;
            // 
            // Kp_button
            // 
            this.Kp_button.Location = new System.Drawing.Point(46, 232);
            this.Kp_button.Name = "Kp_button";
            this.Kp_button.Size = new System.Drawing.Size(42, 23);
            this.Kp_button.TabIndex = 10;
            this.Kp_button.Text = "Kp";
            this.Kp_button.UseVisualStyleBackColor = true;
            // 
            // Kp
            // 
            this.Kp.Location = new System.Drawing.Point(3, 232);
            this.Kp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(38, 20);
            this.Kp.TabIndex = 9;
            // 
            // Velocity_button
            // 
            this.Velocity_button.Location = new System.Drawing.Point(134, 130);
            this.Velocity_button.Name = "Velocity_button";
            this.Velocity_button.Size = new System.Drawing.Size(75, 23);
            this.Velocity_button.TabIndex = 8;
            this.Velocity_button.Text = "Velocity";
            this.Velocity_button.UseVisualStyleBackColor = true;
            // 
            // Velocity
            // 
            this.Velocity.Location = new System.Drawing.Point(3, 130);
            this.Velocity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(125, 20);
            this.Velocity.TabIndex = 7;
            // 
            // Position_Button
            // 
            this.Position_Button.Location = new System.Drawing.Point(134, 92);
            this.Position_Button.Name = "Position_Button";
            this.Position_Button.Size = new System.Drawing.Size(75, 23);
            this.Position_Button.TabIndex = 6;
            this.Position_Button.Text = "Position";
            this.Position_Button.UseVisualStyleBackColor = true;
            // 
            // Position_output
            // 
            this.Position_output.Location = new System.Drawing.Point(3, 92);
            this.Position_output.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Position_output.Name = "Position_output";
            this.Position_output.Size = new System.Drawing.Size(125, 20);
            this.Position_output.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.Deadband_testing);
            this.panel3.Controls.Add(this.statusBox);
            this.panel3.Location = new System.Drawing.Point(-2, 341);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 274);
            this.panel3.TabIndex = 7;
            // 
            // Deadband_testing
            // 
            this.Deadband_testing.Location = new System.Drawing.Point(11, 69);
            this.Deadband_testing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Deadband_testing.Name = "Deadband_testing";
            this.Deadband_testing.Size = new System.Drawing.Size(173, 36);
            this.Deadband_testing.TabIndex = 6;
            this.Deadband_testing.Text = "Deadband Testing";
            this.Deadband_testing.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.ACC_BOX);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Velocity_Box);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Degree_Box);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Count_Box);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.InputBox2);
            this.panel4.Controls.Add(this.Get2);
            this.panel4.Controls.Add(this.Get1);
            this.panel4.Controls.Add(this.InputBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(513, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 625);
            this.panel4.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 567);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(18, 92);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(332, 144);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "Position Vs Time";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Accleration";
            // 
            // ACC_BOX
            // 
            this.ACC_BOX.Location = new System.Drawing.Point(11, 489);
            this.ACC_BOX.Name = "ACC_BOX";
            this.ACC_BOX.Size = new System.Drawing.Size(60, 20);
            this.ACC_BOX.TabIndex = 22;
            this.ACC_BOX.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Velocity";
            // 
            // Velocity_Box
            // 
            this.Velocity_Box.Location = new System.Drawing.Point(11, 256);
            this.Velocity_Box.Name = "Velocity_Box";
            this.Velocity_Box.Size = new System.Drawing.Size(60, 20);
            this.Velocity_Box.TabIndex = 20;
            this.Velocity_Box.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Degree";
            // 
            // Degree_Box
            // 
            this.Degree_Box.Location = new System.Drawing.Point(143, 58);
            this.Degree_Box.Name = "Degree_Box";
            this.Degree_Box.Size = new System.Drawing.Size(60, 20);
            this.Degree_Box.TabIndex = 18;
            this.Degree_Box.Text = "0";
            this.Degree_Box.TextChanged += new System.EventHandler(this.Degree_Box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Count";
            // 
            // Count_Box
            // 
            this.Count_Box.Location = new System.Drawing.Point(11, 58);
            this.Count_Box.Name = "Count_Box";
            this.Count_Box.Size = new System.Drawing.Size(60, 20);
            this.Count_Box.TabIndex = 16;
            this.Count_Box.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Position";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(18, 302);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(332, 144);
            this.chart2.TabIndex = 26;
            this.chart2.Text = "Position Vs Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 625);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Velocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_output)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer getIOtimer;
        private System.Windows.Forms.TextBox InputBox1;
        private System.Windows.Forms.NumericUpDown OutputBox1;
        private System.IO.Ports.SerialPort bluetooth;
        private System.Windows.Forms.Button Send1;
        private System.Windows.Forms.Button Send2;
        private System.Windows.Forms.Button Get1;
        private System.Windows.Forms.Button Get2;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox InputBox2;
        private System.Windows.Forms.NumericUpDown OutputBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Ki_button;
        private System.Windows.Forms.NumericUpDown Ki;
        private System.Windows.Forms.Button Kd_button;
        private System.Windows.Forms.NumericUpDown Kd;
        private System.Windows.Forms.Button Kp_button;
        private System.Windows.Forms.NumericUpDown Kp;
        private System.Windows.Forms.Button Velocity_button;
        private System.Windows.Forms.NumericUpDown Velocity;
        private System.Windows.Forms.Button Position_Button;
        private System.Windows.Forms.NumericUpDown Position_output;
        private System.Windows.Forms.Button Deadband_testing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ACC_BOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Velocity_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Degree_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Count_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

