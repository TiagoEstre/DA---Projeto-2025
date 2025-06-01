using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks.views
{
    public partial class TaskTypeForm : Form
    {
        private readonly Action<Form> _trocarForm;
        public TaskTypeForm(Action<Form> trocarForm)
        {
            InitializeComponent();
            _trocarForm = trocarForm;
        }

        private void b_read_Click(object sender, EventArgs e)
        {
            _trocarForm(new TaskDetailForm());
        }
    }
}
