namespace DATA_BASE_WITH_CSHARP_AND_SQLSERVER
{
    partial class FRM_ORDERS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNameCutomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOrder = new System.Windows.Forms.DateTimePicker();
            this.cmbNoCutomer = new System.Windows.Forms.ComboBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No_Items = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NameItems = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbNameCutomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateOrder);
            this.groupBox1.Controls.Add(this.cmbNoCutomer);
            this.groupBox1.Controls.Add(this.txtOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الزبون";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "الاجمالي";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(16, 125);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(289, 27);
            this.txtTotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم الزبون";
            // 
            // cmbNameCutomer
            // 
            this.cmbNameCutomer.FormattingEnabled = true;
            this.cmbNameCutomer.Location = new System.Drawing.Point(16, 75);
            this.cmbNameCutomer.Name = "cmbNameCutomer";
            this.cmbNameCutomer.Size = new System.Drawing.Size(289, 27);
            this.cmbNameCutomer.TabIndex = 6;
            this.cmbNameCutomer.SelectedIndexChanged += new System.EventHandler(this.cmbNameCutomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم الزبون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاريخ الطلبية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الطلبية";
            // 
            // DateOrder
            // 
            this.DateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOrder.Location = new System.Drawing.Point(510, 121);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(171, 27);
            this.DateOrder.TabIndex = 2;
            // 
            // cmbNoCutomer
            // 
            this.cmbNoCutomer.FormattingEnabled = true;
            this.cmbNoCutomer.Location = new System.Drawing.Point(16, 30);
            this.cmbNoCutomer.Name = "cmbNoCutomer";
            this.cmbNoCutomer.Size = new System.Drawing.Size(289, 27);
            this.cmbNoCutomer.TabIndex = 1;
            this.cmbNoCutomer.SelectedIndexChanged += new System.EventHandler(this.cmbNoCutomer_SelectedIndexChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(510, 30);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(171, 27);
            this.txtOrder.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_Items,
            this.NameItems,
            this.Price,
            this.Qtty,
            this.Total,
            this.Descount,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 192);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // No_Items
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No_Items.DefaultCellStyle = dataGridViewCellStyle1;
            this.No_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No_Items.HeaderText = "رقم الصنف";
            this.No_Items.Name = "No_Items";
            this.No_Items.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.No_Items.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NameItems
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameItems.HeaderText = "اسم الصنف";
            this.NameItems.Name = "NameItems";
            this.NameItems.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Price
            // 
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            // 
            // Qtty
            // 
            this.Qtty.HeaderText = "الكمية";
            this.Qtty.Name = "Qtty";
            // 
            // Total
            // 
            this.Total.HeaderText = "الاجمالي";
            this.Total.Name = "Total";
            // 
            // Descount
            // 
            this.Descount.HeaderText = "الخصم";
            this.Descount.Name = "Descount";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "الصافي";
            this.Amount.Name = "Amount";
            // 
            // cmd_Save
            // 
            this.cmd_Save.Location = new System.Drawing.Point(12, 387);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(120, 39);
            this.cmd_Save.TabIndex = 2;
            this.cmd_Save.Text = "حفظ";
            this.cmd_Save.UseVisualStyleBackColor = true;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Location = new System.Drawing.Point(359, 387);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(120, 39);
            this.cmd_Delete.TabIndex = 3;
            this.cmd_Delete.Text = "حذف";
            this.cmd_Delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نموذج الطلبية";
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNameCutomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOrder;
        private System.Windows.Forms.ComboBox cmbNoCutomer;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewComboBoxColumn No_Items;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}