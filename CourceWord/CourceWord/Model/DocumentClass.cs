using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Threading;

namespace CourceWord.Model
{
    class Dock
    {
        private Document _doc;
        private Application _docApp;

        public Document Document
        {
            get
            {
                return _doc;
            }
        }
        public Application App
        {
            get
            {
                return _docApp;
            }
        }

        public Dock(DocumentMode mode, string path = "")
        {
            try
            {
                object missing = System.Reflection.Missing.Value;

                switch (mode)
                {
                    case DocumentMode.Create:
                        {
                            _docApp = new Application();
                            _docApp.Visible = false;

                            _doc = _docApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                            _doc.Save();
                        }
                        break;

                    case DocumentMode.CreatFromTemplate:
                        {
                            _docApp = new Application();
                            _docApp.Visible = false;

                            object template = path;
                            object newTemplate = true;

                            _doc = _docApp.Documents.Add(template, newTemplate);
                        }
                        break;

                    case DocumentMode.Load:
                        {
                            _docApp = new Application();
                            _docApp.Visible = false;

                            object FileName = path;

                            _doc = _docApp.Documents.Open(ref FileName);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close(WdSaveOptions options, ClosePogrammMode mode = ClosePogrammMode.No)
        {
            switch (mode)
            {
                case ClosePogrammMode.No:
                    _doc.Close(options);
                    _doc = null;
                    break;

                case ClosePogrammMode.Yes:
                    _doc.Close(options);
                    _doc = null;
                    _docApp.Quit(options);
                    _docApp = null;
                    break;
            }
        }

    }

    public class DocumentManager
    {
        Dock document;

        public string text;

        List<string> Text = new List<string>();

        Paragraphs paragraphs;

        public bool isDocumentEmpty
        {
            get
            {
                if (document.Document == null)
                    return true;

                return false;
            }
        }

        public void CreateDocument()
        {
            document = new Dock(DocumentMode.Create);
        }

        public void LoadDocument(string Path)
        {
            try
            {
                document = new Dock(DocumentMode.Load, Path);

                object findText = "И все случайности,  которые,  случившись,  становятся  причиной  других случайностей, становятся причиной других случайностей.";
                object replaceText = "ТЕСТ пройден";
                FindAndReplace(document.App, findText, replaceText);

                paragraphs = document.Document.Paragraphs;
                text = "";// document.Document.Content.Text;

                foreach (Paragraph p in paragraphs)
                {
                    text += p.Range.Text + "\n";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(string Path)
        {
            Object fileFormat = WdSaveFormat.wdFormatDocument;

            document.Document.SaveAs(Path, fileFormat);
        }

        public void SaveAs()
        {
            document.Document.Save();
        }

        public void CloseWithoutSaving()
        {
            document.Close(WdSaveOptions.wdDoNotSaveChanges);
        }

        public void CloseAndSave()
        {
            document.Close(WdSaveOptions.wdSaveChanges);
        }

        public void ExitProgramm(System.Windows.MessageBoxResult result)
        {
            if (result == System.Windows.MessageBoxResult.Yes)
            {
                document.Close(WdSaveOptions.wdSaveChanges, ClosePogrammMode.Yes);
            }
            else if (result == System.Windows.MessageBoxResult.No)
            {
                document.Close(WdSaveOptions.wdDoNotSaveChanges, ClosePogrammMode.Yes);
            }
        }

        public void SynchronizationWithDock(string str)
        {
            try
            {
                document.App.Selection.Range.Text = str;
                text = document.Document.Content.Text;
                //Paragraphs par = document.Document.Paragraphs;
                //string[] buf = str.Split('\n');

                //if(paragraphs.Count < buf.Length)
                //{
                //    object miss = Type.Missing;
                //    bool res = true;

                //    while (res)
                //    {
                //        paragraphs.Add(miss);
                //        if (paragraphs.Count == buf.Length)
                //            res = false;
                //    }
                //}
                //else
                //{
                //    for (int i = 0; i < buf.Length; i++)
                //    {
                //        paragraphs[i].Range.Text = buf[i];
                //    }
                //}
                //text = "";
                //foreach (Paragraph p in par)
                //{
                //    text += p.Range.Text + "\n";
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Distribution(List<string> replaceList)
        {
            foreach (string s in replaceList)
            {
                int i = 0;
                Dock doc = new Dock(DocumentMode.CreatFromTemplate, document.Document.Path + "\\" + document.Document.Name);
                FindAndReplace(doc.App, "#UserName", s);
                object pathToSave = @"C:\TestWord\test" + i.ToString() + ".docx";
                Object fileFormat = WdSaveFormat.wdFormatDocument;

                doc.Document.SaveAs2(pathToSave, fileFormat);

                doc.Document.Close(WdSaveOptions.wdSaveChanges);
                doc.App.Quit(WdSaveOptions.wdSaveChanges);
            }
        }

        public void FindAndReplace(Application app, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace

            app.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        public string TestPath()
        {
            return document.Document.Path + "\\" + document.Document.Name;
        }
    }
}
