using BDO_Ditto.BDO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BDO_Ditto
{
    public partial class MainForm : Form
    {
        private BDO_AppearanceSwaper ApperanceSwaper = new BDO_AppearanceSwaper();
        private Dictionary<string, BDO_DataBlock> SectionsToCopy = new Dictionary<string, BDO_DataBlock>();

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
            List<BDO_DataBlock> setionsToCopy = new List<BDO_DataBlock>(SectionsToCopy.Values);
            PrintSectionsToCopy();
            ApperanceSwaper.CopySectionsToTarget(setionsToCopy);
        }

        // Global handler for selecting what sections to copy
        private void ApperanceSectionsCheckedHandler(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox cb = (CheckBox)sender;
                if (cb.Name.Contains("Cb_") || cb.Name.Length > 3)
                {
                    string sectionName = cb.Name.Substring(3);
                    //Debug.WriteLine(string.Format("Checkbox {0} set to {1}. section name: {2}", cb.Name, cb.Checked, sectionName));

                    if (cb.Checked == false && SectionsToCopy.ContainsKey(sectionName))
                    {
                        SectionsToCopy.Remove(sectionName);
                        Debug.WriteLine(string.Format("Removed section {0} from copy list", sectionName));
                    }
                    else if (cb.Checked && !SectionsToCopy.ContainsKey(sectionName))
                    {
                        if (StaticData.ApperanceSections.ContainsKey(sectionName))
                        {
                            SectionsToCopy.Add(sectionName, StaticData.ApperanceSections[sectionName]);
                            Debug.WriteLine(string.Format("Added section {0} to copy list", sectionName));
                        }
                        else
                        {
                            Debug.Fail(string.Format("The section ({0}) does not exist in the StaticData.ApperanceSections list D: !!!!!!", sectionName));
                        }
                    }
                }
                else
                {
                    Debug.Fail(string.Format("Checkbox {0} was not prefixed with Cb_ but had the apperance handler assigned D:", cb.Name));
                }
            }
        }

        [Conditional("DEBUG")]
        private void PrintSectionsToCopy()
        {
            Debug.WriteLine(string.Format("Copying {0} sections: ", SectionsToCopy.Count));
            Debug.WriteLine("-----------------------------------------------------------");
            Debug.WriteLine(string.Format("{0,-20} {1,-10} {2,-10}", "Section Name", "Offset", "Length"));
            Debug.WriteLine("-----------------------------------------------------------");
            foreach (KeyValuePair<string, BDO_DataBlock> kvp in SectionsToCopy)
            {
                Debug.WriteLine(string.Format("{0,-20} {1,-10} {2,-10}", kvp.Key, kvp.Value.Offset, kvp.Value.Length));
            }
            Debug.WriteLine("-----------------------------------------------------------");
        }
    }
}
