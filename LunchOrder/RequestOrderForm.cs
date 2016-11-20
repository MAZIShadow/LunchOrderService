using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunchOrder.Entity;

namespace LunchOrder
{
    public partial class RequestOrderForm : Form
    {
        private RequestOrderForm()
        {
            InitializeComponent();
        }

        public RequestOrderForm(Order logicOrder) : this()
        {
        }

        private void uiBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void uiBtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
