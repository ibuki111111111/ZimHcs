using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs UpdateInfo.cs
/// 
/// 作成日　2023/12/12
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class UpdateInfo : Form
    {
        //氏名を格納する変数
        private string _strageName = default;
        //住所を格納する変数
        private string _strageAddress = default;
        //電話番号を格納する変数
        private string _stragePhonenumber = default;
        //生年月日を格納する変数
        private string _strageDob = default;
        //コースを格納する変数
        private string _strageCourse = default;
        //パスワードを格納する変数
        private string _stragePassword = default;

        public UpdateInfo()
        {
            InitializeComponent();

        }
        /// <summary>
        /// ---------------------------------------------------------------------------------------------
        /// 変更するテーブルの検索とデータ抽出
        /// ---------------------------------------------------------------------------------------------
        /// </summary>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            //入力されていない場合
            if (string.IsNullOrEmpty(inputId.Text))
            {
                MessageBox.Show("データを入力してください。");
            }
            else
            {
                int customerIdToSearch = int.Parse(inputId.Text);

                // コネクションを開いて検索して閉じる
                using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        // customer_idを使用して検索
                        command.CommandText = "SELECT * FROM hcs_customer WHERE customer_id = @customerId";
                        command.Parameters.AddWithValue("@customerId", customerIdToSearch);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // データがある場合
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

                                _strageName = customerName;
                                _strageAddress = customerAddress;
                                _stragePhonenumber = customerPhoneNumber;
                                _strageDob = customerDob;
                                _strageCourse = course;
                                _stragePassword = customerPassword;
                            }
                            else
                            {
                                // データが見つからなかった場合
                                MessageBox.Show("該当するデータが見つかりませんでした。");
                            }
                        }
                    }
                    con.Close();
                }
            }
            if (inputName.Text != "")
            {
                _strageName = inputName.Text;
            }
            if (inputAddress.Text != "")
            {
                _strageAddress = inputAddress.Text;
            }
            if (inputPhonenumber.Text != "")
            {
                _stragePhonenumber = inputPhonenumber.Text;
            }
            if (inputDob.Text != "")
            {
                _strageDob = inputDob.Text;
            }
            if (testButton.Checked == true)
            {
                _strageCourse = "お試しコース";
            }
            else if (normalButton.Checked == true)
            {
                _strageCourse = "ノーマルコース";
            }
            else if (specialButton.Checked == true)
            {
                _strageCourse = "スペシャルコース";
            }

            if (inputDob.Text != "")
            {
                _stragePassword = inputPassword.Text;
            }

            /// <summary>
            /// ---------------------------------------------------------------------------------------------
            /// レコードの変更
            /// ---------------------------------------------------------------------------------------------
            /// </summary>
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("入力した情報で変更しても大丈夫ですか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "UPDATE   hcs_customer SET customer_name=@Name, customer_address=@Address, customer_phonenumber=@Phonenumber, customer_dob=@Dob, course=@Course, customer_password=@Password WHERE customer_id = @Id";
                        //パラメータセット
                        cmd.Parameters.Add("Name", System.Data.DbType.String);
                        cmd.Parameters.Add("Address", System.Data.DbType.String);
                        cmd.Parameters.Add("Phonenumber", System.Data.DbType.String);
                        cmd.Parameters.Add("Dob", System.Data.DbType.String);
                        cmd.Parameters.Add("Course", System.Data.DbType.String);
                        cmd.Parameters.Add("Password", System.Data.DbType.String);
                        cmd.Parameters.Add("Id", DbType.Int64);

                        //データ追加                     
                        cmd.Parameters["Name"].Value = _strageName;
                        cmd.Parameters["Address"].Value = _strageAddress;
                        cmd.Parameters["Phonenumber"].Value = _stragePhonenumber;
                        cmd.Parameters["Dob"].Value = _strageDob;
                        cmd.Parameters["Course"].Value = _strageCourse;
                        cmd.Parameters["Password"].Value = _stragePassword;                      
                        cmd.Parameters["Id"].Value = int.Parse(inputId.Text);

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
            //現在の画面を非表示
            this.Visible = false;

            //AdminMainMenuを表示
            AdminMainMenu _main = new AdminMainMenu();
            _main.Show();
        }

        #region//プロパティ
        public string StrageName { get => _strageName; set => _strageName = value; }
        public string StrageAddress { get => _strageAddress; set => _strageAddress = value; }
        public string StragePhonenumber { get => _stragePhonenumber; set => _stragePhonenumber = value; }
        public string StrageDob { get => _strageDob; set => _strageDob = value; }
        public string StrageCourse { get => _strageCourse; set => _strageCourse = value; }
        public string StragePassword { get => _stragePassword; set => _stragePassword = value; }
        #endregion
    }
}
