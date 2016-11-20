namespace LunchOrder
{
    partial class RequestOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTxtComments = new System.Windows.Forms.TextBox();
            this.uiTxtEmail = new System.Windows.Forms.TextBox();
            this.uiBtnOk = new System.Windows.Forms.Button();
            this.uiBtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adres email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uwagi do zamówienia:";
            // 
            // uiTxtComments
            // 
            this.uiTxtComments.Location = new System.Drawing.Point(17, 129);
            this.uiTxtComments.Multiline = true;
            this.uiTxtComments.Name = "uiTxtComments";
            this.uiTxtComments.Size = new System.Drawing.Size(552, 164);
            this.uiTxtComments.TabIndex = 5;
            // 
            // uiTxtEmail
            // 
            this.uiTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTxtEmail.Location = new System.Drawing.Point(161, 37);
            this.uiTxtEmail.Name = "uiTxtEmail";
            this.uiTxtEmail.Size = new System.Drawing.Size(408, 29);
            this.uiTxtEmail.TabIndex = 6;
            // 
            // uiBtnOk
            // 
            this.uiBtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnOk.Location = new System.Drawing.Point(357, 299);
            this.uiBtnOk.Name = "uiBtnOk";
            this.uiBtnOk.Size = new System.Drawing.Size(103, 34);
            this.uiBtnOk.TabIndex = 9;
            this.uiBtnOk.Text = "OK";
            this.uiBtnOk.UseVisualStyleBackColor = true;
            this.uiBtnOk.Click += new System.EventHandler(this.uiBtnOk_Click);
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnCancel.Location = new System.Drawing.Point(466, 299);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(103, 34);
            this.uiBtnCancel.TabIndex = 8;
            this.uiBtnCancel.Text = "Anuluj";
            this.uiBtnCancel.UseVisualStyleBackColor = true;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // RequestOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 345);
            this.Controls.Add(this.uiBtnOk);
            this.Controls.Add(this.uiBtnCancel);
            this.Controls.Add(this.uiTxtEmail);
            this.Controls.Add(this.uiTxtComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RequestOrderForm";
            this.Text = "Zamówienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTxtComments;
        private System.Windows.Forms.TextBox uiTxtEmail;
        private System.Windows.Forms.Button uiBtnOk;
        private System.Windows.Forms.Button uiBtnCancel;
    }
}