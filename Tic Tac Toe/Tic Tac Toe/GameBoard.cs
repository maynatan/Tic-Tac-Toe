using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Tic_Tac_Toe
{
    public partial class GameBoard : Form
    {
        private char PlayerChar;
        private char OpponentChar;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        // use TCP listener for connection
        public GameBoard(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if(isHost)
            {
                PlayerChar = 'X';
                OpponentChar = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                PlayerChar = 'O';
                OpponentChar = 'X';
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckState())
                return;
            FreezeBoard();
            labelTurn.Text = "Opponent's Turn!";
            ReceiveMove();
            labelTurn.Text = "Your Trun!";
            if (!CheckState())
                UnfreezeBoard();
        }

       // Check GameBoard status - win, lose, draw
        private bool CheckState()
        {
            //Horizontals
            if(buttonBoard1.Text == buttonBoard2.Text && buttonBoard2.Text == buttonBoard3.Text && buttonBoard3.Text != "")
            {
                if(buttonBoard1.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard4.Text == buttonBoard5.Text && buttonBoard5.Text == buttonBoard6.Text && buttonBoard6.Text != "")
            {
                if (buttonBoard4.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard7.Text == buttonBoard8.Text && buttonBoard8.Text == buttonBoard9.Text && buttonBoard9.Text != "")
            {
                if (buttonBoard7.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            //Verticals
            else if (buttonBoard1.Text == buttonBoard4.Text && buttonBoard4.Text == buttonBoard7.Text && buttonBoard7.Text != "")
            {
                if (buttonBoard1.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard2.Text == buttonBoard5.Text && buttonBoard5.Text == buttonBoard8.Text && buttonBoard8.Text != "")
            {
                if (buttonBoard2.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard3.Text == buttonBoard6.Text && buttonBoard6.Text == buttonBoard9.Text && buttonBoard9.Text != "")
            {
                if (buttonBoard3.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard1.Text == buttonBoard5.Text && buttonBoard5.Text == buttonBoard9.Text && buttonBoard9.Text != "")
            {
                if (buttonBoard1.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            else if (buttonBoard3.Text == buttonBoard5.Text && buttonBoard5.Text == buttonBoard7.Text && buttonBoard7.Text != "")
            {
                if (buttonBoard3.Text[0] == PlayerChar)
                {
                    labelTurn.Text = "Winner!";
                    MessageBox.Show("Winner!");
                }
                else
                {
                    labelTurn.Text = "Loser!";
                    MessageBox.Show("Loser!");
                }
                return true;
            }

            //Draw
            else if(buttonBoard1.Text != "" && buttonBoard2.Text != "" && buttonBoard3.Text != "" && buttonBoard4.Text != "" && buttonBoard5.Text != "" && buttonBoard6.Text != "" && buttonBoard7.Text != "" && buttonBoard8.Text != "" && buttonBoard9.Text != "")
            {
                labelTurn.Text = "draw!";
                MessageBox.Show("draw!");
                return true;
            }
            return false;
        }
        private void FreezeBoard()
        {
            buttonBoard1.Enabled = false;
            buttonBoard2.Enabled = false;
            buttonBoard3.Enabled = false;
            buttonBoard4.Enabled = false;
            buttonBoard5.Enabled = false;
            buttonBoard6.Enabled = false;
            buttonBoard7.Enabled = false;
            buttonBoard8.Enabled = false;
            buttonBoard9.Enabled = false;
        }

        private void UnfreezeBoard()
        {
            if (buttonBoard1.Text == "")
                buttonBoard1.Enabled = true;
            if (buttonBoard2.Text == "")
                buttonBoard2.Enabled = true;
            if (buttonBoard3.Text == "")
                buttonBoard3.Enabled = true;
            if (buttonBoard4.Text == "")
                buttonBoard4.Enabled = true;
            if (buttonBoard5.Text == "")
                buttonBoard5.Enabled = true;
            if (buttonBoard6.Text == "")
                buttonBoard6.Enabled = true;
            if (buttonBoard7.Text == "")
                buttonBoard7.Enabled = true;
            if (buttonBoard8.Text == "")
                buttonBoard8.Enabled = true;
            if (buttonBoard9.Text == "")
                buttonBoard9.Enabled = true;
        }

        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
                buttonBoard1.Text = OpponentChar.ToString();
            if (buffer[0] == 2)
                buttonBoard2.Text = OpponentChar.ToString();
            if (buffer[0] == 3)
                buttonBoard3.Text = OpponentChar.ToString();
            if (buffer[0] == 4)
                buttonBoard4.Text = OpponentChar.ToString();
            if (buffer[0] == 5)
                buttonBoard5.Text = OpponentChar.ToString();
            if (buffer[0] == 6)
                buttonBoard6.Text = OpponentChar.ToString();
            if (buffer[0] == 7)
                buttonBoard7.Text = OpponentChar.ToString();
            if (buffer[0] == 8)
                buttonBoard8.Text = OpponentChar.ToString();
            if (buffer[0] == 9)
                buttonBoard9.Text = OpponentChar.ToString();

        }

        //on press function for each button
        private void buttonBoard1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            sock.Send(num);
            buttonBoard1.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            sock.Send(num);
            buttonBoard2.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            sock.Send(num);
            buttonBoard3.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            sock.Send(num);
            buttonBoard4.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            sock.Send(num);
            buttonBoard5.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            sock.Send(num);
            buttonBoard6.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            sock.Send(num);
            buttonBoard7.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            sock.Send(num);
            buttonBoard8.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void buttonBoard9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            sock.Send(num);
            buttonBoard9.Text = PlayerChar.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void GameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }

        private void labelTurn_Click(object sender, EventArgs e)
        {

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
