using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    public class Corner : ITurnable
    {
        public string Turn()
        {
            return "Corner - Walk to the edge of a corner, turn 90 degrees left or right";
        }
    }
}
