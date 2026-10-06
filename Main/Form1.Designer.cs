namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wvBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
            txtLink = new TextBox();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)wvBrowser).BeginInit();
            SuspendLayout();
            // 
            // wvBrowser
            // 
            wvBrowser.AllowExternalDrop = true;
            wvBrowser.CreationProperties = null;
            wvBrowser.DefaultBackgroundColor = Color.White;
            wvBrowser.Location = new Point(-1, 50);
            wvBrowser.Name = "wvBrowser";
            wvBrowser.Size = new Size(801, 401);
            wvBrowser.TabIndex = 0;
            wvBrowser.ZoomFactor = 1D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "地址：";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(50, 16);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(669, 23);
            txtLink.TabIndex = 2;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(725, 16);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 3;
            btnGo.Text = "前往";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGo);
            Controls.Add(txtLink);
            Controls.Add(label1);
            Controls.Add(wvBrowser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvBrowser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvBrowser;
        private Label label1;
        private TextBox txtLink;
        private Button btnGo;
    }
}
