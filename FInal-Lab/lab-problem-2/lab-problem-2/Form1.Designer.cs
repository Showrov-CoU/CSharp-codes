namespace _3_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbred = new System.Windows.Forms.RadioButton();
            this.rbgreen = new System.Windows.Forms.RadioButton();
            this.rbpink = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chkbold = new System.Windows.Forms.RadioButton();
            this.chkitalic = new System.Windows.Forms.RadioButton();
            this.chkunderline = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rbred
            // 
            this.rbred.AutoSize = true;
            this.rbred.Location = new System.Drawing.Point(235, 219);
            this.rbred.Name = "rbred";
            this.rbred.Size = new System.Drawing.Size(48, 17);
            this.rbred.TabIndex = 5;
            this.rbred.TabStop = true;
            this.rbred.Text = "RED";
            this.rbred.UseVisualStyleBackColor = true;
            // 
            // rbgreen
            // 
            this.rbgreen.AutoSize = true;
            this.rbgreen.Location = new System.Drawing.Point(310, 219);
            this.rbgreen.Name = "rbgreen";
            this.rbgreen.Size = new System.Drawing.Size(63, 17);
            this.rbgreen.TabIndex = 6;
            this.rbgreen.TabStop = true;
            this.rbgreen.Text = "GREEN";
            this.rbgreen.UseVisualStyleBackColor = true;
            // 
            // rbpink
            // 
            this.rbpink.AutoSize = true;
            this.rbpink.Location = new System.Drawing.Point(395, 219);
            this.rbpink.Name = "rbpink";
            this.rbpink.Size = new System.Drawing.Size(50, 17);
            this.rbpink.TabIndex = 7;
            this.rbpink.TabStop = true;
            this.rbpink.Text = "PINK";
            this.rbpink.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 265);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 71);
            this.textBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "DISPLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Message";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 40);
            this.textBox2.TabIndex = 12;
            // 
            // chkbold
            // 
            this.chkbold.AutoSize = true;
            this.chkbold.Location = new System.Drawing.Point(235, 186);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(54, 17);
            this.chkbold.TabIndex = 13;
            this.chkbold.TabStop = true;
            this.chkbold.Text = "BOLD";
            this.chkbold.UseVisualStyleBackColor = true;
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Location = new System.Drawing.Point(310, 186);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(58, 17);
            this.chkitalic.TabIndex = 14;
            this.chkitalic.TabStop = true;
            this.chkitalic.Text = "ITALIC";
            this.chkitalic.UseVisualStyleBackColor = true;
            // 
            // chkunderline
            // 
            this.chkunderline.AutoSize = true;
            this.chkunderline.Location = new System.Drawing.Point(395, 186);
            this.chkunderline.Name = "chkunderline";
            this.chkunderline.Size = new System.Drawing.Size(88, 17);
            this.chkunderline.TabIndex = 15;
            this.chkunderline.TabStop = true;
            this.chkunderline.Text = "UNDERLINE";
            this.chkunderline.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkunderline);
            this.Controls.Add(this.chkitalic);
            this.Controls.Add(this.chkbold);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rbpink);
            this.Controls.Add(this.rbgreen);
            this.Controls.Add(this.rbred);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbred;
        private System.Windows.Forms.RadioButton rbgreen;

        private System.Windows.Forms.RadioButton rbpink;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton chkbold;
        private System.Windows.Forms.RadioButton chkitalic;
        private System.Windows.Forms.RadioButton chkunderline;
        private System.Windows.Forms.Button button2;
        
    }
}

