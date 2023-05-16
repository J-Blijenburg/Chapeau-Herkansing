using Model;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Table table = new Table();
            table.Number = 1;

            Application.Run(new Login());
        }
    }
}