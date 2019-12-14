using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVLandCountdown
{
    public enum ELandState
    {
        EMPTY,
        OCCUPIED
    }

    public enum ERegion
    {
        GJGQ,
        XYCMP,
        HWC,
        BYX,
        COUNT
    }


    public class LandItemData
    {
        public const float CD_HOUR = 10.0f;
        public static TimeSpan sCdHour = TimeSpan.FromHours(CD_HOUR);

        public LandItemData(int index, ELandState landState, DateTime time, int sectionIndex, ERegion region, bool bookmark)
        {
            this.Index = index;
            this.LandState = landState;
            this.EmptyTime = time;
            this.SectionIndex = sectionIndex;
            this.Region = region;
            this.Bookmark = bookmark;
        }


        public ELandState LandState { get; set; }
        public int Index { get; set; }
        public DateTime EmptyTime { get; set; }
        public int SectionIndex { get; set; }
        public ERegion Region { get; set; }
        public bool Bookmark { get; set; }
    }
}
