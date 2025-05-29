using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void cb_Programmer_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Programmer.Checked)
            {
                cb_Manager.Checked = false;
                p_Manager.Visible = false;

                p_Programmer.Visible = true;

                lb_Programmer.Visible = true;
            }
            else
            {
                p_Programmer.Visible = false;

                lb_Programmer.Visible = false;
            }
        }

        private void cb_Manager_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Manager.Checked)
            {
                cb_Programmer.Checked = false;
                p_Programmer.Visible = false;

                p_Manager.Visible = true;

                lb_Manager.Visible = true;
            }
            else
            {
                p_Manager.Visible = false;

                lb_Manager.Visible = false;
            }
        }
    }
}
