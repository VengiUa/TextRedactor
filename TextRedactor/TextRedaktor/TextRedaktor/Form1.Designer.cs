namespace TextRedaktor
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTBMyText = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnTextType = new System.Windows.Forms.Button();
            this.btnTextSize = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.SFD1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCopyStyle = new System.Windows.Forms.Button();
            this.btnPasteStyle = new System.Windows.Forms.Button();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.Controls.Add(this.toolStrip1);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(557, 36);
            this.pnlTopPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(557, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.newFileToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(41, 33);
            this.toolStripSplitButton1.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.EVEOpenFile);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.EVESave);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "Save as ...";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.EVESaveIn);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(65, 33);
            this.toolStripSplitButton2.Text = "Settings";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.ukrainianToolStripMenuItem,
            this.rusToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(59, 33);
            this.toolStripSplitButton3.Text = "Simple";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.EVEhelp);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.EVEAbout);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RTBMyText);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 329);
            this.panel1.TabIndex = 1;
            // 
            // RTBMyText
            // 
            this.RTBMyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBMyText.Location = new System.Drawing.Point(0, 0);
            this.RTBMyText.Name = "RTBMyText";
            this.RTBMyText.Size = new System.Drawing.Size(557, 274);
            this.RTBMyText.TabIndex = 1;
            this.RTBMyText.Text = "";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 55);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 56);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTextColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackColor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTextType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTextSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBold, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnU, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnI, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCenter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLeft, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRight, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPaste, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyStyle, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPasteStyle, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Location = new System.Drawing.Point(406, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 22);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.EVECopy);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextColor.Location = new System.Drawing.Point(3, 3);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(69, 22);
            this.btnTextColor.TabIndex = 0;
            this.btnTextColor.Text = "Text Color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.EveColor);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackColor.Location = new System.Drawing.Point(3, 31);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(69, 22);
            this.btnBackColor.TabIndex = 1;
            this.btnBackColor.Text = "Back Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.EveBackColor);
            // 
            // btnTextType
            // 
            this.btnTextType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextType.Location = new System.Drawing.Point(78, 3);
            this.btnTextType.Name = "btnTextType";
            this.btnTextType.Size = new System.Drawing.Size(77, 22);
            this.btnTextType.TabIndex = 2;
            this.btnTextType.Text = "Type of text";
            this.btnTextType.UseVisualStyleBackColor = true;
            this.btnTextType.Click += new System.EventHandler(this.EVETypeT);
            // 
            // btnTextSize
            // 
            this.btnTextSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextSize.Location = new System.Drawing.Point(78, 31);
            this.btnTextSize.Name = "btnTextSize";
            this.btnTextSize.Size = new System.Drawing.Size(77, 22);
            this.btnTextSize.TabIndex = 3;
            this.btnTextSize.Text = "Text Size";
            this.btnTextSize.UseVisualStyleBackColor = true;
            this.btnTextSize.Click += new System.EventHandler(this.EVESizeChange);
            // 
            // btnBold
            // 
            this.btnBold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBold.Location = new System.Drawing.Point(161, 3);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(70, 22);
            this.btnBold.TabIndex = 5;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.EVEBold);
            // 
            // btnU
            // 
            this.btnU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnU.Location = new System.Drawing.Point(237, 3);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(76, 22);
            this.btnU.TabIndex = 6;
            this.btnU.Text = "UnderLine";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.EVEUnderline);
            // 
            // btnI
            // 
            this.btnI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnI.Location = new System.Drawing.Point(319, 3);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(81, 22);
            this.btnI.TabIndex = 7;
            this.btnI.Text = "Italic";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.EVEItalic);
            // 
            // btnCenter
            // 
            this.btnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCenter.Location = new System.Drawing.Point(161, 31);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(70, 22);
            this.btnCenter.TabIndex = 8;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.EVECenter);
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.Location = new System.Drawing.Point(237, 31);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(76, 22);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.EVELeft);
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.Location = new System.Drawing.Point(319, 31);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(81, 22);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.EVERight);
            // 
            // btnPaste
            // 
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaste.Location = new System.Drawing.Point(406, 31);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(71, 22);
            this.btnPaste.TabIndex = 12;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.EVEPaste);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "openFileDialog1";
            // 
            // btnCopyStyle
            // 
            this.btnCopyStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyStyle.Location = new System.Drawing.Point(483, 3);
            this.btnCopyStyle.Name = "btnCopyStyle";
            this.btnCopyStyle.Size = new System.Drawing.Size(71, 22);
            this.btnCopyStyle.TabIndex = 13;
            this.btnCopyStyle.Text = "Copy Style";
            this.btnCopyStyle.UseVisualStyleBackColor = true;
            this.btnCopyStyle.Click += new System.EventHandler(this.EVECopyStyle);
            // 
            // btnPasteStyle
            // 
            this.btnPasteStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPasteStyle.Location = new System.Drawing.Point(483, 31);
            this.btnPasteStyle.Name = "btnPasteStyle";
            this.btnPasteStyle.Size = new System.Drawing.Size(71, 22);
            this.btnPasteStyle.TabIndex = 14;
            this.btnPasteStyle.Text = "Paste Style";
            this.btnPasteStyle.UseVisualStyleBackColor = true;
            this.btnPasteStyle.Click += new System.EventHandler(this.EVEPasteFont);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EVEChangeLangEng);
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ukrainianToolStripMenuItem.Text = "Ukrainian";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.EVEChangeLangUkr);
            // 
            // rusToolStripMenuItem
            // 
            this.rusToolStripMenuItem.Name = "rusToolStripMenuItem";
            this.rusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rusToolStripMenuItem.Text = "rus";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopPanel);
            this.Name = "MainForm";
            this.Text = "TextRedaktor";
            this.Load += new System.EventHandler(this.CreateFont);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox RTBMyText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnTextType;
        private System.Windows.Forms.Button btnTextSize;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.SaveFileDialog SFD1;
        private System.Windows.Forms.Button btnCopyStyle;
        private System.Windows.Forms.Button btnPasteStyle;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rusToolStripMenuItem;
    }
}

