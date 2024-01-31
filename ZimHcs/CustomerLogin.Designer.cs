
namespace ZimHcs
{
    partial class CustomerLogin
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
            this.nextButton = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.idTextLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(313, 365);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(180, 50);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "ログイン";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(245, 245);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(300, 22);
            this.inputPassword.TabIndex = 10;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(245, 96);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(300, 22);
            this.inputId.TabIndex = 9;
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordTextLabel.Location = new System.Drawing.Point(195, 161);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(400, 23);
            this.passwordTextLabel.TabIndex = 8;
            this.passwordTextLabel.Text = "入力したユーザーのパスワードを入力";
            this.passwordTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTextLabel
            // 
            this.idTextLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextLabel.Location = new System.Drawing.Point(195, 36);
            this.idTextLabel.Name = "idTextLabel";
            this.idTextLabel.Size = new System.Drawing.Size(400, 23);
            this.idTextLabel.TabIndex = 7;
            this.idTextLabel.Text = "ログインするユーザーIDを入力";
            this.idTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(608, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(180, 50);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.passwordTextLabel);
            this.Controls.Add(this.idTextLabel);
            this.Name = "CustomerLogin";
            this.Text = "customerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.Label idTextLabel;
        private System.Windows.Forms.Button backButton;
    }
}