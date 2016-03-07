using BDO_Ditto.BDO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BDO_Ditto
{
    // Defines blocks of apperance data to copy across
    public struct BDO_DataBlock
    {
        public BDO_DataBlock(int offset, int length)
        {
            Offset = offset;
            Length = length;
        }

        public int Offset;
        public int Length;
    }

    public class BDO_AppearanceSwaper
    {
        private string SourceApperancePath = null;
        private string TargetApperancePath = null;

        private byte[] SourceApperanceData = null;
        private byte[] TargetApperanceData = null;

        public bool LoadSource(string path)
        {
            SourceApperancePath = path;
            byte[] data = LoadApperance(SourceApperancePath);
            if (data != null)
            {
                SourceApperanceData = data;
                return true;
            }
            else
            {
                SourceApperanceData = null;
                return false;
            }
        }

        public bool LoadTarget(string path)
        {
            TargetApperancePath = path;
            byte[] data = LoadApperance(TargetApperancePath);
            if (data != null)
            {
                TargetApperanceData = data;
                return true;
            }
            else
            {
                TargetApperanceData = null;
                return false;
            }
        }

        public void CopySectionsToTarget(List<BDO_DataBlock> SetionsToCopy)
        {
            if (SourceApperanceData != null && TargetApperanceData != null)
            {
                byte[] newTemplate = new byte[TargetApperanceData.Length];
                TargetApperanceData.CopyTo(newTemplate, 0);

                foreach (var section in SetionsToCopy)
                {
                    Array.Copy(SourceApperanceData, section.Offset, newTemplate, section.Offset, section.Length);
                }

                try {
                    File.WriteAllBytes(TargetApperancePath, newTemplate);
                }
                catch (Exception e) {
                    MessageBox.Show("Error saving customisation file, sorry :<\n " + e.ToString(), "Error Saving");
                }

                var result = MessageBox.Show("Sections have been copied to target.   ᕕ( ՞ ᗜ ՞ )ᕗ\nCommit changes and reload?", "Done", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoadTarget(TargetApperancePath);
                }
            }
        }

        // TODO: Check file version
        private byte[] LoadApperance(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    byte[] data = File.ReadAllBytes(path);
                    uint version = BitConverter.ToUInt32(data, 0);
                    if (version == StaticData.SupportedVersion)
                    {
                        return data;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Error loading Apperance data\nUnsuported version {0}, only version {1} is supported, sorry :<\nTry loading it and resaving it in game.", version, StaticData.SupportedVersion), "Error");
                        return null;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading Apperance data\n" + e.ToString(), "Error");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Apperance file does not exist.\n" + path, "Error");
                return null;
            }
        }

        private string GetClassFromData(byte[] data)
        {
            // Crude
            ulong classId = BitConverter.ToUInt64(data, StaticData.ClassId.Offset);
            string className = "";
            if (!StaticData.ClassIdLookup.TryGetValue(classId, out className))
            {
                className = "Unkown";
            }
            Debug.WriteLine(string.Format("Class ID: {0}, Name: {1}", classId, className));

            return className;
        }

        public string GetSourceClassStr()
        {
            return GetClassFromData(SourceApperanceData);
        }

        public string GetTargetClassStr()
        {
            return GetClassFromData(TargetApperanceData);
        }

        public bool IsSourceAndTragetApperanceLoaded()
        {
            return SourceApperanceData != null && TargetApperanceData != null;
        }
    }
}
