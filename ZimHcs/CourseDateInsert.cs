using System;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/4
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class CourseDateInsert : Form
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

        /// <summary>
        /// フォームが開かれたとき値を受け取る
        /// </summary>
        /// <param name="_valueName"></param>
        /// <param name="_valueAdress"></param>
        /// <param name="_valuePhonenumber"></param>
        /// <param name="_valueDob"></param>
        public CourseDateInsert(string _valueName, string _valueAdress, string _valuePhonenumber, string _valueDob)
        {
            InitializeComponent();
            _valueCustomerName = _valueName;
            _valueCustomerAddress = _valueAdress;
            _valueCustomerPhonenumber = _valuePhonenumber;
            _valueCustomerDob = _valueDob;
        }

        /// <summary>
        /// コース、利用開始日を入力してPasswordInsertへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonClick(object sender, EventArgs e)
        {
            //チェックされたラジオボタンのコースを変数に入れる
            if (testerButton.Checked == true)
            {
                _valueCustomerCourse = "お試しコース";
            }
            else if (normalButton.Checked == true)
            {
                _valueCustomerCourse = "ノーマルコース";
            }
            else if (specialButton.Checked == true)
            {
                _valueCustomerCourse = "スペシャルコース";
            }

            //利用開始日を変数に入れる
            _valueCustomerStartdate = datePick.Value.ToString("yyyy/MM/dd");

            //現在の画面を非表示
            this.Visible = false;

            //PasswordInsertを表示
            PasswordInsert pi = new PasswordInsert(_valueCustomerName,_valueCustomerAddress,_valueCustomerPhonenumber,_valueCustomerDob, _valueCustomerCourse, _valueCustomerStartdate);
            pi.Show();
        }

        /// <summary>
        /// InsertInfoへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //InsertInfoを表示
            InsertInfo II = new InsertInfo();
            II.Show();
        }

        #region //プロパティ
        public string ValueCustomerName { get => _valueCustomerName; set => _valueCustomerName = value; }
        public string ValueCustomerAdress { get => _valueCustomerAddress; set => _valueCustomerAddress = value; }
        public string ValueCustomerPhonenumber { get => _valueCustomerPhonenumber; set => _valueCustomerPhonenumber = value; }
        public string ValueCustomerDob { get => _valueCustomerDob; set => _valueCustomerDob = value; }
        public string CustomerCourse { get => _valueCustomerCourse; set => _valueCustomerCourse = value; }
        public string CustomerStartdate { get => _valueCustomerStartdate; set => _valueCustomerStartdate = value; }
        #endregion
    }
}
