using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyEditor
{
    /// <summary>
    /// カラーパレットを管理するクラス
    /// </summary>
    public partial class ColorPalette : Form
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ColorPalette()
        {
            InitializeComponent();
        }
        #endregion

        #region getter/setter
        /// <summary>
        /// 現在の色を保持
        /// </summary>
        public Color CurrentColor { get; set; }
        #endregion

        #region インスタンスメソッド(private)
        /// <summary>
        /// ×印のラベルをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時のObject</param>
        /// <param name="e">Event時のArgument</param>
        private void LblColose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 色変更のボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時のObject</param>
        /// <param name="e">Event時のArgument</param>
        private void ColorButton_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            LblSelected.Location = new Point(label.Location.X - 1, label.Location.Y - 1);
            LblSelected.Size = new Size(label.Width + 2, label.Height + 2);
            this.CurrentColor = label.BackColor;
            this.Close();
        }

        /// <summary>
        /// RGBの設定を行うコントローラで値が変わった際の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void NumberUpDownRGB(object sender, EventArgs e)
        {
            // R, G, Bの各コントローラの値が変更されたらその色を目視確認できるように変更する
            int r = (int)this.NudRed.Value;
            int g = (int)this.NudGreen.Value;
            int b = (int)this.NudBlue.Value;
            this.LblOtherColor.BackColor = Color.FromArgb(r, g, b);
        }
        #endregion
    }
}
