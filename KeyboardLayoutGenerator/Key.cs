using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KeyboardLayoutGenerator
{
    public class Key
    {
        private double _size;
        private Color _color;
        private Color _keyColor;
        private double _width;
        private double _width2;
        private double _height;
        private double _height2;
        private double _x;
        private double _x2;
        private double _y;
        private double _y2;

        // The first part of the key is higher than the rest
        private bool _stepped;
        // Adds a bump to this key like on the F and J key on the keyboard
        private bool _homing;

        private string _topLeft;
        private string _topCenter;
        private string _topRight;
        private Color _colorTopLeft;
        private Color _colorTopCenter;
        private Color _colorTopRight;

        private string _centerLeft;
        private string _centerCenter;
        private string _centerRight;
        private Color _colorCenterLeft;
        private Color _colorCenterCenter;
        private Color _colorCenterRight;

        private string _bottomLeft;
        private string _bottomCenter;
        private string _bottomRight;
        private Color _colorBottomLeft;
        private Color _colorBottomCenter;
        private Color _colorBottomRight;

        private string _frontLeft;
        private string _frontCenter;
        private string _frontRight;
        private Color _colorFrontLeft;
        private Color _colorFrontCenter;
        private Color _colorFrontRight;

        public Key()
        {
            this._size = 3.0;
            this._color = Color.FromArgb(0, 0, 0);
            this._keyColor = Color.FromArgb(204, 204, 204);
            this._width = 1.0;
            this._height = 1.0;
            this._width2 = 1.0;
            this._height2 = 1.0;
            this._x = 0.0;
            this._y = 0.0;
            this._x2 = 0.0;
            this._y2 = 0.0;

            this._stepped = false;
            this._homing = false;

            this._topLeft = "";
            this._topCenter = "";
            this._topRight = "";

            this._centerLeft = "";
            this._centerCenter = "";
            this._centerRight = "";

            this._bottomLeft = "";
            this._bottomCenter = "";
            this._bottomRight = "";

            this._frontLeft = "";
            this._frontCenter = "";
            this._frontRight = "";
        }

        public double Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value >= 1.0 ? value : 1.0;
            }
        }

        public Color Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public Color KeyColor
        {
            get
            {
                return this._keyColor;
            }
            set
            {
                this._keyColor = value;
            }
        }

        public double Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value >= 1.0 ? value : 1.0;
            }
        }

        public double Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value >= 1.0 ? value : 1.0;
            }
        }

        public double Width2
        {
            get
            {
                return this._width2;
            }
            set
            {
                this._width2 = value >= 1.0 ? value : 1.0;
            }
        }

        public double Height2
        {
            get
            {
                return this._height2;
            }
            set
            {
                this._height2 = value >= 1.0 ? value : 1.0;
            }
        }

        public double X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        public double Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        public double X2
        {
            get
            {
                return this._x2;
            }
            set
            {
                this._x2 = value;
            }
        }

        public double Y2
        {
            get
            {
                return this._y2;
            }
            set
            {
                this._y2 = value;
            }
        }

        public bool Stepped
        {
            get
            {
                return this._stepped;
            }
            set
            {
                this._stepped = value;
            }
        }

        public bool Homing
        {
            get
            {
                return this._homing;
            }
            set
            {
                this._homing = value;
            }
        }

        public string CaptionTopLeft
        {
            get
            {
                return this._topLeft;
            }
            set
            {
                this._topLeft = value;
            }
        }

        public string CaptionTopCenter
        {
            get
            {
                return this._topCenter;
            }
            set
            {
                this._topCenter = value;
            }
        }

        public string CaptionTopRight
        {
            get
            {
                return this._topRight;
            }
            set
            {
                this._topRight = value;
            }
        }

        public Color ColorTopLeft
        {
            get
            {
                return this._colorTopLeft;
            }
            set
            {
                this._colorTopLeft = value;
            }
        }

        public Color ColorTopCenter
        {
            get
            {
                return this._colorTopCenter;
            }
            set
            {
                this._colorTopCenter = value;
            }
        }

        public Color ColorTopRight
        {
            get
            {
                return this._colorTopRight;
            }
            set
            {
                this._colorTopRight = value;
            }
        }

        public string CaptionCenterLeft
        {
            get
            {
                return this._centerLeft;
            }
            set
            {
                this._centerLeft = value;
            }
        }

        public string CaptionCenterCenter
        {
            get
            {
                return this._centerCenter;
            }
            set
            {
                this._centerCenter = value;
            }
        }

        public string CaptionCenterRight
        {
            get
            {
                return this._centerRight;
            }
            set
            {
                this._centerRight = value;
            }
        }

        public Color ColorCenterLeft
        {
            get
            {
                return this._colorCenterLeft;
            }
            set
            {
                this._colorCenterLeft = value;
            }
        }

        public Color ColorCenterCenter
        {
            get
            {
                return this._colorCenterCenter;
            }
            set
            {
                this._colorCenterCenter = value;
            }
        }

        public Color ColorCenterRight
        {
            get
            {
                return this._colorCenterRight;
            }
            set
            {
                this._colorCenterRight = value;
            }
        }

        public string CaptionBottomLeft
        {
            get
            {
                return this._bottomLeft;
            }
            set
            {
                this._bottomLeft = value;
            }
        }

        public string CaptionBottomCenter
        {
            get
            {
                return this._bottomCenter;
            }
            set
            {
                this._bottomCenter = value;
            }
        }

        public string CaptionBottomRight
        {
            get
            {
                return this._bottomRight;
            }
            set
            {
                this._bottomRight = value;
            }
        }

        public Color ColorBottomLeft
        {
            get
            {
                return this._colorBottomLeft;
            }
            set
            {
                this._colorBottomLeft = value;
            }
        }

        public Color ColorBottomCenter
        {
            get
            {
                return this._colorBottomCenter;
            }
            set
            {
                this._colorBottomCenter = value;
            }
        }

        public Color ColorBottomRight
        {
            get
            {
                return this._colorBottomRight;
            }
            set
            {
                this._colorBottomRight = value;
            }
        }

        public string CaptionFrontLeft
        {
            get
            {
                return this._frontLeft;
            }
            set
            {
                this._frontLeft = value;
            }
        }

        public string CaptionFrontCenter
        {
            get
            {
                return this._frontCenter;
            }
            set
            {
                this._frontCenter = value;
            }
        }

        public string CaptionFrontRight
        {
            get
            {
                return this._frontRight;
            }
            set
            {
                this._frontRight = value;
            }
        }

        public Color ColorFrontLeft
        {
            get
            {
                return this._colorFrontLeft;
            }
            set
            {
                this._colorFrontLeft = value;
            }
        }

        public Color ColorFrontCenter
        {
            get
            {
                return this._colorFrontCenter;
            }
            set
            {
                this._colorFrontCenter = value;
            }
        }

        public Color ColorFrontRight
        {
            get
            {
                return this._colorFrontRight;
            }
            set
            {
                this._colorFrontRight = value;
            }
        }
    }
}
