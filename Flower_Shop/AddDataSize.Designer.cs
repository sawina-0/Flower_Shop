namespace Flower_Shop
{
    partial class AddDataSize
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTSaveData = new System.Windows.Forms.Button();
            this.TBAddSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(187, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size:";
            // 
            // BTSaveData
            // 
            this.BTSaveData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSaveData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSaveData.Location = new System.Drawing.Point(239, 194);
            this.BTSaveData.Name = "BTSaveData";
            this.BTSaveData.Size = new System.Drawing.Size(126, 40);
            this.BTSaveData.TabIndex = 7;
            this.BTSaveData.Text = "Save";
            this.BTSaveData.UseVisualStyleBackColor = false;
            this.BTSaveData.Click += new System.EventHandler(this.BTSaveData_Click);
            // 
            // TBAddSize
            // 
            this.TBAddSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBAddSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAddSize.Location = new System.Drawing.Point(271, 133);
            this.TBAddSize.Name = "TBAddSize";
            this.TBAddSize.Size = new System.Drawing.Size(165, 35);
            this.TBAddSize.TabIndex = 6;
            // 
            // AddDataSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTSaveData);
            this.Controls.Add(this.TBAddSize);
            this.Name = "AddDataSize";
            this.Text = "AddDataSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTSaveData;
        private System.Windows.Forms.TextBox TBAddSize;
    }
}