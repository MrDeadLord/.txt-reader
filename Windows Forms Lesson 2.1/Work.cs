using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Windows_Forms_2._1
{
    class Work
    {
        /// <summary>
        /// Поиск файлов нужного формата
        /// </summary>
        /// <returns>Возвращает список файлом прошедших проверку</returns>
        public List<object> OprenFile()
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;

            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(FolderBrowserDialog1.SelectedPath);
                var files = di.GetFiles("*.docx");

                var filesList = new List<object>();

                foreach (var file in files)
                {
                    filesList.Add(file.FullName);
                }

                return filesList;
            }
            else
            {
                var emptyList = new List<object>();
                return emptyList;
            }
        }

        /// <summary>
        /// Поиск нужных форматов, включая вложенные папки
        /// </summary>
        /// <returns>Возвращает список файлов прошедших проверку(формат)</returns>
        public List<object> OpenAll()
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;

            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(FolderBrowserDialog1.SelectedPath);
                var files = di.GetFiles("*.txt", SearchOption.AllDirectories);

                var filesList = new List<object>();

                foreach (var file in files)
                {
                    filesList.Add(file.FullName);
                }

                return filesList;
            }
            else
            {
                var emptyList = new List<object>();
                return emptyList;
            }
        }

    }
}
