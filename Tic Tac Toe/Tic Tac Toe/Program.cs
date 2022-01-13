using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectionForm());
        }
    }
}
