using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/1
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            // データベースへのコネクションを開いてテーブルが存在しない場合のみ作成して閉じる
            using (SQLiteConnection _con = new SQLiteConnection("Data Source=hcs_customer"))
            {
                _con.Open();

                // テーブルが存在するかどうかを確認
                if (!DoesTableExist(_con, "hcs_customer"))
                {
                    using (SQLiteCommand command = _con.CreateCommand())
                    {
                        command.CommandText =
                            "create table hcs_customer(customer_id INTEGER PRIMARY KEY AUTOINCREMENT,customer_name TEXT,customer_address TEXT,customer_phonenumber TEXT,customer_dob TEXT,course TEXT,start_date TEXT,customer_password TEXT)";
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    // テーブルが既に存在する場合はアラートを表示
                    MessageBox.Show("テーブル 'hcs_customer' は既に存在しています。", "テーブル存在のアラート", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _con.Close();
            }
        }

        /// <summary>
        /// テーブルが存在するかどうかを確認する
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
        /// InsertInfoへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertCustomerButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //InsertInfoを表示
            InsertInfo ii = new InsertInfo();
            ii.Show();
        }

        /// <summary>
        /// SearchInfoへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCustomerButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //SearchInfoを表示
            SearchInfo si = new SearchInfo();
            si.Show();
        }

        /// <summary>
        /// アプリケーションを終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }

        /// <summary>
        /// DeleteInfoへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteInfoButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //DeleteInfoを表示
            DeleteInfo di = new DeleteInfo();
            di.Show();
        }

        /// <summary>
        /// UpdateInfoへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateInfoButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //UpdateInfoを表示
            UpdateInfo ui = new UpdateInfo();
            ui.Show();
        }

        /// <summary>
        /// AllDataIndicationへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataIndicationButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //AllDataIndicationを表示
            AllDataIndication adi = new AllDataIndication();
            adi.Show();
        }

        /// <summary>
        /// AdminLoginへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //AdminLoginを表示
            AdminLogin alog = new AdminLogin();
            alog.Show();
        }
    }
}
