
namespace ZimHcs
{
    partial class Training
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
            this.trainingMenu = new System.Windows.Forms.ComboBox();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.trainingTimes = new System.Windows.Forms.ComboBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.calorieText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainingMenu
            // 
            this.trainingMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingMenu.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trainingMenu.FormattingEnabled = true;
            this.trainingMenu.Items.AddRange(new object[] {
            "レッグプレス",
            "クランチ",
            "ベンチプレス",
            "ダンベルカール",
            "ダンベルデッドリフト",
            "ショルダープレス"});
            this.trainingMenu.Location = new System.Drawing.Point(192, 221);
            this.trainingMenu.Margin = new System.Windows.Forms.Padding(4);
            this.trainingMenu.Name = "trainingMenu";
            this.trainingMenu.Size = new System.Drawing.Size(250, 28);
            this.trainingMenu.TabIndex = 0;
            // 
            // trainingLabel
            // 
            this.trainingLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trainingLabel.Location = new System.Drawing.Point(188, 178);
            this.trainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(250, 20);
            this.trainingLabel.TabIndex = 1;
            this.trainingLabel.Text = "挑戦するトレーニング";
            this.trainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playLabel
            // 
            this.playLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playLabel.Location = new System.Drawing.Point(647, 178);
            this.playLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(250, 20);
            this.playLabel.TabIndex = 2;
            this.playLabel.Text = "セット数";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainingTimes
            // 
            this.trainingTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingTimes.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trainingTimes.FormattingEnabled = true;
            this.trainingTimes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.trainingTimes.Location = new System.Drawing.Point(651, 221);
            this.trainingTimes.Margin = new System.Windows.Forms.Padding(4);
            this.trainingTimes.Name = "trainingTimes";
            this.trainingTimes.Size = new System.Drawing.Size(250, 28);
            this.trainingTimes.TabIndex = 3;
            // 
            // calorieLabel
            // 
            this.calorieLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calorieLabel.Location = new System.Drawing.Point(465, 366);
            this.calorieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(139, 20);
            this.calorieLabel.TabIndex = 4;
            this.calorieLabel.Text = "0";
            this.calorieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calorieText
            // 
            this.calorieText.AutoSize = true;
            this.calorieText.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calorieText.Location = new System.Drawing.Point(465, 334);
            this.calorieText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calorieText.Name = "calorieText";
            this.calorieText.Size = new System.Drawing.Size(129, 20);
            this.calorieText.TabIndex = 5;
            this.calorieText.Text = "消費カロリー";
            this.calorieText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(471, 426);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 62);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "計算";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(917, 485);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(133, 62);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.calorieText);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.trainingTimes);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.trainingLabel);
            this.Controls.Add(this.trainingMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Training";
            this.Text = "Training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainingMenu;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.ComboBox trainingTimes;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.Label calorieText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button backButton;
    }
}