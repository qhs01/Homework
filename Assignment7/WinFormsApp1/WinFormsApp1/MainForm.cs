using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Crawler crawler = new Crawler();

        private void start_button_Click(object sender, EventArgs e)
        {
            crawler.Starturl=starturl_text.Text;
            crawler.Seturl="";
            crawler.startcrawl();
            var newright = crawler.righturl.Select(x => new { url_text = x.Text_url });
            var newwrong = crawler.wrongurl.Select(x => new { url_text = x.Text_url });
            righturl_dataGridView.DataSource = newright.ToList();
            wrongurl_dataGridView.DataSource = newwrong.ToList();
        }

        private void start_button2_Click(object sender, EventArgs e)
        {
            crawler.Starturl = starturl_text.Text;
            crawler.Seturl = seturl_text.Text;
            crawler.startcrawl();
            var newright = crawler.righturl.Select(x => new { url_text = x.Text_url });
            var newwrong = crawler.wrongurl.Select(x => new { url_text = x.Text_url });
            righturl_dataGridView.DataSource = newright.ToList();
            wrongurl_dataGridView.DataSource = newwrong.ToList();
        }
    }
}