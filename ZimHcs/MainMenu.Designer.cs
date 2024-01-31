
namespace ZimHcs
{
    partial class MainMenu
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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(776, 64);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ジムHCS顧客管理データベース";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertCustomerButton
            // 
            this.insertCustomerButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insertCustomerButton.Location = new System.Drawing.Point(323, 127);
            this.insertCustomerButton.Name = "insertCustomerButton";
            this.insertCustomerButton.Size = new System.Drawing.Size(150, 100);
            this.insertCustomerButton.TabIndex = 2;
            this.insertCustomerButton.Text = "会員登録";
            this.insertCustomerButton.UseVisualStyleBackColor = true;
            this.insertCustomerButton.Click += new System.EventHandler(this.insertCustomerButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchCustomerButton.Location = new System.Drawing.Point(599, 127);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(150, 100);
            this.searchCustomerButton.TabIndex = 3;
            this.searchCustomerButton.Text = "会員検索";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.updateInfoButton.Location = new System.Drawing.Point(461, 280);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(150, 100);
            this.updateInfoButton.TabIndex = 4;
            this.updateInfoButton.Text = "会員情報修正";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            // 
            // deleteInfoButton
            // 
            this.deleteInfoButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteInfoButton.Location = new System.Drawing.Point(183, 280);
            this.deleteInfoButton.Name = "deleteInfoButton";
            this.deleteInfoButton.Size = new System.Drawing.Size(150, 100);
            this.deleteInfoButton.TabIndex = 6;
            this.deleteInfoButton.Text = "会員情報削除";
            this.deleteInfoButton.UseVisualStyleBackColor = true;
            this.deleteInfoButton.Click += new System.EventHandler(this.deleteInfoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Aquamarine;
            this.exitButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(668, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "終了する";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createTableButton.Location = new System.Drawing.Point(51, 127);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(150, 100);
            this.createTableButton.TabIndex = 0;
            this.createTableButton.Text = "テーブル作成";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteInfoButton);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.insertCustomerButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createTableButton);
            this.Name = "MainMenu";
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
    }
}

