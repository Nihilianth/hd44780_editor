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

namespace hd44780_editor
{
    public partial class CEditDialog : Form
    {
        public CEditDialog(Label label)
        {
            this.label = label;
            Character orig = (Character)label.Tag;

            //tempChar = orig;
            //tiles = (bool[,])orig..Clone();

            InitializeComponent();

            tempChar = new Character();
            tempChar.TilesData = (RowData[])orig.TilesData.Clone();


            LoadChar(orig);
            spawnLabels();
            GenerateOutputCode();
            UpdateComboBox();
        }

        private void LoadChar(Character character)
        {
            tempChar = new Character();
            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                tempChar.TilesData[i] = character.TilesData[i];

            TilesUpdated();
        }

        public void UpdateComboBox()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (var character in CharacterStore.Characters)
            {

                dict.Add((int)character.Id, character.Name);

                nameBox.DataSource = new BindingSource(dict, null);
                nameBox.DisplayMember = "Value";
                nameBox.ValueMember = "Key";

                //nameBox.Items.Add(character);
            }

            nameBox.SelectedIndex = -1;
        }

        Label label;
        //bool[,] tiles;
        Character tempChar;

        private void spawnLabels()
        {
            charPanel.BackColor = Properties.Settings.Default.DisplayBackground;
            charPanel.AutoSize = true;
            charPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            int width = 50;

            Color ForeColor = Properties.Settings.Default.DisplayForegroundInactive;

            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
            {
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                {
                    int spacing = (int)Math.Max(width * 0.1, 1);

                    Label tile = new Label();
                    tile.Name = String.Format("TILE_{0}_{1}", i, j);
                    tile.Height = width;
                    tile.Width = width;


                    tile.Location = new System.Drawing.Point(0 + (width + spacing) * j, 0 + (width + spacing) * i);
                    tile.FlatStyle = FlatStyle.Flat;
                    tile.BackColor = LCDCharacter.TileColor(tempChar[i, j]);

                    charPanel.Controls.Add(tile);


                    tile.Click += tile_pressed;
                    tile.Paint += tile_Paint;
                }
            }
        }

        private void tile_Paint(object sender, PaintEventArgs e)
        {
            String[] name = ((Label)sender).Name.Split('_');

            int row = Convert.ToInt16(name[1]);
            int col = Convert.ToInt16(name[2]);

            ((Label)sender).BackColor = LCDCharacter.TileColor(tempChar[row, col]);

        }

        private void tile_pressed(object sender, EventArgs e)
        {
            String[] name = ((Label)sender).Name.Split('_');

            int row = Convert.ToInt16(name[1]);
            int col = Convert.ToInt16(name[2]);


            /*
             * Modifiers (can be combined):
             *  None    - Single tile is updated
             *  CTRL    - row is updated (Set to the same value as the button
             *  SHIFT   - column is updated (set to the same value as the button))
             */

            bool val = !tempChar[row, col];

            if ((Control.ModifierKeys & Keys.Control) != Keys.None)
                for (int i = 0; i < Defines.CHAR_WIDTH; ++i)
                    tempChar[row, i] = val;

            if ((Control.ModifierKeys & Keys.Shift) != Keys.None)
                for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                    tempChar[i, col] = val;
            
            if (Control.ModifierKeys == Keys.None)
                tempChar[row, col] = val;

            TilesUpdated();
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            //((Character)label.Tag) = (bool[,])tempChar.Clone();


            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                    ((Character)label.Tag)[i, j] = tempChar[i, j];
        }

        private void charPanel_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                    tempChar[i, j] = false;
            TilesUpdated();
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                    tempChar[i, j] = true;
            TilesUpdated();
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Defines.CHAR_HEIGHT; ++i)
                for (int j = 0; j < Defines.CHAR_WIDTH; ++j)
                    tempChar[i, j] = !tempChar[i, j];
            TilesUpdated();
        }

        private void TilesUpdated()
        {
            charPanel.Refresh();
            GenerateOutputCode();
        }

        public void GenerateOutputCode()
        {
            int temp = 0;
            String binOutput = "";
            String hexOutput = "";
            String decOutput = "";

            String lineBreak = lineBreaks.Checked ? "\r" : "";


            for (ushort i = 0; i < Defines.CHAR_HEIGHT; ++i)
            {
                temp = 0;
                String comma = i != Defines.CHAR_HEIGHT - 1 ? "," : "";

                for (ushort j = 0; j < Defines.CHAR_WIDTH; ++j)
                {
                    temp |= Convert.ToInt16(tempChar[i, j]) << (Defines.CHAR_WIDTH - 1 - j);
                }

                binOutput += String.Format("0b{0}{1}{2}", Convert.ToString(temp, 2).PadLeft(Defines.CHAR_WIDTH, '0'), comma, lineBreak);
                hexOutput += String.Format("0x{0:x}{1}{2}", temp, comma, lineBreak);
                decOutput += String.Format("0x{0}{1}{2}", temp, comma, lineBreak);
            }

            hexCodeBox.Text = hexOutput;
            binCodeBox.Text = binOutput;
            decCodeBox.Text = decOutput;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String filtered = "";

            switch (codeTabControl.SelectedIndex)
            {
                case 0: filtered = hexCodeBox.Text; break;
                case 1: filtered = binCodeBox.Text; break;
                case 2: filtered = decCodeBox.Text; break;
            }

            filtered = filtered.Replace("\n", "");
            filtered = filtered.Replace("\r", "");
            filtered = filtered.Replace(" ", "");

            String[] input = filtered.Split(',');

            if (input.Count() > Defines.CHAR_HEIGHT)
            {
                MessageBox.Show("Invalid amount of rows!");
                return;
            }
            int row = 0;

            foreach (var rowStr in input)
            {
                try
                {
                    int val = Convert.ToInt16(rowStr, 16);
                    for (int i = 0; i < Defines.CHAR_WIDTH; ++i)
                    {
                        int idxVal = val & (1 << Defines.CHAR_WIDTH - 1 - i);
                        tempChar[row, i] = idxVal != 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Failed to parse line:\n\t '{0}'", row), "Error!");
                    return;
                }

                ++row;
            }

            TilesUpdated();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;

            var character = CharacterStore.Characters.Find(itr => itr.Name == name);

            if (character != null)
            {
                // character found
                character.TilesData = (RowData[])tempChar.TilesData.Clone();
            }
            else
            {
                int count = CharacterStore.Characters.Count;
                if (count != 0)
                    count = (int)CharacterStore.Characters[count - 1].Id;

                Character newChar = new Character();
                newChar.Name = name;
                newChar.Id = (uint)++count;
                newChar.TilesData = (RowData[])tempChar.TilesData.Clone();
                CharacterStore.Characters.Add(newChar);
            }

            CharacterStore.Save();
            UpdateComboBox();
            //CharacterStore.Characters[cnt];
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //string val = nameBox.ValueMember
            if (nameBox.SelectedIndex >= 0)
            {
                int val = (int)nameBox.SelectedValue;
                var character = CharacterStore.Characters.Find(itr => itr.Id == val);

                LoadChar(character);
            }
            else
                MessageBox.Show("Invalid Name!");
        }

        private void lineBreaks_CheckedChanged(object sender, EventArgs e)
        {
            GenerateOutputCode();
        }
    }
}
