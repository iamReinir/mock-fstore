namespace MyStoreWinApp
{
    partial class frmUpdate
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
            cancel_btn = new Button();
            ok_btn = new Button();
            country_txt = new TextBox();
            city_txt = new TextBox();
            password_txt = new TextBox();
            email_txt = new TextBox();
            name_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(299, 396);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 25;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            ok_btn.Location = new Point(101, 396);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(94, 29);
            ok_btn.TabIndex = 24;
            ok_btn.Text = "OK";
            ok_btn.UseVisualStyleBackColor = true;
            // 
            // country_txt
            // 
            country_txt.Location = new Point(124, 328);
            country_txt.Name = "country_txt";
            country_txt.Size = new Size(337, 27);
            country_txt.TabIndex = 23;
            // 
            // city_txt
            // 
            city_txt.Location = new Point(124, 282);
            city_txt.Name = "city_txt";
            city_txt.Size = new Size(337, 27);
            city_txt.TabIndex = 22;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(124, 229);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(337, 27);
            password_txt.TabIndex = 21;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(124, 184);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(337, 27);
            email_txt.TabIndex = 20;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(124, 138);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(337, 27);
            name_txt.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 328);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 18;
            label6.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 285);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 17;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 236);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 16;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 191);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 50);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 13;
            label1.Text = "Update Member";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
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
            Controls.Add(label1);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancel_btn;
        private Button ok_btn;
        private TextBox country_txt;
        private TextBox city_txt;
        private TextBox password_txt;
        private TextBox email_txt;
        private TextBox name_txt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}