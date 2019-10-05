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

        /// <summary>
        /// Constructs a standard key with all default parameters.
        /// </summary>
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

        /// <summary>
        /// Creates a copy of the given key object.
        /// </summary>
        /// <param name="key">The key to copy</param>
        public Key(Key key)
        {
            this._size = key.Size;
            this._color = key.Color;
            this._keyColor = key.KeyColor;
            this._width =+ key.Width;
            this._height = key.Height;
            this._width2 = key.Width2;
            this._height2 =key.Height2;
            this._x = key.X;
            this._y = key.Y;
            this._x2 = key.X2;
            this._y2 = key.Y2;

            this._stepped = key.Stepped;
            this._homing = key.Homing;

            this._topLeft = key.CaptionTopLeft;
            this._topCenter = key.CaptionTopCenter;
            this._topRight = key.CaptionTopRight;
            this._colorTopLeft = key.ColorTopLeft;
            this._colorTopCenter = key.ColorTopCenter;
            this._colorTopRight = key.ColorTopRight;

            this._centerLeft = key.CaptionCenterLeft;
            this._centerCenter = key.CaptionCenterCenter;
            this._centerRight = key.CaptionCenterRight;
            this._colorCenterLeft = key.ColorCenterLeft;
            this._colorCenterCenter = key.ColorCenterCenter;
            this._colorCenterRight = key.ColorCenterRight;

            this._bottomLeft = key.CaptionBottomLeft;
            this._bottomCenter = key.CaptionBottomCenter;
            this._bottomRight = key.CaptionBottomRight;
            this._colorBottomLeft = key.ColorBottomLeft;
            this._colorBottomCenter = key.ColorBottomCenter;
            this._colorBottomRight = key.ColorBottomRight;

            this._frontLeft = key.CaptionFrontLeft;
            this._frontCenter = key.CaptionFrontCenter;
            this._frontRight = key.CaptionFrontRight;
            this._colorFrontLeft = key.ColorFrontLeft;
            this._colorFrontCenter = key.ColorFrontCenter;
            this._colorFrontRight = key.ColorFrontRight;  
        }

        /// <summary>
        /// Creates a key object with a set upper left caption.
        /// </summary>
        /// <param name="caption">The caption of the key</param>
        public Key(string caption) : this()
        {
            this.CaptionTopLeft = caption;
        }

        /// <summary>
        /// Creates a key object with a set upper left caption and a key color.
        /// </summary>
        /// <param name="caption">The caption of the key</param>
        /// <param name="keyColor">The color of the key</param>
        public Key(string caption, Color keyColor) : this(caption)
        {
            this.KeyColor = keyColor;
        }

        /// <summary>
        /// Sets the size of all captions.
        /// Minimum = 1.0
        /// Default = 3.0
        /// </summary>
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

        /// <summary>
        /// Sets the color of all captions that do not have a unique color set.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the width of the key.
        /// Minimum = 1.0
        /// Default = 1.0
        /// </summary>
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

        /// <summary>
        /// Sets the height of the key.
        /// Minimum = 1.0
        /// Default = 1.0
        /// </summary>
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

        /// <summary>
        /// Sets the second width of the key. Is used to create non rectangular keys.
        /// </summary>
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

        /// <summary>
        /// Sets the second height of the key. Is used to create non rectangular keys.
        /// </summary>
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

        /// <summary>
        /// Sets the x coordinate of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the y coordinate of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the second x coordinaate of the key. Is used to create non rectangular keys.
        /// </summary>
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

        /// <summary>
        /// Sets the second y coordinaate of the key. Is used to create non rectangular keys.
        /// </summary>
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

        /// <summary>
        /// Sets if the first part of the key is raised higher than the rest of the key.
        /// </summary>
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

        /// <summary>
        /// Sets if the key gets a bump on the bottom part of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the upper left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the upper center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the upper right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the upper left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the upper center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the upper right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the lower left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the lower center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the lower right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the lower left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the lower center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the lower right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the front left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the front center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the front right caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the front left caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the front center caption of the key.
        /// </summary>
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

        /// <summary>
        /// Sets the color of the front right caption of the key.
        /// </summary>
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
