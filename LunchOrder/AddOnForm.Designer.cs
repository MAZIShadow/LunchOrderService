namespace LunchOrder
{
    partial class AddOnForm
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
            this.uiCbGroups = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiChkLstAddOns = new System.Windows.Forms.CheckedListBox();
            this.uiBtnCancel = new System.Windows.Forms.Button();
            this.uiBtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiCbGroups
            // 
            this.uiCbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiCbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiCbGroups.FormattingEnabled = true;
            this.uiCbGroups.Location = new System.Drawing.Point(15, 32);
            this.uiCbGroups.Name = "uiCbGroups";
            this.uiCbGroups.Size = new System.Drawing.Size(408, 32);
            this.uiCbGroups.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategoria:";
            // 
            // uiChkLstAddOns
            // 
            this.uiChkLstAddOns.FormattingEnabled = true;
            this.uiChkLstAddOns.Location = new System.Drawing.Point(15, 70);
            this.uiChkLstAddOns.Name = "uiChkLstAddOns";
            this.uiChkLstAddOns.Size = new System.Drawing.Size(408, 304);
            this.uiChkLstAddOns.TabIndex = 5;
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnCancel.Location = new System.Drawing.Point(320, 380);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(103, 34);
            this.uiBtnCancel.TabIndex = 6;
            this.uiBtnCancel.Text = "Anuluj";
            this.uiBtnCancel.UseVisualStyleBackColor = true;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // uiBtnOk
            // 
            this.uiBtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnOk.Location = new System.Drawing.Point(211, 380);
            this.uiBtnOk.Name = "uiBtnOk";
            this.uiBtnOk.Size = new System.Drawing.Size(103, 34);
            this.uiBtnOk.TabIndex = 7;
            this.uiBtnOk.Text = "OK";
            this.uiBtnOk.UseVisualStyleBackColor = true;
            this.uiBtnOk.Click += new System.EventHandler(this.uiBtnOk_Click);
            // 
            // AddOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 430);
            this.Controls.Add(this.uiBtnOk);
            this.Controls.Add(this.uiBtnCancel);
            this.Controls.Add(this.uiChkLstAddOns);
            this.Controls.Add(this.uiCbGroups);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOnForm";
            this.Text = "Dodatki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiCbGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox uiChkLstAddOns;
        private System.Windows.Forms.Button uiBtnCancel;
        private System.Windows.Forms.Button uiBtnOk;
    }
}