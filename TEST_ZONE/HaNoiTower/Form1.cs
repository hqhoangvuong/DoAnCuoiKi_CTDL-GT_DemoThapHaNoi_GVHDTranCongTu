using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace HaNoiTower
{
    public partial class Form1 : Form
    {
        TimeSpan time;
        PictureBox[] disks;
        Stack<PictureBox> disksRodA, disksRodB, disksRodC;
        const int Def_Y = 302;
        const int Disk_Height = 20;
        const int DIS_X_frm_Rod_to_Disk = 11;
        int DelayTime;
        int movStep;

        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox[] { picDisk1, picDisk2, picDisk3, picDisk4, picDisk5, picDisk6, picDisk7, picDisk8 };
            disksRodA = new Stack<PictureBox>();
            disksRodB = new Stack<PictureBox>();
            disksRodC = new Stack<PictureBox>();
            Event_log.Text += Event_log.Text + "Initalized all request compoment.\nWaiting for command ...\n";
            movStep = 0;
        }

        public struct ThuTuc
        {
            public int N;
            public Stack<PictureBox> A;
            public Stack<PictureBox> B;
            public Stack<PictureBox> C;
        };

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Disk_Amount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            Time_Counter.Text = string.Format("Time: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }

        public void SpeedSelect(ref int delayTime)
        {
            if ((int)SimuatorSpeed.Value == 1)
                delayTime = 1;
            else
                delayTime = (int)SimuatorSpeed.Value * 3;
        }

        public void LogWritter(Stack<PictureBox> I, Stack<PictureBox> O)
        {
            Char i, o;
            if (I == disksRodA)
                i = 'A';
            else if (I == disksRodB)
                i = 'B';
            else
                i = 'C';
            if (O == disksRodA)
                o = 'A';
            else if (O == disksRodB)
                o = 'B';
            else
                o = 'C';
            Event_log.AppendText(Environment.NewLine + "Step " + movStep + ": Move a disk from rod " + i + " to rod " + o);
        }

        public void Movement(Stack<PictureBox> rodSrc, Stack<PictureBox> rodDes)
        {
            int x = 0, y = 0;
            PictureBox DiskPop = new PictureBox();
            Point pntScr = new Point(x, y);

            DiskPop = rodSrc.Pop();
            pntScr = DiskPop.Location;
            x = pntScr.X;
            y = pntScr.Y;
            Application.DoEvents();

            // Nhấc lên
            for (; y > 50; y--)
            {
                DiskPop.Visible = false;
                DiskPop.Location = new Point(x, y);
                DiskPop.Visible = true;
                Application.DoEvents();
                Thread.Sleep(DelayTime);
            }

            int xPeek = 0, yPeek = 0;
            PictureBox tempPeek = new PictureBox();
            if (rodDes.Count != 0)
            {
                tempPeek = rodDes.Peek();
                xPeek = tempPeek.Location.X;
                yPeek = tempPeek.Location.Y - 20;
            }
            else
            {
                yPeek = Def_Y;
                if (rodDes == disksRodA)
                    xPeek = RodA.Location.X + DIS_X_frm_Rod_to_Disk;
                else
                    if (rodDes == disksRodB)
                    xPeek = RodB.Location.X + DIS_X_frm_Rod_to_Disk;
                else
                    xPeek = RodC.Location.X + DIS_X_frm_Rod_to_Disk;
            }

            //MessageBox.Show("x=" + x + ", xPeek=" + xPeek);
            if (xPeek > x)
                for (; x <= xPeek; x++)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(DelayTime);
                }
            else
                for (; x >= xPeek; x--)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(DelayTime);
                }

            // Qua ngang


            //MessageBox.Show("y = " + y);

            // Đặt xuông
            for (; y <= yPeek; y++)
            {
                DiskPop.Visible = false;
                DiskPop.Location = new Point(x, y);
                DiskPop.Visible = true;
                Application.DoEvents();
                Thread.Sleep(DelayTime);
            }
            //MessageBox.Show("x=" + DiskPop.Location.X + ", y=" + DiskPop.Location.Y);
            rodDes.Push(DiskPop);
        }

        public void HaNoiTowerByStack(int x)
        {

            ThuTuc X = new ThuTuc();
            X.N = x;
            X.A = disksRodA;
            X.B = disksRodB;
            X.C = disksRodC;

            Stack<ThuTuc> myStack = new Stack<ThuTuc>();
            ThuTuc temp = new ThuTuc();
            ThuTuc temp1 = new ThuTuc();
            myStack.Push(X);
            do
            {
                temp = myStack.Pop();
                if (temp.N == 1)
                {
                    movStep++;
                    stepCounter.Text = "Step: " + movStep;
                    LogWritter(temp.A, temp.B);
                    Movement(temp.A, temp.B);
                }
                else
                {
                    temp1.N = temp.N - 1;
                    temp1.A = temp.C;
                    temp1.B = temp.B;
                    temp1.C = temp.A;
                    myStack.Push(temp1);
                    temp1.N = 1;
                    temp1.A = temp.A;
                    temp1.B = temp.B;
                    temp1.C = temp.C;
                    myStack.Push(temp1);
                    temp1.N = temp.N - 1;
                    temp1.A = temp.A;
                    temp1.B = temp.C;
                    temp1.C = temp.B;
                    myStack.Push(temp1);
                }
            } while (myStack.Count != 0);
            Event_log.AppendText(Environment.NewLine + "Task completed in " + time.Hours + " Hours, " + time.Minutes + " Minutes, " + time.Seconds + " Seconds, " + time.Milliseconds + " Miliseconds. Total move: " + movStep + " .");
            timer1.Stop();
            MessageBox.Show("Task Completed after " + movStep + " steps!!!", "Program's Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Start_bnt.Enabled = true;
            Disk_Amount.Enabled = true;
            SimuatorSpeed.Enabled = true;
            Event_log.AppendText(Environment.NewLine + "Waiting for new command ...");
        }

        public void InitalizeDisk()
        {
            timer1.Stop();
            foreach (PictureBox disk in disks)
                disk.Visible = false;
            time = new TimeSpan(0);
            Time_Counter.Text = "Time: 00:00:00";
            stepCounter.Text = "Step: 0";
            disksRodA.Clear();
            disksRodB.Clear();
            disksRodC.Clear();
            Disk_Amount.Enabled = false;

            int x = RodA.Location.X + DIS_X_frm_Rod_to_Disk;
            int y = Def_Y;

            for (int i = (int)Disk_Amount.Value - 1; i >= 0; --i, y -= Disk_Height)
            {
                for(int j = 100;j<=y;j+=2)
                {
                    disks[i].Location = new Point(x, j);
                    disks[i].Visible = false;
                    disks[i].Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(DelayTime);
                }
                disksRodA.Push(disks[i]);
            }
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event_log.Clear();
            MessageBox.Show("Event Log Textbox Cleaned.", "Program's Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 

        private void Export_log_Click(object sender, EventArgs e)
        {
            string path;
            SaveFileDialog save = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();
            path = (string)saveFileDialog1.FileName;
            Event_log.SaveFile(path, RichTextBoxStreamType.RichText);
            MessageBox.Show("Log file saved at " + path + " .", "Program's Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void About_Project_Click(object sender, EventArgs e)
        {
            var ShowFrm = new AboutForm();
            ShowFrm.Show();
        }

        private void Exit_Program_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Stop_Solve_Click(object sender, EventArgs e)
        {

        }

        public void Render (int DepX, int depY, int ArrX, int ArrY)
        {

        }

        private void Start_bnt_Click(object sender, EventArgs e)
        {
            SpeedSelect(ref DelayTime);
            Start_bnt.Enabled = false;
            SimuatorSpeed.Enabled = false;
            Event_log.AppendText(Environment.NewLine + "Command from User recevied");
            Event_log.AppendText(Environment.NewLine + "Solve HaNoi Tower with " + (int)Disk_Amount.Value +" disks. Solve speed is "+ DelayTime+". ");
            Event_log.AppendText(Environment.NewLine + "Initalize the original state of HaNoi Tower ...");
            InitalizeDisk();
            HaNoiTowerByStack((int)Disk_Amount.Value);
        }
    }
}
