namespace Chat_Application
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.C1PT = new System.Windows.Forms.TextBox();
            this.C1IP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C2PT = new System.Windows.Forms.TextBox();
            this.C2IP = new System.Windows.Forms.TextBox();
            this.SENT = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.C1PT);
            this.groupBox1.Controls.Add(this.C1IP);
            this.groupBox1.Location = new System.Drawing.Point(121, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENT 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // C1PT
            // 
            this.C1PT.Location = new System.Drawing.Point(179, 62);
            this.C1PT.Name = "C1PT";
            this.C1PT.Size = new System.Drawing.Size(100, 22);
            this.C1PT.TabIndex = 1;
            // 
            // C1IP
            // 
            this.C1IP.Location = new System.Drawing.Point(179, 21);
            this.C1IP.Name = "C1IP";
            this.C1IP.Size = new System.Drawing.Size(100, 22);
            this.C1IP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.C2PT);
            this.groupBox2.Controls.Add(this.C2IP);
            this.groupBox2.Location = new System.Drawing.Point(585, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENT 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // C2PT
            // 
            this.C2PT.Location = new System.Drawing.Point(200, 65);
            this.C2PT.Name = "C2PT";
            this.C2PT.Size = new System.Drawing.Size(100, 22);
            this.C2PT.TabIndex = 1;
            // 
            // C2IP
            // 
            this.C2IP.Location = new System.Drawing.Point(200, 26);
            this.C2IP.Name = "C2IP";
            this.C2IP.Size = new System.Drawing.Size(100, 22);
            this.C2IP.TabIndex = 0;
            // 
            // SENT
            // 
            this.SENT.Location = new System.Drawing.Point(121, 418);
            this.SENT.Name = "SENT";
            this.SENT.Size = new System.Drawing.Size(806, 22);
            this.SENT.TabIndex = 2;
            this.SENT.TextChanged += new System.EventHandler(this.SENT_TextChanged);
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 16;
            this.LB.Location = new System.Drawing.Point(121, 209);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(806, 164);
            this.LB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONNECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1012, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.SENT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C1PT;
        private System.Windows.Forms.TextBox C1IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C2PT;
        private System.Windows.Forms.TextBox C2IP;
        private System.Windows.Forms.TextBox SENT;
        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

