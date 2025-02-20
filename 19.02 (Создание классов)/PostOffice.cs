using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    internal class PostOffice
    {
        private int index;
        private string city;
        private string street;
        private int house;
        private int frame;
        private int flatNum;
        private string letter;


        public PostOffice(int index, string city, string street, int house, int frame, int flatNum, string letter)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.house = house;
            this.frame = frame;
            this.flatNum = flatNum;
            this.letter = letter;
        }

        public void Info()
        {
            Console.WriteLine($"Full adress -> Index: {index}, City: {city}, Street: {street}, House: {house}, Frame: {frame}, Number of flat in house: {flatNum}\n");
        }
    }
}
