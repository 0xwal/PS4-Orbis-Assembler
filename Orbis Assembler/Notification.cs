using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbis_Assembler
{
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
            Hide();
        }
        public enum Mode
        {
            Success,
            Error,
            Information,
            White
        }
        public void Notify(string text, Mode mode)
        {
            Color backColor, fontColor = Color.White;
            switch (mode)
            {
                case Mode.Success:
                    backColor = Color.Green;
                    break;
                case Mode.Error:
                    backColor = Color.Red;
                    break;
                case Mode.White:
                    backColor = Color.White;
                    fontColor = Color.Black;
                    break;
                case Mode.Information:
                default:
                    backColor = Color.LightSkyBlue;
                    break;
            }
            BackColor = backColor;
            txtMessageBox.BackColor = backColor;
            txtMessageBox.ForeColor = fontColor;
            txtMessageBox.Text = text;
            Show();
        }
        public event EventHandler OnClose;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            if (OnClose != null)
                OnClose(this, EventArgs.Empty);
        }
    }
}
