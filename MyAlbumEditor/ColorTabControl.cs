using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyAlbumEditor
{
   public partial class ColorTabControl:TabControl
   {
        public ColorTabControl()
        {
            base.DrawMode = TabDrawMode.OwnerDrawFixed;//表示这个控件将对它的选项卡进行自定义绘制
        }
        private Color _tabColor;
        private Color _setTabColor;
        public new TabDrawMode DrawMode
        {
            get { return TabDrawMode.OwnerDrawFixed; }
        }
        public Color TabColor   //提供了绘制常规选项卡的颜色
        {
            get { return _tabColor; }
            set { _tabColor = value; }
        }
        public Color SelectedTabColor   //定义了当前显示的选项卡的绘图颜色
        {
            get { return _setTabColor; }
            set { _setTabColor = value; }
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {

            base.OnDrawItem(e);
            TabPage page = TabPages[e.Index];//表示当前选项卡的索引值
            Brush b;
            if (e.Index == SelectedIndex)
            {
                b = new SolidBrush(SelectedTabColor);
            }
            else
            {
                b = new SolidBrush(TabColor);
            }
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            if (Alignment == TabAlignment.Right)
            {
                sf.FormatFlags = StringFormatFlags.DirectionVertical;   //绘制垂直文本
                e.Graphics.DrawString(page.Text, e.Font, b, e.Bounds, sf);
            }
            else if (Alignment == TabAlignment.Left)
            {
                sf.FormatFlags = StringFormatFlags.DirectionVertical;   //绘制垂直文本
                Bitmap bmp = new Bitmap(e.Bounds.Width, e.Bounds.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawString(page.Text, e.Font, b, bmp.Width / 2 - 1, bmp.Height / 2 - 1, sf);
                g.Dispose();
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);   //旋转图片
                e.Graphics.DrawImage(bmp, e.Bounds);    //绘制图像
            }
            else
            {
                e.Graphics.DrawString(page.Text, e.Font, b, e.Bounds, sf);
            }
        }
    }
}
