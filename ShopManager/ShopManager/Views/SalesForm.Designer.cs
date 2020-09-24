namespace ShopManager.Views
{
    partial class SalesForm
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
            this.sellButton = new System.Windows.Forms.Button();
            this.Restock = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.signoutButton = new System.Windows.Forms.Button();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.sellUI1 = new ShopManager.Views.SellUI();
            this.contentpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sellButton
            // 
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(12, 27);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(127, 45);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // Restock
            // 
            this.Restock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restock.Location = new System.Drawing.Point(12, 87);
            this.Restock.Name = "Restock";
            this.Restock.Size = new System.Drawing.Size(127, 45);
            this.Restock.TabIndex = 5;
            this.Restock.Text = "Restock";
            this.Restock.UseVisualStyleBackColor = true;
            this.Restock.Click += new System.EventHandler(this.Restock_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(12, 151);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(127, 45);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutButton.Location = new System.Drawing.Point(12, 212);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(127, 45);
            this.signoutButton.TabIndex = 5;
            this.signoutButton.Text = "Sign Out";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.sellUI1);
            this.contentpanel.Location = new System.Drawing.Point(154, 27);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(634, 411);
            this.contentpanel.TabIndex = 6;
            // 
            // sellUI1
            // 
            this.sellUI1.Location = new System.Drawing.Point(3, 3);
            this.sellUI1.Name = "sellUI1";
            this.sellUI1.Size = new System.Drawing.Size(634, 411);
            this.sellUI1.TabIndex = 0;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.Restock);
            this.Controls.Add(this.sellButton);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesForm_FormClosing);
            this.contentpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button Restock;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Panel contentpanel;
        private SellUI sellUI1;
    }
}