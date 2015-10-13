using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Word;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Document_Class d = new Document_Class();
        }

        public class Document_Class
        {
            private Document _doc;
            private Microsoft.Office.Interop.Word.Application _DocApp = new Microsoft.Office.Interop.Word.Application();

            object missing = System.Reflection.Missing.Value;

            public Document_Class()
            {


                _doc = _DocApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                foreach (Microsoft.Office.Interop.Word.Section section in _doc.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "TEST";
                }
                foreach (Microsoft.Office.Interop.Word.Section wordSection in _doc.Sections)
                {
                    Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Footer TEST";
                }

                _doc.Content.SetRange(0, 0);
                _doc.Content.Text = "Text TEST";

                object filename = @"c:\temp1.docx";
                _doc.SaveAs2(ref filename);
                _doc.Close(ref missing, ref missing, ref missing);
                _doc = null;
                _DocApp.Quit(ref missing, ref missing, ref missing);
                _DocApp = null;
                //MessageBox.Show("Document created successfully !");
            }
        }
    }
}
