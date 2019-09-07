using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
namespace Manning.MyPhotoControls
{
    public partial class AlbumEditDialog : BaseEditDialog
    {
        private AlbumManager _manager;
        private AlbumManager Manager
        {
            get { return _manager; }
        }
        public AlbumEditDialog(AlbumManager mgr)
        {
            if (mgr == null)
            {
                throw new ArgumentException("AlbumManager cannot be null");
            }
            InitializeComponent();
            _manager = mgr;
            ResetDialog();
        }
        private void CbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cbxPassword.Checked;
            txtPassword.Enabled = enabled;
            lblComfirm.Enabled = enabled;
            txtConfirm.Enabled = enabled;

            // If enabled, assign focus
            if (enabled)
            {
                txtPassword.Focus();
            }
        }
        protected override void ResetDialog()
        {
            PhotoAlbum album = Manager.Album;

            // Assign text boxes
            txtAlbumFile.Text = Manager.FullName;
            txtTitle.Text = album.Title;

            // Assign radio button
            switch (album.PhotoDescriptor)
            {
                case PhotoAlbum.DescriptorOption.FileName:
                    rbtnFileName.Checked = true;
                    break;
                case PhotoAlbum.DescriptorOption.Caption:
                    rbtnCaption.Checked = true;
                    break;
                case PhotoAlbum.DescriptorOption.DateTaken:
                    rbtnDateTaken.Checked = true;
                    break; 
            }

            // Assign check box
            string pwd = Manager.PassWord;
            cbxPassword.Checked = (pwd != null && pwd.Length > 0);
            txtPassword.Text = pwd;
            txtConfirm.Text = pwd; 
        }
        private bool ValidPassword()
        {
            if (cbxPassword.Checked)
            {
                return (txtPassword.TextLength > 0 &&
                    txtConfirm.Text == txtPassword.Text);
            }
            else
            {
                return true;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (!ValidPassword())
                {
                    DialogResult result = MessageBox.Show("The current password is blank " +
                        " or the password entries " +
                        "do not match.", "Invalid Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    e.Cancel = true;
                        
                }
                if (!e.Cancel)
                {
                    SaveSettings();
                }
            }
        }
        private void SaveSettings()
        {
            PhotoAlbum album = Manager.Album;
            if (album != null)
            { 
                album.Title = txtTitle.Text;
                if (rbtnCaption.Checked)
                {
                    album.PhotoDescriptor = PhotoAlbum.DescriptorOption.Caption;
                }
                else if (rbtnDateTaken.Checked)
                {
                    album.PhotoDescriptor = PhotoAlbum.DescriptorOption.DateTaken;
                }
                else if (rbtnFileName.Checked)
                {
                    album.PhotoDescriptor = PhotoAlbum.DescriptorOption.FileName;
                }
                if (cbxPassword.Checked && ValidPassword())
                {
                    Manager.PassWord = txtPassword.Text; 
                }
                else
                {
                    Manager.PassWord = null;
                }
            }
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtTitle.Text + " - Album Properties";
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.TextLength > 0)
            {
                errorProvider1.SetError(txtPassword, "");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "The assigned password cannot be blank");
            }
        }

        private void TxtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text == txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirm, "");

            }
            else
            {
                errorProvider1.SetError(txtConfirm, "The password and confirmation entries " +
                    "do not match ");
            }
        }

        private void TxtTitle_Validating(object sender, CancelEventArgs e)
        {

            if (this.txtTitle.TextLength <= 0)
            {
                this.errorProvider1.BlinkRate = 400;
                this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                this.errorProvider1.SetError(txtTitle, "Title can not be blank");
            }
            else
            {
                this.errorProvider1.SetError(txtTitle, "");
            }
        }
    }
}
