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

        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox[] { picDisk1, picDisk2, picDisk3, picDisk4, picDisk5, picDisk6, picDisk7, picDisk8 };
            disksRodA = new Stack<PictureBox>();
            disksRodB = new Stack<PictureBox>();
            disksRodC = new Stack<PictureBox>();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Disk_Amount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            Time_Counter.Text = string.Format("Thời gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }

        public void InitalizeDisk()
        {
            timer1.Stop();
            foreach (PictureBox disk in disks)
                disk.Visible = false;
            time = new TimeSpan(0);
            Time_Counter.Text = "Thời gian: 00:00:00";
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
                    Thread.Sleep(1);
                }
                disksRodA.Push(disks[i]);
            }
            timer1.Start();
        }

        private void Start_bnt_Click(object sender, EventArgs e)
        {
            //Reset
            //    timer1.Stop();
            //    foreach (PictureBox disk in disks)
            //        disk.Visible = false;
            //    time = new TimeSpan(0);
            //    Time_Counter.Text = "Thời gian: 00:00:00";
            //    disksRodA.Clear();
            //    disksRodB.Clear();
            //    disksRodC.Clear();
            //    Disk_Amount.Enabled = false;

            //    int x = RodA.Location.X + DIS_X_frm_Rod_to_Disk;
            //    int y = Def_Y;

            //    for (int i = (int)Disk_Amount.Value - 1; i >= 0; --i, y-=Disk_Height)
            //    {
            //        disks[i].Location = new Point(x, y);
            //        disks[i].Visible = true;
            //        disksRodA.Push(disks[i]);
            //    }
            //    timer1.Start();
            //}
            InitalizeDisk();
        }
    }
}
