namespace MyStoreWinApp
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            menu_Member = new ToolStripMenuItem();
            menu_allMembers = new ToolStripMenuItem();
            menu_addMember = new ToolStripMenuItem();
            exportMembersToolStripMenuItem = new ToolStripMenuItem();
            menu_Product = new ToolStripMenuItem();
            menu_allProduct = new ToolStripMenuItem();
            menu_addProduct = new ToolStripMenuItem();
            menu_Order = new ToolStripMenuItem();
            menu_allOrders = new ToolStripMenuItem();
            menu_newOrder = new ToolStripMenuItem();
            menu_createReport = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menu_help = new ToolStripMenuItem();
            menu_quit = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_Member, menu_Product, menu_Order, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(782, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // menu_Member
            // 
            menu_Member.DropDownItems.AddRange(new ToolStripItem[] { menu_allMembers, menu_addMember, exportMembersToolStripMenuItem });
            menu_Member.Name = "menu_Member";
            menu_Member.Size = new Size(79, 24);
            menu_Member.Text = "Member";
            menu_Member.Click += menuToolStripMenuItem_Click;
            // 
            // menu_allMembers
            // 
            menu_allMembers.Name = "menu_allMembers";
            menu_allMembers.Size = new Size(201, 26);
            menu_allMembers.Text = "All Members";
            menu_allMembers.Click += menu_allMembers_Click;
            // 
            // menu_addMember
            // 
            menu_addMember.Name = "menu_addMember";
            menu_addMember.Size = new Size(201, 26);
            menu_addMember.Text = "Add a member";
            menu_addMember.Click += menu_addMember_Click;
            // 
            // exportMembersToolStripMenuItem
            // 
            exportMembersToolStripMenuItem.Name = "exportMembersToolStripMenuItem";
            exportMembersToolStripMenuItem.Size = new Size(201, 26);
            exportMembersToolStripMenuItem.Text = "Export members";
            exportMembersToolStripMenuItem.Click += exportMembersToolStripMenuItem_Click;
            // 
            // menu_Product
            // 
            menu_Product.DropDownItems.AddRange(new ToolStripItem[] { menu_allProduct, menu_addProduct });
            menu_Product.Name = "menu_Product";
            menu_Product.Size = new Size(74, 24);
            menu_Product.Text = "Product";
            // 
            // menu_allProduct
            // 
            menu_allProduct.Name = "menu_allProduct";
            menu_allProduct.Size = new Size(188, 26);
            menu_allProduct.Text = "All Products";
            menu_allProduct.Click += menu_allProduct_Click;
            // 
            // menu_addProduct
            // 
            menu_addProduct.Name = "menu_addProduct";
            menu_addProduct.Size = new Size(188, 26);
            menu_addProduct.Text = "Add a product";
            menu_addProduct.Click += menu_addProduct_Click;
            // 
            // menu_Order
            // 
            menu_Order.DropDownItems.AddRange(new ToolStripItem[] { menu_allOrders, menu_newOrder, menu_createReport });
            menu_Order.Name = "menu_Order";
            menu_Order.Size = new Size(61, 24);
            menu_Order.Text = "Order";
            // 
            // menu_allOrders
            // 
            menu_allOrders.Name = "menu_allOrders";
            menu_allOrders.Size = new Size(195, 26);
            menu_allOrders.Text = "All orders";
            menu_allOrders.Click += menu_allOrders_Click;
            // 
            // menu_newOrder
            // 
            menu_newOrder.Name = "menu_newOrder";
            menu_newOrder.Size = new Size(195, 26);
            menu_newOrder.Text = "Create an order";
            menu_newOrder.Click += menu_newOrder_Click;
            // 
            // menu_createReport
            // 
            menu_createReport.Name = "menu_createReport";
            menu_createReport.Size = new Size(195, 26);
            menu_createReport.Text = "Report ";
            menu_createReport.Click += menu_createReport_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu_help, menu_quit, logOutToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // menu_help
            // 
            menu_help.Name = "menu_help";
            menu_help.Size = new Size(224, 26);
            menu_help.Text = "Help";
            // 
            // menu_quit
            // 
            menu_quit.Name = "menu_quit";
            menu_quit.Size = new Size(224, 26);
            menu_quit.Text = "Quit";
            menu_quit.Click += menu_quit_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Size = new Size(782, 625);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 3;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(224, 26);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 653);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(600, 500);
            Name = "MainForm";
            Text = "Fstore";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menu_Member;
        private ToolStripMenuItem menu_allMembers;
        private ToolStripMenuItem menu_addMember;
        private ToolStripMenuItem menu_Product;
        private ToolStripMenuItem menu_allProduct;
        private ToolStripMenuItem menu_addProduct;
        private ToolStripMenuItem menu_Order;
        private ToolStripMenuItem menu_allOrders;
        private ToolStripMenuItem menu_newOrder;
        private ToolStripMenuItem menu_createReport;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem menu_help;
        private ToolStripMenuItem menu_quit;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem exportMembersToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}