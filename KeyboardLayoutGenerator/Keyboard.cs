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

        /// <summary>
        /// Sets the background color of the keyboard.
        /// </summary>
        public Color BackgroundColor
        {
            get
            {
                return this._backgroundColor;
            }
            set
            {
                this._backgroundColor = value;
            }
        }

        /// <summary>
        /// Sets the title of the keyboard layout.
        /// </summary>
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        /// <summary>
        /// Sets the author of the keyboard layout.
        /// </summary>
        public string Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
            }
        }

        /// <summary>
        /// Adds a key to the keyboard layout.
        /// </summary>
        /// <param name="key">The key that will be added</param>
        public void AddKey(Key key)
        {
            this._keys.Add(key);
        }

        /// <summary>
        /// Get all keys on the keyboard.
        /// </summary>
        /// <returns></returns>
        public Key[] GetKeys()
        {
            Key[] keys = new Key[this._keys.Count];
            for(int i = 0; i < keys.Length; i++)
            {
                keys[i] = this._keys[i];
            }
            return keys;
        }

        /// <summary>
        /// Get a specific key on the keyboard.
        /// </summary>
        /// <param name="index">The index of the wanted key</param>
        /// <returns></returns>
        public Key GetKey(int index)
        {
            if(index >= 0)
            {
                if (index < this._keys.Count)
                    return this._keys[index];
                else
                    throw new Exception("Index is higher than the count of keys.");
            }
            else
            {
                throw new Exception("Index can not be negative.");
            }
        }
    }
}
