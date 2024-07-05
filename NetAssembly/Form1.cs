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
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "All File | *.*| exe File | *.exe| dll File | *.dll"
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = ofd.FileName;
                filePath = ofd.FileName;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (!Check_ControlFlow.Checked && !Check_FakeCode.Checked && !Check_StringEncryption.Checked && !Check_AntiDe4dot.Checked && !Check_Renamer.Checked)
            {
                MessageBox.Show("Select Option");
                return;
            }
            if(Check_WaterMark.Checked && WaterMark_txt.Text == "")
            {
                MessageBox.Show("Please enter a phrase");
                return;
            }

            ModuleDefMD module = ModuleDefMD.Load(filePath);

            if (Check_ControlFlow.Checked) ControlFlowObfuscation.CtrlFlow(module);
            if (Check_FakeCode.Checked) FakeCode.Execute(module);
            if (Check_StringEncryption.Checked) stringEncryption.Inject(module);
            if (Check_AntiDe4dot.Checked) antiDe4dot.Execute(module.Assembly);
            if (Check_Renamer.Checked)
            {
                RenamerPhase.ExecuteNamespaceRenaming(module);
                RenamerPhase.ExecuteModuleRenaming(module);
                RenamerPhase.ExecuteClassRenaming(module);
                RenamerPhase.ExecutePropertiesRenaming(module);
                RenamerPhase.ExecuteFieldRenaming(module);
                RenamerPhase.ExecuteMethodRenaming(module);
            }
            if (Check_WaterMark.Checked) WaterMark.Execute(module, WaterMark_txt.Text);

            SaveAssembly(module, filePath);
        }

        public static void SaveAssembly(ModuleDefMD module, string path)
        {
            string AssemblyPath = Path.GetDirectoryName(module.Location);
            if (!AssemblyPath.EndsWith("\\")) AssemblyPath += "\\";

            string savePath = AssemblyPath + Path.GetFileNameWithoutExtension(module.Location) + "_obfuscated" + Path.GetExtension(module.Location);
            var opts = new ModuleWriterOptions(module);
            opts.Logger = DummyLogger.NoThrowInstance;

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
    }
}
