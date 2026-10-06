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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)wvBrowser).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // wvBrowser
            // 
            wvBrowser.AllowExternalDrop = true;
            wvBrowser.CreationProperties = null;
            wvBrowser.DefaultBackgroundColor = Color.White;
            wvBrowser.Dock = DockStyle.Fill;
            wvBrowser.Location = new Point(0, 0);
            wvBrowser.Name = "wvBrowser";
            wvBrowser.Size = new Size(896, 513);
            wvBrowser.TabIndex = 0;
            wvBrowser.ZoomFactor = 1D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 58);
            label1.TabIndex = 1;
            label1.Text = "地址：";
            // 
            // txtLink
            // 
            txtLink.Dock = DockStyle.Fill;
            txtLink.Location = new Point(53, 3);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(732, 23);
            txtLink.TabIndex = 2;
            // 
            // btnGo
            // 
            btnGo.Dock = DockStyle.Fill;
            btnGo.Location = new Point(791, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(102, 52);
            btnGo.TabIndex = 3;
            btnGo.Text = "前往";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGo, 2, 0);
            tableLayoutPanel1.Controls.Add(txtLink, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(896, 58);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 513);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(wvBrowser);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvBrowser).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvBrowser;
        private Label label1;
        private TextBox txtLink;
        private Button btnGo;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
