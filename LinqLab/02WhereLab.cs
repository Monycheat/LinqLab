using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            return new List<Sample>(Source.Where(x => x.Id > 8));
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            return new List<Sample>(Source.Where(x => x.Price.Equals(200)));
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            return new List<Sample>(Source.Where(x => x.UserName.StartsWith("d")));
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            return new List<Sample>(Source.Where(x => x.UserName.Contains("e")));
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            return new List<Sample>(Source.Where(x => x.UserName.EndsWith("o")));
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            return new List<Sample>(Source.Where(x => x.UserName.Equals("demo") || x.UserName.Equals("joey")));
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            return new List<Sample>(Source.Where(x => x.Id.Equals(99))).Any();
        }
    }
}
