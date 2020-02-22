namespace COVID19_ContactTracing
{
    partial class MainMenu
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
            this.lbTier0 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTier1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTier2 = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.ListBox();
            this.cbSuspectedPeople = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTier3 = new System.Windows.Forms.ListBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTier0
            // 
            this.lbTier0.FormattingEnabled = true;
            this.lbTier0.Location = new System.Drawing.Point(598, 45);
            this.lbTier0.Margin = new System.Windows.Forms.Padding(2);
            this.lbTier0.Name = "lbTier0";
            this.lbTier0.Size = new System.Drawing.Size(389, 212);
            this.lbTier0.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Direct Contact: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tier 1 (90 - 99 Percentile): ";
            // 
            // lbTier1
            // 
            this.lbTier1.FormattingEnabled = true;
            this.lbTier1.Location = new System.Drawing.Point(9, 274);
            this.lbTier1.Margin = new System.Windows.Forms.Padding(2);
            this.lbTier1.Name = "lbTier1";
            this.lbTier1.Size = new System.Drawing.Size(457, 147);
            this.lbTier1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tier 2 (75 - 89 Percentile): ";
            // 
            // lbTier2
            // 
            this.lbTier2.FormattingEnabled = true;
            this.lbTier2.Location = new System.Drawing.Point(472, 274);
            this.lbTier2.Margin = new System.Windows.Forms.Padding(2);
            this.lbTier2.Name = "lbTier2";
            this.lbTier2.Size = new System.Drawing.Size(515, 147);
            this.lbTier2.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(838, 563);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(149, 22);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Get Records";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Infected (Based on Temperature recordings): ";
            // 
            // lbRecords
            // 
            this.lbRecords.FormattingEnabled = true;
            this.lbRecords.Location = new System.Drawing.Point(9, 32);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(585, 225);
            this.lbRecords.TabIndex = 12;
            // 
            // cbSuspectedPeople
            // 
            this.cbSuspectedPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspectedPeople.FormattingEnabled = true;
            this.cbSuspectedPeople.Location = new System.Drawing.Point(299, 7);
            this.cbSuspectedPeople.Margin = new System.Windows.Forms.Padding(2);
            this.cbSuspectedPeople.Name = "cbSuspectedPeople";
            this.cbSuspectedPeople.Size = new System.Drawing.Size(293, 21);
            this.cbSuspectedPeople.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tier 3 (0 - 74 Percentile): ";
            // 
            // lbTier3
            // 
            this.lbTier3.FormattingEnabled = true;
            this.lbTier3.Location = new System.Drawing.Point(9, 438);
            this.lbTier3.Margin = new System.Windows.Forms.Padding(2);
            this.lbTier3.Name = "lbTier3";
            this.lbTier3.Size = new System.Drawing.Size(457, 147);
            this.lbTier3.TabIndex = 14;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(689, 438);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(118, 20);
            this.dtpTime.TabIndex = 16;
            this.dtpTime.Value = new System.DateTime(2020, 2, 23, 18, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ending Hours: ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTier3);
            this.Controls.Add(this.cbSuspectedPeople);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTier2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTier1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTier0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Analyse Form";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbTier0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTier1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTier2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbRecords;
        private System.Windows.Forms.ComboBox cbSuspectedPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbTier3;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label6;
    }
}

