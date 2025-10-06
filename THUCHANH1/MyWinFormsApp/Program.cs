using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu ứng dụng
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cấu hình mặc định cho WinForms (.NET 6+)
            ApplicationConfiguration.Initialize();

            // Khởi chạy Form1
            Application.Run(new Form1());
        }
    }
}
