using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyjimky2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                textBox1.Text = "";
                int n = Convert.ToInt32(textBox2.Text);                            
                int[] pole = new int[n];

                if (n < 6) throw new IndexOutOfRangeException();
                         
                Random rng = new Random();                             
                for (int i = 0; i < n; i++)
                {
                    
                    pole[i] = rng.Next(1, 21);
                    textBox1.Text += pole[i]+Environment.NewLine;
                                                       
                }

                label1.Text = Math.Pow(pole[0], pole[5]).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
