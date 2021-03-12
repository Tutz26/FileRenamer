
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
            this.checkListBox_FolderFiles = new System.Windows.Forms.CheckedListBox();
            this.textBox_PrefixContainer = new System.Windows.Forms.TextBox();
            this.checkListBox_SelectedFiles = new System.Windows.Forms.CheckedListBox();
            this.label_Prefix = new System.Windows.Forms.Label();
            this.button_PrefixAdd = new System.Windows.Forms.Button();
            this.label_Suffix = new System.Windows.Forms.Label();
            this.textBox_SuffixContainer = new System.Windows.Forms.TextBox();
            this.button_SuffixAdd = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_ToFolderDialog = new System.Windows.Forms.Button();
            this.label_ChangeText = new System.Windows.Forms.Label();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.button_ChangeText = new System.Windows.Forms.Button();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkListBox_FolderFiles
            // 
            this.checkListBox_FolderFiles.FormattingEnabled = true;
            this.checkListBox_FolderFiles.Location = new System.Drawing.Point(16, 16);
            this.checkListBox_FolderFiles.Name = "checkListBox_FolderFiles";
            this.checkListBox_FolderFiles.Size = new System.Drawing.Size(312, 346);
            this.checkListBox_FolderFiles.TabIndex = 0;
            // 
            // textBox_PrefixContainer
            // 
            this.textBox_PrefixContainer.Location = new System.Drawing.Point(344, 48);
            this.textBox_PrefixContainer.Name = "textBox_PrefixContainer";
            this.textBox_PrefixContainer.PlaceholderText = " <- This side of the text";
            this.textBox_PrefixContainer.Size = new System.Drawing.Size(152, 23);
            this.textBox_PrefixContainer.TabIndex = 1;
            // 
            // checkListBox_SelectedFiles
            // 
            this.checkListBox_SelectedFiles.FormattingEnabled = true;
            this.checkListBox_SelectedFiles.Location = new System.Drawing.Point(512, 16);
            this.checkListBox_SelectedFiles.Name = "checkListBox_SelectedFiles";
            this.checkListBox_SelectedFiles.Size = new System.Drawing.Size(312, 346);
            this.checkListBox_SelectedFiles.TabIndex = 2;
            // 
            // label_Prefix
            // 
            this.label_Prefix.AutoSize = true;
            this.label_Prefix.Location = new System.Drawing.Point(344, 24);
            this.label_Prefix.Name = "label_Prefix";
            this.label_Prefix.Size = new System.Drawing.Size(37, 15);
            this.label_Prefix.TabIndex = 3;
            this.label_Prefix.Text = "Prefix";
            // 
            // button_PrefixAdd
            // 
            this.button_PrefixAdd.Location = new System.Drawing.Point(344, 80);
            this.button_PrefixAdd.Name = "button_PrefixAdd";
            this.button_PrefixAdd.Size = new System.Drawing.Size(152, 23);
            this.button_PrefixAdd.TabIndex = 4;
            this.button_PrefixAdd.Text = "Add Prefix";
            this.button_PrefixAdd.UseVisualStyleBackColor = true;
            // 
            // label_Suffix
            // 
            this.label_Suffix.AutoSize = true;
            this.label_Suffix.Location = new System.Drawing.Point(344, 128);
            this.label_Suffix.Name = "label_Suffix";
            this.label_Suffix.Size = new System.Drawing.Size(37, 15);
            this.label_Suffix.TabIndex = 5;
            this.label_Suffix.Text = "Suffix";
            // 
            // textBox_SuffixContainer
            // 
            this.textBox_SuffixContainer.Location = new System.Drawing.Point(344, 152);
            this.textBox_SuffixContainer.Name = "textBox_SuffixContainer";
            this.textBox_SuffixContainer.PlaceholderText = "This side of the text ->";
            this.textBox_SuffixContainer.Size = new System.Drawing.Size(152, 23);
            this.textBox_SuffixContainer.TabIndex = 6;
            // 
            // button_SuffixAdd
            // 
            this.button_SuffixAdd.Location = new System.Drawing.Point(344, 184);
            this.button_SuffixAdd.Name = "button_SuffixAdd";
            this.button_SuffixAdd.Size = new System.Drawing.Size(152, 23);
            this.button_SuffixAdd.TabIndex = 7;
            this.button_SuffixAdd.Text = "Add Suffix";
            this.button_SuffixAdd.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(512, 376);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 23);
            this.progressBar.TabIndex = 8;
            // 
            // button_ToFolderDialog
            // 
            this.button_ToFolderDialog.Location = new System.Drawing.Point(16, 376);
            this.button_ToFolderDialog.Name = "button_ToFolderDialog";
            this.button_ToFolderDialog.Size = new System.Drawing.Size(112, 23);
            this.button_ToFolderDialog.TabIndex = 9;
            this.button_ToFolderDialog.Text = "Folder Select";
            this.button_ToFolderDialog.UseVisualStyleBackColor = true;
            this.button_ToFolderDialog.Click += new System.EventHandler(this.button_ToFolderDialog_Click);
            // 
            // label_ChangeText
            // 
            this.label_ChangeText.AutoSize = true;
            this.label_ChangeText.Location = new System.Drawing.Point(344, 232);
            this.label_ChangeText.Name = "label_ChangeText";
            this.label_ChangeText.Size = new System.Drawing.Size(72, 15);
            this.label_ChangeText.TabIndex = 10;
            this.label_ChangeText.Text = "Change Text";
            // 
            // textBox_To
            // 
            this.textBox_To.Location = new System.Drawing.Point(344, 288);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.PlaceholderText = "To this text";
            this.textBox_To.Size = new System.Drawing.Size(152, 23);
            this.textBox_To.TabIndex = 11;
            // 
            // button_ChangeText
            // 
            this.button_ChangeText.Location = new System.Drawing.Point(344, 320);
            this.button_ChangeText.Name = "button_ChangeText";
            this.button_ChangeText.Size = new System.Drawing.Size(152, 23);
            this.button_ChangeText.TabIndex = 12;
            this.button_ChangeText.Text = "Change Text";
            this.button_ChangeText.UseVisualStyleBackColor = true;
            // 
            // textBox_From
            // 
            this.textBox_From.Location = new System.Drawing.Point(344, 256);
            this.textBox_From.Multiline = true;
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.PlaceholderText = "From this text";
            this.textBox_From.Size = new System.Drawing.Size(152, 23);
            this.textBox_From.TabIndex = 13;
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 409);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.button_ChangeText);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.label_ChangeText);
            this.Controls.Add(this.button_ToFolderDialog);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_SuffixAdd);
            this.Controls.Add(this.textBox_SuffixContainer);
            this.Controls.Add(this.label_Suffix);
            this.Controls.Add(this.button_PrefixAdd);
            this.Controls.Add(this.label_Prefix);
            this.Controls.Add(this.checkListBox_SelectedFiles);
            this.Controls.Add(this.textBox_PrefixContainer);
            this.Controls.Add(this.checkListBox_FolderFiles);
            this.Name = "FileRenamer";
            this.Text = "FileRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox_FolderFiles;
        private System.Windows.Forms.TextBox textBox_PrefixContainer;
        private System.Windows.Forms.CheckedListBox checkListBox_SelectedFiles;
        private System.Windows.Forms.Label label_Prefix;
        private System.Windows.Forms.Button button_PrefixAdd;
        private System.Windows.Forms.Label label_Suffix;
        private System.Windows.Forms.TextBox textBox_SuffixContainer;
        private System.Windows.Forms.Button button_SuffixAdd;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button_ToFolderDialog;
        private System.Windows.Forms.Label label_ChangeText;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Button button_ChangeText;
        private System.Windows.Forms.TextBox textBox_From;
    }
}

