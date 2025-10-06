using System;
using System.Windows.Forms;

namespace THUCHANH2   // phải trùng với namespace của Form1.cs
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu của ứng dụng WinForms
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Khởi tạo cấu hình mặc định cho WinForms (.NET 6+)
            ApplicationConfiguration.Initialize();

            // Mở form chính
            Application.Run(new Form1());
        }
    }
}
