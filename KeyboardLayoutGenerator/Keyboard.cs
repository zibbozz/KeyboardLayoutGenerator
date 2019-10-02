using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KeyboardLayoutGenerator
{
    public class Keyboard
    {
        private List<Key> _keys;
        private Color _backgroundColor;
        private string _title;
        private string _author;

        /// <summary>
        /// Constructs a standard keyboard without any keys and default parameters.
        /// </summary>
        public Keyboard()
        {
            this._keys = new List<Key>();
            this._backgroundColor = Color.FromArgb(140, 140, 140);
            this._title = "";
            this._author = "";
        }
    }
}
