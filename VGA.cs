using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia() 
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    { 
        public AMD() 
        {
            base.merk = "AMD";
        } 
    }

