
namespace ZimHcs
{
    partial class InsertInfo
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
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberLabel = new System.Windows.Forms.Label();
            this.phonenumberTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(668, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(12, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(776, 50);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "氏名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.Location = new System.Drawing.Point(16, 62);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(709, 40);
            this.nameTextBox.TabIndex = 2;
            // 
            // adressLabel
            // 
            this.adressLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adressLabel.Location = new System.Drawing.Point(12, 105);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(776, 50);
            this.adressLabel.TabIndex = 3;
            this.adressLabel.Text = "住所";
            this.adressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adressTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adressTextBox.Location = new System.Drawing.Point(16, 149);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(709, 40);
            this.adressTextBox.TabIndex = 4;
            // 
            // phonenumberLabel
            // 
            this.phonenumberLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phonenumberLabel.Location = new System.Drawing.Point(12, 192);
            this.phonenumberLabel.Name = "phonenumberLabel";
            this.phonenumberLabel.Size = new System.Drawing.Size(778, 50);
            this.phonenumberLabel.TabIndex = 5;
            this.phonenumberLabel.Text = "電話番号";
            this.phonenumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phonenumberTextBox
            // 
            this.phonenumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonenumberTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phonenumberTextBox.Location = new System.Drawing.Point(16, 233);
            this.phonenumberTextBox.Multiline = true;
            this.phonenumberTextBox.Name = "phonenumberTextBox";
            this.phonenumberTextBox.Size = new System.Drawing.Size(709, 40);
            this.phonenumberTextBox.TabIndex = 6;
            // 
            // dobLabel
            // 
            this.dobLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dobLabel.Location = new System.Drawing.Point(12, 276);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(778, 50);
            this.dobLabel.TabIndex = 7;
            this.dobLabel.Text = "生年月日";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dobTextBox.Location = new System.Drawing.Point(16, 320);
            this.dobTextBox.Multiline = true;
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(709, 40);
            this.dobTextBox.TabIndex = 8;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Aquamarine;
            this.nextButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(339, 388);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 50);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "確定";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(264, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(244, 28);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "個人情報入力画面";
            // 
            // InsertInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.phonenumberTextBox);
            this.Controls.Add(this.phonenumberLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Name = "InsertInfo";
            this.Text = "個人情報入力";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label phonenumberLabel;
        private System.Windows.Forms.TextBox phonenumberTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label titleLabel;
    }
}