using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace TrafficMap3
{
    public partial class Form1 : Form
    {
        PictureBox[] car2_ = new PictureBox[29];
        PictureBox[] car3_ = new PictureBox[29];
        PictureBox[] train1_ = new PictureBox[11];
        PictureBox[] barrier1_ = new PictureBox[2];

        bool barrierClose = false;


        public Form1()
        {
            InitializeComponent();

            barrier1_1.Image = Properties.Resources.barierOpen;
            barrier1_0.Image = Properties.Resources.barrierCloseBckground1;


            car2_[0] = car2_0;
            car2_[1] = car2_1;
            car2_[2] = car2_2;
            car2_[3] = car2_3;
            car2_[4] = car2_4;
            car2_[5] = car2_5;
            car2_[6] = car2_6;
            car2_[7] = car2_7;
            car2_[8] = car2_8;
            car2_[9] = car2_9;
            car2_[10] = car2_10;
            car2_[11] = car2_11;
            car2_[12] = car2_12;
            car2_[13] = car2_13;
            car2_[14] = car2_14;
            car2_[15] = car2_15;
            car2_[16] = car2_16;
            car2_[17] = car2_17;
            car2_[18] = car2_18;
            car2_[19] = car2_19;
            car2_[20] = car2_20;
            car2_[21] = car2_21;
            car2_[22] = car2_22;
            car2_[23] = car2_23;
            car2_[24] = car2_24;
            car2_[25] = car2_25;
            car2_[26] = car2_26;
            car2_[27] = car2_27;
            car2_[28] = car2_28;



            car3_[0] = car3_0;
            car3_[1] = car3_1;
            car3_[2] = car3_2;
            car3_[3] = car3_3;
            car3_[4] = car3_4;
            car3_[5] = car3_5;
            car3_[6] = car3_6;
            car3_[7] = car3_7;
            car3_[8] = car3_8;
            car3_[9] = car3_9;
            car3_[10] = car3_10;
            car3_[11] = car3_11;
            car3_[12] = car3_12;
            car3_[13] = car3_13;
            car3_[14] = car3_14;
            car3_[15] = car3_15;
            car3_[16] = car3_16;
            car3_[17] = car3_17;
            car3_[18] = car3_18;
            car3_[19] = car3_19;
            car3_[20] = car3_20;
            car3_[21] = car3_21;
            car3_[22] = car3_22;
            car3_[23] = car3_23;
            car3_[24] = car3_24;
            car3_[25] = car3_25;
            car3_[26] = car3_26;
            car3_[27] = car3_27;
            car3_[28] = car3_28;

            train1_[0] = train1_0;
            train1_[1] = train1_1;
            train1_[2] = train1_2;
            train1_[3] = train1_3;
            train1_[4] = train1_4;
            train1_[5] = train1_5;
            train1_[6] = train1_6;
            train1_[7] = train1_7;
            train1_[8] = train1_8;
            train1_[9] = train1_9;
            train1_[10] = train1_10;



            //Thread thr6 = new Thread(Barriers);
            //thr6.Start();
            Thread thr1 = new Thread(auto_prawa_strona1);
            thr1.Start();
            Thread thr2 = new Thread(auto_prawa_strona2);
            thr2.Start();
            Thread thr3 = new Thread(auto_lewa_strona1);
            thr3.Start();
            Thread thr4 = new Thread(auto_lewa_strona2);
            thr4.Start();
            Thread thr5 = new Thread(Train);
            thr5.Start();


        }

        public void auto_prawa_strona1()
        {
            for (; ; )
            {

                for (int i = 0; i < 29; i++)
                {

                    if (car2_[i] == car2_9 || car2_[i] == car2_10 || car2_[i] == car2_11 || car2_[i] == car2_12 || car2_[i] == car2_13 || car2_[i] == car2_14 || car2_[i] == car2_15 || car2_[i] == car2_16 || car2_[i] == car2_17)
                    {
                        car2_[i].Image = Properties.Resources.car2Right;
                        Thread.Sleep(200);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    else
                    {
                        car2_[i].Image = Properties.Resources.car2;
                        Thread.Sleep(200);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    if(barrierClose == true && car2_[i] == car2_8)
                    {
                        
                        car2_[i].Image = Properties.Resources.car2;
                        Thread.Sleep(2000);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
                        


                    }

                }

            }

        }

        public void auto_prawa_strona2()
        {

            Random rand1 = new Random();
            int number1 = rand1.Next(2000, 5000);

            for (; ; )
            {

                Thread.Sleep(number1);

                for (int i = 0; i < 29; i++)
                {

                    if (car2_[i] == car2_9 || car2_[i] == car2_10 || car2_[i] == car2_11 || car2_[i] == car2_12 || car2_[i] == car2_13 || car2_[i] == car2_14 || car2_[i] == car2_15 || car2_[i] == car2_16 || car2_[i] == car2_17 || car2_[i] == car2_18)
                    {
                        car2_[i].Image = Properties.Resources.car3Right;
                        Thread.Sleep(300);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    else
                    {
                        car2_[i].Image = Properties.Resources.car3;
                        Thread.Sleep(300);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                     if(barrierClose == true && car2_[i] == car2_8)
                    {
                        
                        car2_[i].Image = Properties.Resources.car3;
                        Thread.Sleep(2000);
                        car2_[i].Image = Properties.Resources.kolorAsfaltu;
   
                    }
                }
            }
        }


        public void auto_lewa_strona1()
        {
            Random rand2 = new Random();
            int number2 = rand2.Next(3000, 5000);


            for (; ; )
            {
                Thread.Sleep(number2);

                for (int i = 0; i < 29; i++)
                {

                    if (car3_[i] == car3_8 || car3_[i] == car3_9 || car3_[i] == car3_10 || car3_[i] == car3_11 || car3_[i] == car3_12 || car3_[i] == car3_13 || car3_[i] == car3_14 || car3_[i] == car3_15 || car3_[i] == car3_16 || car3_[i] == car3_17)
                    {
                        car3_[i].Image = Properties.Resources.car4;
                        Thread.Sleep(200);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    else
                    {
                        car3_[i].Image = Properties.Resources.car4Right;
                        Thread.Sleep(200);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    if (barrierClose == true && car3_[i] == car3_17)
                    {

                        car3_[i].Image = Properties.Resources.car4;
                        Thread.Sleep(2000);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;

                    }
                }
            }

        }

        public void auto_lewa_strona2()
        {
            Random rand3 = new Random();
            int number3 = rand3.Next(2000, 3000);
            for (; ; )
            {
                Thread.Sleep(number3);

                for (int i = 0; i < 29; i++)
                {
                    if (car3_[i] == car3_8 || car3_[i] == car3_9 || car3_[i] == car3_10 || car3_[i] == car3_11 || car3_[i] == car3_12 || car3_[i] == car3_13 || car3_[i] == car3_14 || car3_[i] == car3_15 || car3_[i] == car3_16 || car3_[i] == car3_17)
                    {
                        car3_[i].Image = Properties.Resources.car5;
                        Thread.Sleep(210);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    else
                    {
                        car3_[i].Image = Properties.Resources.car5Right;
                        Thread.Sleep(210);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;
                    }
                    if (barrierClose == true && car3_[i] == car3_17)
                    {

                        car3_[i].Image = Properties.Resources.car5;
                        Thread.Sleep(2000);
                        car3_[i].Image = Properties.Resources.kolorAsfaltu;

                    }
                }
            }

        }
        public void Train()
        {
            Random train1 = new Random();
            int trainGO = train1.Next(2000, 5000);

            for(; ; )
            { 
            Thread.Sleep(trainGO);
            
                for (int i = 0; i < 11; i++)
                {
                   
                    train1_[i].Image = Properties.Resources.train;
                    Thread.Sleep(200);
                    train1_[0].Image = Properties.Resources.rail0;
                    train1_[1].Image = Properties.Resources.rail1;
                    train1_[2].Image = Properties.Resources.rail1_2;
                    train1_[3].Image = Properties.Resources.train1_2;
                    train1_[4].Image = Properties.Resources.train1_2;
                    train1_[5].Image = Properties.Resources.train1_2;
                    train1_[6].Image = Properties.Resources.train1_2;
                    train1_[7].Image = Properties.Resources.train1_2;
                    train1_[8].Image = Properties.Resources.train1_2;
                    train1_[9].Image = Properties.Resources.train1_2;
                    train1_[10].Image = Properties.Resources.train1_2;

                    if (train1_[i] == train1_0 || train1_[i] == train1_1 || train1_[i] == train1_2 || train1_[i] == train1_3 || train1_[i] == train1_4 || train1_[i] == train1_5 || train1_[i] == train1_6 || train1_[i] == train1_7 || train1_[i] == train1_8 || train1_[i] == train1_9 || train1_[i] == train1_10)
                    {
                        barrier1_0.Image = Properties.Resources.barierClose;
                        barrier1_1.Image = Properties.Resources.barrierOpenBckground;
                        barrierClose = true;
                    } 

                }

                barrier1_1.Image = Properties.Resources.barierOpen;
                barrier1_0.Image = Properties.Resources.barrierCloseBckground1;
                barrierClose = false;

            }

        }

       

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void car2_0_Click(object sender, EventArgs e)
        {

        }
    }   
}
