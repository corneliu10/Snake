using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Inputs
    {
        //Load list of available Keyboard buttons
        private static Hashtable keytable = new Hashtable();

        //Perform a check to see if a particular button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keytable[key] == null)
            {
                return false;
            }

            return (bool) keytable[key];
        }

        //Detect if a keyboard is pressed
        public static void ChangeState(Keys key,bool state)
        {
            keytable[key] = state;
        }
    }
}
