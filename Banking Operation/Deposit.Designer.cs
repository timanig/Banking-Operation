namespace Banking_Operation
{
    partial class Deposit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtbal = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtdep);
            this.groupBox1.Controls.Add(this.txtbal);
            this.groupBox1.Controls.Add(this.txtacc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deposit:";
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(183, 48);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(249, 20);
            this.txtacc.TabIndex = 4;
            // 
            // txtbal
            // 
            this.txtbal.Location = new System.Drawing.Point(183, 173);
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(249, 20);
            this.txtbal.TabIndex = 6;
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(183, 235);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(249, 20);
            this.txtdep.TabIndex = 7;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(183, 98);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(249, 20);
            this.txtdate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 446);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtbal;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}