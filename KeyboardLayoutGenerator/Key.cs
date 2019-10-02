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
    }
}
