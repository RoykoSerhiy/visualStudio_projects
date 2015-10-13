using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace CourceWord.Model
{
    public class Document_Class
    {
        private Document _doc;
        private Application _DocApp;

        #region Properties

        #endregion Properties

        object missing = System.Reflection.Missing.Value;

        public void CreateDocument(string Path)
        {
            _DocApp = new Application();
            //_DocApp.Visible = false;

            _doc = _DocApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            foreach (Section section in _doc.Sections)
            {
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
                headerRange.Font.Size = 10;
                headerRange.Text = "TEST";
            }
            foreach (Section wordSection in _doc.Sections)
            {
                Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 10;
                footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footerRange.Text = "Footer TEST";
            }

            _doc.Content.SetRange(0, 0);
            _doc.Content.Text = "Text TEST";

            object filename = Path; //@"c:\temp1.docx";

            Object fileFormat = WdSaveFormat.wdFormatDocument;
            Object lockComments = false;
            Object password = "";
            Object addToRecentFiles = false;
            Object writePassword = "";
            Object readOnlyRecommended = false;
            Object embedTrueTypeFonts = false;
            Object saveNativePictureFormat = false;
            Object saveFormsData = false;
            Object saveAsAOCELetter = Type.Missing;
            Object encoding = Type.Missing;
            Object insertLineBreaks = Type.Missing;
            Object allowSubstitutions = Type.Missing;
            Object lineEnding = Type.Missing;
            Object addBiDiMarks = Type.Missing;

            _doc.SaveAs(ref filename,
             ref fileFormat, ref lockComments,
             ref password, ref addToRecentFiles, ref writePassword,
             ref readOnlyRecommended, ref embedTrueTypeFonts,
             ref saveNativePictureFormat, ref saveFormsData,
             ref saveAsAOCELetter, ref encoding, ref insertLineBreaks,
             ref allowSubstitutions, ref lineEnding, ref addBiDiMarks);

            //_doc.SaveAs2(ref filename);
            _doc.Close(ref missing, ref missing, ref missing);
            _doc = null;
            _DocApp.Quit(ref missing, ref missing, ref missing);
            _DocApp = null;
            //MessageBox.Show("Document created successfully !");
        }

        public void SaveDocument()
        {
            if (_doc != null || _DocApp != null)
            {

            }
        }

        public void OpenDocument(string Path)
        {
            _DocApp = new Application();
            _DocApp.Visible = false;
            Object filename = Path;//@"C:\a1.doc";
            Object confirmConversions = true;
            Object readOnly = false;
            Object addToRecentFiles = true;
            Object passwordDocument = Type.Missing;
            Object passwordTemplate = Type.Missing;
            Object revert = false;
            Object writePasswordDocument = Type.Missing;
            Object writePasswordTemplate = Type.Missing;
            Object format = Type.Missing;
            Object encoding = Type.Missing; ;
            Object oVisible = Type.Missing;
            Object openConflictDocument = Type.Missing;
            Object openAndRepair = Type.Missing;
            Object documentDirection = Type.Missing;
            Object noEncodingDialog = false;
            Object xmlTransform = Type.Missing;


            _doc = _DocApp.Documents.Open(ref filename,
              ref confirmConversions, ref readOnly, ref addToRecentFiles,
              ref passwordDocument, ref passwordTemplate, ref revert,
              ref writePasswordDocument, ref writePasswordTemplate,
              ref format, ref encoding, ref oVisible,
              ref openAndRepair, ref documentDirection, ref noEncodingDialog, ref xmlTransform);
        }

        public string GetText()
        {
            string text = "";

            if (_doc != null || _DocApp != null)
            {
                Paragraphs paragraphs = _doc.Paragraphs;

                foreach (Paragraph p in paragraphs)
                {
                    text += "\t" + p.Range.Text + "\n";
                }
            }

            return text;
        }

        public void SetText(string text)
        {
            try
            {
                if (_doc != null || _DocApp != null)
                {
                    _doc.Content.Text = text;
                    _doc.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}