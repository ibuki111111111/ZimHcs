
namespace ZimHcs
{
    partial class InsertAdmin
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
            this.nameText = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.Label();
            this.adminPass = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.adminView = new System.Windows.Forms.DataGridView();
            this.indicationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameText.Location = new System.Drawing.Point(12, 28);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(300, 50);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "追加する管理者の氏名";
            this.nameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminName
            // 
            this.adminName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adminName.Location = new System.Drawing.Point(16, 103);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(300, 27);
            this.adminName.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordText.Location = new System.Drawing.Point(12, 151);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(300, 50);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "設定したいパスワード";
            this.passwordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminPass
            // 
            this.adminPass.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adminPass.Location = new System.Drawing.Point(16, 224);
            this.adminPass.Name = "adminPass";
            this.adminPass.Size = new System.Drawing.Size(300, 27);
            this.adminPass.TabIndex = 3;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.insertButton.Location = new System.Drawing.Point(87, 300);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(150, 50);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "追加";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButtonClick);
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
            // adminView
            // 
            this.adminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminView.Location = new System.Drawing.Point(408, 51);
            this.adminView.Name = "adminView";
            this.adminView.RowHeadersWidth = 51;
            this.adminView.RowTemplate.Height = 24;
            this.adminView.Size = new System.Drawing.Size(300, 200);
            this.adminView.TabIndex = 6;
            // 
            // indicationButton
            // 
            this.indicationButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.indicationButton.Location = new System.Drawing.Point(488, 300);
            this.indicationButton.Name = "indicationButton";
            this.indicationButton.Size = new System.Drawing.Size(150, 50);
            this.indicationButton.TabIndex = 7;
            this.indicationButton.Text = "一覧を表示";
            this.indicationButton.UseVisualStyleBackColor = true;
            this.indicationButton.Click += new System.EventHandler(this.IndicationButtonClick);
            // 
            // InsertAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indicationButton);
            this.Controls.Add(this.adminView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.adminPass);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.nameText);
            this.Name = "InsertAdmin";
            this.Text = "管理者追加";
            ((System.ComponentModel.ISupportInitialize)(this.adminView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView adminView;
        private System.Windows.Forms.Button indicationButton;
    }
}