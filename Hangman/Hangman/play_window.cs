using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class play_window : Form
    {
        public play_window()
        {
            InitializeComponent();
        }
        string test = "Tesqt - tqext";


        private void funk(string s)
        {
            textBox.Text = "";
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i].ToString().ToLower() == s.ToLower())
                {
                    textBox.Text += s.ToLower();
                }
                else
                {
                    if (test[i].ToString() == "-")
                    {
                        textBox.Text += "-";
                    }
                    else
                    {
                        textBox.Text += "_";
                    }
                }
                
                textBox.Text += " ";
            }
        }
        private void play_window_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                {
                    if (test[i] == '-')
                    {
                        textBox.Text += "- ";
                    }
                    textBox.Text += "_ ";
                }
                else
                {
                    textBox.Text += "   ";
                }
            }
        }

        private void q_button_Click(object sender, EventArgs e)
        {
            funk(q_button.Text.ToString());
        }

        private void w_button_Click(object sender, EventArgs e)
        {
            funk(w_button.Text.ToString());
        }

        private void e_button_Click(object sender, EventArgs e)
        {
            funk(e_button.Text.ToString());
        }

        private void r_button_Click(object sender, EventArgs e)
        {
            funk(r_button.Text.ToString());

        }

        private void t_button_Click(object sender, EventArgs e)
        {
            funk(t_button.Text.ToString());

        }

        private void y_button_Click(object sender, EventArgs e)
        {
            funk(y_button.Text.ToString());

        }

        private void u_button_Click(object sender, EventArgs e)
        {
            funk(u_button.Text.ToString());

        }

        private void i_button_Click(object sender, EventArgs e)
        {
            funk(i_button.Text.ToString());

        }

        private void o_button_Click(object sender, EventArgs e)
        {
            funk(o_button.Text.ToString());

        }

        private void p_button_Click(object sender, EventArgs e)
        {
            funk(p_button.Text.ToString());

        }

        private void a_button_Click(object sender, EventArgs e)
        {
            funk(a_button.Text.ToString());

        }

        private void s_button_Click(object sender, EventArgs e)
        {
            funk(s_button.Text.ToString());

        }

        private void d_button_Click(object sender, EventArgs e)
        {
            funk(d_button.Text.ToString());

        }

        private void f_button_Click(object sender, EventArgs e)
        {
            funk(f_button.Text.ToString());

        }

        private void g_button_Click(object sender, EventArgs e)
        {
            funk(g_button.Text.ToString());

        }

        private void h_button_Click(object sender, EventArgs e)
        {
            funk(h_button.Text.ToString());

        }

        private void j_button_Click(object sender, EventArgs e)
        {
            funk(j_button.Text.ToString());

        }

        private void k_button_Click(object sender, EventArgs e)
        {
            funk(k_button.Text.ToString());

        }

        private void l_button_Click(object sender, EventArgs e)
        {
            funk(l_button.Text.ToString());

        }

        private void z_button_Click(object sender, EventArgs e)
        {
            funk(z_button.Text.ToString());

        }

        private void x_button_Click(object sender, EventArgs e)
        {
            funk(x_button.Text.ToString());

        }

        private void c_button_Click(object sender, EventArgs e)
        {
            funk(c_button.Text.ToString());

        }

        private void v_button_Click(object sender, EventArgs e)
        {
            funk(v_button.Text.ToString());

        }

        private void b_button_Click(object sender, EventArgs e)
        {
            funk(b_button.Text.ToString());

        }

        private void n_button_Click(object sender, EventArgs e)
        {
            funk(n_button.Text.ToString());

        }

        private void m_button_Click(object sender, EventArgs e)
        {
            funk(m_button.Text.ToString());

        }
    }
}
