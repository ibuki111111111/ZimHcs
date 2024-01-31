
namespace ZimHcs
{
    partial class Login
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
            this.idTextLabel = new System.Windows.Forms.Label();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTextLabel
            // 
            this.idTextLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextLabel.Location = new System.Drawing.Point(195, 59);
            this.idTextLabel.Name = "idTextLabel";
            this.idTextLabel.Size = new System.Drawing.Size(400, 23);
            this.idTextLabel.TabIndex = 0;
            this.idTextLabel.Text = "ログインするユーザーIDを入力";
            this.idTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordTextLabel.Location = new System.Drawing.Point(195, 184);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(400, 23);
            this.passwordTextLabel.TabIndex = 1;
            this.passwordTextLabel.Text = "入力したユーザーのパスワードを入力";
            this.passwordTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(245, 119);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(300, 22);
            this.inputId.TabIndex = 2;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(245, 268);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(300, 22);
            this.inputPassword.TabIndex = 3;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(323, 388);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 50);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "ログイン";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createTableButton.Location = new System.Drawing.Point(12, 388);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(150, 50);
            this.createTableButton.TabIndex = 5;
            this.createTableButton.Text = "管理者テーブル作成";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insertButton.Location = new System.Drawing.Point(638, 388);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(150, 50);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "管理者追加";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.passwordTextLabel);
            this.Controls.Add(this.idTextLabel);
            this.Name = "Login";
            this.Text = "ログイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idTextLabel;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button insertButton;
    }
}