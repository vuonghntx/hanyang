using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseIT
{
    public class saveConfigRegedit
    {
        public string ThongBao { get; set; }
        public string NoiDungThongBao { get; set; }
        public string UserName { get; set; }
        public string language { get; set; }
        public string FullName { get; set; }
        public string IsRoot { get; set; }
        public string IDQuyen { get; set; }
        //mykey.SetValue("UserName", username);
        //    mykey.SetValue("FullName", username);
        //    mykey.SetValue("IsRoot", username);
        //    mykey.SetValue("IDQuyen", username);
        public saveConfigRegedit()
        {
            readFromResgistry();
        }
        public void readFromResgistry()
        {
            Microsoft.Win32.RegistryKey currenUserName = Microsoft.Win32.Registry.CurrentUser;
            Microsoft.Win32.RegistryKey currenSoftware = currenUserName.OpenSubKey("Software");
            Microsoft.Win32.RegistryKey curenKeyConfig = currenSoftware.OpenSubKey("warehouseit", true);
            if (curenKeyConfig == null)
            {
                return;
            }
            else
            {
                string temp1 = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\warehouseit", "UserName", null));
                string temp2 = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\warehouseit", "language", null));
                string temp3 = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\warehouseit", "FullName", null));
                string temp4 = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\warehouseit", "IsRoot", null));
                string temp5 = (string)(Registry.GetValue(@"HKEY_CURRENT_USER\Software\warehouseit", "IDQuyen", null));
                if (temp1 != null)
                {
                    this.UserName = temp1.ToString().Trim();
                }
                if (temp2 != null)
                {
                    this.language = temp2.ToString().Trim();
                }
                if (temp3 != null)
                {
                    this.FullName = temp3.ToString().Trim();
                }
                if (temp4 != null)
                {
                    this.IsRoot = temp4.ToString().Trim();
                }
                if (temp5 != null)
                {
                    this.IDQuyen = temp5.ToString().Trim();
                }
            }
            currenUserName.Close();
        }
        public void savelogin(string username,string fullname, string isroot, string nhomquyenid)
        {
            Microsoft.Win32.RegistryKey mykey;
            mykey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\warehouseit");
            mykey.SetValue("UserName", username);
            mykey.SetValue("FullName", fullname);
            mykey.SetValue("IsRoot", isroot);
            mykey.SetValue("IDQuyen", nhomquyenid);

        }
        public void savelanguage(string language)
        {
            Microsoft.Win32.RegistryKey mykey;
            mykey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\warehouseit");
            mykey.SetValue("language", language);
        }
       
    }
}
