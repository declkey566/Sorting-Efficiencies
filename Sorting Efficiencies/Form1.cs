using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting_Efficiencies
{
    public partial class Form1 : Form
    {
        Stopwatch myWatch = new Stopwatch();
        Stopwatch myWatchB = new Stopwatch();
        Stopwatch myWatchI = new Stopwatch();
        int n;
        int NumLoop=0;
        int NumComp = 0;
        int NumSwap = 0;
        int NumLoopB = 0;
        int NumCompB = 0;
        int NumSwapB = 0;
        int NumLoopI = 0;
        int NumCompI = 0;
        int NumSwapI = 0;
        int[] originalArray;
        int[] sortedArray;
        int[] sortedArray2;
        int[] sortedArray3;
        public Form1()
        {
            
            InitializeComponent();
            
        }
        public void Selection(int[] tempArray)
        {
            int temp;

            for (int i = 0; i < tempArray.Length; i++)
            {
                NumLoop = NumLoop + 1;
                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    NumComp = NumComp + 1;
                    if (tempArray[j] < tempArray[i])
                    {
                        NumSwap = NumSwap + 1;
                        temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                    }
                }
            }
        }
        public void bubble(int[] tempArray)
        {
            int bottom = tempArray.Length - 1;
            int temp;
            Boolean swap = true;

            while (swap == true)
            {
                NumLoopB = NumLoopB + 1;
                swap = false;

                for (int j = 0; j < bottom; j++)
                {
                    NumCompB = NumCompB + 1;
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        NumSwapB = NumSwapB + 1;
                        swap = true;
                        temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;
                    }
                }
                bottom--;
            }
        }
        public void insertion(int[] tempArray)
        {
            int temp, j;

            for (int n = 0; n < tempArray.Length; n++)
            {
                NumLoopI = NumLoopI + 1;
                temp = tempArray[n];
                j = n - 1;

                while (j >= 0 && tempArray[j] > temp)
                {
                    NumCompI = NumCompI + 1;
                    tempArray[j + 1] = tempArray[j];
                    j--;
                }
                NumSwapI = NumSwapI + 1;
                tempArray[j + 1] = temp;
            }
        }
        public void Display()
        {
            originalOutput.Text = sortedOutput.Text = "";
                for (int i = 0; i < n; i++)
                {
                    originalOutput.Text += i + "\n";
                }
            for (int i = 0; i < n; i++)
            {
                sortedOutput.Text += i + "\n";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
             n = 1000;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
             n = 5000;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
             n = 100;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             n = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            originalArray = new int[n];
            sortedArray = new int[n];
            sortedArray2 = new int[n];
            sortedArray3 = new int[n];
            
            Random randGen = new Random();
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = randGen.Next(-1000, 1001);
            }
            originalArray.CopyTo(sortedArray, 0);
            originalArray.CopyTo(sortedArray2, 0);
            originalArray.CopyTo(sortedArray3, 0);
            myWatch.Start();
            Selection(sortedArray);
            myWatch.Stop();
            myWatchB.Start();
            bubble(sortedArray2);
            myWatchB.Stop();
            myWatchI.Start();
            insertion(sortedArray3);
            myWatchI.Stop();
            
            Display();

            label7.Text = "Number of loops:" + (NumLoop);
            label8.Text = "Number of comparisons:" + (NumComp);
            label9.Text = "Number of shifts" + (NumSwap);
            label10.Text = "Time in milliseconds:" + Convert.ToString(myWatch.ElapsedMilliseconds);

            label14.Text = "Number of loops:" + (NumLoopB);
            label13.Text = "Number of comparisons:" + (NumCompB);
            label12.Text = "Number of shifts" + (NumSwapB);
            label11.Text = "Time in milliseconds:" + Convert.ToString(myWatchB.ElapsedMilliseconds);

            label18.Text = "Number of loops:" + (NumLoopI);
            label17.Text = "Number of comparisons:" + (NumCompI);
            label16.Text = "Number of shifts" + (NumSwapI);
            label15.Text = "Time in milliseconds:" + Convert.ToString(myWatchI.ElapsedMilliseconds);



            NumLoop = 0;
            NumSwap = 0;
            NumComp = 0;
            NumLoopB = 0;
            NumSwapB = 0;
            NumCompB = 0;
            NumLoopI = 0;
            NumSwapI = 0;
            NumCompI = 0;
            myWatch.Reset();
            myWatchB.Reset();
            myWatchI.Reset();


        }
    }
}
