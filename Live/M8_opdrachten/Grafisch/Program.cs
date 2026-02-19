
namespace Grafisch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form f1 = new Form();
            f1.Text = "Hello World";
            f1.Width = 800;
            f1.Height = 600;

            Button b1 = new Button();
            b1.Text = "Click me!";
            b1.Width = 140;
            b1.Height = 60;
            b1.Location = new Point(100, 200);

            f1.Controls.Add(b1);

            b1.Click += SetRed;
            b1.Click += SetButtonGreen;

            f1.ShowDialog();
        }

        private static void SetButtonGreen(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            button.BackColor = Color.Green;
        }

        private static void SetRed(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            button.Parent.BackColor = Color.Red;
        }
    }
}