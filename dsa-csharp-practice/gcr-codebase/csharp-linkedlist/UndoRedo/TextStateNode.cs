using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.UndoRedo
{
    class TextStateNode
    {
        public string content;
        public TextStateNode prev;
        public TextStateNode next;
        public TextStateNode(string content)  //constructor to store text state
        {
            this.content = content;
            prev = null;
            next = null;
        }
    }

}
