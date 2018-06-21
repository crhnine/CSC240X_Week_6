namespace LetsMakeADeal
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
            this.door1 = new System.Windows.Forms.Button();
            this.door2 = new System.Windows.Forms.Button();
            this.door3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // door1
            // 
            this.door1.Location = new System.Drawing.Point(146, 220);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(75, 140);
            this.door1.TabIndex = 0;
            this.door1.Text = "Door 1";
            this.door1.UseVisualStyleBackColor = true;
            this.door1.Click += new System.EventHandler(this.door1_Click);
            // 
            // door2
            // 
            this.door2.Location = new System.Drawing.Point(378, 220);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(75, 140);
            this.door2.TabIndex = 1;
            this.door2.Text = "Door 2";
            this.door2.UseVisualStyleBackColor = true;
            this.door2.Click += new System.EventHandler(this.door2_Click);
            // 
            // door3
            // 
            this.door3.Location = new System.Drawing.Point(593, 220);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(75, 140);
            this.door3.TabIndex = 2;
            this.door3.Text = "Door 3";
            this.door3.UseVisualStyleBackColor = true;
            this.door3.Click += new System.EventHandler(this.door3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Let\'s Make A Deal!!!\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(158, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "We have behind these doors three prizes\r\n that will surely knock your socks off!\r" +
    "\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prize 1: A Car!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prize 2: A Big Screen T.V.!";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prize 3: Surely something everyone wants!\r\n\r\nA Live Goat!!!\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 52);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prizes are randomly assigned to the Doors.\r\n\r\nEvery contestant has one extra atte" +
    "mpt at selecting\r\na door to try to get the prize they always desired!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Try Again!?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.door1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button door3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

