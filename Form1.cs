namespace MdDocsCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<string> FileEndings = new();
        string filePath;
        private void btnAddFileEnd_Click(object sender, EventArgs e)
        {
            lbFileEnd.Items.Add(tbFileEnd.Text);
            FileEndings.Add(tbFileEnd.Text);
        }

        private void btnRemoveEnding_Click(object sender, EventArgs e)
        {
            lbFileEnd.Items.RemoveAt(lbFileEnd.SelectedIndex);
        }

        public void btnBrowseCode_Click(object sender, EventArgs e)
        {

            var filePath = new FolderBrowserDialog();
            filePath.ShowDialog();

        }
    }
}