namespace MyStoreWinApp.Forms
{
    partial class ProductDetailForm : Form
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
            button_Cancel = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_Save = new Button();
            label5 = new Label();
            label4 = new Label();
            Title = new Label();
            label3 = new Label();
            txtBox_weight = new TextBox();
            label2 = new Label();
            txtBox_category = new TextBox();
            label1 = new Label();
            txtBox_name = new TextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBox_unitPrice = new NumericUpDown();
            txtBox_inStock = new NumericUpDown();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBox_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBox_inStock).BeginInit();
            SuspendLayout();
            // 
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(404, 18);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(365, 37);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button_Save, 0, 0);
            tableLayoutPanel2.Controls.Add(button_Cancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(30, 15, 30, 15);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(802, 73);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button_Save
            // 
            button_Save.Dock = DockStyle.Fill;
            button_Save.Location = new Point(33, 18);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(365, 37);
            button_Save.TabIndex = 0;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(53, 332);
            label5.Name = "label5";
            label5.Size = new Size(119, 59);
            label5.TabIndex = 8;
            label5.Text = "Currently in stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(53, 264);
            label4.Name = "label4";
            label4.Size = new Size(119, 68);
            label4.TabIndex = 6;
            label4.Text = "Price per unit";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(234, 28);
            Title.Name = "Title";
            Title.Size = new Size(344, 54);
            Title.TabIndex = 0;
            Title.Text = "Detail of product";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(53, 191);
            label3.Name = "label3";
            label3.Size = new Size(119, 73);
            label3.TabIndex = 4;
            label3.Text = "Weight";
            // 
            // txtBox_weight
            // 
            txtBox_weight.Dock = DockStyle.Fill;
            txtBox_weight.Location = new Point(178, 194);
            txtBox_weight.Name = "txtBox_weight";
            txtBox_weight.Size = new Size(569, 27);
            txtBox_weight.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(53, 124);
            label2.Name = "label2";
            label2.Size = new Size(119, 67);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // txtBox_category
            // 
            txtBox_category.Dock = DockStyle.Fill;
            txtBox_category.Location = new Point(178, 127);
            txtBox_category.Name = "txtBox_category";
            txtBox_category.Size = new Size(569, 27);
            txtBox_category.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(119, 74);
            label1.TabIndex = 0;
            label1.Text = "Product's name";
            // 
            // txtBox_name
            // 
            txtBox_name.Dock = DockStyle.Fill;
            txtBox_name.Location = new Point(178, 53);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.Size = new Size(569, 27);
            txtBox_name.TabIndex = 1;
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
            splitContainer1.Panel1.Controls.Add(Title);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(802, 603);
            splitContainer1.SplitterDistance = 81;
            splitContainer1.TabIndex = 1;
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
            splitContainer2.Size = new Size(802, 518);
            splitContainer2.SplitterDistance = 441;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8571434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.14286F));
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtBox_weight, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBox_category, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBox_name, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBox_unitPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBox_inStock, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(800, 450);
            tableLayoutPanel1.MinimumSize = new Size(800, 400);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(50);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.58621F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.41379F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 441);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBox_unitPrice
            // 
            txtBox_unitPrice.DecimalPlaces = 3;
            txtBox_unitPrice.Location = new Point(178, 267);
            txtBox_unitPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            txtBox_unitPrice.Name = "txtBox_unitPrice";
            txtBox_unitPrice.Size = new Size(150, 27);
            txtBox_unitPrice.TabIndex = 9;
            txtBox_unitPrice.ThousandsSeparator = true;
            // 
            // txtBox_inStock
            // 
            txtBox_inStock.Location = new Point(178, 335);
            txtBox_inStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtBox_inStock.Name = "txtBox_inStock";
            txtBox_inStock.Size = new Size(150, 27);
            txtBox_inStock.TabIndex = 10;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 603);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(820, 650);
            Name = "ProductDetailForm";
            Text = "ProductDetailForm";
            Load += ProductDetailForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBox_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBox_inStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_Cancel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_Save;
        private Label label5;
        private Label label4;
        private Label Title;
        private Label label3;
        private TextBox txtBox_weight;
        private Label label2;
        private TextBox txtBox_category;
        private Label label1;
        private TextBox txtBox_name;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown txtBox_unitPrice;
        private NumericUpDown txtBox_inStock;
    }
}