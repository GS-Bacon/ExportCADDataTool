using System;
using System.IO;
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
namespace SolidworksAPIControl
{
    public class FileExport
    {
        SldWorks SolidworksApp = new SldWorks();
        public void ExportDxf(string filePath, string exportFilePath)
        {
            try
            {
                ModelDoc2 SolidworksDocument;
                ModelDocExtension SolidworksModelExtension = default(ModelDocExtension);
                int FileErro = 0;
                int FileWarning = 0;
                bool bRet;
                string ExportFilePath;
                ExportFilePath = exportFilePath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filePath, ".DXF"));

                SolidworksDocument = (ModelDoc2)SolidworksApp.OpenDoc6(
                    filePath,
                    (int)swDocumentTypes_e.swDocDRAWING,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref FileErro,
                    ref FileWarning
                    );

                SolidworksModelExtension = (ModelDocExtension)SolidworksDocument.Extension;

                bRet = SolidworksModelExtension.SaveAs3(
                    ExportFilePath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref FileErro,
                    ref FileWarning
                    );

                SolidworksApp.CloseDoc(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void ExportPdf(string filePath, string exportFilePath)
        {
            try
            {
                ModelDoc2 SolidworksDocument;
                ModelDocExtension SolidworksModelExtension = default(ModelDocExtension);
                int FileErro = 0;
                int FileWarning = 0;
                bool bRet;
                string ExportFilePath;
                ExportFilePath = exportFilePath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filePath, ".pdf"));

                SolidworksDocument = (ModelDoc2)SolidworksApp.OpenDoc6(
                    filePath,
                    (int)swDocumentTypes_e.swDocDRAWING,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref FileErro,
                    ref FileWarning
                    );

                SolidworksModelExtension = (ModelDocExtension)SolidworksDocument.Extension;

                bRet = SolidworksModelExtension.SaveAs3(
                    ExportFilePath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref FileErro,
                    ref FileWarning
                    );

                SolidworksApp.CloseDoc(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void ExportStep(string filePath, string exportFilePath)
        {
            try
            {

                PartDoc SolidworksDocumen = default(PartDoc);
                ModelDoc2 SolidworksModel;
                ModelDocExtension SolidworksModelExtension = default(ModelDocExtension);
                int FileError = 0;
                int FileWarning = 0;
                bool bRet = false;
                string ExportFilePath;
                ExportFilePath = exportFilePath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filePath, ".STEP"));

                SolidworksDocumen = (PartDoc)SolidworksApp.OpenDoc6(
                    filePath,
                    (int)swDocumentTypes_e.swDocPART,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref FileError,
                    ref FileWarning
                    );

                SolidworksModel = (ModelDoc2)SolidworksDocumen;
                SolidworksModelExtension = (ModelDocExtension)SolidworksModel.Extension;

                bRet = SolidworksModelExtension.SaveAs3(
                    ExportFilePath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref FileError,
                    ref FileWarning
                    );
                SolidworksApp.CloseDoc(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void ExportIges(string filePath, string exportFilePath)
        {
            try
            {

                PartDoc SolidworksDocumen = default(PartDoc);
                ModelDoc2 SolidworksModel;
                ModelDocExtension SolidworksModelExtension = default(ModelDocExtension);
                int FileError = 0;
                int FileWarning = 0;
                bool bRet = false;
                string ExportFilePath;
                ExportFilePath = exportFilePath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filePath, ".IGS"));

                SolidworksDocumen = (PartDoc)SolidworksApp.OpenDoc6(
                    filePath,
                    (int)swDocumentTypes_e.swDocPART,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref FileError,
                    ref FileWarning
                    );

                SolidworksModel = (ModelDoc2)SolidworksDocumen;
                SolidworksModelExtension = (ModelDocExtension)SolidworksModel.Extension;

                bRet = SolidworksModelExtension.SaveAs3(
                    ExportFilePath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref FileError,
                    ref FileWarning
                    );
                SolidworksApp.CloseDoc(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void ExportStl(string filePath, string exportFilePath)
        {
            try
            {
                PartDoc SolidworksDocumen = default(PartDoc);
                ModelDoc2 SolidworksModel;
                ModelDocExtension SolidworksModelExtension = default(ModelDocExtension);
                int FileError = 0;
                int FileWarning = 0;
                bool bRet = false;
                string ExportFilePath;
                ExportFilePath = exportFilePath + "\\" + (string)Path.GetFileName(Path.ChangeExtension(filePath, ".STL"));

                SolidworksDocumen = (PartDoc)SolidworksApp.OpenDoc6(
                    filePath,
                    (int)swDocumentTypes_e.swDocPART,
                    (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                    "",
                    ref FileError,
                    ref FileWarning
                    );

                SolidworksModel = (ModelDoc2)SolidworksDocumen;
                SolidworksModelExtension = (ModelDocExtension)SolidworksModel.Extension;

                bRet = SolidworksModelExtension.SaveAs3(
                    ExportFilePath,
                    (int)swSaveAsVersion_e.swSaveAsCurrentVersion,
                    (int)swSaveAsOptions_e.swSaveAsOptions_Silent,
                    null,
                    null,
                    ref FileError,
                    ref FileWarning
                    );
                SolidworksApp.CloseDoc(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
