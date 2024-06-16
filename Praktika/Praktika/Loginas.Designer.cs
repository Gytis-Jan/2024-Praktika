namespace Praktika
{
    partial class Loginas
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
            label4 = new Label();
            chng_to_reg_btn = new Button();
            login_btn = new Button();
            label3 = new Label();
            label2 = new Label();
            pswTextBox = new TextBox();
            userTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 547);
            label4.Name = "label4";
            label4.Size = new Size(279, 20);
            label4.TabIndex = 16;
            label4.Text = "Neturite paskyros? Uzsiregistruokite cia : ";
            // 
            // chng_to_reg_btn
            // 
            chng_to_reg_btn.Location = new Point(311, 542);
            chng_to_reg_btn.Margin = new Padding(3, 4, 3, 4);
            chng_to_reg_btn.Name = "chng_to_reg_btn";
            chng_to_reg_btn.Size = new Size(86, 31);
            chng_to_reg_btn.TabIndex = 15;
            chng_to_reg_btn.Text = "Sign-Up";
            chng_to_reg_btn.UseVisualStyleBackColor = true;
            chng_to_reg_btn.Click += chng_to_reg_btn_Click;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            login_btn.Location = new Point(418, 337);
            login_btn.Margin = new Padding(3, 4, 3, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(86, 31);
            login_btn.TabIndex = 14;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 257);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 187);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // pswTextBox
            // 
            pswTextBox.Location = new Point(391, 281);
            pswTextBox.Margin = new Padding(3, 4, 3, 4);
            pswTextBox.Name = "pswTextBox";
            pswTextBox.PasswordChar = '*';
            pswTextBox.Size = new Size(140, 27);
            pswTextBox.TabIndex = 10;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(391, 211);
            userTextBox.Margin = new Padding(3, 4, 3, 4);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(140, 27);
            userTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.Location = new Point(391, 96);
            label1.Name = "label1";
            label1.Size = new Size(171, 35);
            label1.TabIndex = 8;
            label1.Text = "Prisijungimas";
            // 
            // Loginas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(chng_to_reg_btn);
            Controls.Add(login_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pswTextBox);
            Controls.Add(userTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loginas";
            Text = "Form2";
            FormClosing += Loginas_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button chng_to_reg_btn;
        private Button login_btn;
        private Label label3;
        private Label label2;
        private TextBox pswTextBox;
        private TextBox userTextBox;
        private Label label1;
    }
}