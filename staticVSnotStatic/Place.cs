using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace objekter_via_static
{
    class Place
    {
        public string PlaceName { get; private set; }
        public string Municipality { get; private set; }
        public string Region { get; private set; }

        public Place(string placeName, string municipality, string region)
        {
            PlaceName = placeName;
            Municipality = municipality;
            Region = region;
        }


        public void ShowPlace()
        {
            var labelWidth = 8;
            ShowSeperatorRow(labelWidth);
            ShowFieldNameAndValue("Navn", labelWidth, PlaceName);
            ShowFieldNameAndValue("Kommune", labelWidth, Municipality);
            ShowFieldNameAndValue("Fylke", labelWidth, Region);

        }
        private void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine("    " + label + ":" + " ".PadLeft(labelWidth, ' ') + fieldValue);
        }


        private void ShowSeperatorRow(int labelWidth)
        {
            labelWidth += 15;
            Console.WriteLine(string.Empty.PadLeft(labelWidth, '-'));
        }
    }
}