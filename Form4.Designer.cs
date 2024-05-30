namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_Name = new System.Windows.Forms.TextBox();
            this.textBox2_EmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_Password = new System.Windows.Forms.TextBox();
            this.textBox4_conPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4_ErrorPass = new System.Windows.Forms.Label();
            this.label6_nameError = new System.Windows.Forms.Label();
            this.label7_empID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign up Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_Name
            // 
            this.textBox1_Name.Location = new System.Drawing.Point(8, 31);
            this.textBox1_Name.Name = "textBox1_Name";
            this.textBox1_Name.Size = new System.Drawing.Size(285, 20);
            this.textBox1_Name.TabIndex = 5;
            // 
            // textBox2_EmpID
            // 
            this.textBox2_EmpID.Location = new System.Drawing.Point(9, 88);
            this.textBox2_EmpID.Name = "textBox2_EmpID";
            this.textBox2_EmpID.Size = new System.Drawing.Size(285, 20);
            this.textBox2_EmpID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // textBox3_Password
            // 
            this.textBox3_Password.Location = new System.Drawing.Point(9, 152);
            this.textBox3_Password.Name = "textBox3_Password";
            this.textBox3_Password.Size = new System.Drawing.Size(288, 20);
            this.textBox3_Password.TabIndex = 7;
            this.textBox3_Password.UseSystemPasswordChar = true;
            // 
            // textBox4_conPass
            // 
            this.textBox4_conPass.Location = new System.Drawing.Point(8, 200);
            this.textBox4_conPass.Name = "textBox4_conPass";
            this.textBox4_conPass.Size = new System.Drawing.Size(288, 20);
            this.textBox4_conPass.TabIndex = 11;
            this.textBox4_conPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Retry your Password:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(193, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Login Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(193, 224);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4_ErrorPass
            // 
            this.label4_ErrorPass.AutoSize = true;
            this.label4_ErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_ErrorPass.ForeColor = System.Drawing.Color.Red;
            this.label4_ErrorPass.Location = new System.Drawing.Point(12, 223);
            this.label4_ErrorPass.Name = "label4_ErrorPass";
            this.label4_ErrorPass.Size = new System.Drawing.Size(10, 13);
            this.label4_ErrorPass.TabIndex = 14;
            this.label4_ErrorPass.Text = "`";
            // 
            // label6_nameError
            // 
            this.label6_nameError.AutoSize = true;
            this.label6_nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_nameError.ForeColor = System.Drawing.Color.Red;
            this.label6_nameError.Location = new System.Drawing.Point(9, 57);
            this.label6_nameError.Name = "label6_nameError";
            this.label6_nameError.Size = new System.Drawing.Size(0, 13);
            this.label6_nameError.TabIndex = 15;
            // 
            // label7_empID
            // 
            this.label7_empID.AutoSize = true;
            this.label7_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_empID.ForeColor = System.Drawing.Color.Red;
            this.label7_empID.Location = new System.Drawing.Point(7, 111);
            this.label7_empID.Name = "label7_empID";
            this.label7_empID.Size = new System.Drawing.Size(0, 13);
            this.label7_empID.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 328);
            this.Controls.Add(this.label7_empID);
            this.Controls.Add(this.label6_nameError);
            this.Controls.Add(this.label4_ErrorPass);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4_conPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3_Password);
            this.Controls.Add(this.textBox2_EmpID);
            this.Controls.Add(this.textBox1_Name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Register Account";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1_Name;
        private System.Windows.Forms.TextBox textBox2_EmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_Password;
        private System.Windows.Forms.TextBox textBox4_conPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4_ErrorPass;
        private System.Windows.Forms.Label label6_nameError;
        private System.Windows.Forms.Label label7_empID;
    }
}