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
        List<string> checkedItemsList = new List<string>();

        // URL of selected directory:
        String directoryURL;


        public FileRenamer()
        {
            InitializeComponent();

            // ITEM CHECK:
            this.checkListBoxDirectoryFiles.ItemCheck += new ItemCheckEventHandler(this.checkListBoxDirectoryFiles_ItemCheck);


            // TEXT CHANGES:
            this.textBoxPrefixContainer.TextChanged += new EventHandler(this.textBoxPrefixContainer_TextChanged);
            this.textBoxSuffixContainer.TextChanged += new EventHandler(this.textBoxSuffixContainer_TextChanged);
            this.textBoxFrom.TextChanged += new EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxTo.TextChanged += new EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.TextChanged += new EventHandler(this.textBoxTo_TextChanged);            

        }


        //EVENTS:
        private void button_ToDirectoryDialog_Click(object sender, EventArgs e)
        {

            // Directory selection:
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();


            // If a directory is selected
            if (dialogResult == DialogResult.OK)
            {
                // Clear the selected files in the other checkbox
                checkListBoxSelectedFiles.Items.Clear();

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

        }// [DONE]

        private void textBoxPrefixContainer_TextChanged(object sender, EventArgs e) 
        {
            recalculateTexts();
            reloadFromList();
        }// [DONE]

        private void textBoxSuffixContainer_TextChanged(object sender, EventArgs e)
        {
            recalculateTexts();
            reloadFromList();
        }// [DONE]

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            recalculateTexts();
            reloadFromList();
        }// [DONE]

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            recalculateTexts();
            reloadFromList();
        }// [DONE]

        private void checkListBoxDirectoryFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            String itemName = checkListBoxDirectoryFiles.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                itemName = finalText(itemName);
                checkedItemsList.Add(itemName);
            }
            else
            {
                for (int i = 0; i < checkedItemsList.Count; i++)
                {
                    if (finalText(itemName) == checkedItemsList[i])
                    {
                        checkedItemsList.RemoveAt(i);
                    }
                }

            }
            //recalculateTexts();
            reloadFromList();

        } //[DONE]

        private void buttonPrefixAdd_Click(object sender, EventArgs e)
        {
            addPrefixToFileName();
        }//[DONE]

        private void buttonSuffixAdd_Click(object sender, EventArgs e)
        {
            addSuffixToFileName();
        }//[DONE]

        private void buttonChangeText_Click(object sender, EventArgs e)
        {
            changeTextToFileName();
        }//[DONE]


        // LIST AND CALCULATIONS:
        private void checkListFill(String url) 
        {

            // Clear the values in both CHECKLISTs and stored list:
            filesInDirectory.Clear();
            checkListBoxDirectoryFiles.Items.Clear();
            checkedItemsList.Clear();


            filesInDirectory.AddRange(Directory.GetFiles(url));


            foreach (String fileName in filesInDirectory)
            {
                checkListBoxDirectoryFiles.Items.Add(fileName.Replace(url, "").Substring(1));                
            }

        }//[DONE]

        private void recalculateTexts() 
        {
            // CLEAR LIST
            checkedItemsList.Clear();

            // CALCULATIONS
            foreach (var checkedItem in checkListBoxDirectoryFiles.CheckedItems) 
            {
                String nameOfCheckedItem = checkedItem.ToString();

                nameOfCheckedItem = finalText(nameOfCheckedItem);

                //// ADD ITEM TO LIST
                checkedItemsList.Add(nameOfCheckedItem);

            }

        }// [DONE]

        private void reloadFromList() 
        {
            checkListBoxSelectedFiles.Items.Clear();

            if (checkedItemsList.Count > 0) 
            {
                foreach (String itemName in checkedItemsList) 
                {
                    checkListBoxSelectedFiles.Items.Add(itemName);
                }                            
            }
            

        }// [DONE]

        private String finalText (String itemName) 
        {
            // PREFIX CALCULATION:
            if (textBoxPrefixContainer.Text != "")
            {
                itemName = itemName.Insert(0, textBoxPrefixContainer.Text);
            }

            // SUFFIX CALCULATION:
            if (textBoxSuffixContainer.Text != "")
            {
                itemName = itemName.Insert(itemName.IndexOf("."), textBoxSuffixContainer.Text);
            }

            // FROM TO CALCULATION:
            if (textBoxFrom.Text != "")
            {
                itemName = itemName.Replace(textBoxFrom.Text, textBoxTo.Text);
            }

            return itemName;

        }


        // ACTIONS:
        private void addPrefixToFileName()
        {

            if (textBoxPrefixContainer.Text != "")
            {
                int itemCount = 0;
                progressBar.Maximum = checkListBoxDirectoryFiles.Items.Count;
                progressBar.Step = 1;

                foreach (var item in checkListBoxDirectoryFiles.CheckedItems) 
                {
                    
                    for (int i = 0; i < checkedItemsList.Count; i++) 
                    {
                        if (finalText(item.ToString()) == checkedItemsList[i]) 
                        {
                            String itemNewName = item.ToString().Insert(0, textBoxPrefixContainer.Text);
                            if (fileRenaming(item.ToString(), itemNewName, directoryURL))
                            {
                                checkListBoxSelectedFiles.SetItemChecked(itemCount, true);
                            }
                        }                    
                    }
                    progressBar.PerformStep();
                    ++itemCount;
                }

                checkListFill(directoryURL);
                MessageBox.Show("Succesfully added prefix to the marked files");
                progressBar.Value = 0;

            }

        }// [DONE]

        private void addSuffixToFileName()
        {

            if (textBoxSuffixContainer.Text != "")
            {
                int itemCount = 0;
                progressBar.Maximum = checkListBoxDirectoryFiles.Items.Count;
                progressBar.Step = 1;

                foreach (var item in checkListBoxDirectoryFiles.CheckedItems)
                {

                    for (int i = 0; i < checkedItemsList.Count; i++)
                    {
                        if (finalText(item.ToString()) == checkedItemsList[i])
                        {
                            String itemNewName = item.ToString();
                            itemNewName = itemNewName.Insert(itemNewName.IndexOf("."), textBoxSuffixContainer.Text);
                            if (fileRenaming(item.ToString(), itemNewName, directoryURL))
                            {
                                checkListBoxSelectedFiles.SetItemChecked(itemCount, true);
                            }
                        }
                    }
                    progressBar.PerformStep();
                    ++itemCount;
                    progressBar.Value = 0;
                }

                checkListFill(directoryURL);
                MessageBox.Show("Succesfully added suffix to the marked files");

            }

        }// [DONE]

        private void changeTextToFileName()
        {

            if (textBoxFrom.Text != "")
            {
                int itemCount = 0;
                progressBar.Maximum = checkListBoxDirectoryFiles.Items.Count;
                progressBar.Step = 1;

                foreach (var item in checkListBoxDirectoryFiles.CheckedItems)
                {

                    for (int i = 0; i < checkedItemsList.Count; i++)
                    {
                        if (finalText(item.ToString()) == checkedItemsList[i])
                        {
                            String itemNewName = item.ToString().Replace(textBoxFrom.Text, textBoxTo.Text);
                            if (fileRenaming(item.ToString(), itemNewName, directoryURL))
                            {
                                checkListBoxSelectedFiles.SetItemChecked(itemCount, true);
                            }
                        }
                    }
                    progressBar.PerformStep();
                    ++itemCount;
                    progressBar.Value = 0;
                }

                checkListFill(directoryURL);
                MessageBox.Show("Succesfully changed text to the marked files");

            }

        }// [DONE]

        // FILE MANAGEMENT:
        private bool fileRenaming(String oldFileName, String newFileName, String directory)
        {
            oldFileName = oldFileName.Insert(0, directory + "/");
            newFileName = newFileName.Insert(0, directory + "/");

            System.IO.FileInfo file = new System.IO.FileInfo(oldFileName);

            if (file.Exists)
            {
                // Try to move and rename the file:
                try
                {
                    file.MoveTo(newFileName);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }



        }//[DONE]


        // FEATURES:
        private void button_CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkListBoxDirectoryFiles.Items.Count; i++)
            {
                checkListBoxDirectoryFiles.SetItemChecked(i, true);            
            }
        }//[DONE]

        private void button_UncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkListBoxDirectoryFiles.Items.Count; i++)
            {
                checkListBoxDirectoryFiles.SetItemChecked(i, false);
            }
        }//[DONE]


    }
}
