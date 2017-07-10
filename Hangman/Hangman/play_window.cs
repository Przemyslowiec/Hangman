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
        Graphics g;
        Pen p;
        public play_window(string path)
        {
            InitializeComponent();
            pattern = "";
            random = new Random(Guid.NewGuid().GetHashCode());
            how_much_letters = 10;
            t = File.ReadAllLines(path);
            g = panel.CreateGraphics();
            p = new Pen(Color.Black, 6);

        }

        private void message_box(string message, string title)
        {
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
                draw(how_much_letters);

                --how_much_letters;
            }
            if (how_much_letters == 0)
            {
                message_box(" You lose! \n Play agian?", "Game state:");
            }
            else
            {
                letters_texbox.Text = "You have: " + how_much_letters.ToString() + " letters";
            }
            textBox.Text = gotowe;
            if (pattern.ToString().ToUpper() == gotowe.ToUpper())
            {
                message_box(" You win! \n Play agian?", "Game state:");
            }

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
        void draw(int r)
        {
            switch (r)
            {
                case 10:
                    g.DrawLine(p, new Point(380, 200), new Point(280, 200));
                    break;
                case 9:
                    g.DrawLine(p, new Point(330, 200), new Point(330, 10));
                    break;                    
                case 8:
                    g.DrawLine(p, new Point(333, 10), new Point(180, 10));
                    break;
                case 7:
                    g.DrawLine(p, new Point(183, 10), new Point(183, 60));
                    break;
                case 6:
                    g.DrawEllipse(p, 164, 60, 40, 40);
                    break;
                case 5:
                    //tułów
                    g.DrawLine(p, new Point(183, 100), new Point(183, 150));
                    break;
                case 4:
                    //nogi
                    g.DrawLine(p, new Point(183, 150), new Point(150, 185));
                    break;
                case 3:
                    g.DrawLine(p, new Point(183, 150), new Point(216, 185));
                    break;
                case 2:
                    //ręce
                    g.DrawLine(p, new Point(183, 120), new Point(150, 155));
                    break;
                case 1:
                    g.DrawLine(p, new Point(183, 120), new Point(216, 155));
                    break;
            }
        }
        private void q_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(q_button.Text.ToString());
            q_button.BackColor = Color.Blue;
        }

        private void w_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(w_button.Text.ToString());
            w_button.BackColor = Color.Blue;
        }

        private void e_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(e_button.Text.ToString());
            e_button.BackColor = Color.Blue;
        }

        private void r_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(r_button.Text.ToString());
            r_button.BackColor = Color.Blue;
        }

        private void t_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(t_button.Text.ToString());
            t_button.BackColor = Color.Blue;
        }

        private void y_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(y_button.Text.ToString());
            y_button.BackColor = Color.Blue;
        }

        private void u_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(u_button.Text.ToString());
            u_button.BackColor = Color.Blue;
        }

        private void i_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(i_button.Text.ToString());
            i_button.BackColor = Color.Blue;
        }

        private void o_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(o_button.Text.ToString());
            o_button.BackColor = Color.Blue;
        }

        private void p_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(p_button.Text.ToString());
            p_button.BackColor = Color.Blue;
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(a_button.Text.ToString());
            a_button.BackColor = Color.Blue;
        }

        private void s_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(s_button.Text.ToString());
            s_button.BackColor = Color.Blue;
        }

        private void d_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(d_button.Text.ToString());
            d_button.BackColor = Color.Blue;
        }

        private void f_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(f_button.Text.ToString());
            f_button.BackColor = Color.Blue;
        }

        private void g_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(g_button.Text.ToString());
            g_button.BackColor = Color.Blue;
        }

        private void h_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(h_button.Text.ToString());
            h_button.BackColor = Color.Blue;
        }

        private void j_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(j_button.Text.ToString());
            j_button.BackColor = Color.Blue;
        }

        private void k_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(k_button.Text.ToString());
            k_button.BackColor = Color.Blue;
        }

        private void l_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(l_button.Text.ToString());
            l_button.BackColor = Color.Blue;
        }

        private void z_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(z_button.Text.ToString());
            z_button.BackColor = Color.Blue;
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(x_button.Text.ToString());
            x_button.BackColor = Color.Blue;
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(c_button.Text.ToString());
            c_button.BackColor = Color.Blue;
        }

        private void v_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(v_button.Text.ToString());
            v_button.BackColor = Color.Blue;
        }

        private void b_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(b_button.Text.ToString());
            b_button.BackColor = Color.Blue;
        }

        private void n_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(n_button.Text.ToString());
            n_button.BackColor = Color.Blue;
        }

        private void m_button_Click(object sender, EventArgs e)
        {
            change_string_check_letter(m_button.Text.ToString());
            m_button.BackColor = Color.Blue;
        }

    }
}
