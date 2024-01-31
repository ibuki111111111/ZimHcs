using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/6
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class Indication : Form
    {
        //氏名を格納する変数
        private string _valueCustomerName = default;
        //住所を格納する変数
        private string _valueCustomerAddress = default;
        //電話番号を格納する変数
        private string _valueCustomerPhonenumber = default;
        //生年月日を格納する変数
        private string _valueCustomerDob = default;
        //コースを格納する変数
        private string _valueCustomerCourse = default;
        //利用開始日を格納する変数
        private string _valueCustomerStartdate = default;
        //パスワードを格納する変数
        private string _valueCustomerPassword = default;

        /// <summary>
        /// フォームが開かれたとき値を受け取りテーブルに格納後表示する
        /// </summary>
        /// <param name="_valueName"></param>
        /// <param name="_valueAddress"></param>
        /// <param name="_valuePhonenumber"></param>
        /// <param name="_valueDob"></param>
        /// <param name="_valueCourse"></param>
        /// <param name="_valueStartdate"></param>
        /// <param name="_valuePassword"></param>
        public Indication(string _valueName, string _valueAddress, string _valuePhonenumber, string _valueDob, string _valueCourse, string _valueStartdate, string _valuePassword)
        {
            InitializeComponent();
            _valueCustomerName = _valueName;
            _valueCustomerAddress = _valueAddress;
            _valueCustomerPhonenumber = _valuePhonenumber;
            _valueCustomerDob = _valueDob;
            _valueCustomerCourse = _valueCourse;
            _valueCustomerStartdate = _valueStartdate;
            _valueCustomerPassword = _valuePassword;
            //データベースに登録
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO hcs_customer(customer_name,customer_address,customer_phonenumber,customer_dob,course,start_date,customer_password) VALUES (@Name,@Address,@Phonenumber,@Dob,@Course,@Start_date,@Password)";

                    //パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Address", System.Data.DbType.String);
                    cmd.Parameters.Add("Phonenumber", System.Data.DbType.String);
                    cmd.Parameters.Add("Dob", System.Data.DbType.String);
                    cmd.Parameters.Add("Course", System.Data.DbType.String);
                    cmd.Parameters.Add("Start_date", System.Data.DbType.String);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);

                    //データ追加
                    cmd.Parameters["Name"].Value = _valueCustomerName;
                    cmd.Parameters["Address"].Value = _valueCustomerAddress;
                    cmd.Parameters["Phonenumber"].Value = _valueCustomerPhonenumber;
                    cmd.Parameters["Dob"].Value = _valueCustomerDob;
                    cmd.Parameters["Course"].Value = _valueCustomerCourse;
                    cmd.Parameters["Start_date"].Value = _valueCustomerStartdate;
                    cmd.Parameters["Password"].Value = _valueCustomerPassword;
                    cmd.ExecuteNonQuery();

                    //読み取り
                    using (SQLiteCommand selectCommand = con.CreateCommand())
                    {
                        long lastInsertedId;
                        selectCommand.CommandText = "SELECT last_insert_rowid()";
                        lastInsertedId = (long)selectCommand.ExecuteScalar();
                        // 取得した customer_id をラベルに設定
                        customeridLabel.Text = lastInsertedId.ToString();
                    }
                    //コミット
                    trans.Commit();
                }
            }
            nameLabel.Text = _valueCustomerName;
            adressLabel.Text = _valueCustomerAddress;
            phonenumberLabel.Text = _valueCustomerPhonenumber;
            dobLabel.Text = _valueCustomerDob;
            courseLabel.Text = _valueCustomerCourse;
            dateLabel.Text = _valueCustomerStartdate;
            passwordLabel.Text = _valueCustomerPassword;
        }

        /// <summary>
        /// AdminMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            //AdminMainMenuを表示
            AdminMainMenu main = new AdminMainMenu();
            main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        #region//プロパティ
        public string ValueCustomerName { get => _valueCustomerName; set => _valueCustomerName = value; }
        public string ValueCustomerAdress { get => _valueCustomerAddress; set => _valueCustomerAddress = value; }
        public string ValueCustomerPhonenumber { get => _valueCustomerPhonenumber; set => _valueCustomerPhonenumber = value; }
        public string ValueCustomerDob { get => _valueCustomerDob; set => _valueCustomerDob = value; }
        public string ValueCustomerCourse { get => _valueCustomerCourse; set => _valueCustomerCourse = value; }
        public string ValueCustomerStartdate { get => _valueCustomerStartdate; set => _valueCustomerStartdate = value; }
        public string ValueCustomerPassword { get => _valueCustomerPassword; set => _valueCustomerPassword = value; }
        #endregion
    }
}
