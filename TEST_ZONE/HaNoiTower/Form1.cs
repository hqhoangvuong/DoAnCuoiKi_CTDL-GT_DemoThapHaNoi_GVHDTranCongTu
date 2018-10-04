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
        const int RodA_X = 29;
        const int RodB_X = 311;
        const int RodC_X = 600;
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

        public struct ThuTuc
        {
            public int N;
            public char A;
            public char B;
            public char C;
        };

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
                Thread.Sleep(1);
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
                    xPeek = RodA_X;
                else
                    if (rodDes == disksRodB)
                    xPeek = RodB_X;
                else
                    xPeek = RodC_X;
            }

            //MessageBox.Show("x=" + x + ", xPeek=" + xPeek);
            if (xPeek > x)
                for (; x <= xPeek; x++)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(1);
                }
            else
                for (; x >= xPeek; x--)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                    Thread.Sleep(1);
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
                Thread.Sleep(1);
            }
            //MessageBox.Show("x=" + DiskPop.Location.X + ", y=" + DiskPop.Location.Y);
            rodDes.Push(DiskPop);
        }

        static void HaNoiTowerByStack()
        {
            ThuTuc X = new ThuTuc();
            X.N = int.Parse(Console.ReadLine());
            X.A = 'A';
            X.B = 'B';
            X.C = 'C';

            Stack<ThuTuc> myStack = new Stack<ThuTuc>();
            ThuTuc temp = new ThuTuc();
            ThuTuc temp1 = new ThuTuc();
            myStack.Push(X);
            do
            {
                temp = myStack.Pop();
                if (temp.N == 1) ;
                //Console.WriteLine("{0} {1}", temp.A, temp.B);
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
            Console.ReadKey();
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Render (int DepX, int depY, int ArrX, int ArrY)
        {

        }

        private void Start_bnt_Click(object sender, EventArgs e)
        {
            InitalizeDisk();
            Movement(disksRodA, disksRodB);
            Movement(disksRodA, disksRodC);
            Movement(disksRodB, disksRodC);
            Movement(disksRodA, disksRodB);
            Movement(disksRodC, disksRodA);
            Movement(disksRodC, disksRodB);
            Movement(disksRodA, disksRodB);
        }
    }
}
