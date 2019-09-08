namespace Manning.MyPhotoControls
{
    partial class PhotoEditDialog
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhotoFile = new System.Windows.Forms.Label();
            this.txtPhotoFile = new System.Windows.Forms.TextBox();
            this.lblPhotoCaption = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblPhotoTakenDate = new System.Windows.Forms.Label();
            this.lblPhotographer = new System.Windows.Forms.Label();
            this.comboPhotographer = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel1.Size = new System.Drawing.Size(417, 299);
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tablePanel.Controls.Add(this.lblPhotoFile, 0, 0);
            this.tablePanel.Controls.Add(this.txtPhotoFile, 1, 0);
            this.tablePanel.Controls.Add(this.lblPhotoCaption, 0, 1);
            this.tablePanel.Controls.Add(this.txtCaption, 1, 1);
            this.tablePanel.Controls.Add(this.lblPhotoTakenDate, 0, 2);
            this.tablePanel.Controls.Add(this.lblPhotographer, 0, 3);
            this.tablePanel.Controls.Add(this.comboPhotographer, 1, 3);
            this.tablePanel.Controls.Add(this.dtpDateTaken, 1, 2);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 4;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.Size = new System.Drawing.Size(415, 297);
            this.tablePanel.TabIndex = 0;
            // 
            // lblPhotoFile
            // 
            this.lblPhotoFile.AutoSize = true;
            this.lblPhotoFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhotoFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhotoFile.Location = new System.Drawing.Point(2, 0);
            this.lblPhotoFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotoFile.Name = "lblPhotoFile";
            this.lblPhotoFile.Size = new System.Drawing.Size(141, 74);
            this.lblPhotoFile.TabIndex = 0;
            this.lblPhotoFile.Text = "Photo &File";
            this.lblPhotoFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhotoFile
            // 
            this.txtPhotoFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhotoFile.Location = new System.Drawing.Point(147, 1);
            this.txtPhotoFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPhotoFile.Multiline = true;
            this.txtPhotoFile.Name = "txtPhotoFile";
            this.txtPhotoFile.ReadOnly = true;
            this.txtPhotoFile.Size = new System.Drawing.Size(266, 72);
            this.txtPhotoFile.TabIndex = 1;
            // 
            // lblPhotoCaption
            // 
            this.lblPhotoCaption.AutoSize = true;
            this.lblPhotoCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhotoCaption.Location = new System.Drawing.Point(2, 74);
            this.lblPhotoCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotoCaption.Name = "lblPhotoCaption";
            this.lblPhotoCaption.Size = new System.Drawing.Size(141, 74);
            this.lblPhotoCaption.TabIndex = 2;
            this.lblPhotoCaption.Text = "Cap&tion";
            this.lblPhotoCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCaption
            // 
            this.txtCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaption.Location = new System.Drawing.Point(147, 75);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(266, 72);
            this.txtCaption.TabIndex = 3;
            this.txtCaption.TextChanged += new System.EventHandler(this.TxtCaption_TextChanged);
            this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCaption_KeyPress);
            // 
            // lblPhotoTakenDate
            // 
            this.lblPhotoTakenDate.AutoSize = true;
            this.lblPhotoTakenDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhotoTakenDate.Location = new System.Drawing.Point(2, 148);
            this.lblPhotoTakenDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotoTakenDate.Name = "lblPhotoTakenDate";
            this.lblPhotoTakenDate.Size = new System.Drawing.Size(141, 74);
            this.lblPhotoTakenDate.TabIndex = 4;
            this.lblPhotoTakenDate.Text = "&Date Taken";
            this.lblPhotoTakenDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhotographer
            // 
            this.lblPhotographer.AutoSize = true;
            this.lblPhotographer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhotographer.Location = new System.Drawing.Point(2, 222);
            this.lblPhotographer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotographer.Name = "lblPhotographer";
            this.lblPhotographer.Size = new System.Drawing.Size(141, 75);
            this.lblPhotographer.TabIndex = 6;
            this.lblPhotographer.Text = "&Photographer";
            this.lblPhotographer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboPhotographer
            // 
            this.comboPhotographer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPhotographer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPhotographer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboPhotographer.FormattingEnabled = true;
            this.comboPhotographer.Location = new System.Drawing.Point(148, 225);
            this.comboPhotographer.MaxDropDownItems = 4;
            this.comboPhotographer.Name = "comboPhotographer";
            this.comboPhotographer.Size = new System.Drawing.Size(264, 20);
            this.comboPhotographer.Sorted = true;
            this.comboPhotographer.TabIndex = 7;
            this.comboPhotographer.TextChanged += new System.EventHandler(this.ComboPhotographer_TextChanged);
            this.comboPhotographer.Leave += new System.EventHandler(this.ComboPhotographer_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 359);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 12);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "&Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.ContextMenuStrip = this.contextMenuStrip1;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNotes.Location = new System.Drawing.Point(0, 377);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(417, 128);
            this.txtNotes.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripMenuItem1,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.tsmiDelete,
            this.toolStripMenuItem2,
            this.tsmiSelectAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 148);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.ContextMenuStrip1_Opened);
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.Size = new System.Drawing.Size(124, 22);
            this.tsmiUndo.Text = "&Undo";
            this.tsmiUndo.Click += new System.EventHandler(this.TsmiUndo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(124, 22);
            this.tsmiCopy.Text = "&Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.TsmiCopy_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(124, 22);
            this.tsmiCut.Text = "C&UT";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(124, 22);
            this.tsmiPaste.Text = "&Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.TsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "&Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.TsmiDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(124, 22);
            this.tsmiSelectAll.Text = "&SelectAll";
            this.tsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // dtpDateTaken
            // 
            this.dtpDateTaken.Location = new System.Drawing.Point(148, 151);
            this.dtpDateTaken.Name = "dtpDateTaken";
            this.dtpDateTaken.Size = new System.Drawing.Size(264, 21);
            this.dtpDateTaken.TabIndex = 5;
            // 
            // PhotoEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(417, 505);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "PhotoEditDialog";
            this.Text = "Photo Properties";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblNotes, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.panel1.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label lblPhotoFile;
        private System.Windows.Forms.TextBox txtPhotoFile;
        private System.Windows.Forms.Label lblPhotoCaption;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label lblPhotoTakenDate;
        private System.Windows.Forms.Label lblPhotographer;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboPhotographer;
        private System.Windows.Forms.DateTimePicker dtpDateTaken;
    }
}
