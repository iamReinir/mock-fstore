namespace MyStoreWinApp.Forms
{
    partial class OrderDetailsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button_save = new Button();
            button_cancel = new Button();
            titleText = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            date_shipped = new DateTimePicker();
            txt_memName = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_memID = new TextBox();
            date_order = new DateTimePicker();
            date_required = new DateTimePicker();
            num_freight = new NumericUpDown();
            splitContainer3 = new SplitContainer();
            detailTable = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullOrderDetailBindingSource = new BindingSource(components);
            splitContainer5 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            txt_product = new Label();
            label4 = new Label();
            num_productID = new NumericUpDown();
            num_discount = new NumericUpDown();
            txt_quantity = new MaskedTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            button_productRemove = new Button();
            button_addProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_freight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detailTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fullOrderDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_productID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_discount).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(790, 493);
            splitContainer1.SplitterDistance = 203;
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
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer2.Size = new Size(790, 203);
            splitContainer2.SplitterDistance = 60;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.08642F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.91358F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 232F));
            tableLayoutPanel1.Controls.Add(button_save, 1, 0);
            tableLayoutPanel1.Controls.Add(button_cancel, 2, 0);
            tableLayoutPanel1.Controls.Add(titleText, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(790, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button_save
            // 
            button_save.Dock = DockStyle.Fill;
            button_save.Location = new Point(346, 10);
            button_save.Margin = new Padding(50, 10, 50, 10);
            button_save.Name = "button_save";
            button_save.Size = new Size(161, 40);
            button_save.TabIndex = 1;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Dock = DockStyle.Fill;
            button_cancel.Location = new Point(607, 10);
            button_cancel.Margin = new Padding(50, 10, 50, 10);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(133, 40);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Dock = DockStyle.Fill;
            titleText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titleText.Location = new Point(3, 0);
            titleText.Name = "titleText";
            titleText.Size = new Size(290, 60);
            titleText.TabIndex = 0;
            titleText.Text = "Order Detail #";
            titleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9267731F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.07323F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel2.Controls.Add(date_shipped, 1, 2);
            tableLayoutPanel2.Controls.Add(txt_memName, 3, 0);
            tableLayoutPanel2.Controls.Add(label11, 2, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txt_memID, 1, 0);
            tableLayoutPanel2.Controls.Add(date_order, 1, 1);
            tableLayoutPanel2.Controls.Add(date_required, 3, 1);
            tableLayoutPanel2.Controls.Add(num_freight, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.MaximumSize = new Size(800, 127);
            tableLayoutPanel2.MinimumSize = new Size(800, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7241364F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2758636F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel2.Size = new Size(800, 127);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // date_shipped
            // 
            date_shipped.Dock = DockStyle.Fill;
            date_shipped.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_shipped.Format = DateTimePickerFormat.Short;
            date_shipped.Location = new Point(134, 90);
            date_shipped.Name = "date_shipped";
            date_shipped.Size = new Size(229, 34);
            date_shipped.TabIndex = 17;
            // 
            // txt_memName
            // 
            txt_memName.Dock = DockStyle.Fill;
            txt_memName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_memName.Location = new Point(525, 3);
            txt_memName.Name = "txt_memName";
            txt_memName.ReadOnly = true;
            txt_memName.Size = new Size(272, 34);
            txt_memName.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(369, 87);
            label11.Name = "label11";
            label11.Size = new Size(150, 40);
            label11.TabIndex = 10;
            label11.Text = "Freight";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 87);
            label9.Name = "label9";
            label9.Size = new Size(125, 40);
            label9.TabIndex = 8;
            label9.Text = "Shipped Date";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(369, 45);
            label7.Name = "label7";
            label7.Size = new Size(150, 42);
            label7.TabIndex = 6;
            label7.Text = "Require Date";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 45);
            label5.Name = "label5";
            label5.Size = new Size(125, 42);
            label5.TabIndex = 4;
            label5.Text = "Order Date";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(369, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 45);
            label3.TabIndex = 2;
            label3.Text = "Member Name";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 45);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_memID
            // 
            txt_memID.Dock = DockStyle.Fill;
            txt_memID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_memID.Location = new Point(134, 3);
            txt_memID.Name = "txt_memID";
            txt_memID.Size = new Size(229, 34);
            txt_memID.TabIndex = 11;
            txt_memID.TextChanged += txt_memID_TextChanged;
            // 
            // date_order
            // 
            date_order.Dock = DockStyle.Fill;
            date_order.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_order.Format = DateTimePickerFormat.Short;
            date_order.Location = new Point(134, 48);
            date_order.Name = "date_order";
            date_order.Size = new Size(229, 34);
            date_order.TabIndex = 12;
            // 
            // date_required
            // 
            date_required.Dock = DockStyle.Fill;
            date_required.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_required.Format = DateTimePickerFormat.Short;
            date_required.Location = new Point(525, 48);
            date_required.Name = "date_required";
            date_required.Size = new Size(272, 34);
            date_required.TabIndex = 13;
            // 
            // num_freight
            // 
            num_freight.DecimalPlaces = 3;
            num_freight.Dock = DockStyle.Fill;
            num_freight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            num_freight.Location = new Point(525, 90);
            num_freight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            num_freight.Name = "num_freight";
            num_freight.Size = new Size(272, 34);
            num_freight.TabIndex = 18;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(detailTable);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Size = new Size(790, 286);
            splitContainer3.SplitterDistance = 570;
            splitContainer3.TabIndex = 0;
            // 
            // detailTable
            // 
            detailTable.AllowUserToAddRows = false;
            detailTable.AutoGenerateColumns = false;
            detailTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailTable.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn });
            detailTable.DataSource = fullOrderDetailBindingSource;
            detailTable.Dock = DockStyle.Fill;
            detailTable.Location = new Point(0, 0);
            detailTable.Name = "detailTable";
            detailTable.RowHeadersWidth = 51;
            detailTable.RowTemplate.Height = 29;
            detailTable.Size = new Size(570, 286);
            detailTable.TabIndex = 0;
            detailTable.CellValidating += detailTable_CellValidating;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullOrderDetailBindingSource
            // 
            fullOrderDetailBindingSource.DataSource = typeof(FullOrderDetail);
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(tableLayoutPanel4);
            splitContainer5.Size = new Size(216, 286);
            splitContainer5.SplitterDistance = 159;
            splitContainer5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(txt_product, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(num_productID, 1, 0);
            tableLayoutPanel3.Controls.Add(num_discount, 1, 2);
            tableLayoutPanel3.Controls.Add(txt_quantity, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 67.02128F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32.97872F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(216, 159);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 94);
            label6.Name = "label6";
            label6.Size = new Size(102, 65);
            label6.TabIndex = 3;
            label6.Text = "Discount%";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_product
            // 
            txt_product.AutoSize = true;
            txt_product.Dock = DockStyle.Fill;
            txt_product.Location = new Point(3, 0);
            txt_product.Name = "txt_product";
            txt_product.Size = new Size(102, 63);
            txt_product.TabIndex = 1;
            txt_product.Text = "Product ID";
            txt_product.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 63);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 7;
            label4.Text = "Quantity";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // num_productID
            // 
            num_productID.Anchor = AnchorStyles.None;
            num_productID.Location = new Point(111, 18);
            num_productID.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            num_productID.Name = "num_productID";
            num_productID.Size = new Size(102, 27);
            num_productID.TabIndex = 4;
            num_productID.ValueChanged += num_productID_ValueChanged;
            // 
            // num_discount
            // 
            num_discount.Anchor = AnchorStyles.None;
            num_discount.Location = new Point(111, 113);
            num_discount.Name = "num_discount";
            num_discount.Size = new Size(102, 27);
            num_discount.TabIndex = 6;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(111, 66);
            txt_quantity.Mask = "9999999";
            txt_quantity.Name = "txt_quantity";
            txt_quantity.PromptChar = ' ';
            txt_quantity.Size = new Size(102, 27);
            txt_quantity.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button3, 0, 2);
            tableLayoutPanel4.Controls.Add(button_productRemove, 0, 1);
            tableLayoutPanel4.Controls.Add(button_addProduct, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2467537F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7532463F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.Size = new Size(216, 123);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Enabled = false;
            button3.Location = new Point(40, 85);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 2;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button_productRemove
            // 
            button_productRemove.Anchor = AnchorStyles.None;
            button_productRemove.Location = new Point(40, 44);
            button_productRemove.Name = "button_productRemove";
            button_productRemove.Size = new Size(135, 29);
            button_productRemove.TabIndex = 1;
            button_productRemove.Text = "Remove";
            button_productRemove.UseVisualStyleBackColor = true;
            button_productRemove.Click += button_RemvoveProduct_Click;
            // 
            // button_addProduct
            // 
            button_addProduct.Anchor = AnchorStyles.None;
            button_addProduct.Location = new Point(40, 6);
            button_addProduct.Name = "button_addProduct";
            button_addProduct.Size = new Size(135, 29);
            button_addProduct.TabIndex = 0;
            button_addProduct.Text = "Add Product";
            button_addProduct.UseVisualStyleBackColor = true;
            button_addProduct.Click += button_addProduct_click;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(818, 550);
            Name = "OrderDetailsForm";
            Padding = new Padding(5);
            Text = "OrderDetailsForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_freight).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)detailTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)fullOrderDetailBindingSource).EndInit();
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_productID).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_discount).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label titleText;
        private Button button_save;
        private Button button_cancel;
        private TableLayoutPanel tableLayoutPanel2;
        private SplitContainer splitContainer5;
        private Label label2;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox txt_memID;
        private DateTimePicker date_order;
        private DateTimePicker date_required;
        private DateTimePicker date_shipped;
        private TextBox txt_memName;
        private DataGridView detailTable;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private Label txt_product;
        private Label label4;
        private NumericUpDown num_productID;
        private NumericUpDown num_discount;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button_productRemove;
        private Button button_addProduct;
        private Button button3;
        private BindingSource fullOrderDetailBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private NumericUpDown num_freight;
        private MaskedTextBox txt_quantity;
    }
}