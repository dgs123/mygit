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

namespace MyPhotos
{
    public partial class MainForm : Form    //部分定义类
    {
        private PixelDialog _dlgPixel = null;
        private PixelDialog PixelForm
        {
            get { return _dlgPixel; }
            set { _dlgPixel = value; }
        }

        private AlbumManager _manager;
        private AlbumManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        private ToolStrip toolStrip;
        private ToolStripItem stripItem;
        #region test
        /// <summary>
        /// 常量声明
        /// </summary>
        const int DaysPerYear = 365;

        //The constant value here is calculated by the compiler
        const double AlmostPi = 22.0 / 7.0;

        // A constant taken from a public enumeration
        public enum WeekDay
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        };
        protected const WeekDay FirstDayOfWeek = WeekDay.Sun;

        /// <summary>
        /// 字段声明
        /// </summary>
        public readonly string _defaultDir = @"C:\My Documents\Albums";
        private PhoteAlbum _album;
        private long _num;
        private long _den;

        #endregion

        public MainForm()
        {
            InitializeComponent();       //调用设计器生成的代码
            //SetTitleBar();
            //SetStatusStrip(null);
            NewAlbum();
            menuView.DropDown = ctxMenuPhoto;
            flybyTextProvider.SetFlybyText(menuFileSave, "Save the current album");
        }

        private void NewAlbum()
        {
            // ToDo: clean up, save existing ablum
            if (Manager == null || SaveAndCloseAlbum())
            {
                Manager = new AlbumManager();
                DisplayAlbum();
            }

        }
        private void DisplayAlbum()
        {
            pbxPhoto.Image = Manager.CurrentImage;
            SetStatusStrip(null);
            SetTitleBar();

            Point p = pbxPhoto.PointToClient(
                Form.MousePosition);
            UpdatePixelDialog(p.X, p.Y);
        }
        /// <summary>
        /// 在标题栏中包含版本号
        /// </summary>
        private void SetTitleBar()
        {
            Version version = new Version(Application.ProductVersion);
            string name = Manager.FullName;
            Text = String.Format("{2} - MyPhotos {0:0}.{1:0}",
                version.Major,
                version.Minor,
                string.IsNullOrEmpty(name) ? "Untitled" : name);
        }

