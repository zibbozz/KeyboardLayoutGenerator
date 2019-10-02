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
            this._colorTopLeft = Color.FromArgb(0, 0, 0);
            this._colorTopCenter = Color.FromArgb(0, 0, 0);
            this._colorTopRight = Color.FromArgb(0, 0, 0);

            this._centerLeft = "";
            this._centerCenter = "";
            this._centerRight = "";
            this._colorCenterLeft = Color.FromArgb(0, 0, 0);
            this._colorCenterCenter = Color.FromArgb(0, 0, 0);
            this._colorCenterRight = Color.FromArgb(0, 0, 0);

            this._bottomLeft = "";
            this._bottomCenter = "";
            this._bottomRight = "";
            this._colorBottomLeft = Color.FromArgb(0, 0, 0);
            this._colorBottomCenter = Color.FromArgb(0, 0, 0);
            this._colorBottomRight = Color.FromArgb(0, 0, 0);

            this._frontLeft = "";
            this._frontCenter = "";
            this._frontRight = "";
            this._colorFrontLeft = Color.FromArgb(0, 0, 0);
            this._colorFrontCenter = Color.FromArgb(0, 0, 0);
            this._colorFrontRight = Color.FromArgb(0, 0, 0);
        }
    }
}
