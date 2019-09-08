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
using Manning.MyPhotoControls;
using System.IO;
namespace MyAlbumEditor
{
    public partial class EditorForm : Form
    {
        static private readonly Rectangle DrawRect = new Rectangle(0,0,45,45);
        private AlbumManager _manager;
        private AlbumManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        public EditorForm()
        {
            InitializeComponent();
            Manager = new AlbumManager();
        }

        private bool CloseAlbum()
        {
            if (Manager != null)
            {
                DialogResult result = AlbumController.AskForSave(Manager);
                switch (result)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        return true;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        Manager.Save();
                        break;
                    case DialogResult.No:
                        break; 
                }
                Manager.Album.Dispose();
                Manager = null;
            }
            return false;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = CloseAlbum();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayAlbum()
        {
            if (Manager == null)
            {
                pagePhotos.Enabled = false;
                btnAlbumProps.Enabled = false;
                Text = "The selected album " +
                    "could not be opened";
                lstPhotos.BackColor = SystemColors.Control;
                lstPhotos.Items.Clear();
            }
            else
            {
                pagePhotos.Enabled = true;
                btnAlbumProps.Enabled = true;
                Text = "Album " + Manager.ShortName;
                lstPhotos.BackColor = SystemColors.Window;
                lstPhotos.FormatString = Manager.Album.GetDescriptorFormat();
                if (Manager.Album.PhotoDescriptor ==  PhotoAlbum.DescriptorOption.DateTaken)
                {
                    lstPhotos.FormatString = "dMMMM dd, yyyy";
                }
                lstPhotos.BeginUpdate();
                lstPhotos.Items.Clear();
                foreach (Photograph p in Manager.Album)
                {
                    lstPhotos.Items.Add(p);
                }
                //lstPhotos.DisplayMember = new Photograph(Manager.FullName).Caption;
                //lstPhotos.DataSource = Manager.Album;
                lstPhotos.EndUpdate();
            }
        }

        private void BtnAlbumProps_Click(object sender, EventArgs e)
        {
            if (Manager == null)
            {
                return;
            }
            using (AlbumEditDialog dlg= new AlbumEditDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DisplayAlbum();
                }
            }
        }

