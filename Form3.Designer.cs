namespace WindowsFormsApp1
{
    partial class Form3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1_MotherBoard = new System.Windows.Forms.Button();
            this.button2_GraphicsCard = new System.Windows.Forms.Button();
            this.button3_Processor = new System.Windows.Forms.Button();
            this.button4_RAM = new System.Windows.Forms.Button();
            this.button6_Storage = new System.Windows.Forms.Button();
            this.button5_PowerSupply = new System.Windows.Forms.Button();
            this.button7_HDD = new System.Windows.Forms.Button();
            this.button8_Fan = new System.Windows.Forms.Button();
            this.button9_Monitor = new System.Windows.Forms.Button();
            this.button10_Keyboard = new System.Windows.Forms.Button();
            this.button11_Mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // button1_MotherBoard
            // 
            this.button1_MotherBoard.Location = new System.Drawing.Point(13, 13);
            this.button1_MotherBoard.Name = "button1_MotherBoard";
            this.button1_MotherBoard.Size = new System.Drawing.Size(140, 41);
            this.button1_MotherBoard.TabIndex = 2;
            this.button1_MotherBoard.Text = "Mother Board";
            this.button1_MotherBoard.UseVisualStyleBackColor = true;
            this.button1_MotherBoard.Click += new System.EventHandler(this.button1_MotherBoard_Click);
            // 
            // button2_GraphicsCard
            // 
            this.button2_GraphicsCard.Location = new System.Drawing.Point(13, 60);
            this.button2_GraphicsCard.Name = "button2_GraphicsCard";
            this.button2_GraphicsCard.Size = new System.Drawing.Size(140, 41);
            this.button2_GraphicsCard.TabIndex = 3;
            this.button2_GraphicsCard.Text = "Graphics Card (GPU)";
            this.button2_GraphicsCard.UseVisualStyleBackColor = true;
            this.button2_GraphicsCard.Click += new System.EventHandler(this.button2_GraphicsCard_Click);
            // 
            // button3_Processor
            // 
            this.button3_Processor.Location = new System.Drawing.Point(13, 107);
            this.button3_Processor.Name = "button3_Processor";
            this.button3_Processor.Size = new System.Drawing.Size(140, 41);
            this.button3_Processor.TabIndex = 4;
            this.button3_Processor.Text = "Processor (CPU)";
            this.button3_Processor.UseVisualStyleBackColor = true;
            this.button3_Processor.Click += new System.EventHandler(this.button3_Processor_Click);
            // 
            // button4_RAM
            // 
            this.button4_RAM.Location = new System.Drawing.Point(13, 154);
            this.button4_RAM.Name = "button4_RAM";
            this.button4_RAM.Size = new System.Drawing.Size(140, 41);
            this.button4_RAM.TabIndex = 5;
            this.button4_RAM.Text = "Random Access Memory (RAM)";
            this.button4_RAM.UseVisualStyleBackColor = true;
            this.button4_RAM.Click += new System.EventHandler(this.button4_RAM_Click);
            // 
            // button6_Storage
            // 
            this.button6_Storage.Location = new System.Drawing.Point(13, 248);
            this.button6_Storage.Name = "button6_Storage";
            this.button6_Storage.Size = new System.Drawing.Size(140, 41);
            this.button6_Storage.TabIndex = 6;
            this.button6_Storage.Text = "SSD";
            this.button6_Storage.UseVisualStyleBackColor = true;
            this.button6_Storage.Click += new System.EventHandler(this.button6_Storage_Click);
            // 
            // button5_PowerSupply
            // 
            this.button5_PowerSupply.Location = new System.Drawing.Point(13, 201);
            this.button5_PowerSupply.Name = "button5_PowerSupply";
            this.button5_PowerSupply.Size = new System.Drawing.Size(140, 41);
            this.button5_PowerSupply.TabIndex = 7;
            this.button5_PowerSupply.Text = "Power Supply (PSU)";
            this.button5_PowerSupply.UseVisualStyleBackColor = true;
            this.button5_PowerSupply.Click += new System.EventHandler(this.button5_PowerSupply_Click);
            // 
            // button7_HDD
            // 
            this.button7_HDD.Location = new System.Drawing.Point(13, 295);
            this.button7_HDD.Name = "button7_HDD";
            this.button7_HDD.Size = new System.Drawing.Size(140, 41);
            this.button7_HDD.TabIndex = 8;
            this.button7_HDD.Text = "HDD";
            this.button7_HDD.UseVisualStyleBackColor = true;
            this.button7_HDD.Click += new System.EventHandler(this.button7_HDD_Click);
            // 
            // button8_Fan
            // 
            this.button8_Fan.Location = new System.Drawing.Point(13, 342);
            this.button8_Fan.Name = "button8_Fan";
            this.button8_Fan.Size = new System.Drawing.Size(140, 41);
            this.button8_Fan.TabIndex = 9;
            this.button8_Fan.Text = "Fan (Default | RGB)";
            this.button8_Fan.UseVisualStyleBackColor = true;
            this.button8_Fan.Click += new System.EventHandler(this.button8_Fan_Click);
            // 
            // button9_Monitor
            // 
            this.button9_Monitor.Location = new System.Drawing.Point(13, 389);
            this.button9_Monitor.Name = "button9_Monitor";
            this.button9_Monitor.Size = new System.Drawing.Size(140, 41);
            this.button9_Monitor.TabIndex = 10;
            this.button9_Monitor.Text = "Monitor";
            this.button9_Monitor.UseVisualStyleBackColor = true;
            this.button9_Monitor.Click += new System.EventHandler(this.button9_Monitor_Click);
            // 
            // button10_Keyboard
            // 
            this.button10_Keyboard.Location = new System.Drawing.Point(13, 436);
            this.button10_Keyboard.Name = "button10_Keyboard";
            this.button10_Keyboard.Size = new System.Drawing.Size(140, 41);
            this.button10_Keyboard.TabIndex = 11;
            this.button10_Keyboard.Text = "Keyboard";
            this.button10_Keyboard.UseVisualStyleBackColor = true;
            this.button10_Keyboard.Click += new System.EventHandler(this.button10_Keyboard_Click);
            // 
            // button11_Mouse
            // 
            this.button11_Mouse.Location = new System.Drawing.Point(13, 483);
            this.button11_Mouse.Name = "button11_Mouse";
            this.button11_Mouse.Size = new System.Drawing.Size(140, 41);
            this.button11_Mouse.TabIndex = 12;
            this.button11_Mouse.Text = "Mouse";
            this.button11_Mouse.UseVisualStyleBackColor = true;
            this.button11_Mouse.Click += new System.EventHandler(this.button11_Mouse_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 529);
            this.Controls.Add(this.button11_Mouse);
            this.Controls.Add(this.button10_Keyboard);
            this.Controls.Add(this.button9_Monitor);
            this.Controls.Add(this.button8_Fan);
            this.Controls.Add(this.button7_HDD);
            this.Controls.Add(this.button5_PowerSupply);
            this.Controls.Add(this.button6_Storage);
            this.Controls.Add(this.button4_RAM);
            this.Controls.Add(this.button3_Processor);
            this.Controls.Add(this.button2_GraphicsCard);
            this.Controls.Add(this.button1_MotherBoard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Inventory System | Warehouse Module";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1_MotherBoard;
        private System.Windows.Forms.Button button2_GraphicsCard;
        private System.Windows.Forms.Button button3_Processor;
        private System.Windows.Forms.Button button4_RAM;
        private System.Windows.Forms.Button button6_Storage;
        private System.Windows.Forms.Button button5_PowerSupply;
        private System.Windows.Forms.Button button7_HDD;
        private System.Windows.Forms.Button button8_Fan;
        private System.Windows.Forms.Button button9_Monitor;
        private System.Windows.Forms.Button button10_Keyboard;
        private System.Windows.Forms.Button button11_Mouse;
    }
}