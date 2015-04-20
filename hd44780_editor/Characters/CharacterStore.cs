using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace hd44780_editor.Characters
{
    [XmlRoot("CharacterStore")]
    public class CharacterStore
    {
        [XmlArray("Characters")]
        [XmlArrayItem("Character")]
        public static List<Character> Characters = new List<Character>();

        CharacterStore()
        {
            Characters = new List<Character>();
        }
        public static void Save()
        {
            var serializer = new XmlSerializer(Characters.GetType());
            //serializer.Serialize(Console.Out, Characters);


            TextWriter WriteFileStream = new StreamWriter("CharacterData.xml");
            serializer.Serialize(WriteFileStream, Characters);

            // Cleanup
            WriteFileStream.Close();
        }

        public static void Load()
        { 

            try
            {
                var serializer = new XmlSerializer(Characters.GetType());
                FileStream ReadFileStream = new FileStream("CharacterData.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

                // Load the object saved above by using the Deserialize function
                Characters = (List<Character>)serializer.Deserialize(ReadFileStream);

                // Cleanup
                ReadFileStream.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
