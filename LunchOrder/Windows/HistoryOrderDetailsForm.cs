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
    public partial class HistoryOrderDetailsForm : Form
    {
        private readonly HistoryOrderDetailsFormLogic _logic;

        private HistoryOrderDetailsForm()
        {
            InitializeComponent();
        }

        public HistoryOrderDetailsForm(IOrder pOrder) : this()
        {
            _logic = new HistoryOrderDetailsFormLogic(pOrder);
            SetValues();
        }

        private void SetValues()
        {
            uiTxtEmail.Text = _logic.OrderEmail;
            uiDTPOrderDate.Value = _logic.OrderDateTime;
            uiLblOrderPrice.Text = _logic.OrderPrice;
            uiTxtOrderComments.Text = _logic.OrderComments;
            ReloadTree();
        }

        private void ReloadTree()
        {
            uiTreeViewOrderItems.Nodes.Clear();
            uiTreeViewOrderItems.Nodes.Add(_logic.ReloadTreeView());
            uiTreeViewOrderItems.ExpandAll();
        }

        private void uiBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
