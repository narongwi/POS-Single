using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
namespace BJCBCPOS.Services.Helper {
    public static class FontIcon {
        internal const int DefaultSize = 30;
        private static readonly Color DefaultColor = SystemColors.WindowText;
        private static readonly Brush DefaultBrush = new SolidBrush(DefaultColor);

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,uint cbFont,IntPtr pdv,[System.Runtime.InteropServices.In] ref uint pcFonts);
        public static readonly PrivateFontCollection Fonts = new PrivateFontCollection();
        public static void Initialize() {
            try {
                if(Fonts.Families.Count() == 0) {
                    var resource = "BJCBCPOS.Services.Fonts.materialdesignicons.ttf";
                    var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    using(var fontAsStream = assembly.GetManifestResourceStream(resource)) {
                        if(fontAsStream != null) {
                            byte[] fontAsByte = new byte[fontAsStream.Length];
                            fontAsStream.Read(fontAsByte,0,(int)fontAsStream.Length);
                            fontAsStream.Close();
                            IntPtr memPointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(byte)) * fontAsByte.Length);
                            Marshal.Copy(fontAsByte,0,memPointer,fontAsByte.Length);
                            Fonts.AddMemoryFont(memPointer,fontAsByte.Length);
                        }
                    }
                }

            } catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public static Bitmap ToBitmap<FontAwensomeSolid>(this FontFamily fontFamily,FontAwensomeSolid icon,int width,int height,Color? color = null,bool iconBold = false)
         where FontAwensomeSolid : struct, IConvertible, IComparable, IFormattable {
            var bitmap = new Bitmap(width,height);
            using(var graphics = Graphics.FromImage(bitmap)) {
                var text = icon.ToChar();
                var font = graphics.GetAdjustedIconFont(fontFamily,text,new SizeF(width,height),iconBold);
                var brush = color.HasValue ? new SolidBrush(color.Value) : DefaultBrush;
                DrawIcon(graphics,font,text,width,height,brush);
            }
            return bitmap;
        }
        private static PointF GetTopLeft(this Graphics graphics,string text,Font font,SizeF size) {
            var iconSize = graphics.GetIconSize(text,font,size);
            // center icon
            var left = Math.Max(0f,(size.Width - iconSize.Width) / 2);
            var top = Math.Max(0f,(size.Height - iconSize.Height) / 2);
            return new PointF(left,top);
        }

        public static string ToChar<FontAwensomeSolid>(this FontAwensomeSolid icon) where FontAwensomeSolid : struct, IConvertible, IComparable, IFormattable {
            return char.ConvertFromUtf32(icon.UniCode());
        }

        private static int UniCode<TEnum>(this TEnum icon)
           where TEnum : struct, IConvertible, IComparable, IFormattable {
            return icon.ToInt32(System.Globalization.CultureInfo.InvariantCulture);
        }
        private static Font GetAdjustedIconFont(this Graphics g,FontFamily fontFamily,string text,
           SizeF size,bool iconBold = false,int maxFontSize = 0,int minFontSize = 4,bool smallestOnFail = true) {
            var safeMaxFontSize = maxFontSize > 0 ? maxFontSize : size.Height;
            for(double adjustedSize = safeMaxFontSize ; adjustedSize >= minFontSize ; adjustedSize -= 0.5) {
                var font = GetIconFont(fontFamily,(float)adjustedSize,iconBold);
                var iconSize = g.GetIconSize(text,font,size);
                if(iconSize.Width < size.Width && iconSize.Height < size.Height)
                    return font;
            }
            return GetIconFont(fontFamily,smallestOnFail ? minFontSize : maxFontSize);
        }
        public static void DrawIcon(this Graphics graphics,Font font,string text,int width = DefaultSize,int height = DefaultSize,Brush brush = null) {
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PageUnit = GraphicsUnit.Pixel;
            var topLeft = graphics.GetTopLeft(text,font,new SizeF(width,height));
            graphics.DrawString(text,font,brush ?? DefaultBrush,topLeft);
        }
        private static Font GetIconFont(FontFamily fontFamily,float size,bool iconBold = false) {
            return new Font(fontFamily,size,iconBold ? FontStyle.Bold : FontStyle.Regular,GraphicsUnit.Point);
        }
        private static Font GetIconFont(float size) {
            return new Font(Fonts.Families[0],size,GraphicsUnit.Point);
        }
        private static SizeF GetIconSize(this Graphics graphics,string text,Font font,SizeF size) {
            var format = new StringFormat();
            var ranges = new[] { new CharacterRange(0,text.Length) };
            format.SetMeasurableCharacterRanges(ranges);
            format.Alignment = StringAlignment.Center;
            var iconSize = graphics.MeasureString(text,font,size,format);
            return iconSize;
        }
    }
}