        private void MenuLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Load Photo";
            dlg.Filter = "jpg files(*.jpg)|*.jpg|png files（*.png)|*.png|jpeg file(*.jpeg)|*.jpeg|all file(*.*)|*.*";
            dlg.FilterIndex = 2;


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbxPhoto.Image = new Bitmap(dlg.OpenFile());

                }
                catch (ArgumentException ae)
                {

                    MessageBox.Show("Unable to load file: " + ae.Message);
                }
                SetStatusStrip(dlg.FileName);
            }
            dlg.Dispose();
        }
        private void menu_NotImplementd(object sender, EventArgs e)
        {
            MessageBox.Show("This function would not ready");
        }
        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = null;
        }

        private void MenuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessImageClick(e);
        }

        private void ProcessImageClick(ToolStripItemClickedEventArgs e)     //接收ItemClick事件参数
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;                //把Tag值转换为字符串
            if (enumVal != null)
            {
                pbxPhoto.SizeMode = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode), enumVal);                                     //把字符串转换为SizeMode值
            }
        }

        private void MenuImage_DropDownOpening(object sender, EventArgs e)
        {
            ProcessImageOpening(sender as ToolStripDropDownItem);
        }

        private void ProcessImageOpening(ToolStripDropDownItem parent)
        {
            if (parent != null)
            {
                string enumVal = pbxPhoto.SizeMode.ToString();
                foreach (ToolStripMenuItem item in parent.DropDownItems)
                {
                    item.Enabled = (pbxPhoto.Image != null);
                    item.Checked = item.Tag.Equals(enumVal);
                }
            }
        }


        private void MenuCounter_DropDownOpening(object sender, EventArgs e)
        {
            //ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            //toolStripMenuItem.Text = "Count " +menuCounter.DropDownItems.Count ;
            //menuCounter.DropDownItems.Add(toolStripMenuItem);
        }
        private void SetStatusStrip(string path)
        {
            if (pbxPhoto.Image != null)
            {
                statusInfo.Text = Manager.Current.Caption;
                statusInfo.ToolTipText = path;
                statusStrip1.ShowItemToolTips = true;
                statusImageSize.Text = String.Format("{0:#} X {1:#}", pbxPhoto.Image.Width, pbxPhoto.Image.Height);

                //statusAlbumpos is set in ch. 5
                statusAlbumPos.Text = string.Format(" {0:0}/{1:0} ",
                    Manager.Index + 1,
                    Manager.Album.Count);
            }
            else
            {
                statusInfo.Text = null;
                statusImageSize.Text = null;
                statusAlbumPos.Text = null;
            }
        }

        private void StatusBorder_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessBorderStyle(e);
        }

        private void ProcessBorderStyle(ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;                //把Tag值转换为字符串
            if (enumVal != null)
            {                        //把字符串转换为SizeMode值

                statusImageSize.BorderStyle = (Border3DStyle)Enum.Parse(typeof(Border3DStyle), enumVal);
            }
        }

        private void MenuFileNew_Click(object sender, EventArgs e)
        {
            NewAlbum();
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            string path = null;
            string password = null;
            if (AlbumController.OpenAlbumDialog(ref path, ref password))
            {
                // Close existing album
                if (!SaveAndCloseAlbum())
                {
                    return;// close canceled
                }
                //TODO： save any existing album.
                // Open the new album
                try
                {
                    // Open the new album
                    Manager = new AlbumManager(path, password);
                }
                catch (AlbumStorageException aex)
                {
                    string msg = string.Format("Unable to open album file {0}\n{1}", path, aex);
                    MessageBox.Show(msg, "Unable to Open");
                    Manager = new AlbumManager();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                } 
                // Open the new album
                // TODO: handle invalid album file 
                DisplayAlbum();
            }
        }
        private void SaveAlbum(string name)
        {
            try
            {
                Manager.Save(name, true);
            }
            catch (AlbumStorageException aex)
            {
                string msg = string.Format(
                    "Unable to save album {0} ({1})\n\n" +
                    "Do you wish to save the album  " +
                    "under an alternate name? ", name, aex.Message);
                DialogResult result = MessageBox.Show(msg,
                    "Unable to Save",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    SaveAsAlbum();
                }
            }

        }
        private void SaveAlbum()
        {
            if (string.IsNullOrEmpty(Manager.FullName))
            {
                SaveAsAlbum();      //Force user to select name
            }
            else
            {
                // Save the album under the existing name
                SaveAlbum(Manager.FullName);
            }
        }
        private bool SaveAndCloseAlbum()
        {
            DialogResult result = AlbumController.AskForSave(Manager);
            if (result == DialogResult.Yes)
            {
                SaveAlbum();
            }
            else if (result == DialogResult.Cancel)
            {
                return false;
            }
            // Close the album and return true
            if (Manager.Album != null)
            {
                Manager.Album.Dispose();
            }
            Manager = new AlbumManager();
            SetTitleBar();
            return true;
        }
        private void SaveAsAlbum()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                // Display a dialog for saving the album
                dlg.Title = "Save Album As";
                dlg.DefaultExt = "abm";
                dlg.Filter = "Album Files (*.abm)|*.abm|All Files (*.*)|*.*";
                dlg.InitialDirectory = AlbumManager.DefaultPath;
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Save the album under the new name
                    SaveAlbum(dlg.FileName);

                    // Update title bar to include new name 
                    SetTitleBar();
                }
            }
            // end of using: dlg.Dispose() is called
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            SaveAlbum();
        }

        private void MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            string path = null;
            if (AlbumController.SaveAlbumDialog(ref path))
            {
                // Save the album under the new name
                SaveAlbum(path);

                // Update title bar to include new name
                SetTitleBar();
            }
        }

        private void MenuEditAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Add Photos";
            dlg.Multiselect = true;
            dlg.Filter = "Image Files(JPEG,GIF,BMP,etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png;|" +
                "JPEG Files(*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "GIF Files(*.gif)|*.gif|" +
                "BMP Files(*.bmp)|*.bmp|" +
                "TIFF Files(*.tif;*.tiff)|*.tif;*.tiff|" +
                "PNG Files(*.png)|*.png|" +
                "ALL Files(*.*)|*.*";

            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlg.FileNames;
                int index = 0;
                foreach (string s in files)
                {
                    Photograph photo = new Photograph(s);

                    // Add the file (if not already present)
                    index = Manager.Album.IndexOf(photo);
                    if (index < 0)
                    {
                        Manager.Album.Add(photo);
                    }
                    else
                    {
                        photo.Dispose();        //photo already there
                    }
                }
                Manager.Index = Manager.Album.Count - 1;
            }
            dlg.Dispose();
            DisplayAlbum();
        }

        private void MenuEditRemove_Click(object sender, EventArgs e)
        {

            if (Manager.Album.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to remove?",
                    "Remove album",
                     MessageBoxButtons.YesNo,
                      MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    return;
                }

                Manager.Album.RemoveAt(Manager.Index);
                DisplayAlbum();
            }
        }

        private void MenuNext_Click(object sender, EventArgs e)
        {
            if (Manager.Index < Manager.Album.Count - 1)
            {
                Manager.Index++;
                DisplayAlbum();
            }
        }

        private void MenuPrevious_Click(object sender, EventArgs e)
        {
            if (Manager.Index > 0)
            {
                Manager.Index--;
                DisplayAlbum();
            }
        }

        private void CtxMenuPhoto_Opening(object sender, CancelEventArgs e)
        {
            menuNext.Enabled = (Manager.Index < Manager.Album.Count - 1);
            menuPrevious.Enabled = (Manager.Index > 0);
            menuPhotoProps.Enabled = (Manager.Current != null);
            menuAlbumProps.Enabled = (Manager.Album != null);
        }

        private void MenuFirst_Click(object sender, EventArgs e)
        {
            if (Manager.Album.Count > 0)
            {
                Manager.Index = 0;
                DisplayAlbum();
            }
        }

        private void MenuLast_Click(object sender, EventArgs e)
        {
            if (Manager.Album.Count > 0)
            {
                Manager.Index = Manager.Album.Count - 1;
                DisplayAlbum();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //if (SaveAndCloseAlbum() == false)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = false;
            //}
            e.Cancel = !SaveAndCloseAlbum();
            base.OnFormClosing(e);
        }

        private void MenuPixelData_Click(object sender, EventArgs e)
        {
            if (PixelForm == null || PixelForm.IsDisposed)
            {
                PixelForm = new PixelDialog();
                PixelForm.Owner = this;
            }
            PixelForm.Show();
            Point p = pbxPhoto.PointToClient(Form.MousePosition);
            UpdatePixelDialog(p.X, p.Y);
        }

        private void UpdatePixelDialog(int x, int y)
        {
            if (PixelForm != null && PixelForm.Visible)
            {
                Bitmap bmp = Manager.CurrentImage;
                PixelForm.Text = (Manager.Current == null ? "Pixel Data" : Manager.Current.Caption);
                if (bmp == null || !pbxPhoto.DisplayRectangle.Contains(x, y))
                {
                    PixelForm.ClearPixelData();
                }
                else
                {
                    PixelForm.UpdatePixelData(x, y, bmp, pbxPhoto.DisplayRectangle,
                        new Rectangle(0, 0, bmp.Width, bmp.Height),
                        pbxPhoto.SizeMode);
                }
            }
        }

        private void PbxPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            UpdatePixelDialog(e.X, e.Y);
        }

        private void MenuPhotoProps_Click(object sender, EventArgs e)
        {
            if (Manager.Current == null)
            {
                return;
            }
            using (PhotoEditDialog dlg = new PhotoEditDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DisplayAlbum();
                }
            }
        }

        private void MenuAlbumProps_Click(object sender, EventArgs e)
        {
            if (Manager.Album == null)
            {
                return;
            }
            using (AlbumEditDialog dlg = new AlbumEditDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DisplayAlbum();
                }
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    menuNext.PerformClick();
                    e.Handled = true;
                    break;
                case '-':
                    menuPrevious.PerformClick();
                    e.Handled = true;
                    break;
            }
            // Invoke the base method
            base.OnKeyPress(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.PageUp:
                    if (e.KeyData == Keys.Shift)
                    {
                        menuFirst.PerformClick();
                    }
                    else
                        menuPrevious.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.PageDown:
                    if (e.KeyCode == Keys.Shift)
                    {
                        menuLast.PerformClick();
                    }
                    else
                        menuNext.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Home:
                    menuFirst.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.End:
                    menuLast.PerformClick();
                    e.Handled = true;
                    break;
            }
            base.OnKeyDown(e);
        }
        private const int WM_KEYDOWN = 0x100;
        private const int WM_SYSKEYDOWN = 0x104;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == WM_KEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Tab:
                        menuNext.PerformClick();
                        return true;
                    case Keys.Shift | Keys.Tab:
                        menuPrevious.PerformClick();
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
