using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseProject
{
    public partial class PrivilegeChoiceForm : Form
    {
        public PrivilegeChoiceForm()
        {
            InitializeComponent();
        }

        string adminPassword = "753951qwerty";

        private void B_User_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("privileges.lvl");
            sw.WriteLine("user_privilege");
            sw.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GB_AdminDataForEnter.Enabled = true;
            label3.Enabled = true;
            TB_Password.Enabled = true;
        }

        private void TB_Password_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                // Вызываем обработчик события нажатия кнопки
                if (adminPassword == TB_Password.Text)
                {
                    StreamWriter sw = new StreamWriter("privileges.lvl");
                    sw.WriteLine("admin_privilege");
                    sw.Close();
                    Close();
                }
                else
                {
                    L_Error.Text = "Incorrect password!";
                }
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
