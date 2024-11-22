﻿namespace Flower_Shop
{
    partial class TabColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabColor));
            this.BTToAdForm = new System.Windows.Forms.Button();
            this.dataGridViewColors = new System.Windows.Forms.DataGridView();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTSaveData = new System.Windows.Forms.Button();
            this.BTModify = new System.Windows.Forms.Button();
            this.BTDeleteData = new System.Windows.Forms.Button();
            this.BTAddData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBIDColor = new System.Windows.Forms.TextBox();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.BTSortAsc = new System.Windows.Forms.Button();
            this.BTSortDesc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTToAdForm
            // 
            this.BTToAdForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTToAdForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTToAdForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTToAdForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTToAdForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTToAdForm.Location = new System.Drawing.Point(771, 610);
            this.BTToAdForm.Name = "BTToAdForm";
            this.BTToAdForm.Size = new System.Drawing.Size(202, 34);
            this.BTToAdForm.TabIndex = 2;
            this.BTToAdForm.Text = "Back to admin page";
            this.BTToAdForm.UseVisualStyleBackColor = false;
            this.BTToAdForm.Click += new System.EventHandler(this.BTToAdForm_Click);
            // 
            // dataGridViewColors
            // 
            this.dataGridViewColors.AllowUserToAddRows = false;
            this.dataGridViewColors.AllowUserToDeleteRows = false;
            this.dataGridViewColors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.dataGridViewColors.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewColors.Name = "dataGridViewColors";
            this.dataGridViewColors.ReadOnly = true;
            this.dataGridViewColors.Size = new System.Drawing.Size(675, 282);
            this.dataGridViewColors.TabIndex = 3;
            this.dataGridViewColors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewColors_CellClick);
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSearch.Location = new System.Drawing.Point(719, 12);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(238, 29);
            this.TBSearch.TabIndex = 4;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(719, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 282);
            this.groupBox1.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBColor);
            this.groupBox2.Controls.Add(this.TBIDColor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 208);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(210, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // TBColor
            // 
            this.TBColor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBColor.Location = new System.Drawing.Point(350, 131);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(238, 29);
            this.TBColor.TabIndex = 6;
            // 
            // TBIDColor
            // 
            this.TBIDColor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBIDColor.Location = new System.Drawing.Point(350, 66);
            this.TBIDColor.Name = "TBIDColor";
            this.TBIDColor.Size = new System.Drawing.Size(238, 29);
            this.TBIDColor.TabIndex = 5;
            // 
            // BTUpdate
            // 
            this.BTUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTUpdate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTUpdate.Location = new System.Drawing.Point(607, 12);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(80, 29);
            this.BTUpdate.TabIndex = 7;
            this.BTUpdate.Text = "Update";
            this.BTUpdate.UseVisualStyleBackColor = false;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTClear
            // 
            this.BTClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTClear.Location = new System.Drawing.Point(513, 12);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(75, 29);
            this.BTClear.TabIndex = 8;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = false;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // BTSortAsc
            // 
            this.BTSortAsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortAsc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortAsc.Location = new System.Drawing.Point(393, 12);
            this.BTSortAsc.Name = "BTSortAsc";
            this.BTSortAsc.Size = new System.Drawing.Size(97, 29);
            this.BTSortAsc.TabIndex = 9;
            this.BTSortAsc.Text = "Sort Asc";
            this.BTSortAsc.UseVisualStyleBackColor = false;
            this.BTSortAsc.Click += new System.EventHandler(this.BTSortAsc_Click);
            // 
            // BTSortDesc
            // 
            this.BTSortDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSortDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSortDesc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSortDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSortDesc.Location = new System.Drawing.Point(272, 12);
            this.BTSortDesc.Name = "BTSortDesc";
            this.BTSortDesc.Size = new System.Drawing.Size(97, 29);
            this.BTSortDesc.TabIndex = 10;
            this.BTSortDesc.Text = "Sort Desc";
            this.BTSortDesc.UseVisualStyleBackColor = false;
            this.BTSortDesc.Click += new System.EventHandler(this.BTSortDesc_Click);
            // 
            // TabColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(985, 656);
            this.Controls.Add(this.BTSortDesc);
            this.Controls.Add(this.BTSortAsc);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.dataGridViewColors);
            this.Controls.Add(this.BTToAdForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabColor";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.TabColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTToAdForm;
        private System.Windows.Forms.DataGridView dataGridViewColors;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTAddData;
        private System.Windows.Forms.Button BTSaveData;
        private System.Windows.Forms.Button BTModify;
        private System.Windows.Forms.Button BTDeleteData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBIDColor;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.Button BTSortAsc;
        private System.Windows.Forms.Button BTSortDesc;
    }
}