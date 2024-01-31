
namespace ZimHcs
{
    partial class CourseDateInsert
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
            this.testerButton = new System.Windows.Forms.RadioButton();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.specialButton = new System.Windows.Forms.RadioButton();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(173, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(447, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "利用コース・利用開始日入力画面";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testerButton
            // 
            this.testerButton.AutoSize = true;
            this.testerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testerButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.testerButton.Location = new System.Drawing.Point(43, 122);
            this.testerButton.Name = "testerButton";
            this.testerButton.Size = new System.Drawing.Size(156, 24);
            this.testerButton.TabIndex = 2;
            this.testerButton.TabStop = true;
            this.testerButton.Text = "お試しコース";
            this.testerButton.UseVisualStyleBackColor = true;
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.normalButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.normalButton.Location = new System.Drawing.Point(295, 122);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(177, 24);
            this.normalButton.TabIndex = 3;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "ノーマルコース";
            this.normalButton.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            this.specialButton.AutoSize = true;
            this.specialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.specialButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.specialButton.Location = new System.Drawing.Point(560, 122);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(198, 24);
            this.specialButton.TabIndex = 4;
            this.specialButton.TabStop = true;
            this.specialButton.Text = "スペシャルコース";
            this.specialButton.UseVisualStyleBackColor = true;
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(313, 241);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(159, 22);
            this.datePick.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(301, 338);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(200, 75);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "パスワード設定画面へ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // CourseDateInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.testerButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "CourseDateInsert";
            this.Text = "コース・利用開始日選択";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton testerButton;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton specialButton;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Button nextButton;
    }
}