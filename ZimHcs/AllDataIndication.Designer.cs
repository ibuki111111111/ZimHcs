
namespace ZimHcs
{
    partial class AllDataIndication
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
            this.indicationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGraph = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // indicationButton
            // 
            this.indicationButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.indicationButton.Location = new System.Drawing.Point(338, 356);
            this.indicationButton.Name = "indicationButton";
            this.indicationButton.Size = new System.Drawing.Size(150, 50);
            this.indicationButton.TabIndex = 0;
            this.indicationButton.Text = "データを表示";
            this.indicationButton.UseVisualStyleBackColor = true;
            this.indicationButton.Click += new System.EventHandler(this.IndicationButtonClick);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(688, 388);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 50);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // dataGraph
            // 
            this.dataGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGraph.Location = new System.Drawing.Point(157, 77);
            this.dataGraph.Name = "dataGraph";
            this.dataGraph.RowHeadersWidth = 51;
            this.dataGraph.RowTemplate.Height = 24;
            this.dataGraph.Size = new System.Drawing.Size(500, 250);
            this.dataGraph.TabIndex = 2;
            // 
            // AllDataIndication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGraph);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.indicationButton);
            this.Name = "AllDataIndication";
            this.Text = "データ一覧";
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indicationButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGraph;
    }
}