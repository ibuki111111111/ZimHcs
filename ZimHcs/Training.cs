using System;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------------------------
/// #.cs AdminMainMenu.cs
/// 
/// 作成日　2024/1/24
/// 
/// 作成者　小松伊吹
/// ---------------------------------------------------------------------------------------------
/// </summary>
///

namespace ZimHcs
{
    public partial class Training : Form
    {
        private int _idCatch = default;

        public Training(int _idStorage)
        {
            InitializeComponent();
            _idCatch = _idStorage;
        }

        /// <summary>
        /// 消費カロリー計算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButtonClick(object sender, EventArgs e)
        {
            string selected = trainingMenu.SelectedItem.ToString();
            int times = int.Parse(trainingTimes.SelectedItem.ToString());
            int legCal = 120;
            int clunchCal = 100;
            int benchCal = 120;
            int carlCal = 60;
            int deadRiftCal = 120;
            int shoulderCal = 80;
            int calorie = default;
            if (selected== "レッグプレス")
            {
                calorie = legCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
            if (selected == "クランチ")
            {
                calorie = clunchCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
            if (selected == "ベンチプレス")
            {
                calorie = benchCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
            if (selected == "ダンベルカール")
            {
                calorie = carlCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
            if (selected == "ダンベルデッドリフト")
            {
                calorie = deadRiftCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
            if (selected == "ショルダープレス")
            {
                calorie = shoulderCal * times;
                calorieLabel.Text = calorie.ToString() + "kcal";
            }
        }

        /// <summary>
        /// CustomerMainMenuへ画面遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //CustomerMainMenuを表示
            CustomerMainMenu main = new CustomerMainMenu(_idCatch);
            main.Visible = true;

            //画面を閉じる
            this.Close();
        }

        #region//プロパティ
        public int IdCatch { get => _idCatch; set => _idCatch = value; }
        #endregion
    }
}
