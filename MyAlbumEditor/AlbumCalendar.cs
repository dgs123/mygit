using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;
namespace MyAlbumEditor
{
    public partial class AlbumCalendar : UserControl
    {
        public AlbumCalendar()
        {
            InitializeComponent();
        }
        private AlbumManager _manager = null;
        public AlbumManager Manager
        {
            get { return _manager; }
            set
            {
                _manager = value;
                UpdateCalendar();
            }
        }

        private void UpdateCalendar()
        {
            throw new NotImplementedException();
        }
    }
}
