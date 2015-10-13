using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08._14.Codes
{
    public interface IShape
    {
        Image Image { get; set; }
        Rectangle Rectangle { get; set; }
        void Draw(Graphics g);
        void Move(int x = 0 , int y = 0);
    }
}
