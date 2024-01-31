
namespace ZimHcs
{
    partial class CustomerMainMenu
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
            this.userInfoButton = new System.Windows.Forms.Button();
            this.calorieButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInfoButton
            // 
            this.userInfoButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userInfoButton.Location = new System.Drawing.Point(79, 119);
            this.userInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(150, 80);
            this.userInfoButton.TabIndex = 0;
            this.userInfoButton.Text = "ユーザー情報表示";
            this.userInfoButton.UseVisualStyleBackColor = true;
            this.userInfoButton.Click += new System.EventHandler(this.UserInfoButtonClick);
            // 
            // calorieButton
            // 
            this.calorieButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calorieButton.Location = new System.Drawing.Point(340, 119);
            this.calorieButton.Name = "calorieButton";
            this.calorieButton.Size = new System.Drawing.Size(150, 80);
            this.calorieButton.TabIndex = 1;
            this.calorieButton.Text = "消費カロリー計算";
            this.calorieButton.UseVisualStyleBackColor = true;
            this.calorieButton.Click += new System.EventHandler(this.CalorieButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Aquamarine;
            this.exitButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(464, 310);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 40);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "終了する";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Aquamarine;
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(301, 310);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 40);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "ログイン画面へ戻る";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calorieButton);
            this.Controls.Add(this.userInfoButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerMainMenu";
            this.Text = "CustomerMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userInfoButton;
        private System.Windows.Forms.Button calorieButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
    }
}