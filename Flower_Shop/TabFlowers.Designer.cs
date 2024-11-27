namespace Flower_Shop
{
    partial class TabFlowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabFlowers));
            this.BTToAdForm = new System.Windows.Forms.Button();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.BTSortDesc = new System.Windows.Forms.Button();
            this.BTSortAsc = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBCountry = new System.Windows.Forms.TextBox();
            this.TBSize = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBIDFl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTSaveData = new System.Windows.Forms.Button();
            this.BTModify = new System.Windows.Forms.Button();
            this.BTDeleteData = new System.Windows.Forms.Button();
            this.BTAddData = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewFl = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFl)).BeginInit();
            this.SuspendLayout();
            // 
            // BTToAdForm
            // 
            this.BTToAdForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTToAdForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTToAdForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTToAdForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTToAdForm.Location = new System.Drawing.Point(774, 641);
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
            this.CBFilter.Location = new System.Drawing.Point(92, 48);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(167, 28);
            this.CBFilter.TabIndex = 46;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // BTSortDesc
            // 
            this.BTSortDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortDesc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortDesc.Location = new System.Drawing.Point(282, 48);
            this.BTSortDesc.Name = "BTSortDesc";
            this.BTSortDesc.Size = new System.Drawing.Size(97, 29);
            this.BTSortDesc.TabIndex = 45;
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
            this.BTSortAsc.Location = new System.Drawing.Point(403, 48);
            this.BTSortAsc.Name = "BTSortAsc";
            this.BTSortAsc.Size = new System.Drawing.Size(97, 29);
            this.BTSortAsc.TabIndex = 44;
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
            this.BTClear.Location = new System.Drawing.Point(523, 48);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(75, 29);
            this.BTClear.TabIndex = 43;
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
            this.BTUpdate.Location = new System.Drawing.Point(617, 48);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(80, 29);
            this.BTUpdate.TabIndex = 42;
            this.BTUpdate.Text = "Update";
            this.BTUpdate.UseVisualStyleBackColor = false;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TBPrice);
            this.groupBox2.Controls.Add(this.TBCountry);
            this.groupBox2.Controls.Add(this.TBSize);
            this.groupBox2.Controls.Add(this.TBName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBColor);
            this.groupBox2.Controls.Add(this.TBIDFl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(22, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 278);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(138, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flower name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(191, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price:";
            // 
            // TBPrice
            // 
            this.TBPrice.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPrice.Location = new System.Drawing.Point(350, 248);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(238, 29);
            this.TBPrice.TabIndex = 15;
            // 
            // TBCountry
            // 
            this.TBCountry.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCountry.Location = new System.Drawing.Point(350, 202);
            this.TBCountry.Name = "TBCountry";
            this.TBCountry.Size = new System.Drawing.Size(238, 29);
            this.TBCountry.TabIndex = 14;
            // 
            // TBSize
            // 
            this.TBSize.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSize.Location = new System.Drawing.Point(350, 112);
            this.TBSize.Name = "TBSize";
            this.TBSize.Size = new System.Drawing.Size(238, 29);
            this.TBSize.TabIndex = 13;
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(350, 156);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(238, 29);
            this.TBName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(235, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // TBColor
            // 
            this.TBColor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBColor.Location = new System.Drawing.Point(350, 66);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(238, 29);
            this.TBColor.TabIndex = 6;
            // 
            // TBIDFl
            // 
            this.TBIDFl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBIDFl.Location = new System.Drawing.Point(350, 22);
            this.TBIDFl.Name = "TBIDFl";
            this.TBIDFl.Size = new System.Drawing.Size(238, 29);
            this.TBIDFl.TabIndex = 5;
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
            this.groupBox1.Location = new System.Drawing.Point(729, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 282);
            this.groupBox1.TabIndex = 40;
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
            this.TBSearch.Location = new System.Drawing.Point(729, 48);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(238, 29);
            this.TBSearch.TabIndex = 39;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // dataGridViewFl
            // 
            this.dataGridViewFl.AllowUserToAddRows = false;
            this.dataGridViewFl.AllowUserToDeleteRows = false;
            this.dataGridViewFl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewFl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewFl.Location = new System.Drawing.Point(22, 109);
            this.dataGridViewFl.Name = "dataGridViewFl";
            this.dataGridViewFl.ReadOnly = true;
            this.dataGridViewFl.Size = new System.Drawing.Size(675, 282);
            this.dataGridViewFl.TabIndex = 38;
            this.dataGridViewFl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFl_CellClick);
            // 
            // TabFlowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(988, 687);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.BTSortDesc);
            this.Controls.Add(this.BTSortAsc);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.dataGridViewFl);
            this.Controls.Add(this.BTToAdForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabFlowers";
            this.Text = "TabFlowers";
            this.Load += new System.EventHandler(this.TabFlowers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFl)).EndInit();
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
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBIDFl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTSaveData;
        private System.Windows.Forms.Button BTModify;
        private System.Windows.Forms.Button BTDeleteData;
        private System.Windows.Forms.Button BTAddData;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.DataGridView dataGridViewFl;
        private System.Windows.Forms.TextBox TBCountry;
        private System.Windows.Forms.TextBox TBSize;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}