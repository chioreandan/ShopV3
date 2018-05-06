namespace GlobalShop
{
    partial class AdministratorWindow
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
            this.info_user = new System.Windows.Forms.Button();
            this.viewProduct = new System.Windows.Forms.Button();
            this.deleteUsers = new System.Windows.Forms.Button();
            this.viewUser = new System.Windows.Forms.Button();
            this.viewUsersLIst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // info_user
            // 
            this.info_user.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.info_user.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info_user.Location = new System.Drawing.Point(479, 309);
            this.info_user.Name = "info_user";
            this.info_user.Size = new System.Drawing.Size(187, 39);
            this.info_user.TabIndex = 11;
            this.info_user.Text = "Informatii Utilizator";
            this.info_user.UseVisualStyleBackColor = false;
            // 
            // viewProduct
            // 
            this.viewProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewProduct.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewProduct.Location = new System.Drawing.Point(479, 227);
            this.viewProduct.Name = "viewProduct";
            this.viewProduct.Size = new System.Drawing.Size(187, 39);
            this.viewProduct.TabIndex = 10;
            this.viewProduct.Text = "Vizualizare produse ";
            this.viewProduct.UseVisualStyleBackColor = false;
            // 
            // deleteUsers
            // 
            this.deleteUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteUsers.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUsers.Location = new System.Drawing.Point(479, 150);
            this.deleteUsers.Name = "deleteUsers";
            this.deleteUsers.Size = new System.Drawing.Size(187, 39);
            this.deleteUsers.TabIndex = 9;
            this.deleteUsers.Text = "Stergere Utilizatori";
            this.deleteUsers.UseVisualStyleBackColor = false;
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // viewUser
            // 
            this.viewUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewUser.Font = new System.Drawing.Font("Champagne & Limousines", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewUser.Location = new System.Drawing.Point(479, 77);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(187, 39);
            this.viewUser.TabIndex = 8;
            this.viewUser.Text = "Vizualizare Utilizatori";
            this.viewUser.UseVisualStyleBackColor = false;
            this.viewUser.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // viewUsersLIst
            // 
            this.viewUsersLIst.FormattingEnabled = true;
            this.viewUsersLIst.Location = new System.Drawing.Point(134, 54);
            this.viewUsersLIst.Name = "viewUsersLIst";
            this.viewUsersLIst.Size = new System.Drawing.Size(239, 342);
            this.viewUsersLIst.TabIndex = 7;
            // 
            // AdministratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_user);
            this.Controls.Add(this.viewProduct);
            this.Controls.Add(this.deleteUsers);
            this.Controls.Add(this.viewUser);
            this.Controls.Add(this.viewUsersLIst);
            this.Name = "AdministratorWindow";
            this.Text = "AdministratorWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button info_user;
        private System.Windows.Forms.Button viewProduct;
        private System.Windows.Forms.Button deleteUsers;
        private System.Windows.Forms.Button viewUser;
        private System.Windows.Forms.ListBox viewUsersLIst;
    }
}