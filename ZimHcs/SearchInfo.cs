using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs SearchInfo.cs
/// 
/// 作成日　2023/12/8
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class SearchInfo : Form
    {
        public SearchInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 入力されたIDに一致するレコードの検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, EventArgs e)
        {
            //入力されていない場合
            if (string.IsNullOrEmpty(searchText.Text))
            {
                MessageBox.Show("データを入力してください。");
            }
            else
            {
                int customerIdToSearch = int.Parse(searchText.Text);

                // コネクションを開いて検索して閉じる
                using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        // customer_idを使用して検索
                        command.CommandText = "SELECT * FROM hcs_customer WHERE customer_id = @customerId";
                        command.Parameters.AddWithValue("@customerId", customerIdToSearch);

                        //データが存在するか
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // データがある場合は処理
                            if (reader.Read())
                            {
                                // 取得したデータの処理
                                int customerId = reader.GetInt32(reader.GetOrdinal("customer_id"));
                                string customerName = reader.GetString(reader.GetOrdinal("customer_name"));
                                string customerAddress = reader.GetString(reader.GetOrdinal("customer_address"));
                                string customerPhoneNumber = reader.GetString(reader.GetOrdinal("customer_phonenumber"));
                                string customerDob = reader.GetString(reader.GetOrdinal("customer_dob"));
                                string course = reader.GetString(reader.GetOrdinal("course"));
                                string startDate = reader.GetString(reader.GetOrdinal("start_date"));
                                string customerPassword = reader.GetString(reader.GetOrdinal("customer_password"));

                                //取得したデータを表示
                                nameIndication.Text = customerName;
                                addressIndication.Text = customerAddress;
                                phoneIndication.Text = customerPhoneNumber;
                                dobIndication.Text = customerDob;
                                courseIndication.Text = course;
                                dateIndication.Text = startDate;
                                passwordIndication.Text = customerPassword;
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
        }

        /// <summary>
        /// AdminMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //AdminMainMenuを表示
            AdminMainMenu main = new AdminMainMenu();
            main.Show();
        }
    }
}
