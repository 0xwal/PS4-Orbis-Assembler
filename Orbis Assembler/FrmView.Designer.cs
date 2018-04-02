namespace Orbis_Assembler
{
    partial class FrmView
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
            this.notification = new Orbis_Assembler.Notification();
            this.SuspendLayout();
            // 
            // notification
            // 
            this.notification.BackColor = System.Drawing.Color.Transparent;
            this.notification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification.Location = new System.Drawing.Point(0, 0);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(486, 333);
            this.notification.TabIndex = 0;
            this.notification.Visible = false;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 333);
            this.Controls.Add(this.notification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmView";
            this.Text = "FrmView";
            this.ResumeLayout(false);

        }

        #endregion

        internal Notification notification;
    }
}