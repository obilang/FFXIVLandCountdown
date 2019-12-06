using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandItem
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
        BYX
    }


    public class LandItemData
    {
        public LandItemData(int index, ELandState landState, DateTime time)
        {
            this.Index = index;
            this.LandState = landState;
            this.EmptyTime = time;
        }


        public ELandState LandState { get; set; }
        public int Index { get; set; }
        public DateTime EmptyTime { get; set; }
    }
}
