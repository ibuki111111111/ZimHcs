
namespace ZimHcs
{
    partial class AdminMainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.insertCustomerButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.deleteInfoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.dataIndicationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(9, 7);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(582, 51);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ジムHCS顧客管理データベース";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertCustomerButton
            // 
            this.insertCustomerButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insertCustomerButton.Location = new System.Drawing.Point(228, 85);
            this.insertCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertCustomerButton.Name = "insertCustomerButton";
            this.insertCustomerButton.Size = new System.Drawing.Size(128, 80);
            this.insertCustomerButton.TabIndex = 2;
            this.insertCustomerButton.Text = "会員登録";
            this.insertCustomerButton.UseVisualStyleBackColor = true;
            this.insertCustomerButton.Click += new System.EventHandler(this.InsertCustomerButtonClick);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchCustomerButton.Location = new System.Drawing.Point(434, 85);
            this.searchCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(128, 80);
            this.searchCustomerButton.TabIndex = 3;
            this.searchCustomerButton.Text = "会員検索";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButtonClick);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.updateInfoButton.Location = new System.Drawing.Point(228, 206);
            this.updateInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(128, 80);
            this.updateInfoButton.TabIndex = 4;
            this.updateInfoButton.Text = "会員情報修正";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.UpdateInfoButtonClick);
            // 
            // deleteInfoButton
            // 
            this.deleteInfoButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteInfoButton.Location = new System.Drawing.Point(38, 206);
            this.deleteInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteInfoButton.Name = "deleteInfoButton";
            this.deleteInfoButton.Size = new System.Drawing.Size(128, 80);
            this.deleteInfoButton.TabIndex = 6;
            this.deleteInfoButton.Text = "会員情報削除";
            this.deleteInfoButton.UseVisualStyleBackColor = true;
            this.deleteInfoButton.Click += new System.EventHandler(this.DeleteInfoButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Aquamarine;
            this.exitButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(434, 309);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 40);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "終了する";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // createTableButton
            // 
            this.createTableButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createTableButton.Location = new System.Drawing.Point(38, 85);
            this.createTableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(128, 80);
            this.createTableButton.TabIndex = 0;
            this.createTableButton.Text = "テーブル作成";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // dataIndicationButton
            // 
            this.dataIndicationButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataIndicationButton.Location = new System.Drawing.Point(434, 206);
            this.dataIndicationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataIndicationButton.Name = "dataIndicationButton";
            this.dataIndicationButton.Size = new System.Drawing.Size(128, 80);
            this.dataIndicationButton.TabIndex = 8;
            this.dataIndicationButton.Text = "全データ一覧表示";
            this.dataIndicationButton.UseVisualStyleBackColor = true;
            this.dataIndicationButton.Click += new System.EventHandler(this.DataIndicationButtonClick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Aquamarine;
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(38, 310);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 40);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "ログイン画面へ戻る";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataIndicationButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteInfoButton);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.insertCustomerButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createTableButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMainMenu";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button insertCustomerButton;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button deleteInfoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button dataIndicationButton;
        private System.Windows.Forms.Button backButton;
    }
}

