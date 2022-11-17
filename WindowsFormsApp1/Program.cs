using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
namespace SolidWorksAPIControl
{
    public class FileExport
    {
        SldWorks swapp = new SldWorks();
        public void ExportDxf(string filepath, string savepath)
        {
            try
            {
                Debug.Print("dxf path:" + savepath + "\n");
                ModelDoc2 swdoc;
                ModelDocExtension swdocex = default(ModelDocExtension);
                int fileerror = 0;
                int filewarning = 0;
                bool bRet;
                string saveaspath;
                saveaspath = savepath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filepath, ".DXF"));

                swdoc = (ModelDoc2)swapp.OpenDoc6(
                    filepath,
                    (int)swDocumentTypes_e.swDocDRAWING,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref fileerror,
                    ref filewarning
                    );

                swdocex = (ModelDocExtension)swdoc.Extension;

                bRet = swdocex.SaveAs3(
                    saveaspath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref fileerror,
                    ref filewarning
                    );

                swapp.CloseDoc(filepath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void ExportPdf(string filepath, string savepath)
        {

            ModelDoc2 swdoc;
            ModelDocExtension swdocex = default(ModelDocExtension);
            int fileerror = 0;
            int filewarning = 0;
            bool bRet;
            string saveaspath;
            saveaspath = savepath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filepath, ".pdf"));

            swdoc = (ModelDoc2)swapp.OpenDoc6(
                filepath,
                (int)swDocumentTypes_e.swDocDRAWING,
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                "",
                ref fileerror,
                ref filewarning
                );

            swdocex = (ModelDocExtension)swdoc.Extension;

            bRet = swdocex.SaveAs3(
                saveaspath,
                (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                null,
                null,
                ref fileerror,
                ref filewarning
                );

            swapp.CloseDoc(filepath);
        }
        public void ExportStep(string filepath, string savepath)
        {

            PartDoc swdoc = default(PartDoc);
            ModelDoc2 swmodel;
            ModelDocExtension swdocex = default(ModelDocExtension);
            int fileerror = 0;
            int filewarning = 0;
            bool bRet = false;
            string saveaspath;
            saveaspath = savepath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filepath, ".STEP"));

            swdoc = (PartDoc)swapp.OpenDoc6(
                filepath,
                (int)swDocumentTypes_e.swDocPART,
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                "",
                ref fileerror,
                ref filewarning
                );

            swmodel = (ModelDoc2)swdoc;
            swdocex = (ModelDocExtension)swmodel.Extension;

            bRet = swdocex.SaveAs3(
                saveaspath,
                (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                null,
                null,
                ref fileerror,
                ref filewarning
                );
            swapp.CloseDoc(filepath);

        }
        public void ExportIges(string filepath, string savepath)
        {

            PartDoc swdoc = default(PartDoc);
            ModelDoc2 swmodel;
            ModelDocExtension swdocex = default(ModelDocExtension);
            int fileerror = 0;
            int filewarning = 0;
            bool bRet = false;
            string saveaspath;
            saveaspath = savepath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filepath, ".IGS"));

            swdoc = (PartDoc)swapp.OpenDoc6(
                filepath,
                (int)swDocumentTypes_e.swDocPART,
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                "",
                ref fileerror,
                ref filewarning
                );

            swmodel = (ModelDoc2)swdoc;
            swdocex = (ModelDocExtension)swmodel.Extension;

            bRet = swdocex.SaveAs3(
                saveaspath,
                (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                null,
                null,
                ref fileerror,
                ref filewarning
                );
            swapp.CloseDoc(filepath);

        }
        public void ExportStl(string filepath, string savepath)
        {

            PartDoc swdoc = default(PartDoc);
            ModelDoc2 swmodel;
            ModelDocExtension swdocex = default(ModelDocExtension);
            int fileerror = 0;
            int filewarning = 0;
            bool bRet = false;
            string saveaspath;
            saveaspath = savepath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filepath, ".STL"));

            swdoc = (PartDoc)swapp.OpenDoc6(
                filepath,
                (int)swDocumentTypes_e.swDocPART,
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                "",
                ref fileerror,
                ref filewarning
                );

            swmodel = (ModelDoc2)swdoc;
            swdocex = (ModelDocExtension)swmodel.Extension;

            bRet = swdocex.SaveAs3(
                saveaspath,
                (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                null,
                null,
                ref fileerror,
                ref filewarning
                );
            swapp.CloseDoc(filepath);

        }
    }
}
