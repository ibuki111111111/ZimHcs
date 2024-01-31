
namespace ZimHcs
{
    partial class UpdateInfo
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.updateIdLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.inputId = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPhonenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDob = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.RadioButton();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.specialButton = new System.Windows.Forms.RadioButton();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(323, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "顧客情報更新";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateIdLabel
            // 
            this.updateIdLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.updateIdLabel.Location = new System.Drawing.Point(158, 59);
            this.updateIdLabel.Name = "updateIdLabel";
            this.updateIdLabel.Size = new System.Drawing.Size(500, 50);
            this.updateIdLabel.TabIndex = 1;
            this.updateIdLabel.Text = "登録内容を更新したい顧客のIDを入力";
            this.updateIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.updateButton.Location = new System.Drawing.Point(327, 388);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 50);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "データ更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(327, 121);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(150, 22);
            this.inputId.TabIndex = 3;
            // 
            // dataLabel
            // 
            this.dataLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataLabel.Location = new System.Drawing.Point(158, 146);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(500, 50);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "更新したいデータを入力する";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(26, 212);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "氏名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(16, 238);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(120, 22);
            this.inputName.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addressLabel.Location = new System.Drawing.Point(259, 212);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(100, 23);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "住所";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(154, 238);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(300, 22);
            this.inputAddress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(494, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "電話番号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPhonenumber
            // 
            this.inputPhonenumber.Location = new System.Drawing.Point(471, 238);
            this.inputPhonenumber.Name = "inputPhonenumber";
            this.inputPhonenumber.Size = new System.Drawing.Size(160, 22);
            this.inputPhonenumber.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(666, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "生年月日";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDob
            // 
            this.inputDob.Location = new System.Drawing.Point(649, 237);
            this.inputDob.Name = "inputDob";
            this.inputDob.Size = new System.Drawing.Size(130, 22);
            this.inputDob.TabIndex = 12;
            // 
            // courseLabel
            // 
            this.courseLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.courseLabel.Location = new System.Drawing.Point(36, 291);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(120, 23);
            this.courseLabel.TabIndex = 13;
            this.courseLabel.Text = "利用コース";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testButton
            // 
            this.testButton.AutoSize = true;
            this.testButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.testButton.Location = new System.Drawing.Point(162, 290);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(150, 24);
            this.testButton.TabIndex = 14;
            this.testButton.TabStop = true;
            this.testButton.Text = "お試しコース";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.normalButton.Location = new System.Drawing.Point(327, 290);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(170, 24);
            this.normalButton.TabIndex = 15;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "ノーマルコース";
            this.normalButton.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            this.specialButton.AutoSize = true;
            this.specialButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.specialButton.Location = new System.Drawing.Point(522, 290);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(190, 24);
            this.specialButton.TabIndex = 16;
            this.specialButton.TabStop = true;
            this.specialButton.Text = "スペシャルコース";
            this.specialButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordLabel.Location = new System.Drawing.Point(36, 337);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 23);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "パスワード";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(162, 339);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(550, 22);
            this.inputPassword.TabIndex = 18;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(688, 389);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 50);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.inputDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPhonenumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateIdLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "UpdateInfo";
            this.Text = "個人情報更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label updateIdLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPhonenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDob;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.RadioButton testButton;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton specialButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button backButton;
    }
}