using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;
using BJCBCPOS.Services.Helper;
using BJCBCPOS.Services.Fonts;

namespace BJCBCPOS.Services.Controls {
   public class CustomIcon : PictureBox {
        //Fields
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;
        private int _iconSize = FontIcon.DefaultSize;
        private POSIcons _iconType = POSIcons.Image;
        public new static readonly Size DefaultSize = new Size(FontIcon.DefaultSize,FontIcon.DefaultSize);
        public new static readonly Color DefaultForeColor = Color.Black;
        public new static readonly Color DefaultBackColor = Color.White;

        //Constructor
        public CustomIcon() {
            this.Size = new Size(100,100);
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            FontIcon.Initialize();
            if(!typeof(POSIcons).IsEnum) throw new ArgumentException("FontAwensomeSolid must be an enum.");

            UpdateImage();
            //Size = DefaultSize;

            SetStyle(
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.UserPaint |
             ControlStyles.DoubleBuffer,
             true
         );

        }

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
        public Color BorderColor {
            get { return borderColor; }
            set {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Control")]
        public Color BorderColor2 {
            get { return borderColor2; }
            set {
                borderColor2 = value;
                this.Invalidate();
            }
        }
        [Category("Custom Control")]
        public DashStyle BorderLineStyle {
            get { return borderLineStyle; }
            set {
                borderLineStyle = value;
                this.Invalidate();
            }
        }
        [Category("Custom Control")]
        public DashCap BorderCapStyle {
            get { return borderCapStyle; }
            set {
                borderCapStyle = value;
                this.Invalidate();
            }
        }
        [Category("Custom Control")]
        public float GradientAngle {
            get { return gradientAngle; }
            set {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        [Category("Custom Control"), Description("The icon"), DefaultValue(POSIcons.Image)]
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
            get => _iconSize;
            set {
                if(value == _iconSize) return;
                _iconSize = value;
                UpdateImage();
                this.Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public new Color ForeColor {
            get => base.ForeColor;
            set {
                if(base.ForeColor == value) return;
                base.ForeColor = value;
                UpdateImage();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public new Color BackColor {
            get => base.BackColor;
            set {
                if(base.BackColor == value) return;
                base.BackColor = value;
                UpdateImage();
            }
        }
        [Category("Custom Control"), Description("The icon color")]
        public Color IconColor {
            get => ForeColor;
            set {
                if(ForeColor == value) return;
                ForeColor = value;
            }
        }

        //Overridden methods
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            this.Size = new Size(this.Width,this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle,-1,-1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth,-borderSize,-borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using(var borderGColor = new LinearGradientBrush(rectBorder,borderColor,borderColor2,gradientAngle))
            using(var pathRegion = new GraphicsPath())
            using(var penSmooth = new Pen(this.Parent.BackColor,smoothSize))
            using(var penBorder = new Pen(borderGColor,borderSize)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                //Set rounded region 
                this.Region = new Region(pathRegion);
                //Drawing
                graph.DrawEllipse(penSmooth,rectContourSmooth);//Draw contour smoothing
                if(borderSize > 0) //Draw border
                    graph.DrawEllipse(penBorder,rectBorder);
            }
        }

        // hide Image in designer (we want only icon)
        [ReadOnly(true), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image Image {
            get => base.Image;
            set => base.Image = value;
        }

        protected void UpdateImage() {
            var image = base.Image;
            if(image != null)
                image.Dispose(); // Dispose old image - in other case we will have memory leaks

            Image = FontIcon.Fonts.Families[0].ToBitmap(_iconType,IconSize,IconSize,base.ForeColor);
        }

        private void IconPictureBox_Disposed(object sender,EventArgs e) {
            base.Image = null; // In some cases, catch errors in forms constructor with image
        }

        private void IconPictureBox_SizeChanged(object sender,EventArgs e) {
            if(SizeMode != PictureBoxSizeMode.AutoSize)
                IconSize = Math.Min(Width,Height);
            Invalidate();
        }
    }
}
