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
    public partial class AddOnForm : Form
    {
        private readonly AddOnFormLogic _logic;
        public HashSet<IMeal> SelectedAddOns { get; private set; }

        private AddOnForm()
        {
            InitializeComponent();
        }

        public AddOnForm(IMealGroup pMealGroup) : this()
        {
            _logic = new AddOnFormLogic(pMealGroup);
            LoadSubGroups();
        }

        private void uiBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void uiBtnOk_Click(object sender, EventArgs e)
        {
            SetSelectedAddOns();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadSubGroups()
        {
            uiCbGroups.Items.Clear();
            uiCbGroups.Items.AddRange(_logic.GetSubGroups().ToArray());

            if (uiCbGroups.Items.Count == 1)
            {
                uiCbGroups.SelectedIndex = 0;
            }
        }

        private void uiCbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMealGroup mealGroup = uiCbGroups.SelectedItem as IMealGroup;

            if (mealGroup == null)
            {
                return;
            }

            LoadSubMeals(mealGroup.GroupName);
        }

        private void LoadSubMeals(string pGroupName)
        {
            uiChkLstAddOns.Items.Clear();
            uiChkLstAddOns.Items.AddRange(_logic.GetSubMealsBySubGroupId(pGroupName).ToArray());
            uiChkLstAddOns.ItemCheck -= uiChkLstAddOns_ItemCheck;

            for (int i = 0; i < uiChkLstAddOns.Items.Count; i++)
            {
                var meal = uiChkLstAddOns.Items[i] as IMeal;

                if (meal == null)
                {
                    continue;
                }

                if (_logic.GetSelectedMeals().Contains(meal))
                {
                    uiChkLstAddOns.SetItemChecked(i, true);
                }
            }

            uiChkLstAddOns.ItemCheck += uiChkLstAddOns_ItemCheck;

        }

        private void SetSelectedAddOns()
        {
            SelectedAddOns = _logic.GetSelectedMeals();
        }

        private void uiChkLstAddOns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var meal = uiChkLstAddOns.Items[e.Index] as IMeal;

            if (meal == null)
            {
                return;
            }

            switch (e.NewValue)
            {
                case CheckState.Checked:
                    _logic.AddMeal(meal);
                    break;
                case CheckState.Unchecked:
                    _logic.RemoveMeal(meal);
                    break;
            }
        }
    }
}
