using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/1/19
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class CustomerIndication : Form
    {
        //IDを格納する変数
        private int _idStrage = default;

        /// <summary>
        /// ログインされているユーザーの情報を表示
        /// </summary>
        /// <param name="_idCatch"></param>
        public CustomerIndication(int _idCatch)
        {
            InitializeComponent();
            _idStrage = _idCatch;
            // 検索対象のcustomer_id
            int customerIdToSearch = _idStrage;

            // コネクションを開いて検索して閉じる
            using (var con = new SQLiteConnection("Data Source=hcs_customer"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    // customer_idを使用して検索
                    command.CommandText = "SELECT * FROM hcs_customer WHERE customer_id = @customerId";
                    command.Parameters.AddWithValue("@customerId", customerIdToSearch);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // データがある場合は処理
                        if (reader.Read())
                        {
                            // 取得したデータの処理例
                            int customerId = reader.GetInt32(reader.GetOrdinal("customer_id"));
                            string customerName = reader.GetString(reader.GetOrdinal("customer_name"));
                            string customerAddress = reader.GetString(reader.GetOrdinal("customer_address"));
                            string customerPhoneNumber = reader.GetString(reader.GetOrdinal("customer_phonenumber"));
                            string customerDob = reader.GetString(reader.GetOrdinal("customer_dob"));
                            string course = reader.GetString(reader.GetOrdinal("course"));
                            string startDate = reader.GetString(reader.GetOrdinal("start_date"));
                            string customerPassword = reader.GetString(reader.GetOrdinal("customer_password"));

                            customeridLabel.Text = _idStrage.ToString();
                            nameLabel.Text = customerName;
                            adressLabel.Text = customerAddress;
                            phonenumberLabel.Text = customerPhoneNumber;
                            dobLabel.Text = customerDob;
                            courseLabel.Text = course;
                            dateLabel.Text = startDate;
                            passwordLabel.Text = customerPassword;
                        }
                        else
                        {
                            // データが見つからなかった場合の処理
                            MessageBox.Show("該当するデータが見つかりませんでした。");
                        }
                    }
                }
                con.Close();
            }
        }

        /// <summary>
        /// CustomerMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            //CustomerMainMenuを表示
            CustomerMainMenu main = new CustomerMainMenu(_idStrage);
            main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        #region//プロパティ
        public int IdStrage { get => _idStrage; set => _idStrage = value; }
        #endregion
    }
}
