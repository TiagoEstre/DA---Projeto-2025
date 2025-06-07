using iTasks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class TaskDetailForm : Form
    {
        public TaskDetailForm()
        {
            InitializeComponent();
            Enum.GetValues(typeof(CurrentStatus));
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            string description = tb_Description.Text;
            string taskTipe = cb_TaskTipe.Text;
            string Order = tb_Order.Text;
            string programmer = cb_Programmer.Text;
            string storyPoints = tb_StoryPoints.Text;
            string startDate = stp_StartDate.Text;
            string endDate = stp_EndDate.Text;

            using (var db = new iTasksContext())
            {
                try
                {
                    var newTaks = new Tasks()
                    {
                        Description = description,
                        
                    };
                }
                catch
                { 
                
                }
            }

        }
    }
}
