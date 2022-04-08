using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MdDocsCreater;
using MaterialSkin.Controls;

namespace MdDocsCreater
{
    internal static class MdFileWriter
    {



        static string codePath;
        static List<string> fileEnds =new();
        static string mdPath;
        static bool PublicChecked;
        static bool PrivateChecked;
        static bool NoReturnValueChecked;
        static bool StringChecked;
        static bool IntegerChecked;
        static bool BoolChecked;
        static bool OtherChecked;

        static List<string> filePaths =new();
        static List<string> fileNames =new();
        public static void SendDataToMdFileWriter(MaterialSkin.Controls.MaterialSingleLineTextField tbCodePath,
        ListBox lbFileEnd,
        MaterialSkin.Controls.MaterialSingleLineTextField tbMdPath,
        MaterialSkin.Controls.MaterialCheckBox cbPublic,
        MaterialSkin.Controls.MaterialCheckBox cbPrivate,
        MaterialSkin.Controls.MaterialCheckBox cbNoReturnValue,
        MaterialSkin.Controls.MaterialCheckBox cbString,
        MaterialSkin.Controls.MaterialCheckBox cbInteger,
        MaterialSkin.Controls.MaterialCheckBox cbBool,
        MaterialSkin.Controls.MaterialCheckBox cbOther)
        {
            codePath=tbCodePath.ToString();
            mdPath=tbMdPath.ToString();
            for (int i = 0; i < lbFileEnd.Items.Count; i++)
            {
                 fileEnds.Add(lbFileEnd.Items[i].ToString()) ;
            }
            PublicChecked = cbPublic.Checked;
            PrivateChecked=cbPrivate.Checked;
            NoReturnValueChecked=cbNoReturnValue.Checked;
            StringChecked=cbString.Checked;
            IntegerChecked=cbInteger.Checked;
            BoolChecked=cbBool.Checked;
            OtherChecked=cbOther.Checked;
        }

        public static void findFiles() {
            DirectoryInfo parentDirecrtory = new(@codePath);
            for (int a = 0; a < fileEnds.Count; a++)
            {
                foreach (FileInfo i in parentDirecrtory.GetFiles())
                {
                    if (i.Name.Substring(i.Name.Length - (fileEnds[a].Length -1), fileEnds[a].Length-1) == fileEnds[a])
                    {
                        filePaths.Add(i.FullName);
                        fileNames.Add(i.Name.Substring(0,i.Name.Length-fileEnds[a].Length));
                    }                
                }
            }
        }
    } 
}
