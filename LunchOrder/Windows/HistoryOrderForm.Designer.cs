namespace LunchOrder.Windows
{
    partial class HistoryOrderForm
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
            this.uiDGVOrders = new System.Windows.Forms.DataGridView();
            this.OrderEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiDTPTo = new System.Windows.Forms.DateTimePicker();
            this.uiDTPFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uiDGVOrders);
            this.groupBox1.Controls.Add(this.uiDTPTo);
            this.groupBox1.Controls.Add(this.uiDTPFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historia zamówień";
            // 
            // uiDGVOrders
            // 
            this.uiDGVOrders.AllowUserToAddRows = false;
            this.uiDGVOrders.AllowUserToDeleteRows = false;
            this.uiDGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderEmail,
            this.OrderDate,
            this.OrderPrice,
            this.OrderComment});
            this.uiDGVOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uiDGVOrders.Location = new System.Drawing.Point(10, 71);
            this.uiDGVOrders.MultiSelect = false;
            this.uiDGVOrders.Name = "uiDGVOrders";
            this.uiDGVOrders.ReadOnly = true;
            this.uiDGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDGVOrders.Size = new System.Drawing.Size(938, 413);
            this.uiDGVOrders.TabIndex = 4;
            this.uiDGVOrders.DoubleClick += new System.EventHandler(this.uiDGVOrders_DoubleClick);
            // 
            // OrderEmail
            // 
            this.OrderEmail.DataPropertyName = "EmailDelivery";
            this.OrderEmail.HeaderText = "Email";
            this.OrderEmail.Name = "OrderEmail";
            this.OrderEmail.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Data zamówienia";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.DataPropertyName = "OrderPrice";
            this.OrderPrice.HeaderText = "Cena [zł]";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // OrderComment
            // 
            this.OrderComment.DataPropertyName = "Comment";
            this.OrderComment.HeaderText = "Uwagi";
            this.OrderComment.Name = "OrderComment";
            this.OrderComment.ReadOnly = true;
            // 
            // uiDTPTo
            // 
            this.uiDTPTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDTPTo.Location = new System.Drawing.Point(382, 36);
            this.uiDTPTo.Name = "uiDTPTo";
            this.uiDTPTo.Size = new System.Drawing.Size(200, 29);
            this.uiDTPTo.TabIndex = 3;
            this.uiDTPTo.ValueChanged += new System.EventHandler(this.uiDTPTo_ValueChanged);
            // 
            // uiDTPFrom
            // 
            this.uiDTPFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDTPFrom.Location = new System.Drawing.Point(91, 36);
            this.uiDTPFrom.Name = "uiDTPFrom";
            this.uiDTPFrom.Size = new System.Drawing.Size(200, 29);
            this.uiDTPFrom.TabIndex = 2;
            this.uiDTPFrom.ValueChanged += new System.EventHandler(this.uiDTPFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(297, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data od:";
            // 
            // uiBtnClose
            // 
            this.uiBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiBtnClose.Location = new System.Drawing.Point(863, 508);
            this.uiBtnClose.Name = "uiBtnClose";
            this.uiBtnClose.Size = new System.Drawing.Size(103, 34);
            this.uiBtnClose.TabIndex = 11;
            this.uiBtnClose.Text = "Zamknij";
            this.uiBtnClose.UseVisualStyleBackColor = true;
            this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
            // 
            // HistoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 553);
            this.Controls.Add(this.uiBtnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistoryOrderForm";
            this.Text = "Historia zamówień";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGVOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker uiDTPTo;
        private System.Windows.Forms.DateTimePicker uiDTPFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiBtnClose;
        private System.Windows.Forms.DataGridView uiDGVOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderComment;
    }
}