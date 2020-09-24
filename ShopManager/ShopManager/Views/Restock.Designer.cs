namespace ShopManager.Views
{
    partial class Restock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heading = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buyingPrice = new System.Windows.Forms.TextBox();
            this.sellingPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(124, 36);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(262, 42);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Restock Form";
            // 
            // productCombo
            // 
            this.productCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(129, 92);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(186, 21);
            this.productCombo.TabIndex = 5;
            this.productCombo.SelectedIndexChanged += new System.EventHandler(this.productCombo_SelectedIndexChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(47, 95);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(76, 13);
            this.productNameLabel.TabIndex = 4;
            this.productNameLabel.Text = "Product name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "quantity:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(131, 127);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(184, 20);
            this.quantity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buying Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selling Price:";
            // 
            // buyingPrice
            // 
            this.buyingPrice.Location = new System.Drawing.Point(129, 162);
            this.buyingPrice.Name = "buyingPrice";
            this.buyingPrice.Size = new System.Drawing.Size(184, 20);
            this.buyingPrice.TabIndex = 6;
            // 
            // sellingPrice
            // 
            this.sellingPrice.Location = new System.Drawing.Point(129, 197);
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.Size = new System.Drawing.Size(184, 20);
            this.sellingPrice.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sellingPrice);
            this.Controls.Add(this.buyingPrice);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.Heading);
            this.Name = "Restock";
            this.Size = new System.Drawing.Size(634, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buyingPrice;
        private System.Windows.Forms.TextBox sellingPrice;
        private System.Windows.Forms.Button button1;
    }
}
