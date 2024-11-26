namespace Flower_Shop
{
    partial class TabSalePoints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSalePoints));
            this.BTToAdForm = new System.Windows.Forms.Button();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.BTSortDesc = new System.Windows.Forms.Button();
            this.BTSortAsc = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBSHName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSPAddr = new System.Windows.Forms.TextBox();
            this.TBIDSP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTSaveData = new System.Windows.Forms.Button();
            this.BTModify = new System.Windows.Forms.Button();
            this.BTDeleteData = new System.Windows.Forms.Button();
            this.BTAddData = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            this.SuspendLayout();
            // 
            // BTToAdForm
            // 
            this.BTToAdForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTToAdForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTToAdForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTToAdForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTToAdForm.Location = new System.Drawing.Point(813, 608);
            this.BTToAdForm.Name = "BTToAdForm";
            this.BTToAdForm.Size = new System.Drawing.Size(202, 34);
            this.BTToAdForm.TabIndex = 2;
            this.BTToAdForm.Text = "Back to admin page";
            this.BTToAdForm.UseVisualStyleBackColor = false;
            this.BTToAdForm.Click += new System.EventHandler(this.BTToAdForm_Click);
            // 
            // CBFilter
            // 
            this.CBFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Location = new System.Drawing.Point(111, 32);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(167, 28);
            this.CBFilter.TabIndex = 37;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // BTSortDesc
            // 
            this.BTSortDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortDesc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortDesc.Location = new System.Drawing.Point(301, 32);
            this.BTSortDesc.Name = "BTSortDesc";
            this.BTSortDesc.Size = new System.Drawing.Size(97, 29);
            this.BTSortDesc.TabIndex = 36;
            this.BTSortDesc.Text = "Sort Desc";
            this.BTSortDesc.UseVisualStyleBackColor = false;
            this.BTSortDesc.Click += new System.EventHandler(this.BTSortDesc_Click);
            // 
            // BTSortAsc
            // 
            this.BTSortAsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortAsc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortAsc.Location = new System.Drawing.Point(422, 32);
            this.BTSortAsc.Name = "BTSortAsc";
            this.BTSortAsc.Size = new System.Drawing.Size(97, 29);
            this.BTSortAsc.TabIndex = 35;
            this.BTSortAsc.Text = "Sort Asc";
            this.BTSortAsc.UseVisualStyleBackColor = false;
            this.BTSortAsc.Click += new System.EventHandler(this.BTSortAsc_Click);
            // 
            // BTClear
            // 
            this.BTClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTClear.Location = new System.Drawing.Point(542, 32);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(75, 29);
            this.BTClear.TabIndex = 34;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = false;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTUpdate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTUpdate.Location = new System.Drawing.Point(636, 32);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(80, 29);
            this.BTUpdate.TabIndex = 33;
            this.BTUpdate.Text = "Update";
            this.BTUpdate.UseVisualStyleBackColor = false;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.TBSHName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBSPAddr);
            this.groupBox2.Controls.Add(this.TBIDSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(41, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 226);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data ";
            // 
            // TBSHName
            // 
            this.TBSHName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSHName.Location = new System.Drawing.Point(350, 178);
            this.TBSHName.Name = "TBSHName";
            this.TBSHName.Size = new System.Drawing.Size(238, 29);
            this.TBSHName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Storehouse name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sale point address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // TBSPAddr
            // 
            this.TBSPAddr.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSPAddr.Location = new System.Drawing.Point(350, 105);
            this.TBSPAddr.Name = "TBSPAddr";
            this.TBSPAddr.Size = new System.Drawing.Size(238, 29);
            this.TBSPAddr.TabIndex = 6;
            // 
            // TBIDSP
            // 
            this.TBIDSP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBIDSP.Location = new System.Drawing.Point(350, 34);
            this.TBIDSP.Name = "TBIDSP";
            this.TBIDSP.Size = new System.Drawing.Size(238, 29);
            this.TBIDSP.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.BTSaveData);
            this.groupBox1.Controls.Add(this.BTModify);
            this.groupBox1.Controls.Add(this.BTDeleteData);
            this.groupBox1.Controls.Add(this.BTAddData);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(748, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 282);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data managment";
            // 
            // BTSaveData
            // 
            this.BTSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSaveData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSaveData.Location = new System.Drawing.Point(52, 211);
            this.BTSaveData.Name = "BTSaveData";
            this.BTSaveData.Size = new System.Drawing.Size(126, 40);
            this.BTSaveData.TabIndex = 3;
            this.BTSaveData.Text = "Save";
            this.BTSaveData.UseVisualStyleBackColor = false;
            this.BTSaveData.Click += new System.EventHandler(this.BTSaveData_Click);
            // 
            // BTModify
            // 
            this.BTModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModify.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTModify.Location = new System.Drawing.Point(52, 154);
            this.BTModify.Name = "BTModify";
            this.BTModify.Size = new System.Drawing.Size(126, 40);
            this.BTModify.TabIndex = 2;
            this.BTModify.Text = "Modify";
            this.BTModify.UseVisualStyleBackColor = false;
            this.BTModify.Click += new System.EventHandler(this.BTModify_Click);
            // 
            // BTDeleteData
            // 
            this.BTDeleteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDeleteData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTDeleteData.Location = new System.Drawing.Point(52, 95);
            this.BTDeleteData.Name = "BTDeleteData";
            this.BTDeleteData.Size = new System.Drawing.Size(126, 40);
            this.BTDeleteData.TabIndex = 1;
            this.BTDeleteData.Text = "Delete";
            this.BTDeleteData.UseVisualStyleBackColor = false;
            this.BTDeleteData.Click += new System.EventHandler(this.BTDeleteData_Click);
            // 
            // BTAddData
            // 
            this.BTAddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAddData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTAddData.Location = new System.Drawing.Point(52, 38);
            this.BTAddData.Name = "BTAddData";
            this.BTAddData.Size = new System.Drawing.Size(126, 39);
            this.BTAddData.TabIndex = 0;
            this.BTAddData.Text = "New data";
            this.BTAddData.UseVisualStyleBackColor = false;
            this.BTAddData.Click += new System.EventHandler(this.BTAddData_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSearch.Location = new System.Drawing.Point(748, 32);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(238, 29);
            this.TBSearch.TabIndex = 30;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.AllowUserToAddRows = false;
            this.dataGridViewShop.AllowUserToDeleteRows = false;
            this.dataGridViewShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewShop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewShop.Location = new System.Drawing.Point(41, 93);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.ReadOnly = true;
            this.dataGridViewShop.Size = new System.Drawing.Size(675, 282);
            this.dataGridViewShop.TabIndex = 29;
            this.dataGridViewShop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShop_CellClick);
            // 
            // TabSalePoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1027, 654);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.BTSortDesc);
            this.Controls.Add(this.BTSortAsc);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.dataGridViewShop);
            this.Controls.Add(this.BTToAdForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabSalePoints";
            this.Text = "TabSalePoints";
            this.Load += new System.EventHandler(this.TabSalePoints_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTToAdForm;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.Button BTSortDesc;
        private System.Windows.Forms.Button BTSortAsc;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBSHName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSPAddr;
        private System.Windows.Forms.TextBox TBIDSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTSaveData;
        private System.Windows.Forms.Button BTModify;
        private System.Windows.Forms.Button BTDeleteData;
        private System.Windows.Forms.Button BTAddData;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.DataGridView dataGridViewShop;
    }
}