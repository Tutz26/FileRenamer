
namespace FileRenamer
{
    partial class FileRenamer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkListBoxDirectoryFiles = new System.Windows.Forms.CheckedListBox();
            this.textBoxPrefixContainer = new System.Windows.Forms.TextBox();
            this.checkListBoxSelectedFiles = new System.Windows.Forms.CheckedListBox();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.buttonPrefixAdd = new System.Windows.Forms.Button();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.textBoxSuffixContainer = new System.Windows.Forms.TextBox();
            this.buttonSuffixAdd = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonToDirectoryDialog = new System.Windows.Forms.Button();
            this.labelChangeText = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonChangeText = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelExploringDirectory = new System.Windows.Forms.Label();
            this.label_SelectedURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkListBoxDirectoryFiles
            // 
            this.checkListBoxDirectoryFiles.CheckOnClick = true;
            this.checkListBoxDirectoryFiles.FormattingEnabled = true;
            this.checkListBoxDirectoryFiles.Location = new System.Drawing.Point(16, 32);
            this.checkListBoxDirectoryFiles.Name = "checkListBoxDirectoryFiles";
            this.checkListBoxDirectoryFiles.Size = new System.Drawing.Size(312, 328);
            this.checkListBoxDirectoryFiles.TabIndex = 0;
            // 
            // textBoxPrefixContainer
            // 
            this.textBoxPrefixContainer.Location = new System.Drawing.Point(344, 48);
            this.textBoxPrefixContainer.Name = "textBoxPrefixContainer";
            this.textBoxPrefixContainer.PlaceholderText = " <- This side of the text";
            this.textBoxPrefixContainer.Size = new System.Drawing.Size(152, 23);
            this.textBoxPrefixContainer.TabIndex = 1;
            // 
            // checkListBoxSelectedFiles
            // 
            this.checkListBoxSelectedFiles.FormattingEnabled = true;
            this.checkListBoxSelectedFiles.Location = new System.Drawing.Point(512, 32);
            this.checkListBoxSelectedFiles.Name = "checkListBoxSelectedFiles";
            this.checkListBoxSelectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkListBoxSelectedFiles.Size = new System.Drawing.Size(312, 328);
            this.checkListBoxSelectedFiles.TabIndex = 2;
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(344, 24);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(37, 15);
            this.labelPrefix.TabIndex = 3;
            this.labelPrefix.Text = "Prefix";
            // 
            // buttonPrefixAdd
            // 
            this.buttonPrefixAdd.Location = new System.Drawing.Point(344, 80);
            this.buttonPrefixAdd.Name = "buttonPrefixAdd";
            this.buttonPrefixAdd.Size = new System.Drawing.Size(152, 23);
            this.buttonPrefixAdd.TabIndex = 4;
            this.buttonPrefixAdd.Text = "Add Prefix";
            this.buttonPrefixAdd.UseVisualStyleBackColor = true;
            this.buttonPrefixAdd.Click += new System.EventHandler(this.buttonPrefixAdd_Click);
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(344, 128);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(37, 15);
            this.labelSuffix.TabIndex = 5;
            this.labelSuffix.Text = "Suffix";
            // 
            // textBoxSuffixContainer
            // 
            this.textBoxSuffixContainer.Location = new System.Drawing.Point(344, 152);
            this.textBoxSuffixContainer.Name = "textBoxSuffixContainer";
            this.textBoxSuffixContainer.PlaceholderText = "This side of the text ->";
            this.textBoxSuffixContainer.Size = new System.Drawing.Size(152, 23);
            this.textBoxSuffixContainer.TabIndex = 6;
            // 
            // buttonSuffixAdd
            // 
            this.buttonSuffixAdd.Location = new System.Drawing.Point(344, 184);
            this.buttonSuffixAdd.Name = "buttonSuffixAdd";
            this.buttonSuffixAdd.Size = new System.Drawing.Size(152, 23);
            this.buttonSuffixAdd.TabIndex = 7;
            this.buttonSuffixAdd.Text = "Add Suffix";
            this.buttonSuffixAdd.UseVisualStyleBackColor = true;
            this.buttonSuffixAdd.Click += new System.EventHandler(this.buttonSuffixAdd_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(512, 376);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 23);
            this.progressBar.TabIndex = 8;
            // 
            // buttonToDirectoryDialog
            // 
            this.buttonToDirectoryDialog.Location = new System.Drawing.Point(16, 376);
            this.buttonToDirectoryDialog.Name = "buttonToDirectoryDialog";
            this.buttonToDirectoryDialog.Size = new System.Drawing.Size(112, 23);
            this.buttonToDirectoryDialog.TabIndex = 9;
            this.buttonToDirectoryDialog.Text = "Directory Selection";
            this.buttonToDirectoryDialog.UseVisualStyleBackColor = true;
            this.buttonToDirectoryDialog.Click += new System.EventHandler(this.button_ToDirectoryDialog_Click);
            // 
            // labelChangeText
            // 
            this.labelChangeText.AutoSize = true;
            this.labelChangeText.Location = new System.Drawing.Point(344, 232);
            this.labelChangeText.Name = "labelChangeText";
            this.labelChangeText.Size = new System.Drawing.Size(72, 15);
            this.labelChangeText.TabIndex = 10;
            this.labelChangeText.Text = "Change Text";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(344, 288);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.PlaceholderText = "To this text";
            this.textBoxTo.Size = new System.Drawing.Size(152, 23);
            this.textBoxTo.TabIndex = 11;
            // 
            // buttonChangeText
            // 
            this.buttonChangeText.Location = new System.Drawing.Point(344, 320);
            this.buttonChangeText.Name = "buttonChangeText";
            this.buttonChangeText.Size = new System.Drawing.Size(152, 23);
            this.buttonChangeText.TabIndex = 12;
            this.buttonChangeText.Text = "Change Text";
            this.buttonChangeText.UseVisualStyleBackColor = true;
            this.buttonChangeText.Click += new System.EventHandler(this.buttonChangeText_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(344, 256);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.PlaceholderText = "From this text";
            this.textBoxFrom.Size = new System.Drawing.Size(152, 23);
            this.textBoxFrom.TabIndex = 13;
            // 
            // labelExploringDirectory
            // 
            this.labelExploringDirectory.AutoSize = true;
            this.labelExploringDirectory.Location = new System.Drawing.Point(16, 8);
            this.labelExploringDirectory.Name = "labelExploringDirectory";
            this.labelExploringDirectory.Size = new System.Drawing.Size(111, 15);
            this.labelExploringDirectory.TabIndex = 15;
            this.labelExploringDirectory.Text = "Exploring Directory:";
            // 
            // label_SelectedURL
            // 
            this.label_SelectedURL.AutoSize = true;
            this.label_SelectedURL.Location = new System.Drawing.Point(136, 8);
            this.label_SelectedURL.Name = "label_SelectedURL";
            this.label_SelectedURL.Size = new System.Drawing.Size(0, 15);
            this.label_SelectedURL.TabIndex = 16;
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 409);
            this.Controls.Add(this.label_SelectedURL);
            this.Controls.Add(this.labelExploringDirectory);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.buttonChangeText);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelChangeText);
            this.Controls.Add(this.buttonToDirectoryDialog);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonSuffixAdd);
            this.Controls.Add(this.textBoxSuffixContainer);
            this.Controls.Add(this.labelSuffix);
            this.Controls.Add(this.buttonPrefixAdd);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.checkListBoxSelectedFiles);
            this.Controls.Add(this.textBoxPrefixContainer);
            this.Controls.Add(this.checkListBoxDirectoryFiles);
            this.Name = "FileRenamer";
            this.Text = "FileRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBoxDirectoryFiles;
        private System.Windows.Forms.TextBox textBoxPrefixContainer;
        private System.Windows.Forms.CheckedListBox checkListBoxSelectedFiles;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Button buttonPrefixAdd;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.TextBox textBoxSuffixContainer;
        private System.Windows.Forms.Button buttonSuffixAdd;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonToDirectoryDialog;
        private System.Windows.Forms.Label labelChangeText;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonChangeText;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelExploringDirectory;
        private System.Windows.Forms.Label label_SelectedURL;
    }
}

