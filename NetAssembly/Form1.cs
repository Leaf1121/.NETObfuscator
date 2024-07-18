using dnlib.DotNet;
using dnlib.DotNet.Writer;
using NetAssembly.Protection;
using NetAssembly.Protection.Renamer;
using NetAssembly.Protection.StringEncryption;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetAssembly.Log;

namespace NetAssembly
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTextBox1.Enabled = false;
            WaterMark_txt.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LogUtil.SaveLog("File Select Click!");
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "All File | *.*| exe File | *.exe| dll File | *.dll"
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = ofd.FileName;
                filePath = ofd.FileName;
                LogUtil.SaveLog($"File Select - {filePath}");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            LogUtil.SaveLog("Obfuscate Click!");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Select File!!");
                LogUtil.SaveLog("Obfuscator Cancel - Not Select File");
                return;
            }
            if (!Check_ControlFlow.Checked && !Check_FakeCode.Checked && !Check_StringEncryption.Checked && !Check_AntiDe4dot.Checked && !Check_Renamer.Checked)
            {
                MessageBox.Show("Select Option!!");
                LogUtil.SaveLog("Obfuscator Cancel - Not Select Option");
                return;
            }
            if(Check_WaterMark.Checked && WaterMark_txt.Text == "")
            {
                MessageBox.Show("Please enter a WaterMark");
                LogUtil.SaveLog("Obfuscator Cancel - Not insert WaterMark");
                return;
            }
            LogUtil.SaveLog("--------------------Obfuscate Start--------------------");
            metroTabControl1.SelectedTab = this.metroTabPage2;
            metroTextBox2.Text += "Obfuscation Starting...\r\n\r\n";
            Application.DoEvents();

            ModuleDefMD module = ModuleDefMD.Load(filePath);

            if (Check_ControlFlow.Checked)
            {
                ControlFlowObfuscation.CtrlFlow(module);
                metroTextBox2.Text += "Success Control Flow\r\n";
                LogUtil.SaveLog("Success Control Flow");
                Application.DoEvents();
            }
            if (Check_FakeCode.Checked)
            {
                FakeCode.Execute(module);
                metroTextBox2.Text += "Success Fake Code\r\n";
                LogUtil.SaveLog("Success Fake Code");
                Application.DoEvents();
            }
            if (Check_StringEncryption.Checked)
            {
                stringEncryption.Inject(module);
                metroTextBox2.Text += "Success StringEncryption\r\n";
                LogUtil.SaveLog("Success StringEncryption");
                Application.DoEvents();
            }
            if (Check_AntiDe4dot.Checked)
            {
                antiDe4dot.Execute(module.Assembly);
                metroTextBox2.Text += "Success Anti De4dot\r\n";
                LogUtil.SaveLog("Success Anti De4dot");
                Application.DoEvents();
            }
            if (Check_Renamer.Checked)
            {
                RenamerPhase.ExecuteNamespaceRenaming(module);
                metroTextBox2.Text += "Namespace Renaming Success\r\n";
                LogUtil.SaveLog("Success Namespace Rename");
                Application.DoEvents();

                RenamerPhase.ExecuteModuleRenaming(module);
                metroTextBox2.Text += "Module Renaming Success\r\n";
                LogUtil.SaveLog("Success Module Rename");
                Application.DoEvents();

                RenamerPhase.ExecuteClassRenaming(module);
                metroTextBox2.Text += "Class Renaming Success\r\n";
                LogUtil.SaveLog("Success Class Rename");
                Application.DoEvents();

                RenamerPhase.ExecutePropertiesRenaming(module);
                metroTextBox2.Text += "Properties Renaming Success\r\n";
                LogUtil.SaveLog("Success Properties Rename");
                Application.DoEvents();

                RenamerPhase.ExecuteFieldRenaming(module);
                metroTextBox2.Text += "Field Renaming Success\r\n";
                LogUtil.SaveLog("Success Field Rename");
                Application.DoEvents();

                RenamerPhase.ExecuteMethodRenaming(module);
                metroTextBox2.Text += "Method Renaming Success\r\n";
                LogUtil.SaveLog("Success Method Rename");
                Application.DoEvents();
            }
            if (Check_WaterMark.Checked)
            {
                WaterMark.Execute(module, WaterMark_txt.Text);
                metroTextBox2.Text += "Success Add WaterMark!\r\n";
                LogUtil.SaveLog($"Success Add WaterMark({WaterMark_txt.Text})");
                Application.DoEvents();
            }

            metroTextBox2.Text += "\r\nObfuscation Finish!!\r\n";
            SaveAssembly(module);
            LogUtil.SaveLog($"Save Obfuscate File - {Path.GetDirectoryName(module.Location) + Path.GetFileNameWithoutExtension(module.Location) + "_obfuscated" + Path.GetExtension(module.Location)}");
            LogUtil.SaveLog("--------------------Obfuscate Finish--------------------");
            Application.DoEvents();
            
        }

        public static void SaveAssembly(ModuleDefMD module)
        {
            string AssemblyPath = Path.GetDirectoryName(module.Location);
            if (!AssemblyPath.EndsWith("\\")) AssemblyPath += "\\";

            string savePath = AssemblyPath + Path.GetFileNameWithoutExtension(module.Location) + "_obfuscated" + Path.GetExtension(module.Location);
            var opts = new ModuleWriterOptions(module)
            {
                Logger = DummyLogger.NoThrowInstance
            };

            module.Write(savePath, opts);
            MessageBox.Show("Done.");
        }

        private void Check_WaterMark_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_WaterMark.Checked)
            {
                WaterMark_txt.Enabled = true;
                WaterMark_txt.Focus();
            }
            else
            {
                WaterMark_txt.Enabled = false;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }
    }
}
