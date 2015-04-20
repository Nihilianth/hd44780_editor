using hd44780_editor.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hd44780_editor
{
    public partial class LCDFrame : Form
    {
        public LCDFrame()
        {
            InitializeComponent();
        }

        private Character[,] characters;

        /*
         * Dimensions from the datasheet:
         *  tile width:     0.55mm (100%)
         *  tile spacing:   0.05mm (10%)
         *  char spacing:   0.60mm (110%)
         */

        bool drawn = false;
        const int TILE_WIDTH = 5;
        int TILE_SPACING, CHAR_SPACING;
        uint DISPLAY_WIDTH = Properties.Settings.Default.DisplayWidth;
        uint DISPLAY_HEIGHT = Properties.Settings.Default.DisplayHeight;

        private void LCDFrame_Load(object sender, EventArgs e)
        {
            lcdPanel.BackColor = Properties.Settings.Default.DisplayBackground;
            lcdPanel.AutoSize = true;
            lcdPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            //lcdPanel.Margin = new Padding(30);
            characters = new Character[DISPLAY_WIDTH, DISPLAY_HEIGHT];

            TILE_SPACING = Math.Max(TILE_WIDTH / 10, 1);
            CHAR_SPACING = TILE_WIDTH + TILE_SPACING;

            //DrawTiles();

            
            uint charId = 0;
            int offsetX = (Defines.CHAR_WIDTH + 1) * TILE_WIDTH + Defines.CHAR_WIDTH * TILE_SPACING;
            int offsetY = (Defines.CHAR_HEIGHT + 1) * TILE_WIDTH + Defines.CHAR_HEIGHT * TILE_SPACING;


            for (int i = 0; i < DISPLAY_WIDTH; ++i)
            {
                for (int j = 0; j < DISPLAY_HEIGHT; ++j)
                {
                    //LCDCharacter character = new LCDCharacter(charId, offsetX * i + TILE_WIDTH, offsetY * j + TILE_WIDTH);
                    Character character = new Character();
                    Label label = new Label();
                    label.Location = new Point(offsetX * i + TILE_WIDTH, offsetY * j + TILE_WIDTH);
                    label.Size = new Size(offsetX - TILE_WIDTH, offsetY - TILE_WIDTH);

                    label.BackColor = Color.Black;
                    label.Tag = character;
                    lcdPanel.Controls.Add(label);


                    label.Paint += LCDlabel_Paint;
                    label.Click += LCDlabel_Click;
                    //character.GenerateImage(graphics, TILE_WIDTH);
                    /*try
                    {

                        var serializer = new XmlSerializer(typeof(Character));
                        serializer.Serialize(Console.Out, character);
                    }
                    catch (Exception ex)
                    {

                    }*/


                    ++charId;
                }
            }

        }

        private void LCDlabel_Click(object sender, EventArgs e)
        {
            new CEditDialog((Label)sender).ShowDialog();
            ((Label)sender).Refresh();
        }

        private void LCDlabel_Paint(object sender, PaintEventArgs e)
        {
            Label label = (Label)sender;
            Graphics graphics = e.Graphics;//label.CreateGraphics();
            //LCDCharacter character = (LCDCharacter)label.Tag;
            LCDCharacter.GenerateImage(graphics,(Character)label.Tag, TILE_WIDTH);
        }

        private void lcdPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
