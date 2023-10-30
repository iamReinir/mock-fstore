namespace MyStoreWinApp.Forms
{
    partial class MemberDetailForm
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
            splitContainer1 = new SplitContainer();
            Title = new Label();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            txtBox_country = new TextBox();
            label5 = new Label();
            txtBox_City = new TextBox();
            label4 = new Label();
            txtBox_companyName = new TextBox();
            label3 = new Label();
            txtBox_password = new TextBox();
            label2 = new Label();
            txtBox_email = new TextBox();
            label1 = new Label();
            txtBox_name = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_Save = new Button();
            button_Cancel = new Button();
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
            splitContainer1.Panel1.Controls.Add(Title);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(802, 603);
            splitContainer1.SplitterDistance = 81;
            splitContainer1.TabIndex = 0;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(220, 25);
            Title.Name = "Title";
            Title.Size = new Size(356, 56);
            Title.TabIndex = 0;
            Title.Text = "Detail of member";
            Title.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtBox_country, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtBox_City, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtBox_companyName, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtBox_password, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBox_email, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBox_name, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(800, 450);
            tableLayoutPanel1.MinimumSize = new Size(800, 400);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(50);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.58621F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.41379F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 441);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(53, 340);
            label6.Name = "label6";
            label6.Size = new Size(119, 51);
            label6.TabIndex = 10;
            label6.Text = "Country";
            // 
            // txtBox_country
            // 
            txtBox_country.Dock = DockStyle.Fill;
            txtBox_country.Location = new Point(178, 343);
            txtBox_country.Name = "txtBox_country";
            txtBox_country.Size = new Size(569, 27);
            txtBox_country.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(53, 282);
            label5.Name = "label5";
            label5.Size = new Size(119, 58);
            label5.TabIndex = 8;
            label5.Text = "City";
            // 
            // txtBox_City
            // 
            txtBox_City.Dock = DockStyle.Fill;
            txtBox_City.Location = new Point(178, 285);
            txtBox_City.Name = "txtBox_City";
            txtBox_City.Size = new Size(569, 27);
            txtBox_City.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(53, 223);
            label4.Name = "label4";
            label4.Size = new Size(119, 59);
            label4.TabIndex = 6;
            label4.Text = "Company Name";
            // 
            // txtBox_companyName
            // 
            txtBox_companyName.Dock = DockStyle.Fill;
            txtBox_companyName.Location = new Point(178, 226);
            txtBox_companyName.Name = "txtBox_companyName";
            txtBox_companyName.Size = new Size(569, 27);
            txtBox_companyName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(53, 166);
            label3.Name = "label3";
            label3.Size = new Size(119, 57);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtBox_password
            // 
            txtBox_password.Dock = DockStyle.Fill;
            txtBox_password.Location = new Point(178, 169);
            txtBox_password.Name = "txtBox_password";
            txtBox_password.Size = new Size(569, 27);
            txtBox_password.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(53, 111);
            label2.Name = "label2";
            label2.Size = new Size(119, 55);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtBox_email
            // 
            txtBox_email.Dock = DockStyle.Fill;
            txtBox_email.Location = new Point(178, 114);
            txtBox_email.Name = "txtBox_email";
            txtBox_email.Size = new Size(569, 27);
            txtBox_email.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(119, 61);
            label1.TabIndex = 0;
            label1.Text = "Member's name";
            // 
            // txtBox_name
            // 
            txtBox_name.Dock = DockStyle.Fill;
            txtBox_name.Location = new Point(178, 53);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.Size = new Size(569, 27);
            txtBox_name.TabIndex = 1;
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
            // button_Cancel
            // 
            button_Cancel.Dock = DockStyle.Fill;
            button_Cancel.Location = new Point(404, 18);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(365, 37);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // MemberDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 603);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(820, 650);
            Name = "MemberDetailForm";
            Text = "Member Detail";
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
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private TextBox txtBox_country;
        private Label label5;
        private TextBox txtBox_City;
        private Label label4;
        private TextBox txtBox_companyName;
        private Label label3;
        private TextBox txtBox_password;
        private Label label2;
        private TextBox txtBox_email;
        private Label label1;
        private TextBox txtBox_name;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_Save;
        private Button button_Cancel;
        private Label Title;
    }
}