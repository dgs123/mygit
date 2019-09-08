namespace MyAlbumEditor
{
    partial class AlbumCalendar
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarDates = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // calendarDates
            // 
            this.calendarDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarDates.Location = new System.Drawing.Point(0, 0);
            this.calendarDates.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.calendarDates.MaxSelectionCount = 1;
            this.calendarDates.Name = "calendarDates";
            this.calendarDates.ShowToday = false;
            this.calendarDates.TabIndex = 0;
            this.calendarDates.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calendarDates_MouseDown);
            // 
            // AlbumCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendarDates);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlbumCalendar";
            this.Size = new System.Drawing.Size(344, 284);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarDates;
    }
}
