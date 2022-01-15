using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        private const string Temp_DIR = "ItSoftware_Temp";
        private void CopyFiles()
        {
            try
            {
                //xác định thư mục hiện thời, nơi chương trình đang chạy
                string currentDirectory = Environment.CurrentDirectory;
                //xác định thư mục tạm, nơi Program1.exe đã tải các file cần cập nhật về
                string tempDirectory = Path.GetTempPath() + Temp_DIR;
                //lấy danh sách tất cả các file trong thư mục tạm
                string[] fileList = Directory.GetFiles(tempDirectory);
                //duyệt từng file và copy đè lên file cũ trong thư mục đang chạy chương trình
                foreach (string sourceFile in fileList)
                {
                    //tách tên file ra khỏi đường dẫn (tên file sẽ dùng để tạo đường dẫn đích cần copy đè)
                    string fileName = Path.GetFileName(sourceFile);
                    //progressBarControl1.Text = "Cập nhật: " + fileName;
                    //tạo đường dẫn đích để copy file mới tới
                    string destinationFile = string.Format("{0}\\{1}", currentDirectory, fileName);
                    File.Copy(sourceFile, destinationFile, true);
                }
                //sau khi copy đè tất cả các file xong, ta sẽ tiến hành gọi lại chương trình chính (Program1.exe) để chạy lại chương trình
                Process.Start("warehouseIT.exe");
                //và thoát khỏi chương trình update
                Application.Exit();
            }
            catch
            {
                Application.Exit();
            }

        }

        private void Update_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            //tiến hành ghi đè file
            CopyFiles();
        }
    }
}
