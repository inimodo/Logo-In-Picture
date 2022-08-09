using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace User
{
    public partial class Main : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;

        private string[] s_SourceFiles;
        private string s_LogoFile;
        private string s_DestPath;
        public Main()
        {
            InitializeComponent();
            InitializeInterface(new Size(260, 140)); 
        }

        void InitializeInterface(Size o_size)
        {
            int i_offset = this.Size.Width - o_size.Width;
            this.e_nav_close.Location = new Point(this.e_nav_close.Location.X - i_offset, this.e_nav_close.Location.Y);
            this.Size = new Size(o_size.Width, o_size.Height + e_nav.Size.Height);
            this.e_hider.Size = new Size(o_size.Width - 2, o_size.Height - 2);
            this.e_hider.Location = new Point(1, 1 + e_nav.Size.Height);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width - 2, e_nav.Size.Height);
            this.e_nav_logo.Location = new Point(e_nav_logo.Location.X, 1);
            this.e_nav_title.Text = "LogoInPrinter";

            e_Position.SelectedIndex = 0;
        }

        void event_focus(object sender, EventArgs e)
        {
        }
        void event_unfocus(object sender, EventArgs e)
        {

        }
        void event_close(object sender, EventArgs e)
        {
            this.Close();
        }

        void Move_start(object o_sender, MouseEventArgs o_mouseventargs)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }
        void Move_run(object o_sender, MouseEventArgs o_mouseventargs)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }
        void Move_stop(object o_sender, MouseEventArgs o_mouseventargs)
        {
            b_indrag = false;
        }

        private void SelSourceFolder(object sender, EventArgs e)
        {
            using (OpenFileDialog o_Dialog = new OpenFileDialog())
            {
                o_Dialog.Multiselect = true;
                o_Dialog.Filter = "png files (*.png)|*.png| jpg files (*.jpg)|*.jpg";
                o_Dialog.RestoreDirectory = true;
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    s_SourceFiles = new string[o_Dialog.FileNames.Length];
                    s_SourceFiles = o_Dialog.FileNames;

                    e_SourceFolder.Text = o_Dialog.FileNames.Length + " File(s) Loaded!";
                }
            }
        }

        private void SelLogoSource(object sender, EventArgs e)
        {
            using (OpenFileDialog o_Dialog = new OpenFileDialog())
            {
                o_Dialog.Multiselect = false;
                o_Dialog.Filter = "png files (*.png)|*.png| jpg files (*.jpg)|*.jpg";
                o_Dialog.RestoreDirectory = true;
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    s_LogoFile = o_Dialog.FileName;
                    e_LogoSource.Text = "Logo Loaded!";
                }
            }
        }

        private void SelDestFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog o_Dialog = new FolderBrowserDialog())
            {
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    s_DestPath = o_Dialog.SelectedPath;
                    e_DestFolder.Text = "Folder Selected!";
                }
            }
        }


        private void Run(object sender, EventArgs e)
        {
            int[] xyOffset(int i_imgSizeX,int i_imgSizeY, int i_logoSizeX, int i_logoSizeY)
            {
                int i_xOffset = 0, i_yOffset = 0;
                switch (e_Position.SelectedIndex)
                {
                    case 0:
                        i_xOffset = (int)e_SideOffset.Value;
                        i_yOffset = (int)e_SideOffset.Value;
                        break;
                    case 1:
                        i_xOffset = (int)e_SideOffset.Value;
                        i_yOffset = i_imgSizeY - (int)e_SideOffset.Value- i_logoSizeY;
                        break;
                    case 2:
                        i_xOffset = i_imgSizeX-(int)e_SideOffset.Value- i_logoSizeX;
                        i_yOffset = (int)e_SideOffset.Value;
                        break;
                    case 3:
                        i_xOffset = i_imgSizeX - (int)e_SideOffset.Value- i_logoSizeX;
                        i_yOffset = i_imgSizeY - (int)e_SideOffset.Value - i_logoSizeY;
                        break;
                }
                return new int[2]{i_xOffset,i_yOffset};
            }
            Bitmap o_Logo = (Bitmap)Image.FromFile(s_LogoFile);

            if (o_Logo == null)
            {
                MessageBox.Show("Image file could not be loaded! Aborting!\nPATH:"+ s_LogoFile, "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            for (int i_Index = 0; i_Index < s_SourceFiles.Length; i_Index++)
            {
                Bitmap o_SourceImage =(Bitmap) Image.FromFile(s_SourceFiles[i_Index]);
                if (o_SourceImage == null)
                {
                    MessageBox.Show("Image file could not be loaded! Skipping!\nPATH:" + s_SourceFiles[i_Index], "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                int[] i_Offsets = xyOffset(o_SourceImage.Width, o_SourceImage.Height, o_Logo.Width, o_Logo.Height);

                if (o_SourceImage.Width >= o_Logo.Width + i_Offsets[0] && o_SourceImage.Height >= o_Logo.Height + i_Offsets[1])
                {
                    for (int i_xIndex = 0; i_xIndex < o_Logo.Width; i_xIndex++)
                    {
                        for (int i_yIndex = 0; i_yIndex < o_Logo.Height; i_yIndex++)
                        {
                            Color o_Color = o_Logo.GetPixel(i_xIndex, i_yIndex);
                            if (o_Color.A == 0) continue;
                            o_SourceImage.SetPixel(i_Offsets[0]+ i_xIndex, i_Offsets[1] + i_yIndex, o_Color);
                        }
                    }
                }
                else
                {
                    o_SourceImage.Dispose();
                    MessageBox.Show("Image dimensions missmatch logo! Skipping!\nPATH:" + s_SourceFiles[i_Index], "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                Random o_rnd = new Random();
                o_SourceImage.Save(s_DestPath+"\\"+ s_SourceFiles[i_Index].Split('\\')[s_SourceFiles[i_Index].Split('\\').Length-1]);
                o_SourceImage.Dispose();
            }
            o_Logo.Dispose();

        }
    }
}
