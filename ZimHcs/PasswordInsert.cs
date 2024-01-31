using System;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/5
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class PasswordInsert : Form
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
        /// フォームが開かれたとき値を受け取る
        /// </summary>
        /// <param name="_valueName"></param>
        /// <param name="_valueAddress"></param>
        /// <param name="_valuePhonenumber"></param>
        /// <param name="_valueDob"></param>
        /// <param name="_valueCourse"></param>
        /// <param name="_valueStartdate"></param>
        public PasswordInsert(string _valueName, string _valueAddress, string _valuePhonenumber, string _valueDob, string _valueCourse, string _valueStartdate)
        {
            InitializeComponent();
            _valueCustomerName = _valueName;
            _valueCustomerAddress = _valueAddress;
            _valueCustomerPhonenumber = _valuePhonenumber;
            _valueCustomerDob = _valueDob;
            _valueCustomerCourse = _valueCourse;
            _valueCustomerStartdate = _valueStartdate;
        }

        /// <summary>
        /// パスワードを設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonClick(object sender, EventArgs e)
        {
            //パスワードの入力及び再入力がされていないとき
            if (inputPassword.Text=="" || retypePassword.Text=="")
            {
                //メッセージボックスを表示する
                MessageBox.Show("設定するパスワードを入力またはパスワードを再入力してください。","エラー",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //パスワードの入力及び再入力がされているとき
            else
            {
                if (inputPassword.Text == retypePassword.Text)
                {
                    //メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("パスワードを設定しても大丈夫ですか？","質問", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.Yes)
                    {
                        //「はい」が選択された時
                        _valueCustomerPassword = inputPassword.Text;

                        //現在の画面を非表示
                        this.Visible = false;

                        //Indicationを表示
                        Indication indi = new Indication(_valueCustomerName,_valueCustomerAddress,_valueCustomerPhonenumber,_valueCustomerDob,
                            _valueCustomerCourse,_valueCustomerStartdate,_valueCustomerPassword);
                        indi.Show();
                    }
                }
                else
                {
                    //メッセージボックスを表示する
                    MessageBox.Show("入力された内容に間違いがあります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void BackButtonClick(object sender, EventArgs e)
        {

        }
    }
}
