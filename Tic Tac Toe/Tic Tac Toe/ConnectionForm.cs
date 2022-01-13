using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameBoard newGameBoard = new GameBoard(false, textBoxHost.Text);
            Visible = false;
            if (!newGameBoard.IsDisposed)
                newGameBoard.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameBoard newGameBoard = new GameBoard(true);
            Visible = false;
            if (!newGameBoard.IsDisposed)
                newGameBoard.ShowDialog();
            Visible = true;
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
        }

        private void groupBoxConnect_Enter(object sender, EventArgs e)
        {
        }
    }
}
