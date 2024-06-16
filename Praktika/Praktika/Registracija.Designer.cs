namespace Praktika
{
    partial class Registracija
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            usrnmTextBox = new TextBox();
            pswTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            signup_btn = new Button();
            chng_to_lgn_btn = new Button();
            label4 = new Label();
            label5 = new Label();
            tel_nrTextBox = new TextBox();
            label6 = new Label();
            varTextBox = new TextBox();
            label7 = new Label();
            pavTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.Location = new Point(378, 59);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 0;
            label1.Text = "Registracija";
            label1.Click += label1_Click;
            // 
            // usrnmTextBox
            // 
            usrnmTextBox.Location = new Point(378, 372);
            usrnmTextBox.Margin = new Padding(3, 4, 3, 4);
            usrnmTextBox.Name = "usrnmTextBox";
            usrnmTextBox.Size = new Size(140, 27);
            usrnmTextBox.TabIndex = 4;
            // 
            // pswTextBox
            // 
            pswTextBox.Location = new Point(378, 444);
            pswTextBox.Margin = new Padding(3, 4, 3, 4);
            pswTextBox.Name = "pswTextBox";
            pswTextBox.PasswordChar = '*';
            pswTextBox.Size = new Size(140, 27);
            pswTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 341);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 413);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // signup_btn
            // 
            signup_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            signup_btn.Location = new Point(406, 503);
            signup_btn.Margin = new Padding(3, 4, 3, 4);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(86, 31);
            signup_btn.TabIndex = 6;
            signup_btn.Text = "Sign-Up";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // chng_to_lgn_btn
            // 
            chng_to_lgn_btn.Location = new Point(264, 548);
            chng_to_lgn_btn.Margin = new Padding(3, 4, 3, 4);
            chng_to_lgn_btn.Name = "chng_to_lgn_btn";
            chng_to_lgn_btn.Size = new Size(86, 31);
            chng_to_lgn_btn.TabIndex = 7;
            chng_to_lgn_btn.Text = "Login";
            chng_to_lgn_btn.UseVisualStyleBackColor = true;
            chng_to_lgn_btn.Click += chng_to_lgn_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 553);
            label4.Name = "label4";
            label4.Size = new Size(244, 20);
            label4.TabIndex = 8;
            label4.Text = "Jau turite paskyra? Prisijungkite cia :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 269);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 9;
            label5.Text = "Tel. Nr";
            // 
            // tel_nrTextBox
            // 
            tel_nrTextBox.Location = new Point(378, 307);
            tel_nrTextBox.Margin = new Padding(3, 4, 3, 4);
            tel_nrTextBox.Name = "tel_nrTextBox";
            tel_nrTextBox.Size = new Size(140, 27);
            tel_nrTextBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 125);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 11;
            label6.Text = "Vardas";
            // 
            // varTextBox
            // 
            varTextBox.Location = new Point(378, 156);
            varTextBox.Margin = new Padding(3, 4, 3, 4);
            varTextBox.Name = "varTextBox";
            varTextBox.Size = new Size(140, 27);
            varTextBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 197);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 13;
            label7.Text = "Pavarde";
            // 
            // pavTextBox
            // 
            pavTextBox.Location = new Point(378, 228);
            pavTextBox.Margin = new Padding(3, 4, 3, 4);
            pavTextBox.Name = "pavTextBox";
            pavTextBox.Size = new Size(140, 27);
            pavTextBox.TabIndex = 2;
            // 
            // Registracija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(pavTextBox);
            Controls.Add(label6);
            Controls.Add(varTextBox);
            Controls.Add(label5);
            Controls.Add(tel_nrTextBox);
            Controls.Add(label4);
            Controls.Add(chng_to_lgn_btn);
            Controls.Add(signup_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pswTextBox);
            Controls.Add(usrnmTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registracija";
            Text = "Form1";
            FormClosing += Registracija_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usrnmTextBox;
        private TextBox pswTextBox;
        private Label label2;
        private Label label3;
        private Button signup_btn;
        private Button chng_to_lgn_btn;
        private Label label4;
        private Label label5;
        private TextBox tel_nrTextBox;
        private Label label6;
        private TextBox varTextBox;
        private Label label7;
        private TextBox pavTextBox;
    }
}
