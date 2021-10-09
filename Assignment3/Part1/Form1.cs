using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignement1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //concatinate
        private void label3_Click(object sender, EventArgs e)
        {
            string first = firstStringTextbox.Text;
            string second = secondStringTextbox.Text;

            string ans = first + second;

            result.Text = string.Format("Combine string:{0}",ans);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string first = firstStringTextbox.Text;
            string second = secondStringTextbox.Text;

            result.Text = string.Format("Equal? =>{0}",(first==second));
        }

        //Palindrome
        private void label5_Click(object sender, EventArgs e)
        {
            StringBuilder first = new StringBuilder(firstStringTextbox.Text);
            StringBuilder second = new StringBuilder(secondStringTextbox.Text);

            result.Text = string.Format("Palindrome\n First=>{0}\n Second=>{1}",Palindrome(first),Palindrome(second));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string Reverse(StringBuilder tempString)
        {
            int size = tempString.Length;

            int low = 0;
            int high = size - 1;

            while (low < high)
            {
                //swap low & high 
                char temp = tempString[low];
                tempString[low] = tempString[high];
                tempString[high] = temp;

                low++;
                high--;
            }

            return tempString.ToString();
        }

        //reverse
        private void label7_Click(object sender, EventArgs e)
        {
            StringBuilder first = new StringBuilder(firstStringTextbox.Text);
            StringBuilder second =new StringBuilder(secondStringTextbox.Text);


           result.Text =String.Format("Reverse \nFirst =>{0} \n Second =>{1}", Reverse(first),Reverse(second)) ;


        }

        private bool Palindrome(StringBuilder tempString)
        {
            int size = tempString.Length;

            int low = 0;
            int high = size - 1;

            while (low < high)
            {
                if (tempString[low] != tempString[high])
                    return false;
                low++;
                high--;
            }

            return true;
        }
    }
}
