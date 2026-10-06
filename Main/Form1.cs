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
                string input = txtLink.Text?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("请输入有效的链接。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 如果想允许用户省略 scheme，可以选择自动补全（取消注释下一行）
                // if (!input.Contains("://")) input = "http://" + input;

                if (Uri.TryCreate(input, UriKind.Absolute, out Uri uriResult))
                {
                    wvBrowser.Source = uriResult;
                }
                else
                {
                    MessageBox.Show("无效的 URL，请检查格式，例如：http://example.com", "无效 URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                // 记录详细异常（可接入日志），并向用户显示简短错误信息。
                MessageBox.Show($"发生严重错误：{err.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 若需要将异常传递给上层以便调试，可使用 throw; 或 throw new Exception("说明", err);
            }
        }
    }
}
