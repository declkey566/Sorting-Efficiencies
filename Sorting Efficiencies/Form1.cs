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
       
    
        public Form1()
        {
            InitializeComponent();

            //int n = Convert.ToInt32(textBox1.Text);
            int n = 100;
            int[] originalArray = new int[n];
            //int[] originalArray = { 3, 6, 1, 8, 5, 2 };
            //int[] sortedArray = new int[6];
            int[] sortedArray = new int[n];
           
          
            Selection(sortedArray);
            //bubble(sortedArray);
            //insertion(sortedArray);
            originalOutput.Text = sortedOutput.Text = "";


            foreach (int i in originalArray)
            {
                originalOutput.Text += i + "\n";
            }
            foreach (int i in sortedArray)
            {
                sortedOutput.Text += i + "\n";
            }

            Random randGen = new Random();
            for (int i = 0; i<originalArray.Length; i++)
            {
                originalArray[i] = randGen.Next(-1000,1001);
            }
            originalArray.CopyTo(sortedArray, 0);
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
    }
}
