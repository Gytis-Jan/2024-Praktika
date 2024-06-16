namespace Praktika
{
    partial class Finansai
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
            label1 = new Label();
            logoff_btn = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            showDB_btn = new Button();
            label3 = new Label();
            sumaTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tipasListBox = new ListBox();
            label7 = new Label();
            label8 = new Label();
            mokejimoListBox = new ListBox();
            komentarasTextBox = new TextBox();
            label9 = new Label();
            pildyti_btn = new Button();
            datosParinktis = new DateTimePicker();
            saltinisComboBox = new ComboBox();
            currentLogin = new Label();
            label10 = new Label();
            del_btn = new Button();
            delTextBox = new TextBox();
            label11 = new Label();
            save_btn = new Button();
            update_btn = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            likutisLabel = new Label();
            pajamosLabel = new Label();
            islaidosLabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(309, 59);
            label1.TabIndex = 0;
            label1.Text = "F I N A N S A I";
            // 
            // logoff_btn
            // 
            logoff_btn.Location = new Point(1352, 811);
            logoff_btn.Margin = new Padding(3, 4, 3, 4);
            logoff_btn.Name = "logoff_btn";
            logoff_btn.Size = new Size(86, 31);
            logoff_btn.TabIndex = 1;
            logoff_btn.Text = "Log Out";
            logoff_btn.UseVisualStyleBackColor = true;
            logoff_btn.Click += logoff_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(621, 56);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(817, 328);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(621, 27);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Duomenys :";
            // 
            // showDB_btn
            // 
            showDB_btn.Location = new Point(1311, 392);
            showDB_btn.Margin = new Padding(3, 4, 3, 4);
            showDB_btn.Name = "showDB_btn";
            showDB_btn.Size = new Size(127, 31);
            showDB_btn.TabIndex = 4;
            showDB_btn.Text = "Rodyti duomenis";
            showDB_btn.UseVisualStyleBackColor = true;
            showDB_btn.Click += showDB_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(14, 96);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 5;
            label3.Text = "Finansu sekimas : ";
            // 
            // sumaTextBox
            // 
            sumaTextBox.Location = new Point(42, 176);
            sumaTextBox.Margin = new Padding(3, 4, 3, 4);
            sumaTextBox.Name = "sumaTextBox";
            sumaTextBox.Size = new Size(217, 27);
            sumaTextBox.TabIndex = 6;
            sumaTextBox.TextChanged += sumaTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 144);
            label4.Name = "label4";
            label4.Size = new Size(315, 20);
            label4.TabIndex = 8;
            label4.Text = "Gautų/Išleistų pinigų suma (Iveskite tik skaičiu)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 219);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 383);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 11;
            label6.Text = "Šaltinis";
            // 
            // tipasListBox
            // 
            tipasListBox.FormattingEnabled = true;
            tipasListBox.Location = new Point(42, 325);
            tipasListBox.Margin = new Padding(3, 4, 3, 4);
            tipasListBox.Name = "tipasListBox";
            tipasListBox.Size = new Size(217, 44);
            tipasListBox.TabIndex = 14;
            tipasListBox.SelectedIndexChanged += tipasListBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 293);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 15;
            label7.Text = "Finansų tipas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 457);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 16;
            label8.Text = "Mokėjimo būdas";
            // 
            // mokejimoListBox
            // 
            mokejimoListBox.FormattingEnabled = true;
            mokejimoListBox.Location = new Point(42, 489);
            mokejimoListBox.Margin = new Padding(3, 4, 3, 4);
            mokejimoListBox.Name = "mokejimoListBox";
            mokejimoListBox.Size = new Size(217, 104);
            mokejimoListBox.TabIndex = 17;
            // 
            // komentarasTextBox
            // 
            komentarasTextBox.Location = new Point(42, 639);
            komentarasTextBox.Margin = new Padding(3, 4, 3, 4);
            komentarasTextBox.Multiline = true;
            komentarasTextBox.Name = "komentarasTextBox";
            komentarasTextBox.Size = new Size(217, 104);
            komentarasTextBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 607);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 19;
            label9.Text = "Komentaras";
            // 
            // pildyti_btn
            // 
            pildyti_btn.Location = new Point(160, 752);
            pildyti_btn.Margin = new Padding(3, 4, 3, 4);
            pildyti_btn.Name = "pildyti_btn";
            pildyti_btn.Size = new Size(99, 31);
            pildyti_btn.TabIndex = 20;
            pildyti_btn.Text = "Pildyti";
            pildyti_btn.UseVisualStyleBackColor = true;
            pildyti_btn.Click += pildyti_btn_Click;
            // 
            // datosParinktis
            // 
            datosParinktis.Location = new Point(42, 251);
            datosParinktis.Margin = new Padding(3, 4, 3, 4);
            datosParinktis.Name = "datosParinktis";
            datosParinktis.Size = new Size(217, 27);
            datosParinktis.TabIndex = 21;
            // 
            // saltinisComboBox
            // 
            saltinisComboBox.FormattingEnabled = true;
            saltinisComboBox.Location = new Point(42, 415);
            saltinisComboBox.Margin = new Padding(3, 4, 3, 4);
            saltinisComboBox.Name = "saltinisComboBox";
            saltinisComboBox.Size = new Size(217, 28);
            saltinisComboBox.TabIndex = 22;
            // 
            // currentLogin
            // 
            currentLogin.AutoSize = true;
            currentLogin.Location = new Point(1352, 787);
            currentLogin.Name = "currentLogin";
            currentLogin.Size = new Size(93, 20);
            currentLogin.TabIndex = 23;
            currentLogin.Text = "<logged in>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(1203, 787);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 24;
            label10.Text = "Dabar prisijunges : ";
            // 
            // del_btn
            // 
            del_btn.Location = new Point(1177, 431);
            del_btn.Margin = new Padding(3, 4, 3, 4);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(127, 31);
            del_btn.TabIndex = 25;
            del_btn.Text = "Trinti įraša";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += del_btn_Click;
            // 
            // delTextBox
            // 
            delTextBox.Location = new Point(1177, 392);
            delTextBox.Margin = new Padding(3, 4, 3, 4);
            delTextBox.Name = "delTextBox";
            delTextBox.Size = new Size(126, 27);
            delTextBox.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(942, 397);
            label11.Name = "label11";
            label11.Size = new Size(229, 20);
            label11.TabIndex = 27;
            label11.Text = "Iveskite įrašo ID kurį norite ištrinti";
            // 
            // save_btn
            // 
            save_btn.Location = new Point(621, 431);
            save_btn.Margin = new Padding(3, 4, 3, 4);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(145, 31);
            save_btn.TabIndex = 28;
            save_btn.Text = "Išsaugoti pakeitimus";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(621, 392);
            update_btn.Margin = new Padding(3, 4, 3, 4);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(127, 31);
            update_btn.TabIndex = 29;
            update_btn.Text = "Naujinti įrašus";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1177, 521);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 30;
            label12.Text = "Likutis :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1165, 564);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 31;
            label13.Text = "Pajamos :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1171, 607);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 32;
            label14.Text = "Išlaidos :";
            // 
            // likutisLabel
            // 
            likutisLabel.AutoSize = true;
            likutisLabel.Location = new Point(1254, 521);
            likutisLabel.Name = "likutisLabel";
            likutisLabel.Size = new Size(67, 20);
            likutisLabel.TabIndex = 33;
            likutisLabel.Text = "<likutis>";
            // 
            // pajamosLabel
            // 
            pajamosLabel.AutoSize = true;
            pajamosLabel.Location = new Point(1254, 564);
            pajamosLabel.Name = "pajamosLabel";
            pajamosLabel.Size = new Size(86, 20);
            pajamosLabel.TabIndex = 34;
            pajamosLabel.Text = "<pajamos>";
            // 
            // islaidosLabel
            // 
            islaidosLabel.AutoSize = true;
            islaidosLabel.Location = new Point(1254, 607);
            islaidosLabel.Name = "islaidosLabel";
            islaidosLabel.Size = new Size(79, 20);
            islaidosLabel.TabIndex = 35;
            islaidosLabel.Text = "<islaidos>";
            // 
            // button1
            // 
            button1.Location = new Point(144, 791);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 31);
            button1.TabIndex = 36;
            button1.Text = "Kurti ataskaita";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Finansai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 857);
            Controls.Add(button1);
            Controls.Add(islaidosLabel);
            Controls.Add(pajamosLabel);
            Controls.Add(likutisLabel);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(update_btn);
            Controls.Add(save_btn);
            Controls.Add(label11);
            Controls.Add(delTextBox);
            Controls.Add(del_btn);
            Controls.Add(label10);
            Controls.Add(currentLogin);
            Controls.Add(saltinisComboBox);
            Controls.Add(datosParinktis);
            Controls.Add(pildyti_btn);
            Controls.Add(label9);
            Controls.Add(komentarasTextBox);
            Controls.Add(mokejimoListBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tipasListBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sumaTextBox);
            Controls.Add(label3);
            Controls.Add(showDB_btn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(logoff_btn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Finansai";
            Text = "Finansai";
            FormClosing += Finansai_FormClosing;
            Load += Finansai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logoff_btn;
        private DataGridView dataGridView1;
        private Label label2;
        private Button showDB_btn;
        private Label label3;
        private TextBox sumaTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox tipasListBox;
        private Label label7;
        private Label label8;
        private ListBox mokejimoListBox;
        private TextBox komentarasTextBox;
        private Label label9;
        private Button pildyti_btn;
        private DateTimePicker datosParinktis;
        private ComboBox saltinisComboBox;
        private Label currentLogin;
        private Label label10;
        private Button del_btn;
        private TextBox delTextBox;
        private Label label11;
        private Button save_btn;
        private Button update_btn;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label likutisLabel;
        private Label pajamosLabel;
        private Label islaidosLabel;
        private Button button1;
    }
}