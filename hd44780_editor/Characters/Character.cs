using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace hd44780_editor.Characters
{
    public class Character
    {
        public Character()
        {
            TilesData = new RowData[Defines.CHAR_HEIGHT];
        }

        [XmlAttribute("Id")]
        public uint Id
        { get; set; }

        [XmlAttribute("Name")]
        public String Name
        { get; set; }

        [XmlArray("tiles")]//, XmlArrayItem("state")]
        public RowData[] TilesData
        {
            get;
            set;
        }

        [XmlIgnore]
        public bool this[int i, int j]
        {
            set 
            {
                TilesData[i].Value = value ? TilesData[i].Value | (1 << j) : TilesData[i].Value & ~(1 << j);
                /*if (value == 1
                    
                    )
                    TilesData[i] |= (1 << j);
                else
                    TilesData[i] &= ~(1 << j);*/
            }
                //TilesData[i] = (j == 1) ? TilesData[i] | (1 << j) : TilesData[i] &~(1 << j); }
            get { return (TilesData[i].Value & (1 << j)) != 0; }
        }


    }

    [Serializable]
    public struct RowData
    {
        private int m_index;

        [XmlIgnore]
        public int Value
        {
            get { return m_index; }
            set { m_index = value; }
        }

        [XmlAttribute("Value")]
        public string ValueString
        {
            get { return String.Format("0x{0:X}", Value); }
            set { Value = Convert.ToUInt16(value, 16); }
        }
    }

}
