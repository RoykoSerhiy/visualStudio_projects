using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace game.classes
{
    public interface IShape
    {
        Image Image { get; set; }
        Rectangle Rectangle { get; set; }
        void Draw(Graphics g);
        
    }
}
