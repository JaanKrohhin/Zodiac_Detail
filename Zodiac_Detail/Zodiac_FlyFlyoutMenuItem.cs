using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zodiac_Detail
{
    public class Zodiac_FlyFlyoutMenuItem
    {
        public Zodiac_FlyFlyoutMenuItem()
        {
            TargetType = typeof(Zodiac_FlyDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Pic { get; set; }
        public char Read { get; set; }
        public string TitleRead {
            get { return Title + " " + Read; }
            set { }
        }
        public Type TargetType { get; set; }
    }
}