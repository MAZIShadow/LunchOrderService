using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LunchOrder.Interfaces;

namespace LunchOrder
{
    public partial class OrderForm : Form
    {
        private readonly OrderFormLogic _logic;

        public OrderForm()
        {
            InitializeComponent();
            _logic = new OrderFormLogic();
            LoadGroups();
            ReloadTree();
        }

        private void LoadMeals(long pGroupId)
        {
            uiLstMeals.Items.Clear();
            uiLstMeals.Items.AddRange(_logic.GetMealsByGroupId(pGroupId).ToArray());
        }

        private void LoadGroups()
        {
            uiCbGroups.Items.Clear();
            uiCbGroups.Items.AddRange(_logic.GetMainGroups().ToArray());
        }

        private void ShowPrice()
        {
            uiLblPrice.Text = string.Format("{0,00} zł", _logic.OrderPrice());
        }

        private void ReloadTree()
        {
            uiTreeView.Nodes.Clear();
            uiTreeView.Nodes.Add(_logic.ReloadTreeView());
            uiTreeView.ExpandAll();
            ShowPrice();
        }

        private void uiBtnAddMeal_Click(object sender, EventArgs e)
        {
            IMeal selectedMeal = uiLstMeals.SelectedItem as IMeal;

            if (selectedMeal == null)
            {
                return;
            }

            _logic.AddMeal(new Entity.Meal(selectedMeal.MealName, selectedMeal.MealPrice));
            ReloadTree();
        }

        private void uiBtnRemoveMeal_Click(object sender, EventArgs e)
        {
            if (uiTreeView.SelectedNode == null)
            {
                return;
            }

            if (uiTreeView.SelectedNode == uiTreeView.TopNode)
            {
                return;
            }

            _logic.RemoveMeal((IMeal)uiTreeView.SelectedNode.Tag);
            ReloadTree();
        }

        private void uiBtnCancelOrder_Click(object sender, EventArgs e)
        {
            _logic.ResetOrder();
            ReloadTree();
        }

        private void uiBtnOrderDinner_Click(object sender, EventArgs e)
        {
            //todo: zlozyc zamowienie
        }

        private void uiCbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMealGroup mealGroup = uiCbGroups.SelectedItem as IMealGroup;

            if (mealGroup == null || !mealGroup.Id.HasValue)
            {
                return;
            }

            LoadMeals(mealGroup.Id.Value);
        }

        private void uiBtnAddOns_Click(object sender, EventArgs e)
        {
            using (AddOnForm addOnForm = new AddOnForm())
            {
                if (addOnForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                //todo: dodać dodatki

                ReloadTree();
            }
        }
    }
}
