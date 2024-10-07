using System.Windows.Forms;
using System;
using System.Drawing;
namespace Abstract_Factory
{
    public class Program : Form1
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Program());
        }
    }
}