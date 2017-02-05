using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public static class Input
    {
        private static Hashtable _keys = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            _keys[key] = state;
        }

        public static bool Press (Keys key)
        {
            if (_keys[key] == null)
                _keys[key] = false;
            return (bool)_keys[key]; 
        }
    }
}
