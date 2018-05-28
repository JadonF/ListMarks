/*
 * Created by: Jadon F
 * Created on: 25-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program accepts marks from 1 - 100 and puts them in a list
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ListMarks
{
    public partial class Form1 : Form
    {
        //create the list
        List<int> listOfInts = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
   
        private void CalculateAverage (ref List<int> listOfInts)
        {
            //sum
            int sum = 0;
            double average = 0;

            //average the values
            foreach (int inArray in listOfInts)
            {
                sum = sum + inArray;
            }

            //final calc
            average = sum / listOfInts.Count;
            //Message box
            MessageBox.Show("The average is " + average, "Average");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int userMark = -1;
            try
            {
                userMark = int.Parse(txtInput.Text);
            }
            catch(Exception parseError)
            {
                Console.WriteLine("An error occured: '{0}'", parseError);
            }

            if ((userMark >= 0) && (userMark <= 100))
            {
                lstValues.Items.Add(userMark);
                listOfInts.Add(userMark);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Error");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if(listOfInts.Count == 0)
            {
                MessageBox.Show("Please enter at least one value.", "Error");
            }
            else
            {
                CalculateAverage(ref listOfInts);
            }
        }
    }
}
