
namespace Timer
{
    partial class FormTop
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTop));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageTop = new System.Windows.Forms.TabPage();
            this.materialLabelSetTime = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTimer = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitchPageTop = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.materialButtonAramSet = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxSetTimeM = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxSetTimeH = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSwitchSetting = new MaterialSkin.Controls.MaterialSwitch();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialSliderSetTimeM = new MaterialSkin.Controls.MaterialSlider();
            this.materialSliderSetTimeH = new MaterialSkin.Controls.MaterialSlider();
            this.materialTabControl1.SuspendLayout();
            this.tabPageTop.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageTop);
            this.materialTabControl1.Controls.Add(this.tabPageSetting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(253, 209);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageTop
            // 
            this.tabPageTop.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTop.Controls.Add(this.materialLabelSetTime);
            this.tabPageTop.Controls.Add(this.materialLabelStatus);
            this.tabPageTop.Controls.Add(this.materialLabelTimer);
            this.tabPageTop.Controls.Add(this.materialSwitchPageTop);
            this.tabPageTop.ImageKey = "aram.png";
            this.tabPageTop.Location = new System.Drawing.Point(4, 23);
            this.tabPageTop.Name = "tabPageTop";
            this.tabPageTop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTop.Size = new System.Drawing.Size(245, 182);
            this.tabPageTop.TabIndex = 0;
            this.tabPageTop.Text = "Top";
            // 
            // materialLabelSetTime
            // 
            this.materialLabelSetTime.AutoSize = true;
            this.materialLabelSetTime.Depth = 0;
            this.materialLabelSetTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSetTime.Location = new System.Drawing.Point(6, 92);
            this.materialLabelSetTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSetTime.Name = "materialLabelSetTime";
            this.materialLabelSetTime.Size = new System.Drawing.Size(74, 19);
            this.materialLabelSetTime.TabIndex = 2;
            this.materialLabelSetTime.Text = "SET 00:00";
            // 
            // materialLabelStatus
            // 
            this.materialLabelStatus.AutoSize = true;
            this.materialLabelStatus.Depth = 0;
            this.materialLabelStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelStatus.Location = new System.Drawing.Point(134, 92);
            this.materialLabelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelStatus.Name = "materialLabelStatus";
            this.materialLabelStatus.Size = new System.Drawing.Size(42, 19);
            this.materialLabelStatus.TabIndex = 3;
            this.materialLabelStatus.Text = "STOP";
            // 
            // materialLabelTimer
            // 
            this.materialLabelTimer.AutoSize = true;
            this.materialLabelTimer.Depth = 0;
            this.materialLabelTimer.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTimer.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabelTimer.Location = new System.Drawing.Point(10, 5);
            this.materialLabelTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTimer.Name = "materialLabelTimer";
            this.materialLabelTimer.Size = new System.Drawing.Size(225, 72);
            this.materialLabelTimer.TabIndex = 1;
            this.materialLabelTimer.Text = "00:00:00";
            // 
            // materialSwitchPageTop
            // 
            this.materialSwitchPageTop.AutoSize = true;
            this.materialSwitchPageTop.Depth = 0;
            this.materialSwitchPageTop.Location = new System.Drawing.Point(184, 83);
            this.materialSwitchPageTop.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchPageTop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchPageTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchPageTop.Name = "materialSwitchPageTop";
            this.materialSwitchPageTop.Ripple = true;
            this.materialSwitchPageTop.Size = new System.Drawing.Size(58, 37);
            this.materialSwitchPageTop.TabIndex = 0;
            this.materialSwitchPageTop.UseVisualStyleBackColor = true;
            this.materialSwitchPageTop.CheckedChanged += new System.EventHandler(this.materialSwitchPageTop_CheckedChanged);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSetting.Controls.Add(this.materialSliderSetTimeM);
            this.tabPageSetting.Controls.Add(this.materialSliderSetTimeH);
            this.tabPageSetting.Controls.Add(this.materialButtonAramSet);
            this.tabPageSetting.Controls.Add(this.materialComboBoxSetTimeM);
            this.tabPageSetting.Controls.Add(this.materialComboBoxSetTimeH);
            this.tabPageSetting.Controls.Add(this.materialSwitchSetting);
            this.tabPageSetting.ImageKey = "setting.png";
            this.tabPageSetting.Location = new System.Drawing.Point(4, 23);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(245, 182);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "Setting";
            // 
            // materialButtonAramSet
            // 
            this.materialButtonAramSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAramSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAramSet.Depth = 0;
            this.materialButtonAramSet.DrawShadows = true;
            this.materialButtonAramSet.HighEmphasis = true;
            this.materialButtonAramSet.Icon = null;
            this.materialButtonAramSet.Location = new System.Drawing.Point(194, 49);
            this.materialButtonAramSet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAramSet.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAramSet.Name = "materialButtonAramSet";
            this.materialButtonAramSet.Size = new System.Drawing.Size(47, 36);
            this.materialButtonAramSet.TabIndex = 5;
            this.materialButtonAramSet.Text = "SET";
            this.materialButtonAramSet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonAramSet.UseAccentColor = false;
            this.materialButtonAramSet.UseVisualStyleBackColor = true;
            this.materialButtonAramSet.Click += new System.EventHandler(this.materialButtonAramSet_Click);
            // 
            // materialComboBoxSetTimeM
            // 
            this.materialComboBoxSetTimeM.AutoResize = false;
            this.materialComboBoxSetTimeM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSetTimeM.Depth = 0;
            this.materialComboBoxSetTimeM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSetTimeM.DropDownHeight = 174;
            this.materialComboBoxSetTimeM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSetTimeM.DropDownWidth = 121;
            this.materialComboBoxSetTimeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSetTimeM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSetTimeM.FormattingEnabled = true;
            this.materialComboBoxSetTimeM.IntegralHeight = false;
            this.materialComboBoxSetTimeM.ItemHeight = 43;
            this.materialComboBoxSetTimeM.Items.AddRange(new object[] {
            "0分",
            "1分",
            "2分",
            "3分",
            "4分",
            "5分",
            "6分",
            "7分",
            "8分",
            "9分",
            "10分",
            "11分",
            "12分",
            "13分",
            "14分",
            "15分",
            "16分",
            "17分",
            "18分",
            "19分",
            "20分",
            "21分",
            "22分",
            "23分",
            "24分",
            "25分",
            "26分",
            "27分",
            "28分",
            "29分",
            "30分",
            "31分",
            "32分",
            "33分",
            "34分",
            "35分",
            "36分",
            "37分",
            "38分",
            "39分",
            "40分",
            "41分",
            "42分",
            "43分",
            "44分",
            "45分",
            "46分",
            "47分",
            "48分",
            "49分",
            "50分",
            "51分",
            "52分",
            "53分",
            "54分",
            "55分",
            "56分",
            "57分",
            "58分",
            "59分"});
            this.materialComboBoxSetTimeM.Location = new System.Drawing.Point(103, 43);
            this.materialComboBoxSetTimeM.MaxDropDownItems = 4;
            this.materialComboBoxSetTimeM.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSetTimeM.Name = "materialComboBoxSetTimeM";
            this.materialComboBoxSetTimeM.Size = new System.Drawing.Size(85, 49);
            this.materialComboBoxSetTimeM.StartIndex = 0;
            this.materialComboBoxSetTimeM.TabIndex = 2;
            this.materialComboBoxSetTimeM.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxSetTimeM_SelectedIndexChanged);
            // 
            // materialComboBoxSetTimeH
            // 
            this.materialComboBoxSetTimeH.AutoResize = false;
            this.materialComboBoxSetTimeH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSetTimeH.Depth = 0;
            this.materialComboBoxSetTimeH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSetTimeH.DropDownHeight = 174;
            this.materialComboBoxSetTimeH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSetTimeH.DropDownWidth = 121;
            this.materialComboBoxSetTimeH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSetTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSetTimeH.FormattingEnabled = true;
            this.materialComboBoxSetTimeH.IntegralHeight = false;
            this.materialComboBoxSetTimeH.ItemHeight = 43;
            this.materialComboBoxSetTimeH.Items.AddRange(new object[] {
            "0時",
            "1時",
            "2時",
            "3時",
            "4時",
            "5時",
            "6時",
            "7時",
            "8時",
            "9時",
            "10時",
            "11時",
            "12時",
            "13時",
            "14時",
            "15時",
            "16時",
            "17時",
            "18時",
            "19時",
            "20時",
            "21時",
            "22時",
            "23時"});
            this.materialComboBoxSetTimeH.Location = new System.Drawing.Point(6, 43);
            this.materialComboBoxSetTimeH.MaxDropDownItems = 4;
            this.materialComboBoxSetTimeH.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSetTimeH.Name = "materialComboBoxSetTimeH";
            this.materialComboBoxSetTimeH.Size = new System.Drawing.Size(85, 49);
            this.materialComboBoxSetTimeH.StartIndex = 0;
            this.materialComboBoxSetTimeH.TabIndex = 1;
            this.materialComboBoxSetTimeH.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxSetTimeH_SelectedIndexChanged);
            // 
            // materialSwitchSetting
            // 
            this.materialSwitchSetting.AutoSize = true;
            this.materialSwitchSetting.Checked = true;
            this.materialSwitchSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchSetting.Depth = 0;
            this.materialSwitchSetting.Location = new System.Drawing.Point(3, 3);
            this.materialSwitchSetting.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchSetting.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchSetting.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchSetting.Name = "materialSwitchSetting";
            this.materialSwitchSetting.Ripple = true;
            this.materialSwitchSetting.Size = new System.Drawing.Size(154, 37);
            this.materialSwitchSetting.TabIndex = 0;
            this.materialSwitchSetting.Text = "TIMER MODE";
            this.materialSwitchSetting.UseVisualStyleBackColor = true;
            this.materialSwitchSetting.CheckedChanged += new System.EventHandler(this.materialSwitchSetting_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "setting.png");
            this.imageList1.Images.SetKeyName(1, "aram.png");
            this.imageList1.Images.SetKeyName(2, "aram2.png");
            this.imageList1.Images.SetKeyName(3, "clock.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialSliderSetTimeM
            // 
            this.materialSliderSetTimeM.Depth = 0;
            this.materialSliderSetTimeM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderSetTimeM.Location = new System.Drawing.Point(97, 92);
            this.materialSliderSetTimeM.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderSetTimeM.Name = "materialSliderSetTimeM";
            this.materialSliderSetTimeM.ShowText = false;
            this.materialSliderSetTimeM.ShowValue = false;
            this.materialSliderSetTimeM.Size = new System.Drawing.Size(145, 40);
            this.materialSliderSetTimeM.TabIndex = 4;
            this.materialSliderSetTimeM.Text = "";
            this.materialSliderSetTimeM.Value = 0;
            this.materialSliderSetTimeM.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderSetTimeM_onValueChanged);
            // 
            // materialSliderSetTimeH
            // 
            this.materialSliderSetTimeH.Depth = 0;
            this.materialSliderSetTimeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderSetTimeH.Location = new System.Drawing.Point(1, 92);
            this.materialSliderSetTimeH.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderSetTimeH.Name = "materialSliderSetTimeH";
            this.materialSliderSetTimeH.ShowText = false;
            this.materialSliderSetTimeH.ShowValue = false;
            this.materialSliderSetTimeH.Size = new System.Drawing.Size(91, 40);
            this.materialSliderSetTimeH.TabIndex = 3;
            this.materialSliderSetTimeH.Text = "";
            this.materialSliderSetTimeH.Value = 0;
            this.materialSliderSetTimeH.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderSetTimeH_onValueChanged);
            // 
            // FormTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 215);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTop_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageTop.ResumeLayout(false);
            this.tabPageTop.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageTop;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchPageTop;
        private System.Windows.Forms.TabPage tabPageSetting;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchSetting;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabelTimer;
        private MaterialSkin.Controls.MaterialLabel materialLabelSetTime;
        private MaterialSkin.Controls.MaterialLabel materialLabelStatus;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSetTimeM;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSetTimeH;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialButton materialButtonAramSet;
        private MaterialSkin.Controls.MaterialSlider materialSliderSetTimeH;
        private MaterialSkin.Controls.MaterialSlider materialSliderSetTimeM;
    }
}

