using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bootleg
{
    public partial class Bootleg_game : Form
    {
        List<String> shots=new List<String>();
        int p_lives=4;
        int d_lives=4;

        int total;
        int blank;
        Boolean turn;
        Boolean game;
        public Bootleg_game()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //shoot yourself
            String line;

            

            line = shots[0];
            shots.RemoveAt(0);
            if (game)
            {
                if (turn && p_lives > 0)
                {
                    Event_box.Text = "You shot yourself. It is a " + line;
                    turn = false;
                    if (line == "blank")
                    {
                        turn = true;
                    }

                    if (line == "live")
                    {
                        p_lives--;
                        update_life();
                    }

                }
                else
                {
                    Event_box.Text = "End your turn. NOW";
                    if (p_lives == 0)
                    {
                        Event_box.Text = "Press retry to restart";
                    }
                }

                if (shots.Count == 0)
                {
                    Load_shell();
                }
            }
            else { Event_box.Text = "He is dead already. Press retry"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //shoot him
            String line;

            
            line = shots[0];
            shots.RemoveAt(0);

            if (game)
            {
                if (turn && p_lives > 0)
                {
                    Event_box.Text = "You shot him. It is a " + line;
                    turn = false;
                    if (line == "live")
                    {
                        d_lives--;
                        update_life();
                    }
                }
                else
                {
                    Event_box.Text = "End your turn. NOW";
                    if (p_lives == 0)
                    {
                        Event_box.Text = "Press retry to restart";
                    }
                }

                if (shots.Count == 0)
                {
                    Load_shell();
                }
            }
            else
            {
                Event_box.Text = "He is dead already. Press retry";
            }


        }

        private void Bootleg_game_Load(object sender, EventArgs e)
        {
            shots = new List<String>();
            p_lives = 4;
            d_lives = 4;
            Lives_of_yours.Text = p_lives.ToString();
            Lives_of_his.Text = d_lives.ToString();
            game = true;
            Load_shell();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shots = new List<String>();
            p_lives = 4;
            d_lives = 4;
            Lives_of_yours.Text = p_lives.ToString();
            Lives_of_his.Text = d_lives.ToString();
            game = true;
            Load_shell();


        }

        private void Lives_of_yours_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lives_of_his_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (game)
            {
                if (!turn && p_lives > 0)
                {
                    turn = true;
                    //his turn
                    String line;
                    line = shots[0];
                    shots.RemoveAt(0);

                    double chance = (double)blank / total;
                    chance = (chance * 100.00);


                    if ((int)chance <= 50)
                    {
                        Event_box.Text = "He shot you. It is a " + line;
                        if (line == "live")
                        {
                            p_lives--;
                            update_life();
                        }
                    }

                    if (chance > 50.00)
                    {
                        Event_box.Text = "He shot himself. It is a " + line;
                        if (line == "live")
                        {
                            d_lives--;
                            update_life();
                        }
                        if (line == "blank")
                        {
                            turn = false;
                        }


                    }





                    if (shots.Count == 0)
                    {
                        Load_shell();
                    }

                }
                else
                {
                    Event_box.Text = (total - blank).ToString() + " live " + blank.ToString() + " blank. Don't throw away your life";
                    if (p_lives == 0)
                    {
                        Event_box.Text = "Game Over, pal. Press retry";
                    }
                }
            }
            else
            { Event_box.Text = "He is dead already. Press retry"; }


        }

        private void update_life()
        {
            Lives_of_yours.Text = p_lives.ToString();
            Lives_of_his.Text = d_lives.ToString();

            if (p_lives == 0)
            { Event_box.Text = "Game Over, pal. Press retry"; }
            if (d_lives == 0)
            { Event_box.Text = "He is dead already. Press retry";
                game = false;
            }
        }

        private void Load_shell()
        {
            turn = true;
           
            Random r_t=new Random();
            Random r_b = new Random();
            total = r_t.Next(2,8);
            blank = r_b.Next(1,total-1);
            


            List<String> bar = new List<String>();

            for (int i = 0; i < blank; i++)
            {
                bar.Add("blank");
            }
            for (int i = 0; i < total - blank; i++)
            {
                bar.Add("live");
            }

            Event_box.Text = (total-blank).ToString() + " live " + blank.ToString()+" blank";

            int n;

            while (bar.Count > 0)
            {
                n=r_t.Next(0,bar.Count()-1);
                shots.Add(bar[n]);
                bar.RemoveAt(n);
            }
            
           

        }

       
    }
}
