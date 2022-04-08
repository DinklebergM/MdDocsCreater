using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace MdDocsCreater
{
    public partial class MdDocsCreater : MaterialForm
    {
        public MdDocsCreater()
        {
            InitializeComponent();
        }
        List<string> fileEndings = new();
        List<Regex>  regex = new();
        private void btnAddFileEnd_Click(object sender, EventArgs e)
        {
            if (!tbFileEnd.Text.Contains(' ') && tbFileEnd.Text!="" && tbFileEnd.Text != null)
            {
                lbFileEnd.Items.Add(tbFileEnd.Text);
                fileEndings.Add(tbFileEnd.Text);
            }        
        }
        private void btnRemoveEnding_Click(object sender, EventArgs e)
        {
            try
            {
                lbFileEnd.Items.RemoveAt(lbFileEnd.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nothing To Remove","Error");
            }           
        }
        public void btnBrowseCode_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog filePath = new();
            filePath.ShowDialog();
            tbCodePath.Text = filePath.SelectedPath;
        }

        private void btnBrowseMd_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog filePath = new();
            filePath.ShowDialog();
            tbMdPath.Text = filePath.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cbPrivate.Checked && !cbPublic.Checked ||
                !cbInteger.Checked && !cbNoReturnValue.Checked && !cbString.Checked && !cbBool.Checked && !cbOther.Checked)
            {
                MessageBox.Show("Every Collumn needs one checked field","Error");
                return;
            }
            MdFileWriter.SendDataToMdFileWriter(tbCodePath,lbFileEnd,tbMdPath,cbPublic,cbPrivate,
                cbNoReturnValue,cbString,cbInteger,cbBool,cbOther);
        }
        private void btnInfoFileEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("e.g.: \" .cs \"", "Help");
        }
    }
}