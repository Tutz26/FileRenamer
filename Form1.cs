using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FileRenamer
{
    public partial class FileRenamer : Form
    {
        
        // List where the files string in the directory are stored:
        List<string> filesInFolder = new List<string>();

        // URL of selected directory:
        String folderURL;

        public FileRenamer()
        {
            InitializeComponent();
        }

        private void button_ToFolderDialog_Click(object sender, EventArgs e)
        {
            // Folder selection:
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();


            if (dialogResult == DialogResult.OK)
            {
                filesInFolder.Clear();
                folderURL = folderBrowserDialog.SelectedPath;
                checkListFill(folderURL);
            }
            else
            {
                return;
            }

          //




        }


        // Fills the checlist with the dialog values and stores it into a List
        private void checkListFill(String url) 
        {
           filesInFolder.AddRange(Directory.GetFiles(url));


            foreach (String fileName in filesInFolder)
            {
                checkListBox_FolderFiles.Items.Add(fileName);
            }

           //  checkListBox_FolderFiles.Items.AddRange(filesInFolder);



        }




    }
}
