namespace Flower_Shop
{
    partial class AddDataColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataColor));
            this.TBAddColor = new System.Windows.Forms.TextBox();
            this.BTSaveData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAddColor
            // 
            this.TBAddColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAddColor.Location = new System.Drawing.Point(242, 125);
            this.TBAddColor.Name = "TBAddColor";
            this.TBAddColor.Size = new System.Drawing.Size(165, 35);
            this.TBAddColor.TabIndex = 0;
            // 
            // BTSaveData
            // 
            this.BTSaveData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTSaveData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTSaveData.Location = new System.Drawing.Point(208, 185);
            this.BTSaveData.Name = "BTSaveData";
            this.BTSaveData.Size = new System.Drawing.Size(126, 40);
            this.BTSaveData.TabIndex = 4;
            this.BTSaveData.Text = "Save";
            this.BTSaveData.UseVisualStyleBackColor = false;
            this.BTSaveData.Click += new System.EventHandler(this.BTSaveData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(158, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color:";
            // 
            // AddDataColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(555, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTSaveData);
            this.Controls.Add(this.TBAddColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDataColor";
            this.Text = "AddDataColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAddColor;
        private System.Windows.Forms.Button BTSaveData;
        private System.Windows.Forms.Label label1;
    }
}