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
    public partial class InsertInfo : Form
    {
        //氏名を格納する変数
        private string _valueCustomerName = default;
        //住所を格納する変数
        private string _valueCustomerAddress = default;
        //電話番号を格納する変数
        private string _valueCustomerPhonenumber = default;
        //生年月日を格納する変数
        private string _valueCustomerDob = default;  

        public InsertInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// AdminMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //AdminMainMenuを表示
            AdminMainMenu main = new AdminMainMenu();
            main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        /// <summary>
        /// 個人情報を入力してCourseDateInsertへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonClick(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("この入力内容でよろしいですか？", "質問",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                _valueCustomerName = nameTextBox.Text;
                _valueCustomerAddress = adressTextBox.Text;
                _valueCustomerPhonenumber = phonenumberTextBox.Text;
                _valueCustomerDob = dobTextBox.Text;

                //現在の画面を非表示
                this.Visible = false;

                // CourseDateInsertを表示
                CourseDateInsert cdi = new CourseDateInsert(_valueCustomerName, _valueCustomerAddress, _valueCustomerPhonenumber, _valueCustomerDob);
                cdi.Show();
            }
        }

        #region//プロパティ
        public string CustomerName { get => _valueCustomerName; set => _valueCustomerName = value; }
        public string CustomerAdress { get => _valueCustomerAddress; set => _valueCustomerAddress = value; }
        public string CustomerPhonenumber { get => _valueCustomerPhonenumber; set => _valueCustomerPhonenumber = value; }
        public string CustomerDob { get => _valueCustomerDob; set => _valueCustomerDob = value; }
        #endregion
    }
}
