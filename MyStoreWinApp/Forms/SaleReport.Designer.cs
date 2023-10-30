namespace MyStoreWinApp.Forms
{
    partial class SaleReport
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            date_to = new DateTimePicker();
            button_toExcel = new Button();
            date_from = new DateTimePicker();
            reportTable = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitpriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numbersoldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalsaleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleReportRowBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleReportRowBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reportTable);
            splitContainer1.Size = new Size(815, 450);
            splitContainer1.SplitterDistance = 122;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(815, 122);
            splitContainer2.SplitterDistance = 62;
            splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 41);
            label1.TabIndex = 0;
            label1.Text = "Sale Report";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.72997F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.27003F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(date_to, 3, 0);
            tableLayoutPanel1.Controls.Add(button_toExcel, 4, 0);
            tableLayoutPanel1.Controls.Add(date_from, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(815, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(138, 56);
            label2.TabIndex = 0;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(105, 56);
            label3.TabIndex = 1;
            label3.Text = "To";
            // 
            // date_to
            // 
            date_to.Anchor = AnchorStyles.None;
            date_to.Format = DateTimePickerFormat.Short;
            date_to.Location = new Point(451, 14);
            date_to.Name = "date_to";
            date_to.Size = new Size(190, 27);
            date_to.TabIndex = 3;
            date_to.ValueChanged += date_to_ValueChanged;
            // 
            // button_toExcel
            // 
            button_toExcel.Dock = DockStyle.Fill;
            button_toExcel.Location = new Point(654, 10);
            button_toExcel.Margin = new Padding(10);
            button_toExcel.Name = "button_toExcel";
            button_toExcel.Size = new Size(151, 36);
            button_toExcel.TabIndex = 4;
            button_toExcel.Text = "Export";
            button_toExcel.UseVisualStyleBackColor = true;
            button_toExcel.Click += button_toExcel_Click;
            // 
            // date_from
            // 
            date_from.Anchor = AnchorStyles.None;
            date_from.Format = DateTimePickerFormat.Short;
            date_from.Location = new Point(147, 14);
            date_from.Name = "date_from";
            date_from.Size = new Size(187, 27);
            date_from.TabIndex = 2;
            date_from.ValueChanged += date_from_ValueChanged;
            // 
            // reportTable
            // 
            reportTable.AllowUserToDeleteRows = false;
            reportTable.AutoGenerateColumns = false;
            reportTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportTable.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, unitpriceDataGridViewTextBoxColumn, numbersoldDataGridViewTextBoxColumn, totalsaleDataGridViewTextBoxColumn });
            reportTable.DataSource = saleReportRowBindingSource;
            reportTable.Dock = DockStyle.Fill;
            reportTable.Location = new Point(0, 0);
            reportTable.Margin = new Padding(10);
            reportTable.Name = "reportTable";
            reportTable.RowHeadersWidth = 51;
            reportTable.RowTemplate.Height = 29;
            reportTable.Size = new Size(815, 324);
            reportTable.TabIndex = 0;
            reportTable.ColumnHeaderMouseClick += reportTable_ColumnHeaderMouseClick;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
            productIdDataGridViewTextBoxColumn.HeaderText = "Product_Id";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            unitpriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_price";
            unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit_price";
            unitpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersoldDataGridViewTextBoxColumn
            // 
            numbersoldDataGridViewTextBoxColumn.DataPropertyName = "Number_sold";
            numbersoldDataGridViewTextBoxColumn.HeaderText = "Number_sold";
            numbersoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            numbersoldDataGridViewTextBoxColumn.Name = "numbersoldDataGridViewTextBoxColumn";
            numbersoldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalsaleDataGridViewTextBoxColumn
            // 
            totalsaleDataGridViewTextBoxColumn.DataPropertyName = "Total_sale";
            totalsaleDataGridViewTextBoxColumn.HeaderText = "Total_sale";
            totalsaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalsaleDataGridViewTextBoxColumn.Name = "totalsaleDataGridViewTextBoxColumn";
            totalsaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleReportRowBindingSource
            // 
            saleReportRowBindingSource.DataSource = typeof(ViewModels.SaleReportRow);
            // 
            // SaleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(818, 497);
            Name = "SaleReport";
            Text = "SaleReport";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleReportRowBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private DateTimePicker date_from;
        private DateTimePicker date_to;
        private Button button_toExcel;
        private DataGridView reportTable;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numbersoldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalsaleDataGridViewTextBoxColumn;
        private BindingSource saleReportRowBindingSource;
    }
}