namespace Flower_Shop
{
    partial class TabSysUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSysUs));
            this.BTToAdForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTToAdForm
            // 
            this.BTToAdForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTToAdForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTToAdForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTToAdForm.Location = new System.Drawing.Point(746, 639);
            this.BTToAdForm.Name = "BTToAdForm";
            this.BTToAdForm.Size = new System.Drawing.Size(202, 34);
            this.BTToAdForm.TabIndex = 2;
            this.BTToAdForm.Text = "Back to admin page";
            this.BTToAdForm.UseVisualStyleBackColor = false;
            this.BTToAdForm.Click += new System.EventHandler(this.BTToAdForm_Click);
            // 
            // TabSysUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(960, 685);
            this.Controls.Add(this.BTToAdForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabSysUs";
            this.Text = "TabSysUs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTToAdForm;
    }
}