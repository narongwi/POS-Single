using BJCBCPOS.Services.Fonts;
using BJCBCPOS.Services.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace BJCBCPOS.Services.Controls {
    class CustomPictureIcon:PictureBox {
        private int _iconSize = FontIcon.DefaultSize;
        private POSIcons _iconType = POSIcons.Image;
        public new static readonly Size DefaultSize = new Size(FontIcon.DefaultSize,FontIcon.DefaultSize);
        public new static readonly Color DefaultForeColor = Color.Black;
        public new static readonly Color DefaultBackColor = Color.White;


        [Category("Custom Control"), Description("The icon"),DefaultValue(POSIcons.Image)]
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
        public CustomPictureIcon() {
            FontIcon.Initialize(); 

            if(!typeof(POSIcons).IsEnum) throw new ArgumentException("FontAwensomeSolid must be an enum.");
            UpdateImage();
            Size = DefaultSize;

            SetStyle(
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.UserPaint |
             ControlStyles.DoubleBuffer,
             true
         );

            SizeChanged += IconPictureBox_SizeChanged;
            Disposed += IconPictureBox_Disposed;
        }
        public bool ShouldSerializeImage() { return false; }
        public bool ShouldSerializeForeColor() { return base.ForeColor != DefaultBackColor; }
        public new void ResetForeColor() { ForeColor = DefaultBackColor; }
        public bool ShouldSerializeBackColor() { return base.BackColor != DefaultForeColor; }
        public new void ResetBackColor() { ForeColor = DefaultForeColor; }
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

        protected override void OnPaint(PaintEventArgs pe) {
            var graphics = pe.Graphics;
            base.OnPaint(pe);

            if(!Focused) return;
            var rc = ClientRectangle;
            rc.Inflate(-2,-2);
            ControlPaint.DrawFocusRectangle(pe.Graphics,rc);
        }
    }
}
