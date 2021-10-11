using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using BJCBCPOS.Services.Helper;
using System.Drawing.Design;
using System.Globalization;
using System.Reflection;
using BJCBCPOS.Services.Fonts;

namespace BJCBCPOS.Services.Controls {
    class CustomButton : Button {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private int _size = FontIcon.DefaultSize;
        private Color _color = Color.White;
        private POSIcons _iconType = POSIcons.Image;
        private bool iconBold = false;
        private bool iconVisibled = true;
        private Color borderColor = Color.FromArgb(224,224,224);
        //private Color buttonOver = Color.FromArgb(72,176,72);

        //Properties
        [Category("Custom Control")]
        public int BorderSize {
            get { return borderSize; }
            set {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Control")]
        public int BorderRadius {
            get { return borderRadius; }
            set {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom Control")]
        public Color BorderColor {
            get { return borderColor; }
            set {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Control")]
        public Color BackgroundColor {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        //[Category("Custom Control")]
        //public Color ButtonColor {
        //    get { return this.buttonColor; }
        //    set { this.buttonColor = value; }
        //}
        //[Category("Custom Control")]
        //public Color ButtonOverColor {
        //    get { return this.buttonOver; }
        //    set { this.buttonOver = value; }
        //}
       
        [Category("Custom Control")]
        public Color TextColor {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("Custom Control")]
        public POSIcons IconType {
            get { return _iconType; }
            set {
                _iconType = value;
                UpdateImage();
                this.Invalidate();
            }
        }
      
        [Category("Custom Control"), Description("The icon size in pixels"), DefaultValue(FontIcon.DefaultSize)]
        public int IconSize {
            get => _size;
            set {
                if(_size == value) return;
                _size = value;
                UpdateImage();
                this.Invalidate();

            }
        }
        [Category("Custom Control"), Description("The icon Style Bold"), DefaultValue(false)]
        public bool IconBold {
            get => iconBold;
            set {
                iconBold = value;

                UpdateImage();
                this.Invalidate();

            }
        }
        [Category("Custom Control"), Description("The icon color")]
        public Color IconColor {
            get => _color;
            set {
                if(_color == value) return;
                _color = value;
                UpdateImage();
                this.Invalidate();

            }
        }
        [Category("Custom Control"), Description("Show The icon"), DefaultValue(false)]
        public bool ShowIcon {
            get => iconVisibled;
            set {
                iconVisibled = value;
                UpdateImage();
                this.Invalidate();

            }
        }
        public CustomButton()  {
            FontIcon.Initialize();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150,40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            //this.ImageAlign = ContentAlignment.MiddleLeft;
            //this.TextAlign = ContentAlignment.MiddleRight;
            this.BorderRadius = 8;
            this.borderSize = 1;
            DoubleBuffered = true;
            UpdateImage();

            this.Resize += new EventHandler(Button_Resize);
        }
        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect,int radius) {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X,rect.Y,curveSize,curveSize-2,180,90);
            path.AddArc(rect.Right - curveSize,rect.Y,curveSize,curveSize,270,90);
            path.AddArc(rect.Right - curveSize,rect.Bottom - curveSize,curveSize,curveSize,0,90);
            path.AddArc(rect.X,rect.Bottom - curveSize,curveSize,curveSize,90,90);
            path.CloseFigure();
            return path;
        }

        [ReadOnly(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image Image {
            get => base.Image;
            set => base.Image = value;
        }

        protected void UpdateImage() {
          Image = iconVisibled? FontIcon.Fonts.Families[0].ToBitmap(IconType,IconSize,IconSize,IconColor,IconBold):null;
        }

        //public bool ShouldSerializeImage() { return false; }
        protected override void OnPaint(PaintEventArgs pevent) {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface,-borderSize,-borderSize);
            int smoothSize = 2;
            if(borderSize > 0)
                smoothSize = borderSize;
            if(borderRadius > 2) //Rounded button
            {
                using(GraphicsPath pathSurface = GetFigurePath(rectSurface,borderRadius))
                using(GraphicsPath pathBorder = GetFigurePath(rectBorder,borderRadius - borderSize))
                using(Pen penSurface = new Pen(this.Parent.BackColor,smoothSize))
                using(Pen penBorder = new Pen(borderColor,borderSize)) {
                    pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface,pathSurface);
                    //Button border                    
                    if(borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder,pathBorder);
                }
            } else //Normal button
              {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if(borderSize >= 1) {
                    using(Pen penBorder = new Pen(borderColor,borderSize)) {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder,0,0,this.Width - 1,this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender,EventArgs e) {
            this.Invalidate();
        }
        private void Button_Resize(object sender,EventArgs e) {
            if(borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
