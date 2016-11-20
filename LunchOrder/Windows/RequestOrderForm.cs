using System;
using System.Windows.Forms;
using LunchOrder.Entity;
using LunchOrder.Interfaces;

namespace LunchOrder.Windows
{
    public partial class RequestOrderForm : Form
    {
        private readonly RequestOrderFormLogic _logic;

        private RequestOrderForm()
        {
            InitializeComponent();
            uiBtnOk.Enabled = false;
            uiTxtComments.MaxLength = 500;
        }

        public RequestOrderForm(IOrder pOrder) : this()
        {
            _logic = new RequestOrderFormLogic(pOrder);
        }

        private bool IsValid(out string pMessage)
        {
            return _logic.IsValid(out pMessage);
        }

        private void uiBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void uiBtnOk_Click(object sender, EventArgs e)
        {
            _logic.SetEmail(uiTxtEmail.Text);
            _logic.SetComment(uiTxtComments.Text);

            string message;
            if (!IsValid(out message))
            {
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_logic.SendOrder())
            {
                MessageBox.Show("Zamówienie nie zostanie zrealizowane.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void uiTxtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            uiBtnOk.Enabled = !string.IsNullOrWhiteSpace(uiTxtEmail.Text);
        }
    }
}
