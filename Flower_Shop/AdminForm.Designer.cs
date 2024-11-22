namespace Flower_Shop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.BTLogOutAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTUsers = new System.Windows.Forms.Button();
            this.BTRoles = new System.Windows.Forms.Button();
            this.BTSupplier = new System.Windows.Forms.Button();
            this.BTColor = new System.Windows.Forms.Button();
            this.BTSize = new System.Windows.Forms.Button();
            this.BTType = new System.Windows.Forms.Button();
            this.BTStore = new System.Windows.Forms.Button();
            this.BTSaPo = new System.Windows.Forms.Button();
            this.BTFlowers = new System.Windows.Forms.Button();
            this.BTAvailable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTLogOutAdmin
            // 
            this.BTLogOutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTLogOutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTLogOutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTLogOutAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTLogOutAdmin.Location = new System.Drawing.Point(1299, 633);
            this.BTLogOutAdmin.Name = "BTLogOutAdmin";
            this.BTLogOutAdmin.Size = new System.Drawing.Size(79, 34);
            this.BTLogOutAdmin.TabIndex = 0;
            this.BTLogOutAdmin.Text = "log out";
            this.BTLogOutAdmin.UseVisualStyleBackColor = false;
            this.BTLogOutAdmin.Click += new System.EventHandler(this.BTLogOutAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please, select the table you will be working with\r\n";
            // 
            // BTUsers
            // 
            this.BTUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTUsers.Location = new System.Drawing.Point(271, 152);
            this.BTUsers.Name = "BTUsers";
            this.BTUsers.Size = new System.Drawing.Size(204, 34);
            this.BTUsers.TabIndex = 2;
            this.BTUsers.Text = "System users table";
            this.BTUsers.UseVisualStyleBackColor = false;
            this.BTUsers.Click += new System.EventHandler(this.BTUsers_Click);
            // 
            // BTRoles
            // 
            this.BTRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTRoles.Location = new System.Drawing.Point(271, 241);
            this.BTRoles.Name = "BTRoles";
            this.BTRoles.Size = new System.Drawing.Size(204, 34);
            this.BTRoles.TabIndex = 3;
            this.BTRoles.Text = "Users role table";
            this.BTRoles.UseVisualStyleBackColor = false;
            this.BTRoles.Click += new System.EventHandler(this.BTRoles_Click);
            // 
            // BTSupplier
            // 
            this.BTSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSupplier.Location = new System.Drawing.Point(271, 337);
            this.BTSupplier.Name = "BTSupplier";
            this.BTSupplier.Size = new System.Drawing.Size(204, 34);
            this.BTSupplier.TabIndex = 4;
            this.BTSupplier.Text = "Suppliers table";
            this.BTSupplier.UseVisualStyleBackColor = false;
            this.BTSupplier.Click += new System.EventHandler(this.BTSupplier_Click);
            // 
            // BTColor
            // 
            this.BTColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTColor.Location = new System.Drawing.Point(271, 428);
            this.BTColor.Name = "BTColor";
            this.BTColor.Size = new System.Drawing.Size(204, 34);
            this.BTColor.TabIndex = 5;
            this.BTColor.Text = "Button color table";
            this.BTColor.UseVisualStyleBackColor = false;
            this.BTColor.Click += new System.EventHandler(this.BTColor_Click);
            // 
            // BTSize
            // 
            this.BTSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSize.Location = new System.Drawing.Point(271, 521);
            this.BTSize.Name = "BTSize";
            this.BTSize.Size = new System.Drawing.Size(204, 34);
            this.BTSize.TabIndex = 6;
            this.BTSize.Text = "Button size table";
            this.BTSize.UseVisualStyleBackColor = false;
            this.BTSize.Click += new System.EventHandler(this.BTSize_Click);
            // 
            // BTType
            // 
            this.BTType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTType.Location = new System.Drawing.Point(765, 152);
            this.BTType.Name = "BTType";
            this.BTType.Size = new System.Drawing.Size(204, 34);
            this.BTType.TabIndex = 7;
            this.BTType.Text = "Flower type table";
            this.BTType.UseVisualStyleBackColor = false;
            this.BTType.Click += new System.EventHandler(this.BTType_Click);
            // 
            // BTStore
            // 
            this.BTStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTStore.Location = new System.Drawing.Point(765, 241);
            this.BTStore.Name = "BTStore";
            this.BTStore.Size = new System.Drawing.Size(204, 34);
            this.BTStore.TabIndex = 8;
            this.BTStore.Text = "Storehouse table";
            this.BTStore.UseVisualStyleBackColor = false;
            this.BTStore.Click += new System.EventHandler(this.BTStore_Click);
            // 
            // BTSaPo
            // 
            this.BTSaPo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSaPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSaPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSaPo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSaPo.Location = new System.Drawing.Point(765, 337);
            this.BTSaPo.Name = "BTSaPo";
            this.BTSaPo.Size = new System.Drawing.Size(204, 34);
            this.BTSaPo.TabIndex = 9;
            this.BTSaPo.Text = "Sale points table";
            this.BTSaPo.UseVisualStyleBackColor = false;
            this.BTSaPo.Click += new System.EventHandler(this.BTSaPo_Click);
            // 
            // BTFlowers
            // 
            this.BTFlowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTFlowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFlowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTFlowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTFlowers.Location = new System.Drawing.Point(765, 428);
            this.BTFlowers.Name = "BTFlowers";
            this.BTFlowers.Size = new System.Drawing.Size(204, 34);
            this.BTFlowers.TabIndex = 10;
            this.BTFlowers.Text = "Flowers table";
            this.BTFlowers.UseVisualStyleBackColor = false;
            this.BTFlowers.Click += new System.EventHandler(this.BTFlowers_Click);
            // 
            // BTAvailable
            // 
            this.BTAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTAvailable.Location = new System.Drawing.Point(765, 521);
            this.BTAvailable.Name = "BTAvailable";
            this.BTAvailable.Size = new System.Drawing.Size(204, 34);
            this.BTAvailable.TabIndex = 11;
            this.BTAvailable.Text = "Available flowers table";
            this.BTAvailable.UseVisualStyleBackColor = false;
            this.BTAvailable.Click += new System.EventHandler(this.BTAvailable_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1390, 679);
            this.Controls.Add(this.BTAvailable);
            this.Controls.Add(this.BTFlowers);
            this.Controls.Add(this.BTSaPo);
            this.Controls.Add(this.BTStore);
            this.Controls.Add(this.BTType);
            this.Controls.Add(this.BTSize);
            this.Controls.Add(this.BTColor);
            this.Controls.Add(this.BTSupplier);
            this.Controls.Add(this.BTRoles);
            this.Controls.Add(this.BTUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTLogOutAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLogOutAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTUsers;
        private System.Windows.Forms.Button BTRoles;
        private System.Windows.Forms.Button BTSupplier;
        private System.Windows.Forms.Button BTColor;
        private System.Windows.Forms.Button BTSize;
        private System.Windows.Forms.Button BTType;
        private System.Windows.Forms.Button BTStore;
        private System.Windows.Forms.Button BTSaPo;
        private System.Windows.Forms.Button BTFlowers;
        private System.Windows.Forms.Button BTAvailable;
    }
}