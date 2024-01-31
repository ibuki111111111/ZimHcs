using System;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/12/19
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// AdminLoginへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //AdminLoginを表示
            AdminLogin alog = new AdminLogin();
            alog.Show();
        }

        /// <summary>
        /// CustomerLoginへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerButtonClick(object sender, EventArgs e)
        {
            //現在の画面を非表示
            this.Visible = false;

            //CustomerLoginを表示
            CustomerLogin clog = new CustomerLogin();
            clog.Show();
        }
    }
}
