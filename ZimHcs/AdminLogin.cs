using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/20
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 入力確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonClick(object sender, EventArgs e)
        {
            int adminId = default;
            if (!int.TryParse(inputId.Text, out adminId))
            {
                MessageBox.Show("IDとパスワードを入力してください。");
                return;
            }

            string password = inputPassword.Text;

            if (LoginSearch(adminId, password))
            {
                MessageBox.Show("ログイン成功！");

                //現在の画面を非表示
                this.Visible = false;

                //AdminMainMenuを表示
                AdminMainMenu main = new AdminMainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("IDかパスワードが間違っています。");
            }
        }

        /// <summary>
        /// ログイン検証
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool LoginSearch(int customerId, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_administrator"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "SELECT admin_id FROM hcs_administrator WHERE admin_id = @adminId AND admin_password = @adminPassword";
                    command.Parameters.AddWithValue("@adminId", customerId);
                    command.Parameters.AddWithValue("@adminPassword", password);

                    var result = command.ExecuteScalar();

                    con.Close();

                    return (result != null);
                }
            }
        }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTableButtonClick(object sender, EventArgs e)
        {
            // データベースへのコネクションを開いてテーブルが存在しない場合のみ作成して閉じる
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_administrator"))
            {
                con.Open();

                // テーブルが存在するかどうかを確認
                if (!DoesTableExist(con, "hcs_administrator"))
                {
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table hcs_administrator(admin_id INTEGER PRIMARY KEY AUTOINCREMENT, admin_name Text, admin_password Text)";
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    // テーブルが既に存在する場合はアラートを表示
                    MessageBox.Show("テーブル 'hcs_administrator' は既に存在しています。", "テーブル存在のアラート", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
        }

        /// <summary>
        /// テーブルが存在するかどうかを確認するメソッド
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private bool DoesTableExist(SQLiteConnection connection, string tableName)
        {
            using (SQLiteCommand command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'";
                object result = command.ExecuteScalar();
                return (result != null && result.ToString() == tableName);
            }
        }

        /// <summary>
        /// InsertAdminへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //InsertAdminを表示
            InsertAdmin ia = new InsertAdmin();
            ia.Show();
        }

        /// <summary>
        /// SelectUserへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //SelectUserを表示
            SelectUser su = new SelectUser();
            su.Show();
        }
    }
}
