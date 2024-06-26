namespace SDAM2STOCKTRY1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StockCodeInput = new System.Windows.Forms.TextBox();
            this.StockNameInput = new System.Windows.Forms.TextBox();
            this.StockQuantityInput = new System.Windows.Forms.TextBox();
            this.AddQuantityButton = new System.Windows.Forms.Button();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(44, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Quantity:";
            // 
            // StockCodeInput
            // 
            this.StockCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockCodeInput.Location = new System.Drawing.Point(225, 113);
            this.StockCodeInput.Name = "StockCodeInput";
            this.StockCodeInput.Size = new System.Drawing.Size(365, 38);
            this.StockCodeInput.TabIndex = 3;
            // 
            // StockNameInput
            // 
            this.StockNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.StockNameInput.Location = new System.Drawing.Point(225, 176);
            this.StockNameInput.Name = "StockNameInput";
            this.StockNameInput.Size = new System.Drawing.Size(365, 38);
            this.StockNameInput.TabIndex = 4;
            // 
            // StockQuantityInput
            // 
            this.StockQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.StockQuantityInput.Location = new System.Drawing.Point(225, 233);
            this.StockQuantityInput.Name = "StockQuantityInput";
            this.StockQuantityInput.Size = new System.Drawing.Size(365, 38);
            this.StockQuantityInput.TabIndex = 5;
            // 
            // AddQuantityButton
            // 
            this.AddQuantityButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddQuantityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuantityButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.AddQuantityButton.Location = new System.Drawing.Point(371, 314);
            this.AddQuantityButton.Name = "AddQuantityButton";
            this.AddQuantityButton.Size = new System.Drawing.Size(184, 54);
            this.AddQuantityButton.TabIndex = 6;
            this.AddQuantityButton.Text = "Add Quantity";
            this.AddQuantityButton.UseVisualStyleBackColor = false;
            this.AddQuantityButton.Click += new System.EventHandler(this.AddQuantityButton_Click);
            // 
            // AddStockButton
            // 
            this.AddStockButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStockButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockButton.Location = new System.Drawing.Point(86, 314);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(184, 54);
            this.AddStockButton.TabIndex = 7;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.UseVisualStyleBackColor = false;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1094, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(178, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear Both Tables";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1188, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.AddQuantityButton);
            this.Controls.Add(this.StockQuantityInput);
            this.Controls.Add(this.StockNameInput);
            this.Controls.Add(this.StockCodeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StockCodeInput;
        private System.Windows.Forms.TextBox StockNameInput;
        private System.Windows.Forms.TextBox StockQuantityInput;
        private System.Windows.Forms.Button AddQuantityButton;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

