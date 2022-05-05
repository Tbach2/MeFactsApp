using System;
using System.Collections.Generic;

namespace MeFactsApp
{
    public class MeFactData
    {
        public MeFactData()
        {
        }
        public static IEnumerable<MeFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ThePicture { get; set; }
        static MeFactData()
        {
            List<MeFactData> all = new List<MeFactData>();
            all.Add(new MeFactData() { TheFact = "I like the color red", ShortFact = "Red Fact", ThePicture = "https://images.freeimages.com/images/large-previews/607/red-photos-1172010.jpg" });
            all.Add(new MeFactData() { TheFact = "I also like the color blue", ShortFact = "Blue Fact", ThePicture = "https://www.kovifabrics.com/img/products/7737.JPG" });
            all.Add(new MeFactData() { TheFact = "I think the color green is okay", ShortFact = "Green Fact", ThePicture = "https://www.drodd.com/images16/green-color6.jpg" });
            all.Add(new MeFactData() { TheFact = "I think brown is a bad color", ShortFact = "Brown Fact", ThePicture = "https://149346020.v2.pressablecdn.com/wp-content/uploads/2010/10/brown_0_0-400x400.jpg" });
            all.Add(new MeFactData() { TheFact = "I like the color purple", ShortFact = "Purple Fact", ThePicture = "https://www.ortoped.ca/media/catalog/product/n/l/nlt_solid_purple.jpg" });
            All = all;

        }
    }
}