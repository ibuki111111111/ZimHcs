using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
/// <summary>
/// ---------------------------------------------------------------------------------------------
/// フォーム１を制御する
/// ---------------------------------------------------------------------------------------------
/// </summary>
namespace ZimHcs
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {

            InitializeComponent();
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル作成して閉じる
            using(var con=new SQLiteConnection("Data Source=hcs_customer"))
            {
                con.Open();
                using(SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table hcs_customer(customer_id INTEGER PRIMARY KEY AUTOINCREMENT,customer_name TEXT,customer_adress TEXT,customer_phonenumber TEXT,customer_dob TEXT,course TEXT,start_date TEXT,customer_password TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void insertCustomerButton_Click(object sender, EventArgs e)
        {
            //画面を非表示
            this.Visible = false;

            //InsertInfoを表示
            InsertInfo ii = new InsertInfo();
            ii.Show();
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }

        private void deleteInfoButton_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //DeleteInfoを表示
            DeleteInfo di = new DeleteInfo();
            di.Show();
        }
    }
}
