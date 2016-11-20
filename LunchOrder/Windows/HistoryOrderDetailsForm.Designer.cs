namespace LunchOrder.Windows
{
    partial class HistoryOrderDetailsForm
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
            this.uiTxtOrderComments = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiLblOrderPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiDTPOrderDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uiTreeViewOrderItems = new System.Windows.Forms.TreeView();
            this.uiBtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiTxtOrderComments);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(11, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uwagi";
            // 
            // uiTxtOrderComments
            // 
            this.uiTxtOrderComments.BackColor = System.Drawing.SystemColors.Window;
            this.uiTxtOrderComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTxtOrderComments.Location = new System.Drawing.Point(6, 25);
            this.uiTxtOrderComments.Multiline = true;
            this.uiTxtOrderComments.Name = "uiTxtOrderComments";
            this.uiTxtOrderComments.ReadOnly = true;
            this.uiTxtOrderComments.Size = new System.Drawing.Size(439, 249);
            this.uiTxtOrderComments.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiLblOrderPrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.uiTxtEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.uiDTPOrderDate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 137);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane zamowienia";
            // 
            // uiLblOrderPrice
            // 
            this.uiLblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLblOrderPrice.Location = new System.Drawing.Point(155, 96);
            this.uiLblOrderPrice.Name = "uiLblOrderPrice";
            this.uiLblOrderPrice.Size = new System.Drawing.Size(290, 25);
            this.uiLblOrderPrice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(75, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data:";
            // 
            // uiTxtEmail
            // 
            this.uiTxtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.uiTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTxtEmail.Location = new System.Drawing.Point(155, 60);
            this.uiTxtEmail.Name = "uiTxtEmail";
            this.uiTxtEmail.ReadOnly = true;
            this.uiTxtEmail.Size = new System.Drawing.Size(290, 29);
            this.uiTxtEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adres email:";
            // 
            // uiDTPOrderDate
            // 
            this.uiDTPOrderDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.uiDTPOrderDate.Enabled = false;
            this.uiDTPOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDTPOrderDate.Location = new System.Drawing.Point(155, 25);
            this.uiDTPOrderDate.Name = "uiDTPOrderDate";
            this.uiDTPOrderDate.Size = new System.Drawing.Size(290, 29);
            this.uiDTPOrderDate.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uiTreeViewOrderItems);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(475, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 423);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zamówienie";
            // 
            // uiTreeViewOrderItems
            // 
            this.uiTreeViewOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTreeViewOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTreeViewOrderItems.HideSelection = false;
            this.uiTreeViewOrderItems.Location = new System.Drawing.Point(6, 24);
            this.uiTreeViewOrderItems.Name = "uiTreeViewOrderItems";
            this.uiTreeViewOrderItems.Size = new System.Drawing.Size(436, 393);
            this.uiTreeViewOrderItems.TabIndex = 1;
            // 
            // uiBtnClose
            // 
            this.uiBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnClose.Location = new System.Drawing.Point(820, 454);
            this.uiBtnClose.Name = "uiBtnClose";
            this.uiBtnClose.Size = new System.Drawing.Size(103, 34);
            this.uiBtnClose.TabIndex = 10;
            this.uiBtnClose.Text = "Zamknij";
            this.uiBtnClose.UseVisualStyleBackColor = true;
            this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
            // 
            // HistoryOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 496);
            this.Controls.Add(this.uiBtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistoryOrderDetailsForm";
            this.Text = "Szczegóły zamówienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox uiTxtOrderComments;
        private System.Windows.Forms.DateTimePicker uiDTPOrderDate;
        private System.Windows.Forms.Label uiLblOrderPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiTxtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView uiTreeViewOrderItems;
        private System.Windows.Forms.Button uiBtnClose;
    }
}