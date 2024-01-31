using System;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/1/17
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class CustomerMainMenu : Form
    {
        //IDを格納する変数
        private int _idCatch = default;

        /// <summary>
        /// フォームが開かれたとき値を受け取る
        /// </summary>
        /// <param name="_idStorage"></param>
        public CustomerMainMenu(int _idStorage)
        {
            InitializeComponent();
            _idCatch = _idStorage;
        }

        /// <summary>
        /// アプリケーションを終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }

        /// <summary>
        /// CustomerIndicationへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInfoButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //CustomerIndicationを表示
            CustomerIndication ci = new CustomerIndication(_idCatch);
            ci.Show();
        }

        /// <summary>
        /// CustomerLoginへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //CustomerLoginを表示
            CustomerLogin clog = new CustomerLogin();
            clog.Show();
        }

        /// <summary>
        /// Trainingへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalorieButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //Trainingを表示
            Training train = new Training(_idCatch);
            train.Show();
        }

        #region//プロパティ
        public int IdStrage { get => _idCatch; set => _idCatch = value; }
        #endregion

    }
}
