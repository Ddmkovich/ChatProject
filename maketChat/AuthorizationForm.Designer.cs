
namespace maketChat
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.button1 = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRegistr = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.button1.Location = new System.Drawing.Point(57, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.tbLogin.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.tbLogin.Location = new System.Drawing.Point(57, 141);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(237, 36);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            // 
            // tbPassw
            // 
            this.tbPassw.BackColor = System.Drawing.Color.PowderBlue;
            this.tbPassw.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.tbPassw.Location = new System.Drawing.Point(57, 197);
            this.tbPassw.Name = "tbPassw";
            this.tbPassw.Size = new System.Drawing.Size(237, 36);
            this.tbPassw.TabIndex = 3;
            this.tbPassw.Enter += new System.EventHandler(this.tbPassw_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 10.75F);
            this.label2.Location = new System.Drawing.Point(115, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "First time? Reg then!";
            // 
            // btRegistr
            // 
            this.btRegistr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btRegistr.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btRegistr.FlatAppearance.BorderSize = 0;
            this.btRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistr.Font = new System.Drawing.Font("Noto Sans Cond", 10.75F);
            this.btRegistr.Location = new System.Drawing.Point(87, 330);
            this.btRegistr.Name = "btRegistr";
            this.btRegistr.Size = new System.Drawing.Size(179, 30);
            this.btRegistr.TabIndex = 5;
            this.btRegistr.Text = "Sign up";
            this.btRegistr.UseVisualStyleBackColor = false;
            this.btRegistr.Click += new System.EventHandler(this.btRegistr_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::maketChat.Properties.Resources.chatMain2;
            this.pictureBox3.Location = new System.Drawing.Point(57, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::maketChat.Properties.Resources.logChel;
            this.pictureBox2.Location = new System.Drawing.Point(12, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::maketChat.Properties.Resources.keyPassw;
            this.pictureBox1.Location = new System.Drawing.Point(12, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(335, 382);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRegistr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassw);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.authorizationForm_FormClosed);
            this.Load += new System.EventHandler(this.authorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btRegistr;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

