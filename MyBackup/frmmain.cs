using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ionic.Zip;
using DreamVB.Config;
using System.IO;

namespace MyBackup
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message,
                 Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region Utls
        private bool ItemInList(ListBox lb, string source)
        {
            bool flag = false;
            foreach (string Item in lb.Items)
            {
                if (Item.Equals(source, StringComparison.OrdinalIgnoreCase))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private string FixPath(string S)
        {
            if (!S.EndsWith("\\"))
                return S + "\\";
            return S;
        }

        #endregion


        #region First Backup Projcts
        private void LoadProject(string Filename)
        {
            string Selection = "BackupSet";
            int x = 0;
            int fCounter = 0;

            if (File.Exists(Filename))
            {
                //Open config file
                cfgfile cfg = new cfgfile(Filename);
                //Read backup project settings
                txtBackupName.Text = cfg.ReadString(Selection, "Name");
                txtSaveTo.Text = cfg.ReadString(Selection, "BackupName");
                fCounter = cfg.ReadInteger(Selection, "SourceCount");

                if (fCounter > 0)
                {
                    //Clear the listbox
                    lstSrc.Items.Clear();
                    //Disable remove button
                    cmdRemoveItem.Enabled = false;

                    //Read files+folders into listbox.
                    while (x < fCounter)
                    {
                        //Get source
                        string src = cfg.ReadString(Selection, "source" + (x + 1).ToString());
                        //Add to listbox
                        lstSrc.Items.Add(src);
                        //INC counter
                        x++;
                    }
                }
            }
        }
        #endregion

        #region Gui
        private string GetFilename()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string lzFile = string.Empty;

            ofd.Title = "Select File";
            ofd.Filter = "All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lzFile = ofd.FileName;
            }
            ofd.Dispose();
            return lzFile;
        }

        private string GetBackupName()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            string lzFile = string.Empty;

            ofd.Title = "Save Backup";
            ofd.Filter = "Zip Files(*.zip)|*.zip";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lzFile = ofd.FileName;
            }
            ofd.Dispose();
            return lzFile;
        }

        private string SaveBackUpSet(string defFilename="untitled")
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string lzFile = string.Empty;

            sfd.Title = "Save Backup Set";
            sfd.FileName = defFilename;
            sfd.Filter = "Backup Set Files(*.bsf)|*.bsf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                lzFile = sfd.FileName;
            }
            sfd.Dispose();
            return lzFile;
        }

        private string GetBackUpSet()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string lzFile = string.Empty;

            ofd.Title = "Open Backup Set";
            ofd.Filter = "Backup Set Files(*.bsf)|*.bsf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lzFile = ofd.FileName;
            }
            ofd.Dispose();
            return lzFile;
        }

        private string GetFolderName()
        {
            string lzFolder = string.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lzFolder = fbd.SelectedPath;
            }
            fbd.Dispose();

            return lzFolder;
        }

        #endregion


        private void lstSrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmdRemoveItem.Enabled)
            {
                cmdRemoveItem.Enabled = true;
            }
        }

        private void cmdClearList_Click(object sender, EventArgs e)
        {
            if (lstSrc.Items.Count == 0)
                return;

            DialogResult dr = MessageBox.Show("Are you sure you want to clear all the items?",
                Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lstSrc.Items.Clear();
                cmdRemoveItem.Enabled = false;
            }
        }

        private void cmdAddFiles_Click(object sender, EventArgs e)
        {
            string lzFile = GetFilename();
            if (lzFile.Length > 0)
            {
                if (!ItemInList(lstSrc, lzFile))
                {
                    //Make sure the file is not in the list.
                    lstSrc.Items.Add(lzFile);
                }
            }
        }

        private void cmdRemoveItem_Click(object sender, EventArgs e)
        {
            string sItem = (string)lstSrc.Items[lstSrc.SelectedIndex];

            DialogResult dr = MessageBox.Show("Are you sure you want to remove this item\n" +
                sItem, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                lstSrc.Items.Remove(lstSrc.SelectedItem);
                cmdRemoveItem.Enabled = false;
            }
        }

        private void cmdAddFolder_Click(object sender, EventArgs e)
        {
            string lzFolder = GetFolderName();

            if (lzFolder.Length > 0)
            {
                //Check if the string is already in the listbox
                if (!ItemInList(lstSrc, lzFolder))
                {
                    lstSrc.Items.Add(FixPath(lzFolder));
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            string bs_name = txtBackupName.Text.Trim();

            if (bs_name.Length == 0)
            {
                ShowError(new Exception("Please include a name for the backup set."));
            }
            else
            {
                string lzFile = SaveBackUpSet(bs_name);
                string Selection = "BackupSet";
                int x = 0;

                if (lzFile.Length > 0)
                {
                    cfgfile cfg = new cfgfile(lzFile, false);
                    //
                    cfg.WriteString(Selection, "Name", txtBackupName.Text);
                    cfg.WriteString(Selection, "BackupName", txtSaveTo.Text);
                    cfg.WriteInteger(Selection, "SourceCount", lstSrc.Items.Count);
                    //Write the files.
                    while (x < lstSrc.Items.Count)
                    {
                        cfg.WriteString(Selection, "Source" + (x + 1).ToString(), (string)lstSrc.Items[x]);
                        x++;
                    }
                    cfg.SaveIniFile(lzFile);
                }
            }
        }

        private void cmdSaveZip_Click(object sender, EventArgs e)
        {
            string lzFile = GetBackupName();
            if (lzFile.Length > 0)
            {
                txtSaveTo.Text = lzFile;
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                if (!args[1].EndsWith(".bsf", StringComparison.OrdinalIgnoreCase))
                {
                    ShowError(new Exception("The file\n\n" + args[1]
                        + "\n\nwas an Invalid backup set name."));
                    Application.Exit();
                }
                LoadProject(args[1]);
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            LoadProject(GetBackUpSet());
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            string lzZipFile = txtSaveTo.Text.Trim();

            if (lstSrc.Items.Count == 0)
            {
                ShowError(new Exception("You must first add some files before you can backup."));
            }
            else if (lzZipFile.Length == 0)
            {
                ShowError(new Exception("Please include the name of the backup file."));
            }
            else
            {
                try
                {
                    //Remove the file if it is already found
                    if (File.Exists(txtSaveTo.Text))
                        File.Delete(txtSaveTo.Text);

                    ZipFile zf = new ZipFile(txtSaveTo.Text);
                    
                    foreach (string src in lstSrc.Items)
                    {
                        if((File.GetAttributes(src) | FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            DirectoryInfo di = new DirectoryInfo(src);

                            if (di.Exists)
                            {
                                TipInfo.Text = "Status: " + "Adding folder " + src;
                                zf.AddDirectory(src, "//" + di.Name);
                                Application.DoEvents();
                            }
                        }
                        else
                        {
                            FileInfo fi = new FileInfo(src);
                            if (fi.Exists)
                            {
                                TipInfo.Text = "Status: " + "Adding file " + src;
                                zf.AddEntry(fi.Name, File.ReadAllBytes(src));
                            }
                        }
                    }
                    Application.DoEvents();
                    //Create zip file
                    zf.Save();
                    //Clear up object
                    zf.Dispose();
                    TipInfo.Text = "Status: Finished";
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
