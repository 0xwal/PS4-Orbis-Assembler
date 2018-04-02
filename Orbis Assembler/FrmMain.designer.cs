namespace Orbis_Assembler
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCompile = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuPpcCod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ppcCodeSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOpcodeBox = new System.Windows.Forms.RichTextBox();
            this.menuOpCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btncsharpCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIp = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecuteToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOffsetBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.offsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnWrite = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkTop = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtASMScriptBox = new AboControls.UserControls.NumberedRTB();
            this.chkMASMSyntax = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.notification = new Orbis_Assembler.Notification();
            this.menuPpcCod.SuspendLayout();
            this.menuOpCode.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompile
            // 
            this.btnCompile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCompile.AutoSize = true;
            this.btnCompile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompile.Depth = 0;
            this.btnCompile.Location = new System.Drawing.Point(178, 553);
            this.btnCompile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Primary = false;
            this.btnCompile.Size = new System.Drawing.Size(70, 36);
            this.btnCompile.TabIndex = 0;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // menuPpcCod
            // 
            this.menuPpcCod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ppcCodeSaveAs});
            this.menuPpcCod.Name = "menuPpcCod";
            this.menuPpcCod.Size = new System.Drawing.Size(115, 26);
            // 
            // ppcCodeSaveAs
            // 
            this.ppcCodeSaveAs.Name = "ppcCodeSaveAs";
            this.ppcCodeSaveAs.Size = new System.Drawing.Size(114, 22);
            this.ppcCodeSaveAs.Text = "Save As";
            // 
            // txtOpcodeBox
            // 
            this.txtOpcodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpcodeBox.BackColor = System.Drawing.Color.White;
            this.txtOpcodeBox.ContextMenuStrip = this.menuOpCode;
            this.txtOpcodeBox.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtOpcodeBox.Location = new System.Drawing.Point(281, 122);
            this.txtOpcodeBox.Name = "txtOpcodeBox";
            this.txtOpcodeBox.Size = new System.Drawing.Size(151, 368);
            this.txtOpcodeBox.TabIndex = 2;
            this.txtOpcodeBox.Text = "";
            this.txtOpcodeBox.TextChanged += new System.EventHandler(this.onTextChangedRemoveNonValid);
            // 
            // menuOpCode
            // 
            this.menuOpCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuOpCode.Name = "menuPpcCod";
            this.menuOpCode.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncsharpCopy});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "Copy As";
            // 
            // btncsharpCopy
            // 
            this.btncsharpCopy.Name = "btncsharpCopy";
            this.btncsharpCopy.Size = new System.Drawing.Size(89, 22);
            this.btncsharpCopy.Text = "C#";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "ASM Code";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(277, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "OpCode";
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(5, 565);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(68, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "optsMenu";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtIp,
            this.btnConnect,
            this.btnExecuteToggle});
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.connectToolStripMenuItem.Text = "Options";
            // 
            // txtIp
            // 
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 23);
            this.txtIp.Text = "192.168.100.8";
            // 
            // btnConnect
            // 
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(162, 22);
            this.btnConnect.Text = "Connect / Attach";
            // 
            // btnExecuteToggle
            // 
            this.btnExecuteToggle.Name = "btnExecuteToggle";
            this.btnExecuteToggle.Size = new System.Drawing.Size(162, 22);
            this.btnExecuteToggle.Text = "Execute To PS4";
            // 
            // txtOffsetBox
            // 
            this.txtOffsetBox.Depth = 0;
            this.txtOffsetBox.Hint = "";
            this.txtOffsetBox.Location = new System.Drawing.Point(64, 70);
            this.txtOffsetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOffsetBox.Name = "txtOffsetBox";
            this.txtOffsetBox.PasswordChar = '\0';
            this.txtOffsetBox.SelectedText = "";
            this.txtOffsetBox.SelectionLength = 0;
            this.txtOffsetBox.SelectionStart = 0;
            this.txtOffsetBox.Size = new System.Drawing.Size(211, 23);
            this.txtOffsetBox.TabIndex = 7;
            this.txtOffsetBox.UseSystemPasswordChar = false;
            this.txtOffsetBox.Visible = false;
            this.txtOffsetBox.TextChanged += new System.EventHandler(this.onTextChangedRemoveNonValid);
            // 
            // offsLbl
            // 
            this.offsLbl.AutoSize = true;
            this.offsLbl.Depth = 0;
            this.offsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.offsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.offsLbl.Location = new System.Drawing.Point(8, 74);
            this.offsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.offsLbl.Name = "offsLbl";
            this.offsLbl.Size = new System.Drawing.Size(50, 19);
            this.offsLbl.TabIndex = 8;
            this.offsLbl.Text = "Offset";
            this.offsLbl.Visible = false;
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.AutoSize = true;
            this.btnWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWrite.Depth = 0;
            this.btnWrite.Location = new System.Drawing.Point(302, 553);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Primary = false;
            this.btnWrite.Size = new System.Drawing.Size(131, 36);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write in Memory";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Visible = false;
            // 
            // chkTop
            // 
            this.chkTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTop.AutoSize = true;
            this.chkTop.Depth = 0;
            this.chkTop.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkTop.Location = new System.Drawing.Point(379, 70);
            this.chkTop.Margin = new System.Windows.Forms.Padding(0);
            this.chkTop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTop.Name = "chkTop";
            this.chkTop.Ripple = true;
            this.chkTop.Size = new System.Drawing.Size(54, 30);
            this.chkTop.TabIndex = 10;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // txtASMScriptBox
            // 
            this.txtASMScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtASMScriptBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtASMScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtASMScriptBox.ContextMenuStrip = this.menuPpcCod;
            this.txtASMScriptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASMScriptBox.Location = new System.Drawing.Point(12, 122);
            this.txtASMScriptBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtASMScriptBox.Name = "txtASMScriptBox";
            this.txtASMScriptBox.Size = new System.Drawing.Size(263, 368);
            this.txtASMScriptBox.TabIndex = 11;
            // 
            // chkMASMSyntax
            // 
            this.chkMASMSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMASMSyntax.AutoSize = true;
            this.chkMASMSyntax.Checked = true;
            this.chkMASMSyntax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMASMSyntax.Depth = 0;
            this.chkMASMSyntax.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkMASMSyntax.Location = new System.Drawing.Point(315, 70);
            this.chkMASMSyntax.Margin = new System.Windows.Forms.Padding(0);
            this.chkMASMSyntax.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMASMSyntax.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMASMSyntax.Name = "chkMASMSyntax";
            this.chkMASMSyntax.Ripple = true;
            this.chkMASMSyntax.Size = new System.Drawing.Size(57, 30);
            this.chkMASMSyntax.TabIndex = 12;
            this.chkMASMSyntax.Text = "Intel";
            this.chkMASMSyntax.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(302, 449);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(102, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "disassemble";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // notification
            // 
            this.notification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notification.BackColor = System.Drawing.Color.Transparent;
            this.notification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notification.Location = new System.Drawing.Point(12, 491);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(420, 53);
            this.notification.TabIndex = 14;
            this.notification.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 593);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.chkMASMSyntax);
            this.Controls.Add(this.txtASMScriptBox);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.offsLbl);
            this.Controls.Add(this.txtOffsetBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtOpcodeBox);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orbis Assembler";
            this.menuPpcCod.ResumeLayout(false);
            this.menuOpCode.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCompile;
        private System.Windows.Forms.RichTextBox txtOpcodeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOffsetBox;
        private MaterialSkin.Controls.MaterialLabel offsLbl;
        private MaterialSkin.Controls.MaterialFlatButton btnWrite;
        private MaterialSkin.Controls.MaterialCheckBox chkTop;
        private System.Windows.Forms.ContextMenuStrip menuPpcCod;
        private System.Windows.Forms.ToolStripMenuItem ppcCodeSaveAs;
        private System.Windows.Forms.ContextMenuStrip menuOpCode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btncsharpCopy;
        private AboControls.UserControls.NumberedRTB txtASMScriptBox;
        private System.Windows.Forms.ToolStripMenuItem btnExecuteToggle;
        private MaterialSkin.Controls.MaterialCheckBox chkMASMSyntax;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Notification notification;
        private System.Windows.Forms.ToolStripTextBox txtIp;
    }
}

