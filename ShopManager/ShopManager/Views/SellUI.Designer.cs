namespace ShopManager.Views
{
    partial class SellUI
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
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionvalue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.procevalue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalvalue = new System.Windows.Forms.Label();
            this.productData = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.resetButon = new System.Windows.Forms.Button();
            this.resetAll = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceAll = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paidTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.returnvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(172, 19);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(238, 42);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Selling Form";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(53, 88);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(76, 13);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product name:";
            // 
            // productCombo
            // 
            this.productCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(135, 85);
            this.productCombo.Name = "productCombo";
            this.productCombo.Size = new System.Drawing.Size(407, 21);
            this.productCombo.TabIndex = 3;
            this.productCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // descriptionvalue
            // 
            this.descriptionvalue.AutoSize = true;
            this.descriptionvalue.Location = new System.Drawing.Point(132, 121);
            this.descriptionvalue.Name = "descriptionvalue";
            this.descriptionvalue.Size = new System.Drawing.Size(89, 13);
            this.descriptionvalue.TabIndex = 2;
            this.descriptionvalue.Text = "Description value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(135, 149);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(100, 20);
            this.quantityText.TabIndex = 4;
            this.quantityText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.quantityText_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // procevalue
            // 
            this.procevalue.AutoSize = true;
            this.procevalue.Location = new System.Drawing.Point(308, 152);
            this.procevalue.Name = "procevalue";
            this.procevalue.Size = new System.Drawing.Size(60, 13);
            this.procevalue.TabIndex = 2;
            this.procevalue.Text = "Price value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total:";
            // 
            // totalvalue
            // 
            this.totalvalue.AutoSize = true;
            this.totalvalue.Location = new System.Drawing.Point(432, 152);
            this.totalvalue.Name = "totalvalue";
            this.totalvalue.Size = new System.Drawing.Size(60, 13);
            this.totalvalue.TabIndex = 2;
            this.totalvalue.Text = "Price value";
            // 
            // productData
            // 
            this.productData.AllowUserToAddRows = false;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productData.Location = new System.Drawing.Point(56, 205);
            this.productData.Name = "productData";
            this.productData.ReadOnly = true;
            this.productData.Size = new System.Drawing.Size(486, 89);
            this.productData.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(467, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // resetButon
            // 
            this.resetButon.Location = new System.Drawing.Point(56, 176);
            this.resetButon.Name = "resetButon";
            this.resetButon.Size = new System.Drawing.Size(75, 23);
            this.resetButon.TabIndex = 6;
            this.resetButon.Text = "Reset";
            this.resetButon.UseVisualStyleBackColor = true;
            this.resetButon.Click += new System.EventHandler(this.resetButon_Click);
            // 
            // resetAll
            // 
            this.resetAll.Location = new System.Drawing.Point(271, 367);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(75, 23);
            this.resetAll.TabIndex = 6;
            this.resetAll.Text = "Reset All";
            this.resetAll.UseVisualStyleBackColor = true;
            this.resetAll.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(56, 367);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(467, 176);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total price:";
            // 
            // totalPriceAll
            // 
            this.totalPriceAll.AutoSize = true;
            this.totalPriceAll.Location = new System.Drawing.Point(132, 325);
            this.totalPriceAll.Name = "totalPriceAll";
            this.totalPriceAll.Size = new System.Drawing.Size(60, 13);
            this.totalPriceAll.TabIndex = 2;
            this.totalPriceAll.Text = "Total price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Paid:";
            // 
            // paidTextbox
            // 
            this.paidTextbox.Location = new System.Drawing.Point(257, 318);
            this.paidTextbox.Name = "paidTextbox";
            this.paidTextbox.Size = new System.Drawing.Size(100, 20);
            this.paidTextbox.TabIndex = 4;
            this.paidTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.paidTextbox_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Return:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // returnvalue
            // 
            this.returnvalue.AutoSize = true;
            this.returnvalue.Location = new System.Drawing.Point(450, 321);
            this.returnvalue.Name = "returnvalue";
            this.returnvalue.Size = new System.Drawing.Size(42, 13);
            this.returnvalue.TabIndex = 2;
            this.returnvalue.Text = "Return:";
            this.returnvalue.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resetButon);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.resetAll);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.productData);
            this.Controls.Add(this.paidTextbox);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.productCombo);
            this.Controls.Add(this.descriptionvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalvalue);
            this.Controls.Add(this.procevalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnvalue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalPriceAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.Heading);
            this.Name = "SellUI";
            this.Size = new System.Drawing.Size(634, 411);
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label procevalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalvalue;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button resetButon;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalPriceAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paidTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label returnvalue;
    }
}
