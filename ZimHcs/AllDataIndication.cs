using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2023/1/18
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class AllDataIndication : Form
    {
        public AllDataIndication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テーブルの内容を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndicationButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=hcs_customer"))
            {
                var dataTable = new DataTable();
                var adapter = new SQLiteDataAdapter("SELECT * FROM hcs_customer", con);
                adapter.Fill(dataTable);
                dataGraph.DataSource = dataTable;
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
