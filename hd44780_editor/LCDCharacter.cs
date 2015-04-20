using hd44780_editor.Characters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hd44780_editor
{
    public class LCDCharacter
    {
        public static Color TileColor(bool enabled)
        {
            return enabled ? Properties.Settings.Default.DisplayForeground : Properties.Settings.Default.DisplayForegroundInactive;
        }

        public static void GenerateImage(System.Drawing.Graphics formGraphics, Character character, int width)
        {
            System.Drawing.SolidBrush brushA = new System.Drawing.SolidBrush(TileColor(true));
            System.Drawing.SolidBrush brushD = new System.Drawing.SolidBrush(TileColor(false));

            int spacing = (int)Math.Ceiling(width * 1.1);
            Rectangle rec = new Rectangle(0, 0, width, width);

            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
            {
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                {
                    rec.X = spacing * j;
                    rec.Y = spacing * i;
                    formGraphics.FillRectangle(character[i, j] ? brushA : brushD, rec);
                }
            }

        }

    }
}
