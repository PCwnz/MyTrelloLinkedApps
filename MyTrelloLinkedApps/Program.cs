// File Program.cs: Điểm khởi đầu của ứng dụng WinForms
using System;
using System.Windows.Forms;

namespace MyTrelloLinkedApps
{
    // Lớp Program chứa hàm Main - entry point của ứng dụng
    static class Program
    {
        // Thuộc tính này bắt buộc với ứng dụng WinForms để đảm bảo các thao tác với UI chạy trên một luồng STA (Single Thread Apartment)
        [STAThread]
        static void Main()
        {
            // Kích hoạt các kiểu hiển thị hiện đại cho controls (giao diện đẹp hơn)
            Application.EnableVisualStyles();
            // Thiết lập chế độ render text mặc định cho WinForms
            Application.SetCompatibleTextRenderingDefault(false);
            // Chạy form chính của ứng dụng (Form1)
            Application.Run(new Form1());
        }
    }
}
