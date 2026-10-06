namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 初始化 WebView2 控件
            await wvBrowser.EnsureCoreWebView2Async(null);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                // 导航到指定 URL
                wvBrowser.Source = new Uri(txtLink.Text);
            }
            catch(Exception err)
            {
                DialogResult dr = MessageBox.Show(String.Format("发生严重错误！\n{0}\n若要反馈异常，请访问：\"{1}\"或官方Github仓库的issue页面。",
                    err.Message, err.HelpLink), "OpenEdge", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                if(dr == DialogResult.Ignore) {  }else if (dr == DialogResult.Retry) { throw; }else if (dr == DialogResult.Continue) { } else { }
            }
        }
    }
}
