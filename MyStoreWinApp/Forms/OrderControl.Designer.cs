namespace MyStoreWinApp.Forms
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            orderTable = new DataGridView();
            orderBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            button_delete = new Button();
            button_update = new Button();
            freightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shippeddateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requiredateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(orderTable);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(852, 311);
            splitContainer1.SplitterDistance = 227;
            splitContainer1.TabIndex = 0;
            // 
            // orderTable
            // 
            orderTable.AllowUserToAddRows = false;
            orderTable.AllowUserToDeleteRows = false;
            orderTable.AutoGenerateColumns = false;
            orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderTable.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, memberidDataGridViewTextBoxColumn, orderdateDataGridViewTextBoxColumn, requiredateDataGridViewTextBoxColumn, shippeddateDataGridViewTextBoxColumn, freightDataGridViewTextBoxColumn });
            orderTable.DataSource = orderBindingSource;
            orderTable.Dock = DockStyle.Fill;
            orderTable.Location = new Point(0, 0);
            orderTable.Name = "orderTable";
            orderTable.ReadOnly = true;
            orderTable.RowHeadersWidth = 51;
            orderTable.RowTemplate.Height = 29;
            orderTable.Size = new Size(852, 227);
            orderTable.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(BusinessObject.Order);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button_delete, 1, 0);
            tableLayoutPanel1.Controls.Add(button_update, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(852, 80);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button_delete
            // 
            button_delete.Dock = DockStyle.Fill;
            button_delete.Location = new Point(456, 20);
            button_delete.Margin = new Padding(30, 20, 30, 20);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(366, 40);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Dock = DockStyle.Fill;
            button_update.Location = new Point(30, 20);
            button_update.Margin = new Padding(30, 20, 30, 20);
            button_update.Name = "button_update";
            button_update.Size = new Size(366, 40);
            button_update.TabIndex = 0;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            freightDataGridViewTextBoxColumn.MinimumWidth = 6;
            freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            freightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shippeddateDataGridViewTextBoxColumn
            // 
            shippeddateDataGridViewTextBoxColumn.DataPropertyName = "Shipped_date";
            shippeddateDataGridViewTextBoxColumn.HeaderText = "Shipped_date";
            shippeddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            shippeddateDataGridViewTextBoxColumn.Name = "shippeddateDataGridViewTextBoxColumn";
            shippeddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredateDataGridViewTextBoxColumn
            // 
            requiredateDataGridViewTextBoxColumn.DataPropertyName = "Require_date";
            requiredateDataGridViewTextBoxColumn.HeaderText = "Require_date";
            requiredateDataGridViewTextBoxColumn.MinimumWidth = 6;
            requiredateDataGridViewTextBoxColumn.Name = "requiredateDataGridViewTextBoxColumn";
            requiredateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            orderdateDataGridViewTextBoxColumn.DataPropertyName = "Order_date";
            orderdateDataGridViewTextBoxColumn.HeaderText = "Order_date";
            orderdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            memberidDataGridViewTextBoxColumn.DataPropertyName = "Member_id";
            memberidDataGridViewTextBoxColumn.HeaderText = "Member_id";
            memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            memberidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrderControl";
            Size = new Size(852, 311);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView orderTable;
        private BindingSource orderBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_delete;
        private Button button_update;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requiredateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shippeddateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
    }
}
