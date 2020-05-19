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
        //int n = 100;
        int[] originalArray = new int[100];
        int[] sortedArray = new int[100];

        int[] originalArray2 = new int[100];
        int[] sortedArray2 = new int[100];

        int[] originalArray3 = new int[100];
        int[] sortedArray3 = new int[100];
        public Form1()
        {
            InitializeComponent();

            //int n = Convert.ToInt32(textBox1.Text);

            Random randGen = new Random();
            for (int i = 0; i < originalArray.Length; i++)
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
            //bubble(sortedArray);
            //insertion(sortedArray);
         

            
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


            foreach (int i in originalArray)
            {
                originalOutput.Text += i + "\n";
            }
            foreach (int i in sortedArray)
            {
                sortedOutput.Text += i + "\n";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int n = 1000;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int n = 5000;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int n = 10;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int n = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
