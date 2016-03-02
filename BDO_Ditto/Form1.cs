using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BDO_Ditto
{
    public partial class MainForm : Form
    {
        private BDO_AppearanceSwaper ApperanceSwaper = new BDO_AppearanceSwaper();

        public MainForm()
        {
            InitializeComponent();

            Text = string.Format("Ditto (v{0})", Application.ProductVersion);
        }

        private string GetBDOCustomizationFolder()
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Black Desert",
                "Customization"
            );
            return path;
        }

        private string OpenCustomizationTemplateBrowser(string title)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();

            string baseDir = GetBDOCustomizationFolder();
            if (Directory.Exists(baseDir))
            {
                OpenDialog.InitialDirectory = GetBDOCustomizationFolder();
            }

            OpenDialog.Title = title;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                return OpenDialog.FileName;
            }
            else
            {
                return "";
            }
        }

        private void Btt_SourceBrowse_Click(object sender, EventArgs e)
        {
            string path = OpenCustomizationTemplateBrowser("Source Template File");

            if (path != "")
            {
                Tb_SourcePath.Text = path;

                if (ApperanceSwaper.LoadSource(path))
                {
                    Gb_Source.Text = string.Format("Source Template ({0})", ApperanceSwaper.GetSourceClassStr());
                }
            }

            Btt_CopySections.Enabled = ApperanceSwaper.IsSourceAndTragetApperanceLoaded();
        }

        private void Btt_TargetBrowse_Click(object sender, EventArgs e)
        {
            string path = OpenCustomizationTemplateBrowser("Target Template File");

            if (path != "")
            {
                Tb_TargetPath.Text = path;

                if (ApperanceSwaper.LoadTarget(path))
                {
                    Gb_Target.Text = string.Format("Target Template ({0})", ApperanceSwaper.GetTargetClassStr());
                }
            }

            Btt_CopySections.Enabled = ApperanceSwaper.IsSourceAndTragetApperanceLoaded();
        }

        // Open the help web page
        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("http://goomichan.github.io/BDO-Ditto/Index.html");
        }

        private void Btt_CopySections_Click(object sender, EventArgs e)
        {
            List<BDO_DataBlock> setionsToCopy = new List<BDO_DataBlock>();

            if (Cb_Eyes.Checked)
                setionsToCopy.Add(BDO.StaticData.Eyes);
            else if (Cb_HairColor.Checked)
                setionsToCopy.Add(BDO.StaticData.HairColors);
            else if (Cb_Skin.Checked)
                setionsToCopy.Add(BDO.StaticData.Skin);
            else if (Cb_FaceShape.Checked)
            {
                setionsToCopy.Add(BDO.StaticData.FaceShape1);
                setionsToCopy.Add(BDO.StaticData.FaceShape2);
            }
            else if (Cb_StandbyExpression.Checked)
                setionsToCopy.Add(BDO.StaticData.StandByExpression);
            else if (Cb_Eyes.Checked)
                setionsToCopy.Add(BDO.StaticData.Eyes);
            else if (Cb_EyeMakeup.Checked)
                setionsToCopy.Add(BDO.StaticData.EyeMakeUp);
            else if (Cb_EyeLine.Checked)
                setionsToCopy.Add(BDO.StaticData.EyeLine);
            else if (Cb_BodyShape.Checked)
                setionsToCopy.Add(BDO.StaticData.BodyShape);
            else if (Cb_Voice.Checked)
                setionsToCopy.Add(BDO.StaticData.Voice);

            ApperanceSwaper.CopySectionsToTarget(setionsToCopy);
        }
    }
}