        private void BtnPhotoProps_Click(object sender, EventArgs e)
        {
            if (Manager == null ||
                lstPhotos .SelectedIndex < 0)
            {
                return; // nothing selected
            }
            Manager.Index = lstPhotos.SelectedIndex;
            using (PhotoEditDialog dlg = new PhotoEditDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DisplayAlbum();
                }
            }
        }

        private void LstPhotos_DoubleClick(object sender, EventArgs e)
        {
            btnPhotoProps.PerformClick();
        }

        private void LstPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnablePhotoButtons();
        }

        private void EnablePhotoButtons()
        {
            int selCount = lstPhotos.SelectedIndices.Count;
            bool someSelected = (selCount > 0);
            if (someSelected)
            {
                bool firstSelected = lstPhotos.GetSelected(0);
                bool lastSelected = lstPhotos.GetSelected(lstPhotos.Items.Count - 1);
                btnMoveUp.Enabled = !firstSelected;
                btnMoveDown.Enabled = !lastSelected;
            }
            else
            {
                btnMoveDown.Enabled = false;
                btnMoveUp.Enabled = false;
            }
            btnRemove.Enabled = someSelected;
            btnPhotoProps.Enabled = (selCount == 1);
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
            int count = indices.Count;
            int[] newIndices = new int[count];

            // Move each selection up
            for (int i = 0; i < count; i++)
            {
                int x = indices[i];
                Manager.MoveItemBackward(x);
                newIndices[i] = x - 1;
            }
            ReselectMovedItems(newIndices);
        }

        private void ReselectMovedItems(int[] newIndices)
        {
            DisplayAlbum();

            // Reselect moved items
            foreach (int x in newIndices)
            {
                lstPhotos.SetSelected(x, true);
            }
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
            int count = indices.Count;
            int[] newIndices = new int[count];

            // Move each selection down
            for (int i = count -1; i >= 0; i--)
            {
                int x = indices[i];
                Manager.MoveItemForward(x);
                newIndices[i] = x + 1;
            }
            ReselectMovedItems(newIndices);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = lstPhotos.SelectedIndices;
            int count = indices.Count;
            string msg;
            if (count == 1)
            {
                msg = "Do you really want to remove the " +
                    "selected photograph ? ";
             
            }
            else
            {
                msg = string.Format("Do you really want to  " +
                    "remove the {0} selected photographs?", count);

            }
            DialogResult result = MessageBox.Show(msg,
                "Remove Photos?",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    Manager.Album.RemoveAt(indices[i]);
                }
                DisplayAlbum();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            comboAlbums.DataSource = Directory.GetFiles(AlbumManager.DefaultPath, "*.abm");
            OpenAlbum(comboAlbums.Text);
            base.OnLoad(e);
        }

        private void ComboAlbums_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string path = comboAlbums.Text;

            // Don't reopen the existing album
            if (Manager != null && path  == Manager.FullName)
            {
                return;
            }

            // Open the new album
            OpenAlbum(path);
        }

        private void OpenAlbum(string path)
        { 
            string password = null;
            if (path != null && 
                path.Length > 0 &&
                AlbumController.CheckAlbumPassword(path, ref password))
            {
                if (CloseAlbum())
                {
                    return; // cancel open
                }
                try
                {
                    Manager = new AlbumManager(path, password);
                }
                catch (AlbumStorageException)
                {

                    Manager = null;
                }
            }
            DisplayAlbum();
            EnablePhotoButtons();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select an album file " +
                    "directory to add to the dialog";
                dlg.SelectedPath = AlbumManager.DefaultPath;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (CloseAlbum())
                    {
                        return;// cancel browse

                    }
                    comboAlbums.Text = null;
                    comboAlbums.DataSource = Directory.GetFiles(dlg.SelectedPath, "*.abm");
                    OpenAlbum(comboAlbums.Text);
                }
            }
        }

        private void LstPhotos_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            Photograph p = Manager.Album[e.Index];
            Rectangle scaleRect = ImageUtility.ScaleToFit(p.Image, DrawRect);//当图像根据它的绘图矩形进行缩放时，确定它的正确大小
            Font f = lstPhotos.Font;
            string text = lstPhotos.GetItemText(p);
            int textWidth = (int)e.Graphics.MeasureString(text, f).Width;
            e.ItemWidth = scaleRect.Width + textWidth + 2;
            e.ItemHeight = Math.Max(scaleRect.Height, f.Height) + 2;
        }

        private void LstPhotos_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            if (e.Index < 0 ||
                e.Index > Manager.Album.Count - 1)
            {
                return;
            }
            Photograph p = Manager.Album[e.Index];
            //Determine image rectangle
            Rectangle imageRect = ImageUtility.ScaleToFit(p.Image, DrawRect);
            imageRect.X = e.Bounds.X + 2;
            imageRect.Y = e.Bounds.Y + 1;
            // Draw text image
            g.DrawImage(p.Image, imageRect);
            g.DrawRectangle(Pens.Black, imageRect);
            p.ReleaseImage();

            // Determine text rectange
            Rectangle textRect = new Rectangle();
            textRect.X = imageRect.Right + 2;
            textRect.Y = imageRect.Y + ((imageRect.Height - e.Font.Height) / 2);
            textRect.Width = e.Bounds.Width - imageRect.Width - 4;
            textRect.Height = e.Font.Height;

            // Determine text brush (handle selection)
            Brush textBrush;
            if ((e.State & DrawItemState.Selected) ==  DrawItemState.Selected)
            {
                g.FillRectangle(SystemBrushes.Highlight, textRect);
                textBrush = SystemBrushes.HighlightText;
            }
            else
            {
                g.FillRectangle(SystemBrushes.Window, textRect);
                textBrush = SystemBrushes.WindowText;
            }
            // Draw the text
            g.DrawString(lstPhotos.GetItemText(p), e.Font, textBrush, textRect);
        }
    }
}
