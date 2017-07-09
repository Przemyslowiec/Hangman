using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class play_window : Form
    {
        private static int how_much_letters;
        private string pattern;
        private string test;
        private Random random;
        private string[] t;

        public play_window()
        {
            InitializeComponent();
            pattern = "";
            random = new Random(Guid.NewGuid().GetHashCode());
            how_much_letters = 10;
            t = File.ReadAllLines(@"D:\Programy\Repozytorium\Hangman\Hangman\Hangman\animals.txt");
        }

        private void message_box(string message, string title)
        {
           // string message = " You lose! \n Play agian?";
            //string title = "Game state:";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                how_much_letters = 10;
            }
            else
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

        }

        private void change_string_check_letter(string s)
        {
            string tekst_aktualny = textBox.Text;
            string gotowe = "";

            for (int i = 0; i<pattern.Length; i++)
            {
                if (tekst_aktualny[i] =='_')
                {
                    if (pattern[i].ToString().ToUpper() == s.ToUpper())
                    {
                        gotowe += s.ToUpper();
                    }
                    else
                    {
                        gotowe += "_";
                    }
                }
                else
                {
                    gotowe += tekst_aktualny[i];
                }
            }
            if(tekst_aktualny == gotowe)
            {
                --how_much_letters;
            }
            if (how_much_letters == 0)
            {
                message_box(" You lose! \n Play agian?", "Game state:");
            }
            textBox.Text = gotowe;
            if (pattern.ToString().ToUpper() == gotowe.ToUpper())
            {
                message_box(" You win! \n Play agian?", "Game state:");
            }

            letters_texbox.Text = "You have: " + how_much_letters.ToString() + " letters";
        }


        private void play_window_Load(object sender, EventArgs e)
        {
            test = t[random.Next(0,t.Length)];
            System.Console.Write(test);
            letters_texbox.Text = "You have: " + how_much_letters.ToString() + " letters";
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ' ')
                {
                    if (test[i] == '-')
                    {
                        textBox.Text += "- ";
                        pattern += "- ";
                    }
                    else
                    {
                        textBox.Text += "_ ";
                        pattern += test[i]+" ";
                    }
                }
                else
                {
                    textBox.Text += "   ";
                    pattern += "   ";
                }
            }
        }

        private void q_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(q_button.Text.ToString());
        }

        private void w_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(w_button.Text.ToString());
        }

        private void e_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(e_button.Text.ToString());
        }

        private void r_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(r_button.Text.ToString());
        }

        private void t_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(t_button.Text.ToString());
        }

        private void y_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(y_button.Text.ToString());
        }

        private void u_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(u_button.Text.ToString());
        }

        private void i_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(i_button.Text.ToString());
        }

        private void o_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(o_button.Text.ToString());
        }

        private void p_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(p_button.Text.ToString());
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(a_button.Text.ToString());
        }

        private void s_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(s_button.Text.ToString());
        }

        private void d_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(d_button.Text.ToString());
        }

        private void f_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(f_button.Text.ToString());
        }

        private void g_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(g_button.Text.ToString());
        }

        private void h_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(h_button.Text.ToString());
        }

        private void j_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(j_button.Text.ToString());
        }

        private void k_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(k_button.Text.ToString());
        }

        private void l_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(l_button.Text.ToString());
        }

        private void z_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(z_button.Text.ToString());
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(x_button.Text.ToString());
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(c_button.Text.ToString());
        }

        private void v_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(v_button.Text.ToString());
        }

        private void b_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(b_button.Text.ToString());
        }

        private void n_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(n_button.Text.ToString());
        }

        private void m_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(m_button.Text.ToString());
        }
    }
}
