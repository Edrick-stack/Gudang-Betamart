
namespace Kasir_Betamart
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(467, 238);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(231, 90);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Location = new System.Drawing.Point(466, 57);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(306, 39);
            this.txtbx_Username.TabIndex = 1;
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Location = new System.Drawing.Point(466, 142);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.PasswordChar = '*';
            this.txtbx_Password.Size = new System.Drawing.Size(306, 39);
            this.txtbx_Password.TabIndex = 2;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(328, 57);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(121, 32);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(328, 145);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(111, 32);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kasir_Betamart.Properties.Resources.lock_private_key_19662;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.btn_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "LOGIN ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}