using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using PS4Lib;

namespace Orbis_Assembler
{
    public partial class FrmMain : MaterialForm
    {
        private static PS4API PS4 => new PS4API();
        private readonly string _localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\BISOON Projects\Orbis Assembler\";
        private const string orbis_as = "orbis-as.exe";
        private const string orbis_objcopy = "orbis-objcopy.exe";
        private const string orbis_objdump = "orbis-objdump.exe";
        private const string script = "script";

 
        private string SaveData
        {
            get
            {
                if (File.Exists(_localPath + "data"))
                {
                    return File.ReadAllText(_localPath + "data");
                }
                return "";
            }
            set => File.WriteAllText(_localPath + "data", value);
        }
        private void Init()
        {
            MinimumSize = new Size(420, 434);
            txtASMScriptBox.RichTextBox.ContextMenuStrip = menuPpcCod;
            txtASMScriptBox.Strip.BackColor = Color.White;
            txtASMScriptBox.Strip.Size = new Size(1, 1);
            txtASMScriptBox.RichTextBox.Font = new Font("Arial", 9.5f, FontStyle.Bold);
            txtASMScriptBox.RichTextBox.ForeColor = (Color)new ColorConverter().ConvertFromString("#555555");
            txtASMScriptBox.Strip.Font = new Font("", 7f, FontStyle.Bold);
            txtASMScriptBox.Strip.OffsetColor = Color.White;
            txtASMScriptBox.Strip.Style = AboControls.UserControls.LineNumberStyle.Boxed;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public FrmMain()
        {
            InitializeComponent();
            Init();
            chkTop.CheckedChanged += delegate { TopMost = chkTop.Checked; };
            Click += delegate
            {
                SaveData = txtASMScriptBox.RichTextBox.Text;
            };
           
            SaveFileDialog sv = new SaveFileDialog();
            ppcCodeSaveAs.Click += delegate
            {
                sv.Filter = "ASM Code|*.asm";
                sv.FileName = "ASM Code";
                if (sv.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sv.FileName, txtASMScriptBox.RichTextBox.Text);
            };
            btncsharpCopy.Click += delegate
            {
                Helper.CopyAsCsharp(txtOpcodeBox.Text);
                notification.Notify("Copied!", Notification.Mode.Success);
            };
           
            if (!Directory.Exists(_localPath))
                Directory.CreateDirectory(_localPath);
            Helper.LoadFile(orbis_as, _localPath);
            Helper.LoadFile(orbis_objcopy, _localPath);
            Helper.LoadFile(orbis_objdump, _localPath);
           
            btnWrite.Click += delegate
            {
                try
                {
                    if (txtOffsetBox.TextLength < 1 && txtOpcodeBox.TextLength < 1)
                        return;
                    byte[] input = Helper.Hex(txtOpcodeBox.Text);
                    PS4.SetMemory(Convert.ToUInt64(Helper.OnlyHexValues(txtOffsetBox.Text), 0x10), input);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            };
            btnConnect.Click += delegate
            {
                btnConnect.ForeColor = 
                (PS4.ConnectTarget(txtIp.Text) && PS4.AttachProcess()) 
                ? Color.Green 
                : Color.Red;
            };
            btnExecuteToggle.Click += delegate
            {
                if (!btnExecuteToggle.Checked)
                {
                    txtOffsetBox.Visible = true;
                    offsLbl.Visible = true;
                    btnWrite.Visible = true;
                    btnExecuteToggle.CheckState = CheckState.Checked;
                    return;
                }
                txtOffsetBox.Visible = false;
                offsLbl.Visible = false;
                btnWrite.Visible = false;
                btnExecuteToggle.CheckState = CheckState.Unchecked;
            };
            txtASMScriptBox.RichTextBox.Text = SaveData;
        }
       
        private bool Assemble(out string standardOutput)
        {
            string isIntel = chkMASMSyntax.Checked ? "-mmnemonic=intel  -msyntax=intel -mnaked-reg" : string.Empty;
            string flags = $"{isIntel} -W";
            Helper.Cmd(_localPath + orbis_as, script + " -o " + script + ".bin " + flags, out standardOutput);
            return !standardOutput.ToLower().Contains("error");
        }
        private bool ExtractBinary()
        {
            string standardOutput;
            Helper.Cmd(_localPath + orbis_objcopy, script + ".bin -O binary", out standardOutput);
            return !standardOutput.ToLower().Contains("no such");
        }
        private void Disassemble(string input, out string standardOutput)
        {
            if (input.Length > 1)
            {
                File.WriteAllBytes(_localPath + script + ".dis", Helper.Hex(input));
                string flags = chkMASMSyntax.Checked ? ",intel" : string.Empty;
                Helper.Cmd(_localPath + orbis_objdump, $"-D -b binary -mi386 -Mx86-64{flags} " + script + ".dis", out standardOutput);
                return;
            }
            standardOutput = string.Empty;
        }
        private void btnCompile_Click(object sender, EventArgs e)
        {
            Helper.SafeDelete(_localPath + script);
            Helper.SafeDelete(_localPath + script + ".bin");
            File.WriteAllText(_localPath + script, txtASMScriptBox.RichTextBox.Text);
            notification.Hide();
            if (!Assemble(out string outPutCmd))
            {
                notification.Notify(outPutCmd, Notification.Mode.Error);
                return;
            }
            if (!File.Exists(_localPath + script + ".bin"))
                return;
            if (!ExtractBinary())
                return;
            byte[] outArray = File.ReadAllBytes(_localPath + "script.bin");
            notification.Notify($"Done! (Length: {outArray.Length})", Notification.Mode.Success);
            txtOpcodeBox.Text = BitConverter.ToString(outArray).Replace("-", " ");
            SaveData = txtASMScriptBox.RichTextBox.Text;
        }

        private void btnDisassemble_Click(object sender, EventArgs e)
        {
            string code;
            Disassemble(txtOpcodeBox.Text, out code);
            using (FrmView frmView = new FrmView())
            {
                frmView.StartPosition = FormStartPosition.CenterScreen;
                frmView.notification.Notify(code, Notification.Mode.White);
                frmView.ShowDialog();
            }
        }

        private void onTextChangedRemoveNonHexDecimal(object sender, EventArgs e)
        {
            Control currentControl = sender as Control;
            
            currentControl.Text = Helper.OnlyHexValues(currentControl.Text);
        }
    }
}