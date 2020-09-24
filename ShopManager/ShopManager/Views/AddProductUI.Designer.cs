namespace ShopManager.Views
{
    partial class AddProductUI
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deskcriptionText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buyingCostTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(109, 18);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(351, 42);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Add a new Product";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(50, 110);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(76, 13);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product name:";
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(132, 107);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(328, 20);
            this.productNameTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description:";
            // 
            // deskcriptionText
            // 
            this.deskcriptionText.Location = new System.Drawing.Point(132, 133);
            this.deskcriptionText.Name = "deskcriptionText";
            this.deskcriptionText.Size = new System.Drawing.Size(328, 78);
            this.deskcriptionText.TabIndex = 3;
            this.deskcriptionText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buying Cost:";
            // 
            // buyingCostTextbox
            // 
            this.buyingCostTextbox.Location = new System.Drawing.Point(132, 226);
            this.buyingCostTextbox.Name = "buyingCostTextbox";
            this.buyingCostTextbox.Size = new System.Drawing.Size(328, 20);
            this.buyingCostTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price:";
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(132, 262);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(328, 20);
            this.pricetextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity:";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(132, 295);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(328, 20);
            this.quantityText.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(355, 340);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProductUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deskcriptionText);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.buyingCostTextbox);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.Heading);
            this.Name = "AddProductUI";
            this.Size = new System.Drawing.Size(634, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox deskcriptionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buyingCostTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Button addButton;
    }
}
