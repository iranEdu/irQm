using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class BackupAndRestoreForm : MasterForm
    {
        public BackupAndRestoreForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnselectpath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.Substring(0,1)=="C")
                
                    MessageBox.Show("مسیری غیر از درایو\n "+"C \n"+"را برای فایل پشتیبان انتخاب کنید");
                    if (folderBrowserDialog1.SelectedPath.Length>350)
                   
                        MessageBox.Show("مسیری که برای فایل پشتیبان انتخاب کرده‌اید، طولانی می‌باشد");
                    else
                {
                    txtselectpath.Text = folderBrowserDialog1.SelectedPath;
                }
               
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtselectpath.Text))
                errorProvider1.SetError(txtselectpath, "مسیر ذخیره فایل پشتیبان را مشخص کنید");
            else if (string.IsNullOrWhiteSpace(txtbackupname.Text))
                errorProvider1.SetError(txtbackupname, "نام فایل پشتیبان را وارد نمایید");
            else
            {

            
            }
        }
    }
}
