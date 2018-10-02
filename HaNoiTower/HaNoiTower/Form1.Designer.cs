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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picDisk3 = new System.Windows.Forms.PictureBox();
            this.picDisk4 = new System.Windows.Forms.PictureBox();
            this.picDisk5 = new System.Windows.Forms.PictureBox();
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
            this.Event_log = new System.Windows.Forms.RichTextBox();
            this.Clear_log = new System.Windows.Forms.Button();
            this.Emegency_Stop = new System.Windows.Forms.Button();
            this.Start_bnt = new System.Windows.Forms.Button();
            this.Time_Counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Disk_Amount = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.Disk_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picDisk3);
            this.groupBox1.Controls.Add(this.picDisk4);
            this.groupBox1.Controls.Add(this.picDisk5);
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
            this.groupBox1.Size = new System.Drawing.Size(841, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphics Zone";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.picDisk2.Location = new System.Drawing.Point(312, 302);
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
            this.RodB.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.RodA.Click += new System.EventHandler(this.RodA_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Event_log);
            this.groupBox2.Controls.Add(this.Clear_log);
            this.groupBox2.Controls.Add(this.Emegency_Stop);
            this.groupBox2.Controls.Add(this.Start_bnt);
            this.groupBox2.Controls.Add(this.Time_Counter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Disk_Amount);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Zone";
            // 
            // Event_log
            // 
            this.Event_log.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Event_log.Location = new System.Drawing.Point(170, 27);
            this.Event_log.Name = "Event_log";
            this.Event_log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Event_log.Size = new System.Drawing.Size(655, 149);
            this.Event_log.TabIndex = 4;
            this.Event_log.Text = "";
            this.Event_log.TextChanged += new System.EventHandler(this.Event_log_TextChanged);
            // 
            // Clear_log
            // 
            this.Clear_log.Location = new System.Drawing.Point(18, 150);
            this.Clear_log.Name = "Clear_log";
            this.Clear_log.Size = new System.Drawing.Size(129, 31);
            this.Clear_log.TabIndex = 3;
            this.Clear_log.Text = "Xóa Log";
            this.Clear_log.UseVisualStyleBackColor = true;
            this.Clear_log.Click += new System.EventHandler(this.Start_bnt_Click);
            // 
            // Emegency_Stop
            // 
            this.Emegency_Stop.Location = new System.Drawing.Point(18, 113);
            this.Emegency_Stop.Name = "Emegency_Stop";
            this.Emegency_Stop.Size = new System.Drawing.Size(129, 31);
            this.Emegency_Stop.TabIndex = 3;
            this.Emegency_Stop.Text = "Dừng khẩn cấp";
            this.Emegency_Stop.UseVisualStyleBackColor = true;
            this.Emegency_Stop.Click += new System.EventHandler(this.Start_bnt_Click);
            // 
            // Start_bnt
            // 
            this.Start_bnt.Location = new System.Drawing.Point(18, 76);
            this.Start_bnt.Name = "Start_bnt";
            this.Start_bnt.Size = new System.Drawing.Size(129, 31);
            this.Start_bnt.TabIndex = 3;
            this.Start_bnt.Text = "Bắt đầu Demo";
            this.Start_bnt.UseVisualStyleBackColor = true;
            this.Start_bnt.Click += new System.EventHandler(this.Start_bnt_Click);
            // 
            // Time_Counter
            // 
            this.Time_Counter.AutoSize = true;
            this.Time_Counter.Location = new System.Drawing.Point(14, 54);
            this.Time_Counter.Name = "Time_Counter";
            this.Time_Counter.Size = new System.Drawing.Size(139, 19);
            this.Time_Counter.TabIndex = 2;
            this.Time_Counter.Text = "Thời gian: 00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn số đĩa";
            // 
            // Disk_Amount
            // 
            this.Disk_Amount.Location = new System.Drawing.Point(109, 25);
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
            this.Disk_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ClientSize = new System.Drawing.Size(862, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tháp Hà Nội";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button Emegency_Stop;
        private System.Windows.Forms.Button Clear_log;
    }
}

