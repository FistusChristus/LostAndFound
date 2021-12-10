using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gmap_Markers
{
    internal class Db_Ad
    {
        static List<Db_Ad> adList = new List<Db_Ad>();

        internal static List<Db_Ad> AdList { get => adList; set => adList = value; }
        public int id { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public string Login { get; set; }
        public bool Type { get; set; }
        public int Category { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string description { get; set; }  
        

        public void Add_Obj()
        {
            AdList.Add(this);
        }

    }
}
