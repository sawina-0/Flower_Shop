namespace Flower_Shop
{
    partial class Catalog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.BTLogOutUser = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.BTSortAscPrice = new System.Windows.Forms.Button();
            this.BTSortDescPrice = new System.Windows.Forms.Button();
            this.BTSortAscCount = new System.Windows.Forms.Button();
            this.BTSortDescCount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.CBFilterAddr = new System.Windows.Forms.ComboBox();
            this.CBFilterType = new System.Windows.Forms.ComboBox();
            this.CBFilterColor = new System.Windows.Forms.ComboBox();
            this.CBFilterSize = new System.Windows.Forms.ComboBox();
            this.CBFilterCountry = new System.Windows.Forms.ComboBox();
            this.BTRemoveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTLogOutUser
            // 
            this.BTLogOutUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTLogOutUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTLogOutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTLogOutUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTLogOutUser.Location = new System.Drawing.Point(970, 503);
            this.BTLogOutUser.Name = "BTLogOutUser";
            this.BTLogOutUser.Size = new System.Drawing.Size(75, 33);
            this.BTLogOutUser.TabIndex = 1;
            this.BTLogOutUser.Text = "log out";
            this.BTLogOutUser.UseVisualStyleBackColor = false;
            this.BTLogOutUser.Click += new System.EventHandler(this.BTLogOutUser_Click);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToAddRows = false;
            this.dataGridViewCat.AllowUserToDeleteRows = false;
            this.dataGridViewCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewCat.Location = new System.Drawing.Point(293, 171);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.ReadOnly = true;
            this.dataGridViewCat.Size = new System.Drawing.Size(752, 317);
            this.dataGridViewCat.TabIndex = 48;
            // 
            // BTSortAscPrice
            // 
            this.BTSortAscPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortAscPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortAscPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortAscPrice.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortAscPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortAscPrice.Location = new System.Drawing.Point(12, 171);
            this.BTSortAscPrice.Name = "BTSortAscPrice";
            this.BTSortAscPrice.Size = new System.Drawing.Size(129, 29);
            this.BTSortAscPrice.TabIndex = 54;
            this.BTSortAscPrice.Text = "Sort Asc Price";
            this.BTSortAscPrice.UseVisualStyleBackColor = false;
            this.BTSortAscPrice.Click += new System.EventHandler(this.BTSortAscPrice_Click);
            // 
            // BTSortDescPrice
            // 
            this.BTSortDescPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortDescPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortDescPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortDescPrice.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortDescPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortDescPrice.Location = new System.Drawing.Point(147, 171);
            this.BTSortDescPrice.Name = "BTSortDescPrice";
            this.BTSortDescPrice.Size = new System.Drawing.Size(140, 29);
            this.BTSortDescPrice.TabIndex = 55;
            this.BTSortDescPrice.Text = "Sort Desc Price";
            this.BTSortDescPrice.UseVisualStyleBackColor = false;
            this.BTSortDescPrice.Click += new System.EventHandler(this.BTSortDescPrice_Click);
            // 
            // BTSortAscCount
            // 
            this.BTSortAscCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortAscCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortAscCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortAscCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortAscCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortAscCount.Location = new System.Drawing.Point(12, 228);
            this.BTSortAscCount.Name = "BTSortAscCount";
            this.BTSortAscCount.Size = new System.Drawing.Size(129, 29);
            this.BTSortAscCount.TabIndex = 56;
            this.BTSortAscCount.Text = "Sort Asc Count";
            this.BTSortAscCount.UseVisualStyleBackColor = false;
            this.BTSortAscCount.Click += new System.EventHandler(this.BTSortAscCount_Click);
            // 
            // BTSortDescCount
            // 
            this.BTSortDescCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortDescCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortDescCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortDescCount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortDescCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortDescCount.Location = new System.Drawing.Point(147, 228);
            this.BTSortDescCount.Name = "BTSortDescCount";
            this.BTSortDescCount.Size = new System.Drawing.Size(140, 29);
            this.BTSortDescCount.TabIndex = 57;
            this.BTSortDescCount.Text = "Sort Desc Count";
            this.BTSortDescCount.UseVisualStyleBackColor = false;
            this.BTSortDescCount.Click += new System.EventHandler(this.BTSortDescCount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Flower_Shop.Properties.Resources.logo_sunrise;
            this.pictureBox1.Location = new System.Drawing.Point(45, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSearch.Location = new System.Drawing.Point(12, 12);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(238, 29);
            this.TBSearch.TabIndex = 59;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // CBFilterAddr
            // 
            this.CBFilterAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilterAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilterAddr.FormattingEnabled = true;
            this.CBFilterAddr.Location = new System.Drawing.Point(12, 58);
            this.CBFilterAddr.Name = "CBFilterAddr";
            this.CBFilterAddr.Size = new System.Drawing.Size(167, 28);
            this.CBFilterAddr.TabIndex = 60;
            this.CBFilterAddr.SelectedIndexChanged += new System.EventHandler(this.CBFilterAddr_SelectedIndexChanged);
            // 
            // CBFilterType
            // 
            this.CBFilterType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilterType.FormattingEnabled = true;
            this.CBFilterType.Location = new System.Drawing.Point(185, 58);
            this.CBFilterType.Name = "CBFilterType";
            this.CBFilterType.Size = new System.Drawing.Size(167, 28);
            this.CBFilterType.TabIndex = 61;
            this.CBFilterType.SelectedIndexChanged += new System.EventHandler(this.CBFilterType_SelectedIndexChanged);
            // 
            // CBFilterColor
            // 
            this.CBFilterColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilterColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilterColor.FormattingEnabled = true;
            this.CBFilterColor.Location = new System.Drawing.Point(358, 58);
            this.CBFilterColor.Name = "CBFilterColor";
            this.CBFilterColor.Size = new System.Drawing.Size(167, 28);
            this.CBFilterColor.TabIndex = 62;
            this.CBFilterColor.SelectedIndexChanged += new System.EventHandler(this.CBFilterColor_SelectedIndexChanged);
            // 
            // CBFilterSize
            // 
            this.CBFilterSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilterSize.FormattingEnabled = true;
            this.CBFilterSize.Location = new System.Drawing.Point(531, 58);
            this.CBFilterSize.Name = "CBFilterSize";
            this.CBFilterSize.Size = new System.Drawing.Size(167, 28);
            this.CBFilterSize.TabIndex = 63;
            this.CBFilterSize.SelectedIndexChanged += new System.EventHandler(this.CBFilterSize_SelectedIndexChanged);
            // 
            // CBFilterCountry
            // 
            this.CBFilterCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilterCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilterCountry.FormattingEnabled = true;
            this.CBFilterCountry.Location = new System.Drawing.Point(704, 58);
            this.CBFilterCountry.Name = "CBFilterCountry";
            this.CBFilterCountry.Size = new System.Drawing.Size(167, 28);
            this.CBFilterCountry.TabIndex = 64;
            this.CBFilterCountry.SelectedIndexChanged += new System.EventHandler(this.CBFilterCountry_SelectedIndexChanged);
            // 
            // BTRemoveSettings
            // 
            this.BTRemoveSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTRemoveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTRemoveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTRemoveSettings.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTRemoveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTRemoveSettings.Location = new System.Drawing.Point(887, 12);
            this.BTRemoveSettings.Name = "BTRemoveSettings";
            this.BTRemoveSettings.Size = new System.Drawing.Size(158, 40);
            this.BTRemoveSettings.TabIndex = 65;
            this.BTRemoveSettings.Text = "Remove settings";
            this.BTRemoveSettings.UseVisualStyleBackColor = false;
            this.BTRemoveSettings.Click += new System.EventHandler(this.BTRemoveSettings_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1057, 548);
            this.Controls.Add(this.BTRemoveSettings);
            this.Controls.Add(this.CBFilterCountry);
            this.Controls.Add(this.CBFilterSize);
            this.Controls.Add(this.CBFilterColor);
            this.Controls.Add(this.CBFilterType);
            this.Controls.Add(this.CBFilterAddr);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTSortDescCount);
            this.Controls.Add(this.BTSortAscCount);
            this.Controls.Add(this.BTSortDescPrice);
            this.Controls.Add(this.BTSortAscPrice);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.BTLogOutUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLogOutUser;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.Button BTSortAscPrice;
        private System.Windows.Forms.Button BTSortDescPrice;
        private System.Windows.Forms.Button BTSortAscCount;
        private System.Windows.Forms.Button BTSortDescCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.ComboBox CBFilterAddr;
        private System.Windows.Forms.ComboBox CBFilterType;
        private System.Windows.Forms.ComboBox CBFilterColor;
        private System.Windows.Forms.ComboBox CBFilterSize;
        private System.Windows.Forms.ComboBox CBFilterCountry;
        private System.Windows.Forms.Button BTRemoveSettings;
    }
}