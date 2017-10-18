using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Getter/Setter
        /// <summary>
        /// Editorのインスタンス
        /// </summary>
        private TinyEditor.TinyEditor Editor { get; set; }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetEditor();
        }

        /// <summary>
        /// エディタで使用するボタンの設定
        /// </summary>
        private void SetEditor()
        {
            // Editorの設定
            this.Editor = new TinyEditor.TinyEditor(this.RtbxEditor);
            this.Editor.PbxBold = this.PbxBold;
            this.Editor.PbxItalic = this.PbxItalic;
            this.Editor.PbxUnderline = this.PbxUnderline;
            this.Editor.PbxStrilkeout = this.PbxStrikeout;

            this.Editor.PbxAlignLeft = this.PbxAlignLeft;
            this.Editor.PbxAlignCenter = this.PbxAlignCenter;
            this.Editor.PbxAlignRight = this.PbxAlignRight;

            this.Editor.PbxFontColor = this.PbxFontColor;
            this.Editor.CbxFontSize = this.CbxFontSize;
            this.Editor.PbxPicture = this.PbxPicture;
        }

    }
}
