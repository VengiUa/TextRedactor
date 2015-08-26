using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedaktor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Font MyFont;
        Font PasteFont;
        Color textColor;
        Color BackColor;
        HorizontalAlignment MyAlig;
        protected int sizeOfMyText = 10;
        string _sometext;
        string _currentpath = "C:\\MyFirstProject.rtf";

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void EveColor(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                
                RTBMyText.SelectionColor = colorDialog1.Color;
                colorDialog1.Reset();
            }
            CreateFont(this, e);
        }

        private void EveBackColor(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog2.ShowDialog())
            {

                RTBMyText.SelectionBackColor = colorDialog2.Color;
                colorDialog2.Reset();
            }
            CreateFont(this, e);
        }

        private void EVEBold(object sender, EventArgs e)
        {

            if (RTBMyText.SelectionFont.Bold)
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Bold); 
            }
            CreateFont(this, e);
        }


        private void EVEItalic(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionFont.Italic)
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Italic);
            }

            CreateFont(this, e);
        }

        private void EVEUnderline(object sender, EventArgs e)
        {

            if (RTBMyText.SelectionFont.Underline)
            {
                RTBMyText.SelectionFont = new  Font(RTBMyText.SelectionFont, FontStyle.Regular);
            }
            else
            {
                RTBMyText.SelectionFont = new Font(RTBMyText.SelectionFont, FontStyle.Underline);
            }

            CreateFont(this, e);
            
        }

        private void EVECenter(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionAlignment == HorizontalAlignment.Center)
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Center;
               
            }
            CreateFont(this, e);
        }

        private void EVELeft(object sender, EventArgs e)
        {
            RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            CreateFont(this, e);
        }
        
        private void EVERight(object sender, EventArgs e)
        {
            if (RTBMyText.SelectionAlignment == HorizontalAlignment.Right)
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                RTBMyText.SelectionAlignment = HorizontalAlignment.Right;
            }

            CreateFont(this, e);
        }

        private void EVETypeT(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog(this))
            {
                RTBMyText.SelectionFont = fontDialog1.Font;
            }

            else
            {
                MessageBox.Show("Cancel");
            }

            CreateFont(this, e);
            
        }

        private void CreateFont(object sender, EventArgs e)
        {
            MyFont = RTBMyText.Font;
        }

        private void EVESizeChange(object sender, EventArgs e)
        {
            string size = RTBMyText.SelectionFont.GetHeight().ToString(); 

            frmSizeOftext MySize = new frmSizeOftext();
            MySize.Owner = this;



            if (DialogResult.OK == MySize.ShowDialog())
            {
                
                string s = MySize.Text;
                int sizes = sizeOfMyText;

                try
                {
                    sizes = int.Parse(s);

                    if (int.Parse(s) < 0 || int.Parse(s) > 150)
                        {
                        MessageBox.Show("Size is incorrect");
                        }
                    else
                        {
                        RTBMyText.SelectionFont = new Font(MyFont.FontFamily, int.Parse(s), MyFont.Style);
                        MessageBox.Show("Ok");
                        }
                }
                catch
                {
                    MessageBox.Show("Size is incorrect");
                }

                sizeOfMyText = sizes;
                
            }
            else
            {
                MessageBox.Show("Cancel");
            }
            
            CreateFont(this, e);

        }

        private void EVECopy(object sender, EventArgs e)
        {
            _sometext = RTBMyText.SelectedText;
        }

        private void EVEPaste(object sender, EventArgs e)
        {
            RTBMyText.SelectedText = _sometext;
        }

        private void EVEOpenFile(object sender, EventArgs e)
        {
           string rez = _currentpath;
            if (DialogResult.OK == OFD1.ShowDialog())
            {
               rez = OFD1.FileName;
                RTBMyText.LoadFile(OFD1.FileName);
            }

            else
            {
                MessageBox.Show("Cancel");
            }

            _currentpath = rez;
        }

        private void EVESave(object sender, EventArgs e)
        {
            string rez = _currentpath;

            if (_currentpath == "C:\\MyFirstProject.rtf")
            {
                if (DialogResult.OK == SFD1.ShowDialog())
                {
                    rez = SFD1.FileName+".rtf";
                    RTBMyText.SaveFile(rez);
                    MessageBox.Show(rez);
                }

                else
                {
                    MessageBox.Show("Cancel");
                }
                _currentpath = rez;
            }
            else
            {
                RTBMyText.SaveFile(_currentpath);
            }
        }

        private void EVESaveIn(object sender, EventArgs e)
        {
            string rez = _currentpath;
            if (DialogResult.OK == SFD1.ShowDialog())
            {
                rez = SFD1.FileName;
                File.Delete(SFD1.FileName);
                RTBMyText.SaveFile(SFD1.FileName);
            }

            else
            {
                MessageBox.Show("Cancel");
            }
            _currentpath = rez;
        }

        private void EVEhelp(object sender, EventArgs e)
        {
            MessageBox.Show("All help, that you can get - is a cuirrent link to MSDN! GOODBYE!!");
        }

        private void EVEAbout(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by VNG");
        }

        private void EVEPasteFont(object sender, EventArgs e)
        {
            RTBMyText.SelectionFont = PasteFont;
            RTBMyText.SelectionColor = textColor;
            RTBMyText.SelectionBackColor = BackColor;
            RTBMyText.SelectionAlignment = MyAlig;
        }

        private void EVECopyStyle(object sender, EventArgs e)
        {
            PasteFont = RTBMyText.SelectionFont;
            textColor = RTBMyText.SelectionColor;
            BackColor = RTBMyText.SelectionBackColor;
            MyAlig = RTBMyText.SelectionAlignment;
        }

        private void EVEChangeLangUkr(object sender, EventArgs e)
        {
            RTBMyText.Name = "Текстовий редактор";
            toolStripSplitButton1.Text = "Щось зроби з файлом";
            openFileToolStripMenuItem.Text = "Вiдкрити щось...";
            saveFileToolStripMenuItem.Text = "Кудись цей файл засунути...";
            newFileToolStripMenuItem.Text = "Засейвитись";
            toolStripSplitButton2.Text = "Рiзна маячня";
            viewToolStripMenuItem.Text = "Мова, а э питання?";
            optionToolStripMenuItem.Text = "Якась фiгня";
            profileToolStripMenuItem.Text = "Даннi про папiр";
            englishToolStripMenuItem.Text = "Англiйська";
            rusToolStripMenuItem.Text = "Мова окупанта";
            ukrainianToolStripMenuItem.Text = "Рiдна спiвоча мова";
            toolStripSplitButton3.Text = "Щось ще";
            helpToolStripMenuItem.Text = "Допомога - сам собi допоможи";
            aboutToolStripMenuItem.Text = "О програмi";
            btnTextColor.Text = "Колiр лiтер";
            btnBackColor.Text = "Колiр папiрусу";
            btnTextType.Text = "Купа налаштувань";
            btnTextSize.Text = "Розмiр, а маэ значення?";
            btnBold.Text = "Товстий";
            btnI.Text = "Кривий";
            btnU.Text = "З 1 полоскою";
            btnCenter.Text = "По центру";
            btnLeft.Text = "З лiвого краю";
            btnRight.Text = "З правого краю";
            btnCopy.Text = "Клонувати у буфер";
            btnPaste.Text = "Забрати у буфера";
            btnCopyStyle.Text = "Копiювати калечнiсть тексту";
            btnPasteStyle.Text = "Зробити цей текст таким же вмазаним";



        }

        private void EVEChangeLangEng(object sender, EventArgs e)
        {
            RTBMyText.Name = "Text redactor";
            toolStripSplitButton1.Text = "File";
            openFileToolStripMenuItem.Text = "Open...";
            saveFileToolStripMenuItem.Text = "Save as...";
            newFileToolStripMenuItem.Text = "Save";
            toolStripSplitButton2.Text = "Settings";
            viewToolStripMenuItem.Text = "View";
            optionToolStripMenuItem.Text = "Option";
            profileToolStripMenuItem.Text = "Profile";
            englishToolStripMenuItem.Text = "English";
            rusToolStripMenuItem.Text = "PArussian";
            ukrainianToolStripMenuItem.Text = "Ukrainian";
            toolStripSplitButton3.Text = "Simple";
            helpToolStripMenuItem.Text = "Help";
            aboutToolStripMenuItem.Text = "About";
            btnTextColor.Text = "TextColor";
            btnBackColor.Text = "BackColor";
            btnTextType.Text = "Text type";
            btnTextSize.Text = "Size";
            btnBold.Text = "Bold";
            btnI.Text = "Italic";
            btnU.Text = "Underline";
            btnCenter.Text = "Center";
            btnLeft.Text = "Left";
            btnRight.Text = "Right";
            btnCopy.Text = "Copy";
            btnPaste.Text = "Paste";
            btnCopyStyle.Text = "Copy style";
            btnPasteStyle.Text = "Paste style";   
        }

    }


    
}
