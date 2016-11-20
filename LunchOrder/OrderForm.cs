using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;
using LunchOrder.Windows;

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

        private void LoadMeals(string pGroupName)
        {
            uiLstMeals.Items.Clear();
            uiLstMeals.Items.AddRange(_logic.GetMealsByGroupName(pGroupName).ToArray());
        }

        private bool GroupHasSubGroups(IMealGroup pMealGroup)
        {
            return _logic.GroupHasSubGroups(pMealGroup);
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
            uiTreeView.SelectedNode = uiTreeView.Nodes[0];
            ShowPrice();
        }

        private void uiBtnAddMeal_Click(object sender, EventArgs e)
        {
            IMeal selectedMeal = uiLstMeals.SelectedItem as IMeal;

            if (selectedMeal == null)
            {
                return;
            }

            _logic.AddMeal(new Entity.Meal(selectedMeal.MealName, selectedMeal.MealPrice, selectedMeal.MealGroup));
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
            if (!_logic.IsOrderHasMeals())
            {
                return;
            }

            if (
                MessageBox.Show("Czy jesteś pewny anulowania zamowienia?", "Pytanie", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _logic.ResetOrder();
            ReloadTree();
        }

        private void uiBtnOrderDinner_Click(object sender, EventArgs e)
        {
            using (RequestOrderForm requestOrderForm = new RequestOrderForm(_logic.Order)
            {
                StartPosition = FormStartPosition.CenterParent
            })
            {
                if (requestOrderForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _logic.ResetOrder();
                ReloadTree();
            }
        }

        private void uiCbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMealGroup mealGroup = uiCbGroups.SelectedItem as IMealGroup;

            if (mealGroup == null)
            {
                return;
            }

            LoadMeals(mealGroup.GroupName);
        }

        private void uiBtnAddOns_Click(object sender, EventArgs e)
        {
            var node = uiTreeView.SelectedNode;

            if (node == null)
            {
                return;
            }

            var meal = node.Tag as IMeal;

            if (meal == null || meal.MealGroup == null)
            {
                return;
            }
            try
            {
                using (var addOnForm = new AddOnForm(meal.MealGroup)
                {
                    StartPosition = FormStartPosition.CenterParent
                })
                {
                    if (addOnForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    meal.AddOns = addOnForm.SelectedAddOns;
                    ReloadTree();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = uiTreeView.SelectedNode;

            if (node == null)
            {
                return;
            }

            var meal = node.Tag as IMeal;
            uiBtnAddOns.Enabled = meal != null && GroupHasSubGroups(meal.MealGroup);
        }
    }
}
