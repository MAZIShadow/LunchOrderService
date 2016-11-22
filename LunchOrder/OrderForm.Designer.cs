namespace LunchOrder
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiLstMeals = new System.Windows.Forms.ListBox();
            this.uiCbGroups = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiBtnAddOns = new System.Windows.Forms.Button();
            this.uiBtnCancelOrder = new System.Windows.Forms.Button();
            this.uiLblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBtnOrderDinner = new System.Windows.Forms.Button();
            this.uiTreeView = new System.Windows.Forms.TreeView();
            this.uiBtnAddMeal = new System.Windows.Forms.Button();
            this.uiBtnRemoveMeal = new System.Windows.Forms.Button();
            this.uiMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTSMIHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.uiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiLstMeals);
            this.groupBox1.Controls.Add(this.uiCbGroups);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // uiLstMeals
            // 
            this.uiLstMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLstMeals.FormattingEnabled = true;
            this.uiLstMeals.ItemHeight = 24;
            this.uiLstMeals.Location = new System.Drawing.Point(9, 100);
            this.uiLstMeals.Name = "uiLstMeals";
            this.uiLstMeals.Size = new System.Drawing.Size(407, 340);
            this.uiLstMeals.TabIndex = 2;
            // 
            // uiCbGroups
            // 
            this.uiCbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiCbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiCbGroups.FormattingEnabled = true;
            this.uiCbGroups.Location = new System.Drawing.Point(9, 52);
            this.uiCbGroups.Name = "uiCbGroups";
            this.uiCbGroups.Size = new System.Drawing.Size(408, 32);
            this.uiCbGroups.TabIndex = 1;
            this.uiCbGroups.SelectedIndexChanged += new System.EventHandler(this.uiCbGroups_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategoria:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiBtnAddOns);
            this.groupBox2.Controls.Add(this.uiBtnCancelOrder);
            this.groupBox2.Controls.Add(this.uiLblPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.uiBtnOrderDinner);
            this.groupBox2.Controls.Add(this.uiTreeView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(584, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 618);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zamówienie";
            // 
            // uiBtnAddOns
            // 
            this.uiBtnAddOns.Location = new System.Drawing.Point(6, 355);
            this.uiBtnAddOns.Name = "uiBtnAddOns";
            this.uiBtnAddOns.Size = new System.Drawing.Size(103, 34);
            this.uiBtnAddOns.TabIndex = 4;
            this.uiBtnAddOns.Text = "Dodatki";
            this.uiBtnAddOns.UseVisualStyleBackColor = true;
            this.uiBtnAddOns.Click += new System.EventHandler(this.uiBtnAddOns_Click);
            // 
            // uiBtnCancelOrder
            // 
            this.uiBtnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnCancelOrder.Location = new System.Drawing.Point(6, 551);
            this.uiBtnCancelOrder.Name = "uiBtnCancelOrder";
            this.uiBtnCancelOrder.Size = new System.Drawing.Size(431, 61);
            this.uiBtnCancelOrder.TabIndex = 4;
            this.uiBtnCancelOrder.Text = "Anuluj Zamówienie";
            this.uiBtnCancelOrder.UseVisualStyleBackColor = true;
            this.uiBtnCancelOrder.Click += new System.EventHandler(this.uiBtnCancelOrder_Click);
            // 
            // uiLblPrice
            // 
            this.uiLblPrice.AutoSize = true;
            this.uiLblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLblPrice.Location = new System.Drawing.Point(86, 415);
            this.uiLblPrice.Name = "uiLblPrice";
            this.uiLblPrice.Size = new System.Drawing.Size(50, 25);
            this.uiLblPrice.TabIndex = 3;
            this.uiLblPrice.Text = "0 zł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cena:";
            // 
            // uiBtnOrderDinner
            // 
            this.uiBtnOrderDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnOrderDinner.Location = new System.Drawing.Point(6, 477);
            this.uiBtnOrderDinner.Name = "uiBtnOrderDinner";
            this.uiBtnOrderDinner.Size = new System.Drawing.Size(431, 61);
            this.uiBtnOrderDinner.TabIndex = 1;
            this.uiBtnOrderDinner.Text = "ZŁÓŻ ZAMÓWIENIE";
            this.uiBtnOrderDinner.UseVisualStyleBackColor = true;
            this.uiBtnOrderDinner.Click += new System.EventHandler(this.uiBtnOrderDinner_Click);
            // 
            // uiTreeView
            // 
            this.uiTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTreeView.HideSelection = false;
            this.uiTreeView.Location = new System.Drawing.Point(6, 24);
            this.uiTreeView.Name = "uiTreeView";
            this.uiTreeView.Size = new System.Drawing.Size(431, 325);
            this.uiTreeView.TabIndex = 0;
            this.uiTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uiTreeView_AfterSelect);
            // 
            // uiBtnAddMeal
            // 
            this.uiBtnAddMeal.Location = new System.Drawing.Point(459, 83);
            this.uiBtnAddMeal.Name = "uiBtnAddMeal";
            this.uiBtnAddMeal.Size = new System.Drawing.Size(103, 34);
            this.uiBtnAddMeal.TabIndex = 2;
            this.uiBtnAddMeal.Text = ">>";
            this.uiBtnAddMeal.UseVisualStyleBackColor = true;
            this.uiBtnAddMeal.Click += new System.EventHandler(this.uiBtnAddMeal_Click);
            // 
            // uiBtnRemoveMeal
            // 
            this.uiBtnRemoveMeal.Location = new System.Drawing.Point(459, 123);
            this.uiBtnRemoveMeal.Name = "uiBtnRemoveMeal";
            this.uiBtnRemoveMeal.Size = new System.Drawing.Size(103, 34);
            this.uiBtnRemoveMeal.TabIndex = 3;
            this.uiBtnRemoveMeal.Text = "<<";
            this.uiBtnRemoveMeal.UseVisualStyleBackColor = true;
            this.uiBtnRemoveMeal.Click += new System.EventHandler(this.uiBtnRemoveMeal_Click);
            // 
            // uiMenu
            // 
            this.uiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.uiMenu.Location = new System.Drawing.Point(0, 0);
            this.uiMenu.Name = "uiMenu";
            this.uiMenu.Size = new System.Drawing.Size(1039, 24);
            this.uiMenu.TabIndex = 4;
            this.uiMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiTSMIExit});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // uiTSMIExit
            // 
            this.uiTSMIExit.Name = "uiTSMIExit";
            this.uiTSMIExit.Size = new System.Drawing.Size(118, 22);
            this.uiTSMIExit.Text = "Zakończ";
            this.uiTSMIExit.Click += new System.EventHandler(this.uiTSMIExit_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiTSMIHistory});
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.historiaToolStripMenuItem.Text = "Historia";
            // 
            // uiTSMIHistory
            // 
            this.uiTSMIHistory.Name = "uiTSMIHistory";
            this.uiTSMIHistory.Size = new System.Drawing.Size(172, 22);
            this.uiTSMIHistory.Text = "Historia zamówień";
            this.uiTSMIHistory.Click += new System.EventHandler(this.uiTSMIHistory_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiTSMIAbout});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // uiTSMIAbout
            // 
            this.uiTSMIAbout.Name = "uiTSMIAbout";
            this.uiTSMIAbout.Size = new System.Drawing.Size(141, 22);
            this.uiTSMIAbout.Text = "O programie";
            this.uiTSMIAbout.Click += new System.EventHandler(this.uiTSMIAbout_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.uiBtnRemoveMeal);
            this.Controls.Add(this.uiBtnAddMeal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiMenu);
            this.MainMenuStrip = this.uiMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1055, 695);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1055, 695);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Zamówień Posiłków";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.uiMenu.ResumeLayout(false);
            this.uiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uiBtnOrderDinner;
        private System.Windows.Forms.TreeView uiTreeView;
        private System.Windows.Forms.Button uiBtnAddMeal;
        private System.Windows.Forms.Button uiBtnRemoveMeal;
        private System.Windows.Forms.Label uiLblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiBtnCancelOrder;
        private System.Windows.Forms.ComboBox uiCbGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox uiLstMeals;
        private System.Windows.Forms.Button uiBtnAddOns;
        private System.Windows.Forms.MenuStrip uiMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiTSMIExit;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiTSMIHistory;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiTSMIAbout;
    }
}

