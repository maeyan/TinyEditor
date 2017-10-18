using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TinyEditor
{
    /// <summary>
    /// 汎用的なメソッドをまとめたクラス
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// WindowsAPIをまとめたクラス
        /// </summary>
        public class API
        {
            /// <summary>
            /// 再描画を設定するメッセージ
            /// </summary>
            private const int WM_SETREDRAW = 0x000B;

            /// <summary>
            /// [WindowsAPI]SendMessage
            /// </summary>
            /// <param name="hWnd">送信先ウィンドウのハンドル</param>
            /// <param name="msg">メッセージ</param>
            /// <param name="wParam">メッセージの最初のパラメータ</param>
            /// <param name="lParam">メッセージの 2 番目のパラメータ</param>
            /// <returns>メッセージ処理の結果</returns>
            [DllImport("user32.dll")]
            public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

            /// <summary>
            /// コントロールの再描画を停止させる
            /// </summary>
            /// <param name="control">対象のコントロール</param>
            public static void BeginControlUpdate(Control control)
            {
                SendMessage(new HandleRef(control, control.Handle), WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
            }

            /// <summary>
            /// コントロールの再描画を再開させる
            /// </summary>
            /// <param name="control">対象のコントロール</param>
            public static void EndControlUpdate(Control control)
            {
                SendMessage(new HandleRef(control, control.Handle), WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
                control.Invalidate();
            }
        }

        /// <summary>
        /// TabPageを管理するクラス
        /// </summary>
        public class TabPageManager
        {
            #region Class変数
            /// <summary>
            /// タブページデータ
            /// </summary>
            private TabPageInfo[] tabPageInfos = null;

            /// <summary>
            /// タブコントロール
            /// </summary>
            private TabControl tabControl = null;
            #endregion

            #region コンストラクタ
            /// <summary>
            /// TabPageManagerクラスのインスタンスを作成する
            /// </summary>
            /// <param name="crl">基になるTabControlオブジェクト</param>
            public TabPageManager(TabControl crl)
            {
                this.tabControl = crl;
                this.tabPageInfos = new TabPageInfo[this.tabControl.TabPages.Count];

                for (int i = 0; i < this.tabControl.TabPages.Count; i++)
                {
                    this.tabPageInfos[i] = new TabPageInfo(this.tabControl.TabPages[i], true);
                }
            }
            #endregion

            #region インスタンスメソッド(public)
            /// <summary>
            /// TabPageの表示・非表示を変更する
            /// </summary>
            /// <param name="index">変更するTabPageのIndex番号</param>
            /// <param name="v">表示するときはTrue。
            /// 非表示にするときはFalse。</param>
            public void ChangeTabPageVisible(int index, bool v)
            {
                if (this.tabPageInfos[index].Visible == v)
                {
                    return;
                }

                this.tabPageInfos[index].Visible = v;
                this.tabControl.SuspendLayout();
                this.tabControl.TabPages.Clear();

                for (int i = 0; i < this.tabPageInfos.Length; i++)
                {
                    if (this.tabPageInfos[i].Visible)
                    {
                        this.tabControl.TabPages.Add(this.tabPageInfos[i].TabPage);
                    }
                }

                this.tabControl.ResumeLayout();
            }
            #endregion

            #region インスタンスメソッド(private)
            /// <summary>
            /// タブページの情報を管理するクラス
            /// </summary>
            private class TabPageInfo
            {
                /// <summary>
                /// コンストラクタ
                /// </summary>
                /// <param name="page">ページ情報</param>
                /// <param name="v">表示・非表示</param>
                public TabPageInfo(TabPage page, bool v)
                {
                    this.TabPage = page;
                    this.Visible = v;
                }

                /// <summary>
                /// タブページコントロール
                /// </summary>
                public TabPage TabPage { get; set; }

                /// <summary>
                /// 表示・非表示
                /// </summary>
                public bool Visible { get; set; }
            }
            #endregion
        }
    }
}
