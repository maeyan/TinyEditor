using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyEditor
{
    public class TinyEditor
    {
        #region プロパティ
        /// <summary>
        /// 太字ボタン
        /// </summary>
        private PictureBox pbxBold;

        /// <summary>
        /// 斜体ボタン
        /// </summary>
        private PictureBox pbxItalic;

        /// <summary>
        /// 下線ボタン
        /// </summary>
        private PictureBox pbxUnderline;

        /// <summary>
        /// 打ち消しボタン
        /// </summary>
        private PictureBox pbxStrikeout;

        /// <summary>
        /// 左寄せボタン
        /// </summary>
        private PictureBox pbxAlignLeft;

        /// <summary>
        /// 中央寄せボタン
        /// </summary>
        private PictureBox pbxAlignCenter;

        /// <summary>
        /// 右寄せボタン
        /// </summary>
        private PictureBox pbxAlignRight;

        /// <summary>
        /// 画像挿入ボタン
        /// </summary>
        private PictureBox pbxPicture;

        /// <summary>
        /// フォントカラー
        /// </summary>
        private PictureBox pbxFontColor;

        /// <summary>
        /// フォントサイズ
        /// </summary>
        private ComboBox cbxFontSize;
        #endregion

        #region コンストラクター
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rtbxEditor">エディタ</param>
        public TinyEditor(RichTextBox rtbxEditor)
        {
            this.RtbxEditor = rtbxEditor;
            this.RtbxEditor.MouseDown += this.RtbxEditor_MouseDown;
            this.RtbxEditor.KeyUp += this.RtbxEditor_KeyUp;
        }
        #endregion

        #region getter/setter
        /// <summary>
        /// 太字ボタンのSetter
        /// </summary>
        public PictureBox PbxBold
        {
            set
            {
                this.pbxBold = value;
                this.pbxBold.Click += this.PbxBold_Click;
            }
        }

        /// <summary>
        /// 斜体ボタンのSetter
        /// </summary>
        public PictureBox PbxItalic
        {
            set
            {
                this.pbxItalic = value;
                this.pbxItalic.Click += this.PbxItalic_Click;
            }
        }

        /// <summary>
        /// 下線ボタンのSetter
        /// </summary>
        public PictureBox PbxUnderline
        {
            set
            {
                this.pbxUnderline = value;
                this.pbxUnderline.Click += this.PbxUnderline_Click;
            }
        }

        /// <summary>
        /// 打ち消しボタンのSetter
        /// </summary>
        public PictureBox PbxStrilkeout
        {
            set
            {
                this.pbxStrikeout = value;
                this.pbxStrikeout.Click += this.PbxStrikeout_Click;
            }
        }

        /// <summary>
        /// 左寄席ボタンのSetter
        /// </summary>
        public PictureBox PbxAlignLeft
        {
            set
            {
                this.pbxAlignLeft = value;
                this.pbxAlignLeft.Click += this.PbxAlignLeft_Click;
            }
        }

        /// <summary>
        /// 中央寄せボタンのSetter
        /// </summary>
        public PictureBox PbxAlignCenter
        {
            set
            {
                this.pbxAlignCenter = value;
                this.pbxAlignCenter.Click += this.PbxAlignCenter_Click;
            }
        }

        /// <summary>
        /// 右寄せボタンのSetter
        /// </summary>
        public PictureBox PbxAlignRight
        {
            set
            {
                this.pbxAlignRight = value;
                this.pbxAlignRight.Click += this.PbxAlignRight_Click;
            }
        }

        /// <summary>
        /// 右寄せボタンのSetter
        /// </summary>
        public PictureBox PbxFontColor
        {
            set
            {
                this.pbxFontColor = value;
                this.pbxFontColor.Click += this.PbxFontColor_Click;
            }
        }

        /// <summary>
        /// FontSizeコンボボックス
        /// </summary>
        public ComboBox CbxFontSize
        {
            set
            {
                this.cbxFontSize = value;
                object[] sizeList = new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
                this.cbxFontSize.Items.AddRange(sizeList);

                // デフォルトのフォントサイズ
                if (this.RtbxEditor.Text == string.Empty)
                {
                    Font baseFont = this.RtbxEditor.Font;
                    this.RtbxEditor.Font = new Font(baseFont.FontFamily, 10, baseFont.Style);
                    this.cbxFontSize.SelectedIndex = 2;
                }

                this.cbxFontSize.SelectedIndexChanged += this.CbxFontSize_SelectedIndexChanged;
            }
        }

        /// <summary>
        /// 画像挿入アイコン
        /// </summary>
        public PictureBox PbxPicture
        {
            set
            {
                this.pbxPicture = value;
                this.pbxPicture.Click += this.PbxPicgture_Click;
            }
        }

        /// <summary>
        /// エディタのGetter/Setter
        /// </summary>
        private RichTextBox RtbxEditor { get; set; }
        #endregion

        #region pubilc
        /// <summary>
        /// RichTextEditoreのデフォルト
        /// </summary>
        public void Default()
        {
            this.RtbxEditor.Text = string.Empty;

            this.RtbxEditor.Font = new Font("メイリオ", 10, FontStyle.Regular);
            this.RtbxEditor.ForeColor = Color.Black;

            if (this.pbxBold != null)
            {
                this.pbxBold.Image = Properties.Resources.BoldOff;
                this.pbxBold.Tag = "OFF";
            }

            if (this.pbxItalic != null)
            {
                this.pbxItalic.Image = Properties.Resources.ItalicOff;
                this.pbxItalic.Tag = "OFF";
            }

            if (this.pbxStrikeout != null)
            {
                this.pbxStrikeout.Image = Properties.Resources.StrikeoutOff;
                this.pbxStrikeout.Tag = "OFF";
            }

            if (this.pbxUnderline != null)
            {
                this.pbxUnderline.Image = Properties.Resources.UnderlineOff;
                this.pbxUnderline.Tag = "OFF";
            }

            if (this.pbxAlignLeft != null)
            {
                this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOff;
                this.pbxAlignLeft.Tag = "OFF";
            }

            if (this.pbxAlignCenter != null)
            {
                this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOff;
                this.pbxAlignCenter.Tag = "OFF";
            }

            if (this.pbxAlignRight != null)
            {
                this.pbxAlignRight.Image = Properties.Resources.AlignRightOff;
                this.pbxAlignRight.Tag = "OFF";
            }

            if (this.pbxFontColor != null)
            {
                this.pbxFontColor.BackColor = Color.Black;
            }

            if (this.cbxFontSize != null)
            {
                this.cbxFontSize.ValueMember = "10";
            }
        }
        #endregion

        #region イベント
        /// <summary>
        /// 太字ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxBold_Click(object sender, EventArgs e)
        {
            if (this.pbxBold.Tag.ToString() == "OFF")
            {
                this.ChangeFontStyle(false, FontStyle.Bold);
                this.pbxBold.Image = Properties.Resources.BoldOn;
                this.pbxBold.Tag = "ON";
            }
            else
            {
                this.ChangeFontStyle(true, FontStyle.Bold);
                this.pbxBold.Image = Properties.Resources.BoldOff;
                this.pbxBold.Tag = "OFF";
            }
        }

        /// <summary>
        /// 斜体ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxItalic_Click(object sender, EventArgs e)
        {
            if (this.pbxItalic.Tag.ToString() == "OFF")
            {
                this.ChangeFontStyle(false, FontStyle.Italic);
                this.pbxItalic.Image = Properties.Resources.ItalicOn;
                this.pbxItalic.Tag = "ON";
            }
            else
            {
                this.ChangeFontStyle(true, FontStyle.Italic);
                this.pbxItalic.Image = Properties.Resources.ItalicOff;
                this.pbxItalic.Tag = "OFF";
            }
        }

        /// <summary>
        /// 下線ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxUnderline_Click(object sender, EventArgs e)
        {
            if (this.pbxUnderline.Tag.ToString() == "OFF")
            {
                this.ChangeFontStyle(false, FontStyle.Underline);
                this.pbxUnderline.Image = Properties.Resources.UnderlineOn;
                this.pbxUnderline.Tag = "ON";
            }
            else
            {
                this.ChangeFontStyle(true, FontStyle.Underline);
                this.pbxUnderline.Image = Properties.Resources.UnderlineOff;
                this.pbxUnderline.Tag = "OFF";
            }
        }

        /// <summary>
        /// 打ち消しボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxStrikeout_Click(object sender, EventArgs e)
        {
            if (this.pbxStrikeout.Tag.ToString() == "OFF")
            {
                this.ChangeFontStyle(false, FontStyle.Strikeout);
                this.pbxStrikeout.Image = Properties.Resources.StrikeoutOn;
                this.pbxStrikeout.Tag = "ON";
            }
            else
            {
                this.ChangeFontStyle(true, FontStyle.Strikeout);
                this.pbxStrikeout.Image = Properties.Resources.StrikeoutOff;
                this.pbxStrikeout.Tag = "OFF";
            }
        }

        /// <summary>
        /// 左寄せボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxAlignLeft_Click(object sender, EventArgs e)
        {
            bool toggle = this.pbxAlignLeft.Tag.ToString() == "OFF" ? false : true;
            this.ChangeHAlignment(toggle, HorizontalAlignment.Left);
        }

        /// <summary>
        /// 中央寄席ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxAlignCenter_Click(object sender, EventArgs e)
        {
            bool toggle = this.pbxAlignCenter.Tag.ToString() == "OFF" ? false : true;
            this.ChangeHAlignment(toggle, HorizontalAlignment.Center);
        }

        /// <summary>
        /// 右寄せボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxAlignRight_Click(object sender, EventArgs e)
        {
            bool toggle = this.pbxAlignRight.Tag.ToString() == "OFF" ? false : true;
            this.ChangeHAlignment(toggle, HorizontalAlignment.Right);
        }

        /// <summary>
        /// フォントカラーのボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxFontColor_Click(object sender, EventArgs e)
        {
            // FontColorボタンの下にカラーパレットを表示する
            // FontColorボタンの座標をスクリーン座標に変換し、引数にボタンの高さ分オフセットした位置を原点とする
            Point offset = new Point(0, this.pbxFontColor.Height);
            Point screenLocation = this.pbxFontColor.PointToScreen(offset);

            ColorPalette form = new ColorPalette();
            form.Location = screenLocation; // 位置変更
            form.ShowDialog();

            // FontColorをかえる
            this.pbxFontColor.BackColor = form.CurrentColor;

            // フォントの色を変える
            this.RtbxEditor.SelectionColor = form.CurrentColor;
        }

        /// <summary>
        /// フォントサイズを変更した際の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void CbxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChangeFontStize();
        }

        /// <summary>
        /// 画像挿入アイコンをクリックした際の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void PbxPicgture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "画像ファイル|*.bmp;*.gif;*.png;*jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(fileDialog.FileName);
                Clipboard.SetDataObject(bitmap);
                DataFormats.Format format = DataFormats.GetFormat(DataFormats.Bitmap);

                if (this.RtbxEditor.CanPaste(format))
                {
                    this.RtbxEditor.Paste(format);
                }
                else
                {
                    MessageBox.Show("貼り付けられる画像形式でありません");
                }
            }
        }

        /// <summary>
        /// 入力画面でマウスダウンした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void RtbxEditor_MouseDown(object sender, MouseEventArgs e)
        {
            // 処理軽減のため、Clickしてフォーカスをあてたときも、文字を選択した後もこのタイミングで行う
            this.ChangeButtonStatus();
        }

        /// <summary>
        /// 入力画面でキーアップした時の処理
        /// </summary>
        /// <param name="sender">Event時Object</param>
        /// <param name="e">Event時Argument</param>
        private void RtbxEditor_KeyUp(object sender, KeyEventArgs e)
        {
            // 矢印キーが操作された場合styleボタンの状態を変える
            // Deleteした際に前の行に移動したら水平方向の状態が変わる可能性があるのでDeleteでも処理を実行する
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                this.ChangeButtonStatus();
            }
        }
        #endregion

        #region ボタン操作によるFontStyleの変更、HAlignmentの変更
        /// <summary>
        /// フォントスタイルを変更
        /// </summary>
        /// <param name="toggle">イベント発生したボタンのon/off状態</param>
        /// <param name="style">フォントスタイル</param>
        private void ChangeFontStyle(bool toggle, FontStyle style)
        {
            int currentSelectStart = this.RtbxEditor.SelectionStart;
            int currentSelectLength = this.RtbxEditor.SelectionLength;

            // 描画を停止
            Utility.API.BeginControlUpdate(this.RtbxEditor);

            // 未選択状態の処理
            this.RtbxEditor.Select(currentSelectStart, 0);
            Font baseFont = this.RtbxEditor.SelectionFont;
            if (toggle)
            {
                this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size, baseFont.Style ^ style);
            }
            else
            {
                this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size, baseFont.Style | style);
            }

            // 選択状態の処理(１文字ずつ処理していく)
            for (int i = 0; i < currentSelectLength; i++)
            {
                this.RtbxEditor.Select(currentSelectStart + i, 1);

                baseFont = this.RtbxEditor.SelectionFont;

                if (toggle)
                {
                    this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size, baseFont.Style & ~style);
                }
                else
                {
                    this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size, baseFont.Style | style);
                }
            }

            // 描画を再開する
            Utility.API.EndControlUpdate(this.RtbxEditor);

            // Editor選択状態にするためフォーカスあててもとの選択状態を再現する
            this.RtbxEditor.Focus();
            this.RtbxEditor.Select(currentSelectStart, currentSelectLength);
        }

        /// <summary>
        /// フォントサイズを変更した際の処理
        /// </summary>
        private void ChangeFontStize()
        {
            int currentSelectStart = this.RtbxEditor.SelectionStart;
            int currentSelectLength = this.RtbxEditor.SelectionLength;

            // 描画を停止
            Utility.API.BeginControlUpdate(this.RtbxEditor);

            // フォントサイズ
            float fontSize = (float)Convert.ToDouble(this.cbxFontSize.Text);

            // 未選択状態の処理
            this.RtbxEditor.Select(currentSelectStart, 0);
            Font baseFont = this.RtbxEditor.SelectionFont;
            this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, fontSize, baseFont.Style);

            // 選択状態の処理(１文字ずつ処理していく)
            for (int i = 0; i < currentSelectLength; i++)
            {
                this.RtbxEditor.Select(currentSelectStart + i, 1);

                baseFont = this.RtbxEditor.SelectionFont;
                this.RtbxEditor.SelectionFont = new Font(baseFont.FontFamily, fontSize, baseFont.Style);
            }

            // 描画を再開する
            Utility.API.EndControlUpdate(this.RtbxEditor);

            // Editor選択状態にするためフォーカスあててもとの選択状態を再現する
            this.RtbxEditor.Focus();
            this.RtbxEditor.Select(currentSelectStart, currentSelectLength);
        }

        /// <summary>
        /// 水平方向の位置を変更
        /// </summary>
        /// <param name="toggle">イベント発生したボタンのon/off状態</param>
        /// <param name="hArignment">水平位置</param>
        private void ChangeHAlignment(bool toggle, HorizontalAlignment hArignment)
        {
            this.RtbxEditor.SelectionAlignment = hArignment;

            this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOff;
            this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOff;
            this.pbxAlignRight.Image = Properties.Resources.AlignRightOff;

            this.pbxAlignLeft.Tag = "OFF";
            this.pbxAlignCenter.Tag = "OFF";
            this.pbxAlignRight.Tag = "OFF";

            if (hArignment == HorizontalAlignment.Left)
            {
                this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOn;
            }
            else if (hArignment == HorizontalAlignment.Center)
            {
                this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOn;
            }
            else
            {
                this.pbxAlignRight.Image = Properties.Resources.AlignRightOn;
            }
        }
        #endregion

        #region カーソルの変化によりFontstyle/HAlignmentステータスの反映
        /// <summary>
        /// カーソルの変化によりボタンの変化を反映
        /// </summary>
        private void ChangeButtonStatus()
        {
            // FontStyleを変更
            this.ChangeStyleButtonStatus();

            // 水平方向の変更
            this.ChangeHAlignmentButtonStatus();

            // FontColorの変更
            this.ChangeFontColorButtonStatus();

            // FontSizeの変更
            this.ChangeFontSizeStatus();
        }

        /// <summary>
        /// カーソルが変化した際の、FontStyleの状態をBold,Italic,Underline,Strikeoutボタンに反映する
        /// </summary>
        private void ChangeStyleButtonStatus()
        {
            Font currentFont = this.RtbxEditor.SelectionFont;

            if (currentFont == null)
            {
                return;
            }

            if (currentFont.Bold)
            {
                this.pbxBold.Image = Properties.Resources.BoldOn;
                this.pbxBold.Tag = "ON";
            }
            else
            {
                this.pbxBold.Image = Properties.Resources.BoldOff;
                this.pbxBold.Tag = "OFF";
            }

            if (currentFont.Italic)
            {
                this.pbxItalic.Image = Properties.Resources.ItalicOn;
                this.pbxItalic.Tag = "ON";
            }
            else
            {
                this.pbxItalic.Image = Properties.Resources.ItalicOff;
                this.pbxItalic.Tag = "OFF";
            }

            if (currentFont.Underline)
            {
                this.pbxUnderline.Image = Properties.Resources.UnderlineOn;
                this.pbxUnderline.Tag = "ON";
            }
            else
            {
                this.pbxUnderline.Image = Properties.Resources.UnderlineOff;
                this.pbxUnderline.Tag = "OFF";
            }

            if (currentFont.Strikeout)
            {
                this.pbxStrikeout.Image = Properties.Resources.StrikeoutOn;
                this.pbxStrikeout.Tag = "ON";
            }
            else
            {
                this.pbxStrikeout.Image = Properties.Resources.StrikeoutOff;
                this.pbxStrikeout.Tag = "OFF";
            }
        }

        /// <summary>
        /// カーソルが変化した際の、水平方向のボタンのステータスを変更
        /// </summary>
        private void ChangeHAlignmentButtonStatus()
        {
            HorizontalAlignment currentHAlignment = this.RtbxEditor.SelectionAlignment;
            if (this.RtbxEditor.SelectionAlignment == HorizontalAlignment.Left)
            {
                this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOn;
                this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOff;
                this.pbxAlignRight.Image = Properties.Resources.AlignRightOff;
                this.pbxAlignLeft.Tag = "ON";
                this.pbxAlignCenter.Tag = "OFF";
                this.pbxAlignRight.Tag = "OFF";
            }
            else if (this.RtbxEditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOff;
                this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOn;
                this.pbxAlignRight.Image = Properties.Resources.AlignRightOff;
                this.pbxAlignLeft.Tag = "OFF";
                this.pbxAlignCenter.Tag = "ON";
                this.pbxAlignRight.Tag = "OFF";
            }
            else
            {
                this.pbxAlignLeft.Image = Properties.Resources.AlignLeftOff;
                this.pbxAlignCenter.Image = Properties.Resources.AlignCenterOff;
                this.pbxAlignRight.Image = Properties.Resources.AlignRightOn;
                this.pbxAlignLeft.Tag = "OFF";
                this.pbxAlignCenter.Tag = "OFF";
                this.pbxAlignRight.Tag = "ON";
            }
        }

        /// <summary>
        /// カーソルが変化した際の、FontColorのボタンステータスを変更
        /// </summary>
        private void ChangeFontColorButtonStatus()
        {
            this.pbxFontColor.BackColor = this.RtbxEditor.SelectionColor;
        }

        /// <summary>
        /// フォントサイズを変更した際の処理
        /// </summary>
        private void ChangeFontSizeStatus()
        {
            Font currentFont = this.RtbxEditor.SelectionFont;

            if (currentFont == null)
            {
                return;
            }

            this.cbxFontSize.Text = currentFont.Size.ToString();
        }
        #endregion
    }
}
