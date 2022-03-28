using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> Skip5Data()
        {
            return new List<Sample>(Source.Skip(5));
        }

        public List<Sample> Take5Data()
        {
            return new List<Sample>(Source.Take(5));
        }

        public List<Sample> Skip5DataAndTake2Data()
        {
            return new List<Sample>(Source.Skip(5).Take(2));
        }
    }
}
