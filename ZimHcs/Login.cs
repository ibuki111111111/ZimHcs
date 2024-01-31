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

namespace ZimHcs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int adminId;
            if (!int.TryParse(inputId.Text, out adminId))
            {
                MessageBox.Show("IDとパスワードを入力してください。");
                return;
            }

            string password = inputPassword.Text;

            if (loginsearch(adminId, password))
            {
                MessageBox.Show("ログイン成功！");

                //現在の画面を非表示
                this.Visible = false;

                //UpdateInfoを表示
                AdminMainMenu main = new AdminMainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("IDかパスワードが間違っています。");
            }
        }

        private bool loginsearch(int customerId, string password)
        {
            using (var con = new SQLiteConnection("Data Source=hcs_administrator"))
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

        private void createTableButton_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル作成して閉じる
            using (var con = new SQLiteConnection("Data Source=hcs_administrator"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table hcs_administrator(admin_id INTEGER PRIMARY KEY AUTOINCREMENT, admin_name Text, admin_password Text)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //InsertAdminを表示
            InsertAdmin ia = new InsertAdmin();
            ia.Show();
        }
    }
}
