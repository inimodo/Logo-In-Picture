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


        public Main()
        {
            InitializeComponent();
            InitializeInterface(this.e_hider.Size); 
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
            this.e_nav_title.Text = "Logo-In-Picture";


            e_Position.SelectedIndex = 3;
            e_Modi.Items.Add("Add");
            e_Modi.Items.Add("Invert");
            e_Modi.Items.Add("Cut"); 
            e_Modi.SelectedIndex = 1;
        }


        void Close(object sender, EventArgs e)
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

        private void SelLogoSource(object sender, EventArgs e)
        {
            using (OpenFileDialog o_Dialog = new OpenFileDialog())
            {
                o_Dialog.FileName = Application.ExecutablePath;
                o_Dialog.Multiselect = false;
                o_Dialog.Filter = "png files (*.png)|*.png| jpg files (*.jpg)|*.jpg";
                o_Dialog.RestoreDirectory = true;
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    Smarts.s_LogoFile = o_Dialog.FileName;
                    e_LogoSource.Text = "Logo Loaded!";
                }
            }
        }

        private void SelDestFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog o_Dialog = new FolderBrowserDialog())
            {
                o_Dialog.SelectedPath = Application.StartupPath;
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    Smarts.s_DestPath = o_Dialog.SelectedPath;
                    e_DestFolder.Text = "Folder Selected!";
                }
            }
        }
        private void OpenFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog o_Dialog = new FolderBrowserDialog())
            {
                o_Dialog.SelectedPath = Application.StartupPath;
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> s_Files = new List<string>();
                    foreach (string o_Item in Directory.GetFileSystemEntries(o_Dialog.SelectedPath, "*", SearchOption.AllDirectories))
                    {
                        if (File.Exists(o_Item)) s_Files.Add(o_Item);
                    }
                    Smarts.s_SourcePath = o_Dialog.SelectedPath;
                    Smarts.s_SourceFiles = s_Files.ToArray();
                    e_SourceFolder.Text = Smarts.s_SourceFiles.Length + " File(s) Loaded!";
                }
            }
        }


        private async void Run(object sender, EventArgs e)
        {
            int i_Alpha = 255;
            if (e_TransparentToggle.Checked) i_Alpha = 0;

            Smarts.i_PosModi = e_Position.SelectedIndex;
            Smarts.i_MixModi = e_Modi.SelectedIndex;
            Smarts.f_Opacity =(float)e_Opacity.Value / 100.0f;
            Smarts.i_Sideoffset =(int)e_SideOffset.Value;
            Smarts.f_CoverScale = (float)e_CoverScale.Value/100.0f;
            Smarts.i_StreamLength = (int)e_StreamLength.Value;
            Smarts.i_StreamVariation= (int)e_StreamVariation.Value;
            Smarts.i_StreamDensity= (int)e_CoverScale.Value;
            Smarts.o_StreamEndcolor = Color.FromArgb(i_Alpha, e_StreamEndcolor.BackColor);

            e_hider.Enabled = false;
            await Task.Run(() =>
            {
                Smarts.LogoCompine();
            });
            MessageBox.Show("All files were processed successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            e_hider.Enabled = true;
        }

        private void OpenColorDialog(object sender, EventArgs e)
        {
            using (ColorDialog o_Dialog = new ColorDialog())
            {
                if (o_Dialog.ShowDialog() == DialogResult.OK)
                {
                    e_StreamEndcolor.BackColor = o_Dialog.Color;
                }
            }
        }
    }
}
