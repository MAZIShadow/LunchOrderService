using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunchOrder.Interfaces;

namespace LunchOrder.Windows
{
    public partial class HistoryOrderForm : Form
    {
        private readonly HistoryOrderFormLogic _logic;

        public HistoryOrderForm()
        {
            InitializeComponent();
            _logic = new HistoryOrderFormLogic();
            uiDTPFrom.Value = DateTime.Today;
            uiDTPTo.Value = DateTime.Today;
            uiDGVOrders.AutoGenerateColumns = false;
            LoadHistory();
        }

        private void uiBtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadHistory()
        {
            uiDGVOrders.AutoGenerateColumns = false;
            uiDGVOrders.DataSource = _logic.LoadHistoryOrders(uiDTPFrom.Value, uiDTPTo.Value);
            uiDGVOrders.Refresh();
        }

        private void uiDTPFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void uiDTPTo_ValueChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void uiDGVOrders_DoubleClick(object sender, EventArgs e)
        {
            if (uiDGVOrders.SelectedRows.Count <= 0)
            {
                return;
            }

            var order = uiDGVOrders.SelectedRows[0].DataBoundItem as IOrder;

            if (order == null)
            {
                return;
            }

            using (var historyOrderDetailsForm = new HistoryOrderDetailsForm(order)
            {
                StartPosition = FormStartPosition.CenterParent
            })
            {
                historyOrderDetailsForm.ShowDialog();
            }
        }
    }
}
