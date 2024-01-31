
namespace ZimHcs
{
    partial class SearchInfo
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
            this.searchTitle = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameIndication = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressIndication = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneIndication = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobIndication = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseIndication = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateIndication = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordIndication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchTitle
            // 
            this.searchTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchTitle.Location = new System.Drawing.Point(314, 9);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(150, 50);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "会員検索";
            this.searchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchId
            // 
            this.searchId.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchId.Location = new System.Drawing.Point(183, 74);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(400, 23);
            this.searchId.TabIndex = 1;
            this.searchId.Text = "検索したい会員番号を入力";
            this.searchId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(277, 128);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 22);
            this.searchText.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchButton.Location = new System.Drawing.Point(305, 388);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 50);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(688, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 50);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(12, 182);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(150, 23);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "氏名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameIndication
            // 
            this.nameIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameIndication.Location = new System.Drawing.Point(12, 205);
            this.nameIndication.Name = "nameIndication";
            this.nameIndication.Size = new System.Drawing.Size(150, 30);
            this.nameIndication.TabIndex = 7;
            this.nameIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addressLabel.Location = new System.Drawing.Point(168, 182);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(250, 23);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "住所";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressIndication
            // 
            this.addressIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addressIndication.Location = new System.Drawing.Point(168, 205);
            this.addressIndication.Name = "addressIndication";
            this.addressIndication.Size = new System.Drawing.Size(250, 30);
            this.addressIndication.TabIndex = 9;
            this.addressIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phoneLabel.Location = new System.Drawing.Point(424, 182);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(170, 23);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "電話番号";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneIndication
            // 
            this.phoneIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phoneIndication.Location = new System.Drawing.Point(424, 205);
            this.phoneIndication.Name = "phoneIndication";
            this.phoneIndication.Size = new System.Drawing.Size(170, 30);
            this.phoneIndication.TabIndex = 11;
            this.phoneIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobLabel
            // 
            this.dobLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dobLabel.Location = new System.Drawing.Point(600, 182);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(170, 23);
            this.dobLabel.TabIndex = 12;
            this.dobLabel.Text = "生年月日";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dobIndication
            // 
            this.dobIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dobIndication.Location = new System.Drawing.Point(600, 205);
            this.dobIndication.Name = "dobIndication";
            this.dobIndication.Size = new System.Drawing.Size(170, 30);
            this.dobIndication.TabIndex = 13;
            this.dobIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseLabel
            // 
            this.courseLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.courseLabel.Location = new System.Drawing.Point(82, 276);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(200, 23);
            this.courseLabel.TabIndex = 14;
            this.courseLabel.Text = "コース";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseIndication
            // 
            this.courseIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.courseIndication.Location = new System.Drawing.Point(82, 299);
            this.courseIndication.Name = "courseIndication";
            this.courseIndication.Size = new System.Drawing.Size(200, 30);
            this.courseIndication.TabIndex = 15;
            this.courseIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateLabel.Location = new System.Drawing.Point(314, 276);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 23);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "利用開始日";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateIndication
            // 
            this.dateIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateIndication.Location = new System.Drawing.Point(314, 299);
            this.dateIndication.Name = "dateIndication";
            this.dateIndication.Size = new System.Drawing.Size(150, 30);
            this.dateIndication.TabIndex = 17;
            this.dateIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordLabel.Location = new System.Drawing.Point(506, 276);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(170, 23);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "パスワード";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordIndication
            // 
            this.passwordIndication.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordIndication.Location = new System.Drawing.Point(506, 299);
            this.passwordIndication.Name = "passwordIndication";
            this.passwordIndication.Size = new System.Drawing.Size(170, 30);
            this.passwordIndication.TabIndex = 19;
            this.passwordIndication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordIndication);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.dateIndication);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.courseIndication);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.dobIndication);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.phoneIndication);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressIndication);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameIndication);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.searchTitle);
            this.Name = "SearchInfo";
            this.Text = "会員検索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Label searchId;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameIndication;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label addressIndication;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label phoneIndication;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label dobIndication;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label courseIndication;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateIndication;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordIndication;
    }
}