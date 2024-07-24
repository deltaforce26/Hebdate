namespace כתובה
{
    partial class Form1
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
            comboBox_dayOfWeek = new ComboBox();
            comboBox_DayOfMonth = new ComboBox();
            comboBox_month = new ComboBox();
            comboBox_year = new ComboBox();
            label_dayOfWeek = new Label();
            label2_dayOfMonth = new Label();
            label_month = new Label();
            label4_year = new Label();
            label1_insertDate = new Label();
            button1_confirm = new Button();
            SuspendLayout();
            // 
            // comboBox_dayOfWeek
            // 
            comboBox_dayOfWeek.FormattingEnabled = true;
            comboBox_dayOfWeek.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            comboBox_dayOfWeek.Location = new Point(757, 139);
            comboBox_dayOfWeek.Name = "comboBox_dayOfWeek";
            comboBox_dayOfWeek.Size = new Size(151, 28);
            comboBox_dayOfWeek.TabIndex = 0;
            // 
            // comboBox_DayOfMonth
            // 
            comboBox_DayOfMonth.FormattingEnabled = true;
            comboBox_DayOfMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox_DayOfMonth.Location = new Point(512, 139);
            comboBox_DayOfMonth.Name = "comboBox_DayOfMonth";
            comboBox_DayOfMonth.Size = new Size(151, 28);
            comboBox_DayOfMonth.TabIndex = 1;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            comboBox_month.Location = new Point(262, 139);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(151, 28);
            comboBox_month.TabIndex = 2;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBox_year.Location = new Point(43, 139);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(151, 28);
            comboBox_year.TabIndex = 3;
            // 
            // label_dayOfWeek
            // 
            label_dayOfWeek.AutoSize = true;
            label_dayOfWeek.Location = new Point(793, 84);
            label_dayOfWeek.Name = "label_dayOfWeek";
            label_dayOfWeek.Size = new Size(84, 20);
            label_dayOfWeek.TabIndex = 4;
            label_dayOfWeek.Text = "היום בשבוע";
            // 
            // label2_dayOfMonth
            // 
            label2_dayOfMonth.AutoSize = true;
            label2_dayOfMonth.Location = new Point(541, 84);
            label2_dayOfMonth.Name = "label2_dayOfMonth";
            label2_dayOfMonth.Size = new Size(83, 20);
            label2_dayOfMonth.TabIndex = 5;
            label2_dayOfMonth.Text = "היום בחודש";
            // 
            // label_month
            // 
            label_month.AutoSize = true;
            label_month.Location = new Point(304, 84);
            label_month.Name = "label_month";
            label_month.Size = new Size(42, 20);
            label_month.TabIndex = 7;
            label_month.Text = "חודש";
            // 
            // label4_year
            // 
            label4_year.AutoSize = true;
            label4_year.Location = new Point(84, 84);
            label4_year.Name = "label4_year";
            label4_year.Size = new Size(37, 20);
            label4_year.TabIndex = 6;
            label4_year.Text = "שנה";
            // 
            // label1_insertDate
            // 
            label1_insertDate.AutoSize = true;
            label1_insertDate.Location = new Point(398, 9);
            label1_insertDate.Name = "label1_insertDate";
            label1_insertDate.Size = new Size(96, 20);
            label1_insertDate.TabIndex = 8;
            label1_insertDate.Text = "בחירת תאריך";
            // 
            // button1_confirm
            // 
            button1_confirm.Location = new Point(398, 538);
            button1_confirm.Name = "button1_confirm";
            button1_confirm.Size = new Size(176, 56);
            button1_confirm.TabIndex = 9;
            button1_confirm.Text = "אישור";
            button1_confirm.UseVisualStyleBackColor = true;
            button1_confirm.Click += button1_confirm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 620);
            Controls.Add(button1_confirm);
            Controls.Add(label1_insertDate);
            Controls.Add(label_month);
            Controls.Add(label4_year);
            Controls.Add(label2_dayOfMonth);
            Controls.Add(label_dayOfWeek);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_DayOfMonth);
            Controls.Add(comboBox_dayOfWeek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_dayOfWeek;
        private ComboBox comboBox_DayOfMonth;
        private ComboBox comboBox_month;
        private ComboBox comboBox_year;
        private Label label_dayOfWeek;
        private Label label2_dayOfMonth;
        private Label label_month;
        private Label label4_year;
        private Label label1_insertDate;
        private Button button1_confirm;
    }
}
