using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandItem;

namespace FFXIVLandCountdown
{
    public sealed class DataManager
    {
        #region Singleton
        private static DataManager instance = null;
        private static readonly object padlock = new object();

        DataManager()
        {

        }

        public static DataManager Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataManager();
                    }
                    return instance;
                }
            }
        }
        #endregion




        public void Init()
        {
            LandItemDataList = new List<LandItemData>();

            LandItemData landItemData = new LandItemData(1, ELandState.EMPTY, DateTime.Now);
            LandItemDataList.Add(landItemData);
            landItemData = new LandItemData(2, ELandState.OCCUPIED, DateTime.Now);
            LandItemDataList.Add(landItemData);

        }

        public List<LandItemData> LandItemDataList { get; private set; }
    }
}

