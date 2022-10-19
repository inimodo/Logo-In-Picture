using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{

    public static class Smarts{


        public static string[] s_SourceFiles;
        public static string s_LogoFile;
        public static string s_DestPath;
        public static string s_SourcePath;
        public static int i_PosModi;
        public static int i_MixModi;
        public static int i_Sideoffset;
        public static float f_Opacity;
        public static float f_CoverScale;

        public static Color o_StreamEndcolor;
        public static int i_StreamLength;
        public static int i_StreamVariation;
        public static int i_StreamDensity;


        private static int[] xyOffset(Size o_imgSize, Size o_logoSize)
        {
            int i_xOffset = 0, i_yOffset = 0;
            switch (i_PosModi)
            {
                case 0:
                    i_xOffset = i_Sideoffset;
                    i_yOffset = i_Sideoffset;
                    break;
                case 1:
                    i_xOffset = i_Sideoffset;
                    i_yOffset = o_imgSize.Height - i_Sideoffset - o_logoSize.Height;
                    break;
                case 2:
                    i_xOffset = o_imgSize.Width - i_Sideoffset - o_logoSize.Width;
                    i_yOffset = i_Sideoffset;
                    break;
                case 3:
                    i_xOffset = o_imgSize.Width - i_Sideoffset - o_logoSize.Width;
                    i_yOffset = o_imgSize.Height- i_Sideoffset - o_logoSize.Height;
                    break;
            }
            return new int[2] { i_xOffset, i_yOffset };
        }
        private static Color MixColor(Color c_Basecolor, Color c_Logocolor)
        {
            switch (i_MixModi)
            {
                case 0:
                    return Color.FromArgb(
                        (int)((c_Basecolor.R) + c_Logocolor.R * f_Opacity) / 2,
                        (int)((c_Basecolor.G) + c_Logocolor.G * f_Opacity) / 2,
                        (int)((c_Basecolor.B) + c_Logocolor.B * f_Opacity) / 2);
                case 1:
                    return Color.FromArgb(
                        (int)(255 - c_Basecolor.R),
                        (int)(255 - c_Basecolor.G),
                        (int)(255 - c_Basecolor.B));
                case 2:
                    return Color.FromArgb(
                        (int)(((255 - c_Basecolor.R) * (c_Basecolor.R * f_Opacity)) % 255.0f),
                        (int)(((255 - c_Basecolor.G) * (c_Basecolor.R * f_Opacity)) % 255.0f),
                        (int)(((255 - c_Basecolor.B) * (c_Basecolor.R * f_Opacity)) % 255.0f));
                default:
                    return new Color();
            }

        }


        public static int[] LogoCompine()
        {
            Bitmap o_Logo = (Bitmap)Image.FromFile(s_LogoFile), o_SourceImage;
            List<int> i_Error = new List<int>();
            if (o_Logo == null)
            {
                return null;
            }
            for (int i_Index = 0; i_Index < s_SourceFiles.Length; i_Index++)
            {
                o_SourceImage = (Bitmap)Image.FromFile(s_SourceFiles[i_Index]);
                if (o_SourceImage == null)
                {
                    i_Error.Add(i_Index);
                    continue;
                }
                int[] i_Offsets = xyOffset(o_SourceImage.Size, o_Logo.Size);

                if (o_SourceImage.Width >= o_Logo.Width + i_Offsets[0] && o_SourceImage.Height >= o_Logo.Height + i_Offsets[1])
                {
                    for (int i_xIndex = 0; i_xIndex < o_Logo.Width; i_xIndex++)
                    {
                        for (int i_yIndex = 0; i_yIndex < o_Logo.Height; i_yIndex++)
                        {
                            Color o_SourceColor = o_Logo.GetPixel(i_xIndex, i_yIndex);
                            Color o_BaseColor = o_SourceImage.GetPixel(i_Offsets[0] + i_xIndex, i_Offsets[1] + i_yIndex);
                            Color o_Color = MixColor(o_BaseColor, o_SourceColor);
                            if (o_SourceColor.A == 0) continue;
                            o_SourceImage.SetPixel(i_Offsets[0] + i_xIndex, i_Offsets[1] + i_yIndex, o_Color);
                        }
                    }
                }
                else
                {
                    o_SourceImage.Dispose();
                    i_Error.Add(i_Index);
                    continue;
                }
                string s_Path = s_SourceFiles[i_Index].Replace(s_SourcePath, s_DestPath).ToLower();
                Console.WriteLine(s_Path);
                if (File.Exists(s_Path)) File.Delete(s_Path);
                o_SourceImage.Save(s_Path,System.Drawing.Imaging.ImageFormat.Jpeg);

                if (s_Path.Contains("edit"))
                {
                    Bitmap o_Temp = new Bitmap(o_SourceImage,new Size(
                        (int)((float)o_SourceImage.Width*f_CoverScale),
                        (int)((float)o_SourceImage.Height * f_CoverScale)
                        
                        ));
                    DrawStream(ref o_Temp);
                    o_Temp.Save(s_Path.Replace("edit", "cover").Replace("jpg","png"), System.Drawing.Imaging.ImageFormat.Png);
                    o_Temp.Dispose();

                }
                o_SourceImage.Dispose();
            }
            o_Logo.Dispose();
            return i_Error.ToArray();
        }
        public static void DrawStream(ref Bitmap o_Image)
        {
            Color ColorGradient(Color o_Base,Color o_Goal,float f_Pos)
            {
                return Color.FromArgb(
                    (int)((float)(o_Base.A - o_Goal.A) * f_Pos + (float)o_Goal.A),
                    (int)((float)(o_Base.R - o_Goal.R) * f_Pos + (float)o_Goal.R),
                    (int)((float)(o_Base.G - o_Goal.G) * f_Pos + (float)o_Goal.G),
                    (int)((float)(o_Base.B - o_Goal.B) * f_Pos + (float)o_Goal.B));
            }
            try
            {
                Random o_Rand = new Random();

                Bitmap o_Output = new Bitmap(o_Image.Size.Width + i_StreamLength, o_Image.Size.Height + i_StreamLength);
                Graphics o_Graphic = Graphics.FromImage(o_Output);
                o_Graphic.DrawImage(o_Image, new Rectangle(new Point(0,0),o_Image.Size));
                o_Graphic.Dispose();
                
 
                for (int i_X = 0; i_X < o_Image.Size.Width; i_X++)
                {
                    Color o_Base = o_Image.GetPixel(i_X, o_Image.Size.Height-1);
                    int i_Length = i_StreamLength - o_Rand.Next(i_StreamVariation);
                    for (int i_Sub = 0; i_Sub < i_Length; i_Sub++)
                    {
                        o_Output.SetPixel(i_X + i_Sub, o_Image.Size.Height + i_Sub, ColorGradient(o_Base,o_StreamEndcolor,1.0f-(float)i_Sub/ (float)i_Length));
                    }

                }
                for (int i_Y = 0; i_Y < o_Image.Size.Height; i_Y++)
                {
                    Color o_Base = o_Image.GetPixel(o_Image.Size.Width- 1, i_Y);
                    int i_Length = i_StreamLength - o_Rand.Next(i_StreamVariation);
                    for (int i_Sub = 0; i_Sub < i_Length; i_Sub++)
                    {
                        o_Output.SetPixel(o_Image.Size.Width + i_Sub, i_Y + i_Sub, ColorGradient(o_Base, o_StreamEndcolor, 1.0f - (float)i_Sub / (float)i_Length));
                    }
                    
                }
                o_Image.Dispose();
                o_Image = (Bitmap)o_Output.Clone();
                o_Output.Dispose();
            }
            catch (Exception e_Error)
            {
                Console.WriteLine(e_Error);
            }

        }
    }
}
