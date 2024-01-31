using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs DeleteInfo.cs
/// 
/// 作成日　2023/12/15
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class DeleteInfo : Form
    {
        public DeleteInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ---------------------------------------------------------------------------------------------
        /// レコードの削除
        /// ---------------------------------------------------------------------------------------------
        /// </summary>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("本当に削除しても大丈夫ですか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //Yesが選択された場合
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "DELETE FROM hcs_customer WHERE customer_id = @customer_id;";
                        //パラメータセット
                        cmd.Parameters.Add("customer_id", System.Data.DbType.Int64);
                        //データ削除
                        cmd.Parameters["customer_id"].Value = int.Parse(searchButton.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();

                    }
                }
            }
        }

        /// <summary>
        /// AdminMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //AdminMainMenuを表示
            AdminMainMenu main = new AdminMainMenu();
            main.Visible = true;

            //画面を閉じる
            this.Close();
        }
    }
}
