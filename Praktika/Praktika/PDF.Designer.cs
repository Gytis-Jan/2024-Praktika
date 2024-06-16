namespace Praktika
{
    partial class PDF
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
            reset_btn = new Button();
            report_btn = new Button();
            reportListBox = new ListBox();
            label20 = new Label();
            reportComboBox = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            reportDatePicker2 = new DateTimePicker();
            reportDatePicker1 = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(134, 304);
            reset_btn.Margin = new Padding(3, 4, 3, 4);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(133, 31);
            reset_btn.TabIndex = 47;
            reset_btn.Text = "Anuliuoti parinktis";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // report_btn
            // 
            report_btn.Location = new Point(14, 304);
            report_btn.Margin = new Padding(3, 4, 3, 4);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(113, 31);
            report_btn.TabIndex = 58;
            report_btn.Text = "Kurti ataskaita";
            report_btn.UseVisualStyleBackColor = true;
            report_btn.Click += report_btn_Click;
            // 
            // reportListBox
            // 
            reportListBox.FormattingEnabled = true;
            reportListBox.Location = new Point(202, 223);
            reportListBox.Margin = new Padding(3, 4, 3, 4);
            reportListBox.Name = "reportListBox";
            reportListBox.Size = new Size(137, 44);
            reportListBox.TabIndex = 57;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 223);
            label20.Name = "label20";
            label20.Size = new Size(182, 20);
            label20.TabIndex = 56;
            label20.Text = "Pagal pajamas ar išlaidas :";
            // 
            // reportComboBox
            // 
            reportComboBox.FormattingEnabled = true;
            reportComboBox.Location = new Point(166, 158);
            reportComboBox.Margin = new Padding(3, 4, 3, 4);
            reportComboBox.Name = "reportComboBox";
            reportComboBox.Size = new Size(138, 28);
            reportComboBox.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(14, 161);
            label19.Name = "label19";
            label19.Size = new Size(146, 20);
            label19.TabIndex = 54;
            label19.Text = "Pagal finansų šaltinį :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(287, 97);
            label18.Name = "label18";
            label18.Size = new Size(24, 20);
            label18.TabIndex = 53;
            label18.Text = "—";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 97);
            label17.Name = "label17";
            label17.Size = new Size(108, 20);
            label17.TabIndex = 52;
            label17.Text = "Pagal perioda :";
            // 
            // reportDatePicker2
            // 
            reportDatePicker2.Location = new Point(312, 92);
            reportDatePicker2.Margin = new Padding(3, 4, 3, 4);
            reportDatePicker2.Name = "reportDatePicker2";
            reportDatePicker2.Size = new Size(158, 27);
            reportDatePicker2.TabIndex = 51;
            // 
            // reportDatePicker1
            // 
            reportDatePicker1.Location = new Point(128, 92);
            reportDatePicker1.Margin = new Padding(3, 4, 3, 4);
            reportDatePicker1.Name = "reportDatePicker1";
            reportDatePicker1.Size = new Size(158, 27);
            reportDatePicker1.TabIndex = 50;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 37);
            label16.Name = "label16";
            label16.Size = new Size(280, 20);
            label16.TabIndex = 49;
            label16.Text = "Pasirinkite pagal ką norite gauti ataskaitą";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label15.Location = new Point(14, 12);
            label15.Name = "label15";
            label15.Size = new Size(162, 23);
            label15.TabIndex = 48;
            label15.Text = "Ataskaitos kūrimas";
            // 
            // PDF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 411);
            Controls.Add(reset_btn);
            Controls.Add(report_btn);
            Controls.Add(reportListBox);
            Controls.Add(label20);
            Controls.Add(reportComboBox);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(reportDatePicker2);
            Controls.Add(reportDatePicker1);
            Controls.Add(label16);
            Controls.Add(label15);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PDF";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reset_btn;
        private Button report_btn;
        private ListBox reportListBox;
        private Label label20;
        private ComboBox reportComboBox;
        private Label label19;
        private Label label18;
        private Label label17;
        private DateTimePicker reportDatePicker2;
        private DateTimePicker reportDatePicker1;
        private Label label16;
        private Label label15;
    }
}