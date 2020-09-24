namespace ShopManager.Views
{
    partial class AddUser
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
            this.components = new System.ComponentModel.Container();
            this.Heading = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.adduserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(188, 45);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(298, 33);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Add Salesman Form";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(143, 133);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 13);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "userName:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(207, 130);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(235, 20);
            this.usernameTextbox.TabIndex = 2;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(143, 168);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(56, 13);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password:";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(207, 165);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(235, 20);
            this.passwordtextbox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // adduserButton
            // 
            this.adduserButton.Location = new System.Drawing.Point(330, 224);
            this.adduserButton.Name = "adduserButton";
            this.adduserButton.Size = new System.Drawing.Size(112, 23);
            this.adduserButton.TabIndex = 3;
            this.adduserButton.Text = "Add Salesman";
            this.adduserButton.UseVisualStyleBackColor = true;
            this.adduserButton.Click += new System.EventHandler(this.adduserButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adduserButton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.Heading);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(649, 405);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button adduserButton;
    }
}
