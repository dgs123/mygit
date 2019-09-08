using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using System.Collections.Specialized;

namespace Manning.MyPhotoControls
{
    public partial class PhotoEditDialog : Manning.MyPhotoControls.BaseEditDialog
    {
        
        private Photograph _photo;
        private Photograph Photo
        {
            get { return _photo; }
        }

        private AlbumManager _manager = null;
        private AlbumManager Manager
        {
            get { return _manager; }
        }
 
        public PhotoEditDialog()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(txtPhotoFile, "Photo file");
            this.toolTip1.SetToolTip(txtCaption, "Photo caption");
            this.toolTip1.SetToolTip(dtpDateTaken, "Photographs taken date");
            this.toolTip1.SetToolTip(comboPhotographer, "Who take the photo?");
            this.toolTip1.SetToolTip(txtNotes, "This is notes message box");
        }
        private void InitializeDialog(Photograph photo)
        {
            _photo = photo;
            ResetDialog();
        }
        public PhotoEditDialog(Photograph photo):this()
        {
            if (photo == null)
            {
                throw new ArgumentException("The photo parameter cannot be null");
                
            }
            InitializeDialog(photo);
        }
        public PhotoEditDialog(AlbumManager mgr):this()
        {
            if (mgr == null)
            {
                throw new ArgumentNullException("The mgr parameter cannot be null");
            }
            _manager = mgr;
            InitializeDialog(mgr.Current);
        }
        protected override void ResetDialog()
        {
            // Fill combo obx with photographers in album
            comboPhotographer.BeginUpdate();
            comboPhotographer.Items.Clear();
            if (Manager != null)
            {
                StringCollection coll = Manager.Photographers;
                foreach (string s in coll)
                {
                    comboPhotographer.Items.Add(s);
                }
            }
            else
            {
                comboPhotographer.Items.Add(Photo.Photographer);
            }
            comboPhotographer.EndUpdate();

            // Initialize form contents
            Photograph photo = Photo;
            if (photo != null)
            {
                txtPhotoFile.Text = photo.FileName;
                txtCaption.Text = photo.Caption;
                dtpDateTaken.Value = photo.DateTaken;
                comboPhotographer.Text = photo.Photographer;
                txtNotes.Text= photo.Notes;
            }
            base.ResetDialog();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                SaveSettings();
            }
            base.OnClosing(e);
        }

        private void SaveSettings()
        {

            Photograph photo = Photo;
            if (photo != null)
            {
                photo.Caption = txtCaption.Text;
                photo.Photographer = comboPhotographer.Text;
                photo.Notes = txtNotes.Text;
                photo.DateTaken = dtpDateTaken.Value;
            }
        }

        private void TxtCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsLetterOrDigit(c) ||
                char.IsWhiteSpace(c) ||
                char.IsControl(c));
            if (e.Handled)
            {
                Console.Beep();
            }
        }

        private void TxtCaption_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtCaption.Text + " - Properties";
        }

        private void TsmiUndo_Click(object sender, EventArgs e)
        {
            if (txtNotes.CanUndo)
            {
                txtNotes.Undo();
            }
        }

        private void TsmiCopy_Click(object sender, EventArgs e)
        {
            if (txtNotes.SelectedText.Length > 0)
            {
                txtNotes.Copy();
            }
        }

        private void TsmiPaste_Click(object sender, EventArgs e)
        {
            txtNotes.Paste();
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (txtNotes.SelectionLength > 0)
            {

                StringBuilder sb = new StringBuilder(txtNotes.Text);
                sb.Remove(txtNotes.SelectionStart, txtNotes.SelectionLength);
                txtNotes.Text = sb.ToString();
            }
        }

        private void TsmiSelectAll_Click(object sender, EventArgs e)
        {
            txtNotes.SelectionStart = 0;
            txtNotes.SelectionLength = txtNotes.Text.Length;
        }

        private void ContextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (txtNotes.SelectionLength > 0)
            {
                tsmiCopy.Enabled = true;
                tsmiCut.Enabled = true;
                tsmiDelete.Enabled = true;
            }
            else
            {
                tsmiCopy.Enabled = false;
                tsmiCut.Enabled = false;
                tsmiDelete.Enabled = false;
            }
        }

        private void MskDateTaken_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                DialogResult result = MessageBox.Show("The Date Taken entry is invalid of " +
                    "in the future and may be ignored." +
                    "Do you wish to correct this?", "Photo Properties",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = (result == DialogResult.Yes);
            }
        }

        private void ComboPhotographer_Leave(object sender, EventArgs e)
        {
            string person = comboPhotographer.Text;
            if (!comboPhotographer.Items.Contains(person))
            {
                comboPhotographer.Items.Add(person);
            }
        }

        private void ComboPhotographer_TextChanged(object sender, EventArgs e)
        {
            // See if a matching string exists in the list
            string text = comboPhotographer.Text;
            int index = -1;
            if (text.Length > 0 )
            {
                index = comboPhotographer.FindString(text);
            }
            // Show list box only if a match was found
            if (index < 0)
            {
                comboPhotographer.DroppedDown = false;
            }
            else
            {
                comboPhotographer.DroppedDown = true;

                // Display and select remaining portion of matched entry
                string newText = comboPhotographer.Items[index].ToString();
                comboPhotographer.SelectionStart = text.Length;
                comboPhotographer.SelectionLength = newText.Length - text.Length;
            }
        }
    }
}
