using System;
using System.Windows.Forms;
using System.IO;

namespace LearningUIpathcoding
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Program program = new Program();
            Clipboard.Clear();
            bool SETresult = program.SetClipboardText("");
            string GETresult = program.GetClipboardText();
            Console.WriteLine("SET Result: = " + SETresult + " GET Result: " + GETresult);

            /*
                        bool FileEx = program.FilePathExits(@"k: \RPA Rookies \ReadFile.txt");
                        string ReadText = program.ReadFileText(@"k: \RPA Rookies \ReadFile.txt");
                        string WriteText = program.WriteFileText(@"k: \RPA Rookies \WriteFile.txt", ReadText);
                        string AppendText = program.AppendFileText(@"k: \RPA Rookies \AppendFile.txt", ReadText);


                        Console.WriteLine("Read Oiutput:" + ReadText);
                        Console.WriteLine("Read Oiutput:" + WriteText);
                        Console.WriteLine("Read Oiutput:" + AppendText);
            */
            Console.WriteLine();



        }
        public string GetClipboardText()
        {
            string output = "";
            if (Clipboard.ContainsText(TextDataFormat.Text))
                output = Clipboard.GetText(TextDataFormat.Text);
            else
                output = "No Data Found";

            return output;
        }
        public bool SetClipboardText(string message)
        {

            if (string.IsNullOrEmpty(message))
                return false;
            else
                Clipboard.SetText(message);

            return true;

        }
    }


    /*
        public bool FilePathExists(string path)
        {
            bool result = false;
            if(File.Exists(path))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool FolderPathExists(string path)
        {
            bool result = false;

            if (Directory.Exists(path))
                result = true;

            else
                result = false;

            return result;
        }

        public string ReadFileText(string path)
        {
            string FileText = "";

            if(string.IsNullOrEmpty(path))
            {
                FileText = "File path is empty";
            }
            else
            {
                FileText = File.ReadAllText(path);
            }

            return FileText;
        }
        public string WriteFileText(string path, string text)
        {
            string FileText = "";

            if(string.IsNullOrEmpty(path))
            {
                FileText = "File path is empty";
            }
             else
            {
                FileText = "Write file text successful";
            }
            return FileText;
        }

        public string AppendFileText(string path, string text)
        {
            string FileText = "";

            if(string.IsNullOrEmpty (path))
            {
                FileText = "File Path is empty";
            }
            else
            {
                File.AppendAllText(path, text);
                FileText = "Append File Text successful";
            }
            return FileText;
        }
    */
}