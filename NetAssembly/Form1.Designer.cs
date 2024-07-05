namespace NetAssembly
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Check_ControlFlow = new MetroFramework.Controls.MetroCheckBox();
            this.Check_FakeCode = new MetroFramework.Controls.MetroCheckBox();
            this.Check_StringEncryption = new MetroFramework.Controls.MetroCheckBox();
            this.Check_AntiDe4dot = new MetroFramework.Controls.MetroCheckBox();
            this.Check_Renamer = new MetroFramework.Controls.MetroCheckBox();
            this.WaterMark_txt = new MetroFramework.Controls.MetroTextBox();
            this.Check_WaterMark = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(540, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(20, 62);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(570, 31);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(596, 62);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 31);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "File Select";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(596, 310);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 32);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Obfuscate";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Check_ControlFlow
            // 
            this.Check_ControlFlow.AutoSize = true;
            this.Check_ControlFlow.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_ControlFlow.Location = new System.Drawing.Point(21, 108);
            this.Check_ControlFlow.Name = "Check_ControlFlow";
            this.Check_ControlFlow.Size = new System.Drawing.Size(129, 25);
            this.Check_ControlFlow.TabIndex = 3;
            this.Check_ControlFlow.Text = "Control Flow";
            this.Check_ControlFlow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_ControlFlow.UseSelectable = true;
            // 
            // Check_FakeCode
            // 
            this.Check_FakeCode.AutoSize = true;
            this.Check_FakeCode.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_FakeCode.Location = new System.Drawing.Point(21, 139);
            this.Check_FakeCode.Name = "Check_FakeCode";
            this.Check_FakeCode.Size = new System.Drawing.Size(110, 25);
            this.Check_FakeCode.TabIndex = 4;
            this.Check_FakeCode.Text = "Fake Code";
            this.Check_FakeCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_FakeCode.UseSelectable = true;
            // 
            // Check_StringEncryption
            // 
            this.Check_StringEncryption.AutoSize = true;
            this.Check_StringEncryption.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_StringEncryption.Location = new System.Drawing.Point(21, 170);
            this.Check_StringEncryption.Name = "Check_StringEncryption";
            this.Check_StringEncryption.Size = new System.Drawing.Size(163, 25);
            this.Check_StringEncryption.TabIndex = 6;
            this.Check_StringEncryption.Text = "String Encryption";
            this.Check_StringEncryption.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_StringEncryption.UseSelectable = true;
            // 
            // Check_AntiDe4dot
            // 
            this.Check_AntiDe4dot.AutoSize = true;
            this.Check_AntiDe4dot.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_AntiDe4dot.Location = new System.Drawing.Point(21, 201);
            this.Check_AntiDe4dot.Name = "Check_AntiDe4dot";
            this.Check_AntiDe4dot.Size = new System.Drawing.Size(125, 25);
            this.Check_AntiDe4dot.TabIndex = 7;
            this.Check_AntiDe4dot.Text = "Anti De4dot";
            this.Check_AntiDe4dot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_AntiDe4dot.UseSelectable = true;
            // 
            // Check_Renamer
            // 
            this.Check_Renamer.AutoSize = true;
            this.Check_Renamer.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_Renamer.Location = new System.Drawing.Point(20, 232);
            this.Check_Renamer.Name = "Check_Renamer";
            this.Check_Renamer.Size = new System.Drawing.Size(97, 25);
            this.Check_Renamer.TabIndex = 8;
            this.Check_Renamer.Text = "Renamer";
            this.Check_Renamer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_Renamer.UseSelectable = true;
            // 
            // WaterMark_txt
            // 
            // 
            // 
            // 
            this.WaterMark_txt.CustomButton.Image = null;
            this.WaterMark_txt.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.WaterMark_txt.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WaterMark_txt.CustomButton.Name = "";
            this.WaterMark_txt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.WaterMark_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WaterMark_txt.CustomButton.TabIndex = 1;
            this.WaterMark_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WaterMark_txt.CustomButton.UseSelectable = true;
            this.WaterMark_txt.CustomButton.Visible = false;
            this.WaterMark_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.WaterMark_txt.Lines = new string[0];
            this.WaterMark_txt.Location = new System.Drawing.Point(140, 317);
            this.WaterMark_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WaterMark_txt.MaxLength = 32767;
            this.WaterMark_txt.Name = "WaterMark_txt";
            this.WaterMark_txt.PasswordChar = '\0';
            this.WaterMark_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WaterMark_txt.SelectedText = "";
            this.WaterMark_txt.SelectionLength = 0;
            this.WaterMark_txt.SelectionStart = 0;
            this.WaterMark_txt.ShortcutsEnabled = true;
            this.WaterMark_txt.Size = new System.Drawing.Size(200, 25);
            this.WaterMark_txt.TabIndex = 9;
            this.WaterMark_txt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WaterMark_txt.UseSelectable = true;
            this.WaterMark_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WaterMark_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Check_WaterMark
            // 
            this.Check_WaterMark.AutoSize = true;
            this.Check_WaterMark.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Check_WaterMark.Location = new System.Drawing.Point(20, 316);
            this.Check_WaterMark.Name = "Check_WaterMark";
            this.Check_WaterMark.Size = new System.Drawing.Size(114, 25);
            this.Check_WaterMark.TabIndex = 10;
            this.Check_WaterMark.Text = "WaterMark";
            this.Check_WaterMark.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Check_WaterMark.UseSelectable = true;
            this.Check_WaterMark.CheckedChanged += new System.EventHandler(this.Check_WaterMark_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.Check_WaterMark);
            this.Controls.Add(this.WaterMark_txt);
            this.Controls.Add(this.Check_Renamer);
            this.Controls.Add(this.Check_AntiDe4dot);
            this.Controls.Add(this.Check_StringEncryption);
            this.Controls.Add(this.Check_FakeCode);
            this.Controls.Add(this.Check_ControlFlow);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = ".NET Obfuscator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroCheckBox Check_ControlFlow;
        private MetroFramework.Controls.MetroCheckBox Check_FakeCode;
        private MetroFramework.Controls.MetroCheckBox Check_StringEncryption;
        private MetroFramework.Controls.MetroCheckBox Check_AntiDe4dot;
        private MetroFramework.Controls.MetroCheckBox Check_Renamer;
        private MetroFramework.Controls.MetroTextBox WaterMark_txt;
        private MetroFramework.Controls.MetroCheckBox Check_WaterMark;
    }
}

