namespace MyStoreWinApp.Forms
{
    partial class frmAdd
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
            head_msg = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            name_txt = new TextBox();
            email_txt = new TextBox();
            password_txt = new TextBox();
            city_txt = new TextBox();
            country_txt = new TextBox();
            ok_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // head_msg
            // 
            head_msg.AutoSize = true;
            head_msg.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            head_msg.Location = new Point(111, 33);
            head_msg.Name = "head_msg";
            head_msg.Size = new Size(292, 41);
            head_msg.TabIndex = 0;
            head_msg.Text = "Add a new member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 128);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 174);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 219);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 268);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 311);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // name_txt
            // 
            name_txt.Location = new Point(134, 121);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(337, 27);
            name_txt.TabIndex = 6;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(134, 167);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(337, 27);
            email_txt.TabIndex = 7;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(134, 212);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(337, 27);
            password_txt.TabIndex = 8;
            // 
            // city_txt
            // 
            city_txt.Location = new Point(134, 265);
            city_txt.Name = "city_txt";
            city_txt.Size = new Size(337, 27);
            city_txt.TabIndex = 9;
            // 
            // country_txt
            // 
            country_txt.Location = new Point(134, 311);
            country_txt.Name = "country_txt";
            country_txt.Size = new Size(337, 27);
            country_txt.TabIndex = 10;
            // 
            // ok_btn
            // 
            ok_btn.Location = new Point(111, 379);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(94, 29);
            ok_btn.TabIndex = 11;
            ok_btn.Text = "OK";
            ok_btn.UseVisualStyleBackColor = true;
            ok_btn.Click += ok_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(309, 379);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 12;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // frmAdd
            // 
            AcceptButton = ok_btn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel_btn;
            ClientSize = new Size(516, 450);
            Controls.Add(cancel_btn);
            Controls.Add(ok_btn);
            Controls.Add(country_txt);
            Controls.Add(city_txt);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(name_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(head_msg);
            MaximizeBox = false;
            Name = "frmAdd";
            Text = "frmAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label head_msg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox name_txt;
        private TextBox email_txt;
        private TextBox password_txt;
        private TextBox city_txt;
        private TextBox country_txt;
        private Button ok_btn;
        private Button cancel_btn;
    }
}