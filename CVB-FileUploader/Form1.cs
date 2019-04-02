using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVB_FileUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectorySecurity dSecurity = Directory.GetAccessControl(@"c:\Windows");
            foreach (FileSystemAccessRule rule in dSecurity.GetAccessRules(true, true, typeof(NTAccount)))
            {
                listView1.Items.Add(rule.IdentityReference.Value.ToString());
                /*if (rule.FileSystemRights == FileSystemRights.Read)
                {
                    listView1.Items.Add("Account:{0}", rule.IdentityReference.Value);
                    //Console.WriteLine("Account:{0}", rule.IdentityReference.Value);
                }*/
            }
        }
    }
}
