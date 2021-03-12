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
        List<string> filesInDirectory = new List<string>();

        // URL of selected directory:
        String directoryURL;

        public FileRenamer()
        {
            InitializeComponent();
        }

        // Directory Selection:
        private void button_ToDirectoryDialog_Click(object sender, EventArgs e)
        {

            // Directory selection:
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();


            // If a directory is selected
            if (dialogResult == DialogResult.OK)
            {
                // CLear the values in LIST:
                filesInDirectory.Clear();

                // Clear the values in the CHECKLIST:
                checkListBox_DirectoryFiles.Items.Clear();


                // Open selection Dialog:
                directoryURL = folderBrowserDialog.SelectedPath;
                checkListFill(directoryURL);

                // Fill Label with used directory:
                label_SelectedURL.Text = directoryURL;

            }
            else
            {
                return;
            }

        }



        // On change in checlist event:
        private void checkListBox_DirectoryFiles_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            String currentItem = checkListBox_DirectoryFiles.SelectedItem.ToString();

            checkListBox_SelectedFiles.Items.Add(currentItem);

        }




        // Fills the checlist with the dialog values and stores it into a List
        private void checkListFill(String url) 
        {
            filesInDirectory.AddRange(Directory.GetFiles(url));


            foreach (String fileName in filesInDirectory)
            {
                // TEST:
                label_extension.Text = findFileExtension(fileName);
                //

                checkListBox_DirectoryFiles.Items.Add(fileName.Replace(url, "").Substring(1));

                
            }

            //  checkListBox_FolderFiles.Items.AddRange(filesInDirectory);



        }

        private void addPrefixToFileName(String prefixToAdd, String fileURL) 
        {

          //  System.IO.File.Move("oldfilename", "newfilename");

        }

        private String findFileExtension(String fileURL)
        {

            int lastPointInString = fileURL.LastIndexOf(".");
            string fileExtension = fileURL.Substring(lastPointInString);

            return fileExtension;
        
        }


    }
}
