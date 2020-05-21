using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Efficiencies
{
    public partial class Form1 : Form
    {
        int n;
        int[] originalArray;
        int[] sortedArray;

        int[] originalArray2;
        int[] sortedArray2;

        int[] originalArray3;
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
                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    if (tempArray[j] < tempArray[i])
                    {
                        temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                    }
                }
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
            // foreach (int i in sortedArray)
            // {
            //      if (originalArray.Length < n)
            //      {
            //         originalOutput.Text += i + "\n";
            //     }
            // }
            // foreach (int i in sortedArray)
            // {
            //      if (originalArray.Length < n)
            //      {
            //         sortedOutput.Text += i + "\n";
            //     }
            // }
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
             n = 10;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             n = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random randGen = new Random();
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = randGen.Next(-1000, 1001);
            }
            originalArray.CopyTo(sortedArray, 0);
            originalArray.CopyTo(sortedArray2, 0);
            originalArray.CopyTo(sortedArray3, 0);
            originalArray.CopyTo(originalArray2, 0);
            originalArray.CopyTo(originalArray3, 0);
            Selection(sortedArray);
            Display();

        }
    }
}
