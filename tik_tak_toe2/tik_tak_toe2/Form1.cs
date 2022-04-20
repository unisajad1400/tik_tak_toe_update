namespace tik_tak_toe2
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int ply;

        public Form1()
        {
            InitializeComponent();

            ply = 1;

            dokmeha = new Button[3, 3] { {button1, button2, button3},
                                         {button4, button5, button6},
                                         {button7, button8, button9}};
            new_game();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                    dokmeha[i, j].Text = "";

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Button this_button = (sender as Button);

            if (radioButton1.Checked == true)
            {
                if (this_button.Text == "")
                {
                    if (ply == 1)
                    {
                        this_button.Text = "X";
                        this_button.ForeColor = Color.Green;
                        this_button.BackColor = Color.LightGreen;
                        ply = 2;
                    }
                    else if (ply == 2)
                    {
                        this_button.Text = "0";
                        this_button.ForeColor = Color.Red;
                        this_button.BackColor = Color.Pink;
                        ply = 1;
                    }
                }
                row();
                cloumn();
                diagonal();
            }
            else if (radioButton2.Checked == true)
            {
                Button button = (sender as Button);

                if (button.Text == "")
                {
                    button.Text = "X";
                    button.ForeColor = Color.Green;
                    button.BackColor = Color.LightGreen;
                }
                user_Two();

                row();
                cloumn();
                diagonal();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();
        }

        private void new_game()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }
            }

            ply = 1;
        }

        private void row()
        {
            int countX = 0;
            int countZiro = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[i, j].Text == "X")
                    {
                        countX++;
                    }

                    if (dokmeha[i, j].Text == "0")
                    {
                        countZiro++;
                    }
                }

                if (countX == 3)
                {
                    MessageBox.Show("بازیکن شماره 1 برنده است");
                }
                if (countZiro == 3)
                {
                    MessageBox.Show("بازیکن شماره 2 برنده است");
                }
               
                countX = 0;
                countZiro = 0;
            }
        }

        private void cloumn()
        {
            int countX = 0;
            int countZiro = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[j, i].Text == "X")
                    {
                        countX++;
                    }

                    if (dokmeha[j, i].Text == "0")
                    {
                        countZiro++;
                    }
                }

                if (countX == 3)
                {
                    MessageBox.Show("بازیکن شماره 1 برنده است");
                }

                if (countZiro == 3)
                {
                    MessageBox.Show("بازیکن شماره 2 برنده است");
                }

                countZiro = 0;
                countX = 0;
            }
        }

        private void diagonal()
        {
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده است");
            }
            else if (dokmeha[0, 0].Text == "0" && dokmeha[1, 1].Text == "0" && dokmeha[2, 2].Text == "0")
            {
                MessageBox.Show("بازیکن شماره 2 برنده است");
            }

            else if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده است");
            }
            else if (dokmeha[0, 2].Text == "0" && dokmeha[1, 1].Text == "0" && dokmeha[2, 0].Text == "0")
            {
                MessageBox.Show("بازیکن شماره 2 برنده است");
            }
        }

        private void user_Two()
        {
            int step = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = i; j < 3; j++)
                {
                    if (dokmeha[i, j].Text == "" &&  step == 0)
                    {
                        dokmeha[i, j].Text = "0";
                        dokmeha[i, j].ForeColor = Color.Red;
                        dokmeha[i, j].BackColor = Color.Pink;

                       step = 1;
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}