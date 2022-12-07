using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.IO;
using System;

namespace SolidworksAPIControl
{
    public class SolidworksFileExeport
    {
        SldWorks SolidworksApp = new SldWorks();
        public string ExportDxf(string filePath, string exportFilePath)
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
                return exportFilePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }
        }
        public string ExportPdf(string filePath, string exportFilePath)
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
                return exportFilePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }
        }
        public string ExportStep(string filePath, string exportFilePath)
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
                return exportFilePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }

        }
        public string ExportIges(string filePath, string exportFilePath)
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
                return exportFilePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }
        }
        public string ExportStl(string filePath, string exportFilePath)
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
                return exportFilePath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }

        }
    }
}