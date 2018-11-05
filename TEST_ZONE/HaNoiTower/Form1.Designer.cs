namespace HaNoiTower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picDisk3 = new System.Windows.Forms.PictureBox();
            this.picDisk4 = new System.Windows.Forms.PictureBox();
            this.picDisk5 = new System.Windows.Forms.PictureBox();
            this.Time_Counter = new System.Windows.Forms.Label();
            this.picDisk6 = new System.Windows.Forms.PictureBox();
            this.picDisk7 = new System.Windows.Forms.PictureBox();
            this.picDisk8 = new System.Windows.Forms.PictureBox();
            this.picDisk2 = new System.Windows.Forms.PictureBox();
            this.picDisk1 = new System.Windows.Forms.PictureBox();
            this.RodC = new System.Windows.Forms.PictureBox();
            this.RodB = new System.Windows.Forms.PictureBox();
            this.RodA = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exit_Program = new System.Windows.Forms.Button();
            this.About_Project = new System.Windows.Forms.Button();
            this.Stop_Solve = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Export_log = new System.Windows.Forms.Button();
            this.Event_log = new System.Windows.Forms.RichTextBox();
            this.Wipe_Log = new System.Windows.Forms.Button();
            this.SimuatorSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_bnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Disk_Amount = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimuatorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepCounter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picDisk3);
            this.groupBox1.Controls.Add(this.picDisk4);
            this.groupBox1.Controls.Add(this.picDisk5);
            this.groupBox1.Controls.Add(this.Time_Counter);
            this.groupBox1.Controls.Add(this.picDisk6);
            this.groupBox1.Controls.Add(this.picDisk7);
            this.groupBox1.Controls.Add(this.picDisk8);
            this.groupBox1.Controls.Add(this.picDisk2);
            this.groupBox1.Controls.Add(this.picDisk1);
            this.groupBox1.Controls.Add(this.RodC);
            this.groupBox1.Controls.Add(this.RodB);
            this.groupBox1.Controls.Add(this.RodA);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphics Zone";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // stepCounter
            // 
            this.stepCounter.AutoSize = true;
            this.stepCounter.ForeColor = System.Drawing.SystemColors.Info;
            this.stepCounter.Location = new System.Drawing.Point(753, 22);
            this.stepCounter.Name = "stepCounter";
            this.stepCounter.Size = new System.Drawing.Size(56, 19);
            this.stepCounter.TabIndex = 4;
            this.stepCounter.Text = "Step: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rod C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rod B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rod A";
            // 
            // picDisk3
            // 
            this.picDisk3.Image = global::HaNoiTower.Properties.Resources.Disk_3;
            this.picDisk3.Location = new System.Drawing.Point(600, 173);
            this.picDisk3.Name = "picDisk3";
            this.picDisk3.Size = new System.Drawing.Size(214, 20);
            this.picDisk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk3.TabIndex = 1;
            this.picDisk3.TabStop = false;
            this.picDisk3.Tag = "3";
            this.picDisk3.Visible = false;
            // 
            // picDisk4
            // 
            this.picDisk4.Image = global::HaNoiTower.Properties.Resources.Disk_4;
            this.picDisk4.Location = new System.Drawing.Point(600, 199);
            this.picDisk4.Name = "picDisk4";
            this.picDisk4.Size = new System.Drawing.Size(214, 20);
            this.picDisk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk4.TabIndex = 1;
            this.picDisk4.TabStop = false;
            this.picDisk4.Tag = "4";
            this.picDisk4.Visible = false;
            // 
            // picDisk5
            // 
            this.picDisk5.Image = global::HaNoiTower.Properties.Resources.Disk_5;
            this.picDisk5.Location = new System.Drawing.Point(600, 225);
            this.picDisk5.Name = "picDisk5";
            this.picDisk5.Size = new System.Drawing.Size(214, 20);
            this.picDisk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk5.TabIndex = 1;
            this.picDisk5.TabStop = false;
            this.picDisk5.Tag = "5";
            this.picDisk5.Visible = false;
            // 
            // Time_Counter
            // 
            this.Time_Counter.AutoSize = true;
            this.Time_Counter.ForeColor = System.Drawing.SystemColors.Info;
            this.Time_Counter.Location = new System.Drawing.Point(6, 22);
            this.Time_Counter.Name = "Time_Counter";
            this.Time_Counter.Size = new System.Drawing.Size(110, 19);
            this.Time_Counter.TabIndex = 2;
            this.Time_Counter.Text = "Time: 00:00:00";
            this.Time_Counter.Click += new System.EventHandler(this.Time_Counter_Click);
            // 
            // picDisk6
            // 
            this.picDisk6.Image = global::HaNoiTower.Properties.Resources.Disk_6;
            this.picDisk6.Location = new System.Drawing.Point(600, 251);
            this.picDisk6.Name = "picDisk6";
            this.picDisk6.Size = new System.Drawing.Size(214, 20);
            this.picDisk6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk6.TabIndex = 1;
            this.picDisk6.TabStop = false;
            this.picDisk6.Tag = "6";
            this.picDisk6.Visible = false;
            // 
            // picDisk7
            // 
            this.picDisk7.Image = global::HaNoiTower.Properties.Resources.Disk_7;
            this.picDisk7.Location = new System.Drawing.Point(600, 277);
            this.picDisk7.Name = "picDisk7";
            this.picDisk7.Size = new System.Drawing.Size(214, 20);
            this.picDisk7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk7.TabIndex = 1;
            this.picDisk7.TabStop = false;
            this.picDisk7.Tag = "7";
            this.picDisk7.Visible = false;
            // 
            // picDisk8
            // 
            this.picDisk8.Image = global::HaNoiTower.Properties.Resources.Disk_8;
            this.picDisk8.Location = new System.Drawing.Point(600, 302);
            this.picDisk8.Name = "picDisk8";
            this.picDisk8.Size = new System.Drawing.Size(214, 20);
            this.picDisk8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk8.TabIndex = 1;
            this.picDisk8.TabStop = false;
            this.picDisk8.Tag = "8";
            this.picDisk8.Visible = false;
            // 
            // picDisk2
            // 
            this.picDisk2.Image = global::HaNoiTower.Properties.Resources.Disk_2;
            this.picDisk2.Location = new System.Drawing.Point(311, 302);
            this.picDisk2.Name = "picDisk2";
            this.picDisk2.Size = new System.Drawing.Size(214, 20);
            this.picDisk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk2.TabIndex = 1;
            this.picDisk2.TabStop = false;
            this.picDisk2.Tag = "2";
            this.picDisk2.Visible = false;
            // 
            // picDisk1
            // 
            this.picDisk1.Image = global::HaNoiTower.Properties.Resources.Disk_1;
            this.picDisk1.Location = new System.Drawing.Point(29, 302);
            this.picDisk1.Name = "picDisk1";
            this.picDisk1.Size = new System.Drawing.Size(214, 20);
            this.picDisk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDisk1.TabIndex = 1;
            this.picDisk1.TabStop = false;
            this.picDisk1.Tag = "1";
            this.picDisk1.Visible = false;
            // 
            // RodC
            // 
            this.RodC.Image = global::HaNoiTower.Properties.Resources.Rod_01;
            this.RodC.Location = new System.Drawing.Point(589, 95);
            this.RodC.Name = "RodC";
            this.RodC.Size = new System.Drawing.Size(236, 242);
            this.RodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodC.TabIndex = 0;
            this.RodC.TabStop = false;
            // 
            // RodB
            // 
            this.RodB.Image = global::HaNoiTower.Properties.Resources.Rod_01;
            this.RodB.Location = new System.Drawing.Point(300, 95);
            this.RodB.Name = "RodB";
            this.RodB.Size = new System.Drawing.Size(236, 242);
            this.RodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodB.TabIndex = 0;
            this.RodB.TabStop = false;
            this.RodB.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RodA
            // 
            this.RodA.Image = global::HaNoiTower.Properties.Resources.Rod_01;
            this.RodA.Location = new System.Drawing.Point(18, 95);
            this.RodA.Name = "RodA";
            this.RodA.Size = new System.Drawing.Size(236, 242);
            this.RodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodA.TabIndex = 0;
            this.RodA.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exit_Program);
            this.groupBox2.Controls.Add(this.About_Project);
            this.groupBox2.Controls.Add(this.Stop_Solve);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.SimuatorSpeed);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Start_bnt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Disk_Amount);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 248);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Zone";
            // 
            // Exit_Program
            // 
            this.Exit_Program.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Program.Image")));
            this.Exit_Program.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Program.Location = new System.Drawing.Point(18, 204);
            this.Exit_Program.Name = "Exit_Program";
            this.Exit_Program.Size = new System.Drawing.Size(205, 32);
            this.Exit_Program.TabIndex = 10;
            this.Exit_Program.Text = "Exit";
            this.Exit_Program.UseVisualStyleBackColor = true;
            this.Exit_Program.Click += new System.EventHandler(this.Exit_Program_Click);
            // 
            // About_Project
            // 
            this.About_Project.Image = ((System.Drawing.Image)(resources.GetObject("About_Project.Image")));
            this.About_Project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_Project.Location = new System.Drawing.Point(18, 166);
            this.About_Project.Name = "About_Project";
            this.About_Project.Size = new System.Drawing.Size(205, 32);
            this.About_Project.TabIndex = 10;
            this.About_Project.Text = "About Project";
            this.About_Project.UseVisualStyleBackColor = true;
            this.About_Project.Click += new System.EventHandler(this.About_Project_Click);
            // 
            // Stop_Solve
            // 
            this.Stop_Solve.Image = ((System.Drawing.Image)(resources.GetObject("Stop_Solve.Image")));
            this.Stop_Solve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stop_Solve.Location = new System.Drawing.Point(18, 126);
            this.Stop_Solve.Name = "Stop_Solve";
            this.Stop_Solve.Size = new System.Drawing.Size(205, 32);
            this.Stop_Solve.TabIndex = 8;
            this.Stop_Solve.Text = "Stop Solve";
            this.Stop_Solve.UseVisualStyleBackColor = true;
            this.Stop_Solve.Click += new System.EventHandler(this.Stop_Solve_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Export_log);
            this.groupBox3.Controls.Add(this.Event_log);
            this.groupBox3.Controls.Add(this.Wipe_Log);
            this.groupBox3.Location = new System.Drawing.Point(251, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 226);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // Export_log
            // 
            this.Export_log.Image = ((System.Drawing.Image)(resources.GetObject("Export_log.Image")));
            this.Export_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Export_log.Location = new System.Drawing.Point(338, 185);
            this.Export_log.Name = "Export_log";
            this.Export_log.Size = new System.Drawing.Size(205, 32);
            this.Export_log.TabIndex = 9;
            this.Export_log.Text = "Export Log To File";
            this.Export_log.UseVisualStyleBackColor = true;
            this.Export_log.Click += new System.EventHandler(this.Export_log_Click);
            // 
            // Event_log
            // 
            this.Event_log.Location = new System.Drawing.Point(6, 25);
            this.Event_log.Name = "Event_log";
            this.Event_log.ReadOnly = true;
            this.Event_log.Size = new System.Drawing.Size(572, 154);
            this.Event_log.TabIndex = 4;
            this.Event_log.Text = "";
            // 
            // Wipe_Log
            // 
            this.Wipe_Log.Image = ((System.Drawing.Image)(resources.GetObject("Wipe_Log.Image")));
            this.Wipe_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wipe_Log.Location = new System.Drawing.Point(45, 185);
            this.Wipe_Log.Name = "Wipe_Log";
            this.Wipe_Log.Size = new System.Drawing.Size(205, 32);
            this.Wipe_Log.TabIndex = 8;
            this.Wipe_Log.Text = "Delete Log Textbox";
            this.Wipe_Log.UseVisualStyleBackColor = true;
            this.Wipe_Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimuatorSpeed
            // 
            this.SimuatorSpeed.Location = new System.Drawing.Point(185, 56);
            this.SimuatorSpeed.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SimuatorSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimuatorSpeed.Name = "SimuatorSpeed";
            this.SimuatorSpeed.Size = new System.Drawing.Size(38, 26);
            this.SimuatorSpeed.TabIndex = 6;
            this.SimuatorSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Solve Speed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start_bnt
            // 
            this.Start_bnt.Image = ((System.Drawing.Image)(resources.GetObject("Start_bnt.Image")));
            this.Start_bnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_bnt.Location = new System.Drawing.Point(18, 88);
            this.Start_bnt.Name = "Start_bnt";
            this.Start_bnt.Size = new System.Drawing.Size(205, 32);
            this.Start_bnt.TabIndex = 3;
            this.Start_bnt.Text = "Start Solve";
            this.Start_bnt.UseVisualStyleBackColor = true;
            this.Start_bnt.Click += new System.EventHandler(this.Start_bnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Disks";
            // 
            // Disk_Amount
            // 
            this.Disk_Amount.Location = new System.Drawing.Point(185, 25);
            this.Disk_Amount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Disk_Amount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Disk_Amount.Name = "Disk_Amount";
            this.Disk_Amount.Size = new System.Drawing.Size(38, 26);
            this.Disk_Amount.TabIndex = 0;
            this.Disk_Amount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Disk_Amount.ValueChanged += new System.EventHandler(this.Disk_Amount_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HaNoi Tower";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimuatorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RodA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox RodC;
        private System.Windows.Forms.PictureBox RodB;
        private System.Windows.Forms.PictureBox picDisk3;
        private System.Windows.Forms.PictureBox picDisk4;
        private System.Windows.Forms.PictureBox picDisk5;
        private System.Windows.Forms.PictureBox picDisk6;
        private System.Windows.Forms.PictureBox picDisk7;
        private System.Windows.Forms.PictureBox picDisk8;
        private System.Windows.Forms.PictureBox picDisk2;
        private System.Windows.Forms.PictureBox picDisk1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Time_Counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Disk_Amount;
        private System.Windows.Forms.RichTextBox Event_log;
        private System.Windows.Forms.Button Start_bnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SimuatorSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Wipe_Log;
        private System.Windows.Forms.Button Export_log;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stepCounter;
        private System.Windows.Forms.Button Exit_Program;
        private System.Windows.Forms.Button About_Project;
        private System.Windows.Forms.Button Stop_Solve;
    }
}

