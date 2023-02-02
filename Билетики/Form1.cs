using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Билетики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        string num1, num2, num3, num4, num5, num6;
        




        private void label1_Click(object sender, EventArgs e)
        {
     
 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num1 = e.KeyChar;
            if (!char.IsDigit(num1))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num2 = e.KeyChar;
            if (!char.IsDigit(num2))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char num2 = e.KeyChar;
            if (!char.IsDigit(num2))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = textBox2.Text;
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            num3 = textBox3.Text;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            num4 = textBox4.Text;
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            num5 = textBox5.Text;
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            num6 = textBox6.Text;
            

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            num1 = textBox1.Text;
            if (e.KeyCode == Keys.D0)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox6.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num3 = e.KeyChar;
            if (!char.IsDigit(num3))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num4 = e.KeyChar;
            if (!char.IsDigit(num4))
            {
                if (e.KeyChar != (int)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num5 = e.KeyChar;
            if (!char.IsDigit(num5))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num6 = e.KeyChar;
            if (!char.IsDigit(num6))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            int sum1, sum2;
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            int c = Convert.ToInt32(num3);
            int d = Convert.ToInt32(num4);
            int E = Convert.ToInt32(num5);
            int f = Convert.ToInt32(num6);

            sum1 = a + b + c;
            sum2 = d + E + f;

            if (String.IsNullOrEmpty(num1) | String.IsNullOrEmpty(num2) | String.IsNullOrEmpty(num3) 
                | String.IsNullOrEmpty(num4) | String.IsNullOrEmpty(num5) | String.IsNullOrEmpty(num6))
                    {
                    return;
                    }
            if (sum1 == sum2)
                    {
                    Form2 form = new Form2();
                    form.Show();
                    }
            if (sum1 != sum2)
                    {
                    Form3 form = new Form3();
                    form.Show();
                    }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}
