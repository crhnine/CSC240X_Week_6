namespace BedAndBreakfast
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            this.lincolnRoomDescription = new System.Windows.Forms.Label();
            this.lincolnRoomPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lincolnRoomDescription
            // 
            this.lincolnRoomDescription.AutoSize = true;
            this.lincolnRoomDescription.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnRoomDescription.Location = new System.Drawing.Point(51, 32);
            this.lincolnRoomDescription.Name = "lincolnRoomDescription";
            this.lincolnRoomDescription.Size = new System.Drawing.Size(197, 42);
            this.lincolnRoomDescription.TabIndex = 0;
            this.lincolnRoomDescription.Text = "Return to the 1850s in this lovely\r\nroom with private bath";
            // 
            // lincolnRoomPrice
            // 
            this.lincolnRoomPrice.AutoSize = true;
            this.lincolnRoomPrice.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnRoomPrice.Location = new System.Drawing.Point(95, 114);
            this.lincolnRoomPrice.Name = "lincolnRoomPrice";
            this.lincolnRoomPrice.Size = new System.Drawing.Size(91, 21);
            this.lincolnRoomPrice.TabIndex = 1;
            this.lincolnRoomPrice.Text = "$110 per night";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 194);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lincolnRoomPrice);
            this.Controls.Add(this.lincolnRoomDescription);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lincolnRoomDescription;
        private System.Windows.Forms.Label lincolnRoomPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}