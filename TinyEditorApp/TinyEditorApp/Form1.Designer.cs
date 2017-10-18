namespace TinyEditorApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CbxFontSize = new System.Windows.Forms.ComboBox();
            this.RtbxEditor = new System.Windows.Forms.RichTextBox();
            this.PbxUnderline = new System.Windows.Forms.PictureBox();
            this.PbxPicture = new System.Windows.Forms.PictureBox();
            this.PbxStrikeout = new System.Windows.Forms.PictureBox();
            this.PbxItalic = new System.Windows.Forms.PictureBox();
            this.PbxAlignRight = new System.Windows.Forms.PictureBox();
            this.PbxAlignLeft = new System.Windows.Forms.PictureBox();
            this.PbxAlignCenter = new System.Windows.Forms.PictureBox();
            this.PbxFontColor = new System.Windows.Forms.PictureBox();
            this.PbxBold = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxStrikeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxItalic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBold)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxFontSize
            // 
            this.CbxFontSize.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CbxFontSize.FormattingEnabled = true;
            this.CbxFontSize.Location = new System.Drawing.Point(256, 9);
            this.CbxFontSize.Name = "CbxFontSize";
            this.CbxFontSize.Size = new System.Drawing.Size(150, 26);
            this.CbxFontSize.TabIndex = 21;
            this.CbxFontSize.Tag = "";
            // 
            // RtbxEditor
            // 
            this.RtbxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbxEditor.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RtbxEditor.Location = new System.Drawing.Point(12, 40);
            this.RtbxEditor.Name = "RtbxEditor";
            this.RtbxEditor.Size = new System.Drawing.Size(601, 305);
            this.RtbxEditor.TabIndex = 13;
            this.RtbxEditor.Text = "";
            // 
            // PbxUnderline
            // 
            this.PbxUnderline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxUnderline.Image = global::TinyEditorApp.Properties.Resources.UnderlineOff;
            this.PbxUnderline.Location = new System.Drawing.Point(60, 9);
            this.PbxUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.PbxUnderline.Name = "PbxUnderline";
            this.PbxUnderline.Size = new System.Drawing.Size(25, 25);
            this.PbxUnderline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxUnderline.TabIndex = 23;
            this.PbxUnderline.TabStop = false;
            this.PbxUnderline.Tag = "OFF";
            // 
            // PbxPicture
            // 
            this.PbxPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPicture.Image = ((System.Drawing.Image)(resources.GetObject("PbxPicture.Image")));
            this.PbxPicture.Location = new System.Drawing.Point(228, 9);
            this.PbxPicture.Margin = new System.Windows.Forms.Padding(0);
            this.PbxPicture.Name = "PbxPicture";
            this.PbxPicture.Padding = new System.Windows.Forms.Padding(3);
            this.PbxPicture.Size = new System.Drawing.Size(25, 25);
            this.PbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPicture.TabIndex = 22;
            this.PbxPicture.TabStop = false;
            this.PbxPicture.Tag = "フォントカラー";
            // 
            // PbxStrikeout
            // 
            this.PbxStrikeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxStrikeout.Image = global::TinyEditorApp.Properties.Resources.StrikeoutOff;
            this.PbxStrikeout.Location = new System.Drawing.Point(84, 9);
            this.PbxStrikeout.Margin = new System.Windows.Forms.Padding(0);
            this.PbxStrikeout.Name = "PbxStrikeout";
            this.PbxStrikeout.Size = new System.Drawing.Size(26, 25);
            this.PbxStrikeout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxStrikeout.TabIndex = 20;
            this.PbxStrikeout.TabStop = false;
            this.PbxStrikeout.Tag = "OFF";
            // 
            // PbxItalic
            // 
            this.PbxItalic.BackColor = System.Drawing.Color.Transparent;
            this.PbxItalic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxItalic.Image = global::TinyEditorApp.Properties.Resources.ItalicOff;
            this.PbxItalic.Location = new System.Drawing.Point(36, 9);
            this.PbxItalic.Margin = new System.Windows.Forms.Padding(0);
            this.PbxItalic.Name = "PbxItalic";
            this.PbxItalic.Size = new System.Drawing.Size(25, 25);
            this.PbxItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxItalic.TabIndex = 19;
            this.PbxItalic.TabStop = false;
            this.PbxItalic.Tag = "OFF";
            // 
            // PbxAlignRight
            // 
            this.PbxAlignRight.BackColor = System.Drawing.Color.Transparent;
            this.PbxAlignRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlignRight.Image = global::TinyEditorApp.Properties.Resources.AlignRightOff;
            this.PbxAlignRight.Location = new System.Drawing.Point(171, 9);
            this.PbxAlignRight.Margin = new System.Windows.Forms.Padding(0);
            this.PbxAlignRight.Name = "PbxAlignRight";
            this.PbxAlignRight.Size = new System.Drawing.Size(25, 25);
            this.PbxAlignRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlignRight.TabIndex = 18;
            this.PbxAlignRight.TabStop = false;
            this.PbxAlignRight.Tag = "OFF";
            // 
            // PbxAlignLeft
            // 
            this.PbxAlignLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlignLeft.Image = global::TinyEditorApp.Properties.Resources.AlignLeftOn;
            this.PbxAlignLeft.Location = new System.Drawing.Point(123, 9);
            this.PbxAlignLeft.Margin = new System.Windows.Forms.Padding(0);
            this.PbxAlignLeft.Name = "PbxAlignLeft";
            this.PbxAlignLeft.Size = new System.Drawing.Size(25, 25);
            this.PbxAlignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlignLeft.TabIndex = 17;
            this.PbxAlignLeft.TabStop = false;
            this.PbxAlignLeft.Tag = "ON";
            // 
            // PbxAlignCenter
            // 
            this.PbxAlignCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxAlignCenter.Image = global::TinyEditorApp.Properties.Resources.AlignCenterOff;
            this.PbxAlignCenter.Location = new System.Drawing.Point(147, 9);
            this.PbxAlignCenter.Margin = new System.Windows.Forms.Padding(0);
            this.PbxAlignCenter.Name = "PbxAlignCenter";
            this.PbxAlignCenter.Size = new System.Drawing.Size(25, 25);
            this.PbxAlignCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAlignCenter.TabIndex = 16;
            this.PbxAlignCenter.TabStop = false;
            this.PbxAlignCenter.Tag = "OFF";
            // 
            // PbxFontColor
            // 
            this.PbxFontColor.BackColor = System.Drawing.Color.Black;
            this.PbxFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxFontColor.Image = global::TinyEditorApp.Properties.Resources.Font;
            this.PbxFontColor.Location = new System.Drawing.Point(204, 9);
            this.PbxFontColor.Margin = new System.Windows.Forms.Padding(0);
            this.PbxFontColor.Name = "PbxFontColor";
            this.PbxFontColor.Size = new System.Drawing.Size(25, 25);
            this.PbxFontColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFontColor.TabIndex = 15;
            this.PbxFontColor.TabStop = false;
            this.PbxFontColor.Tag = "フォントカラー";
            // 
            // PbxBold
            // 
            this.PbxBold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxBold.Image = global::TinyEditorApp.Properties.Resources.BoldOff;
            this.PbxBold.Location = new System.Drawing.Point(12, 9);
            this.PbxBold.Margin = new System.Windows.Forms.Padding(0);
            this.PbxBold.Name = "PbxBold";
            this.PbxBold.Size = new System.Drawing.Size(25, 25);
            this.PbxBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBold.TabIndex = 14;
            this.PbxBold.TabStop = false;
            this.PbxBold.Tag = "OFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 372);
            this.Controls.Add(this.PbxUnderline);
            this.Controls.Add(this.PbxPicture);
            this.Controls.Add(this.CbxFontSize);
            this.Controls.Add(this.RtbxEditor);
            this.Controls.Add(this.PbxStrikeout);
            this.Controls.Add(this.PbxItalic);
            this.Controls.Add(this.PbxAlignRight);
            this.Controls.Add(this.PbxAlignLeft);
            this.Controls.Add(this.PbxAlignCenter);
            this.Controls.Add(this.PbxFontColor);
            this.Controls.Add(this.PbxBold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxStrikeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxItalic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAlignCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxUnderline;
        private System.Windows.Forms.PictureBox PbxPicture;
        private System.Windows.Forms.ComboBox CbxFontSize;
        private System.Windows.Forms.RichTextBox RtbxEditor;
        private System.Windows.Forms.PictureBox PbxStrikeout;
        private System.Windows.Forms.PictureBox PbxItalic;
        private System.Windows.Forms.PictureBox PbxAlignRight;
        private System.Windows.Forms.PictureBox PbxAlignLeft;
        private System.Windows.Forms.PictureBox PbxAlignCenter;
        private System.Windows.Forms.PictureBox PbxFontColor;
        private System.Windows.Forms.PictureBox PbxBold;
    }
}

