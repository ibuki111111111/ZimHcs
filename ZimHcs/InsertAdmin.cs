using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/1/15
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class InsertAdmin : Form
    {
        public InsertAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 追加の管理者情報を登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButtonClick(object sender, EventArgs e)
        {
            if (adminName.Text == null || adminPass.Text == null)
            {
                MessageBox.Show("情報が入力されていません。");
            }
            else
            {
                //データベースに登録
                using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_administrator"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "INSERT INTO hcs_administrator(admin_name, admin_password) VALUES (@Name, @Password)";

                        //パラメータセット
                        cmd.Parameters.Add("Name", System.Data.DbType.String);
                        cmd.Parameters.Add("Password", System.Data.DbType.String);

                        //データ追加
                        cmd.Parameters["Name"].Value = adminName.Text;
                        cmd.Parameters["Password"].Value = adminPass.Text;
                        cmd.ExecuteNonQuery();
                        trans.Commit();
                    }
                }
            }
        }

        /// <summary>
        /// AdminLoginへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //AdminLoginを表示
            AdminLogin log = new AdminLogin();
            log.Visible = true;

            //画面を閉じる
            this.Close();
        }

        /// <summary>
        /// テーブルの内容を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndicationButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_administrator"))
            {
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM hcs_administrator", con);
                adapter.Fill(dataTable);
                adminView.DataSource = dataTable;
            }
        }
    }
}
