namespace Flower_Shop
{
    partial class WelcomeWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWin));
            this.label1 = new System.Windows.Forms.Label();
            this.TBLog = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTCreateAcc = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flower shop \"Sunrise\" ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBLog
            // 
            this.TBLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.TBLog.Location = new System.Drawing.Point(377, 207);
            this.TBLog.Name = "TBLog";
            this.TBLog.Size = new System.Drawing.Size(200, 29);
            this.TBLog.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.TBPassword.Location = new System.Drawing.Point(377, 242);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(200, 29);
            this.TBPassword.TabIndex = 2;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // BTEnter
            // 
            this.BTEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEnter.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTEnter.Location = new System.Drawing.Point(420, 297);
            this.BTEnter.Name = "BTEnter";
            this.BTEnter.Size = new System.Drawing.Size(120, 46);
            this.BTEnter.TabIndex = 3;
            this.BTEnter.Text = "Enter";
            this.BTEnter.UseVisualStyleBackColor = false;
            this.BTEnter.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(314, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(279, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // BTCreateAcc
            // 
            this.BTCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.BTCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCreateAcc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(64)))));
            this.BTCreateAcc.Location = new System.Drawing.Point(377, 421);
            this.BTCreateAcc.Name = "BTCreateAcc";
            this.BTCreateAcc.Size = new System.Drawing.Size(200, 37);
            this.BTCreateAcc.TabIndex = 6;
            this.BTCreateAcc.Text = "Create an account";
            this.BTCreateAcc.UseVisualStyleBackColor = false;
            this.BTCreateAcc.Click += new System.EventHandler(this.BTCreateAcc_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(221)))), ((int)(((byte)(127)))));
            this.logo.Image = global::Flower_Shop.Properties.Resources.logo_sunrise;
            this.logo.Location = new System.Drawing.Point(46, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(63, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // WelcomeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(935, 535);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.BTCreateAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTEnter);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLog);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeWin";
            this.Text = "WelcomeWin";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLog;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTCreateAcc;
        private System.Windows.Forms.PictureBox logo;
    }
}

