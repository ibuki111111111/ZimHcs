using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/1/12
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class CustomerLogin : Form
    {
        //IDを格納する変数
        private int _idStorage = default;

        public CustomerLogin()
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
            int customerId = default;
            if (!int.TryParse(inputId.Text, out customerId))
            {
                MessageBox.Show("IDとパスワードを入力してください。");
                return;
            }

            string password = inputPassword.Text;

            if (LoginSearch(customerId, password))
            {
                MessageBox.Show("ログイン成功！");

                _idStorage = customerId;

                //現在の画面を非表示
                this.Visible = false;

                //CustomerMainMenuを表示
                CustomerMainMenu main = new CustomerMainMenu(_idStorage);
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
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "SELECT customer_id FROM hcs_customer WHERE customer_id = @customerId AND customer_password = @customerPassword";
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@customerPassword", password);

                    var result = command.ExecuteScalar();

                    con.Close();

                    return (result != null);
                }
            }
        }

        #region //プロパティ
        public int IdStorage { get => _idStorage; set => _idStorage = value; }
        #endregion

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
