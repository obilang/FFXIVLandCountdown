using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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

        public const string SAVE_FILE_PATH = "save.txt";
        private const int SECTION_COUNT = 20;
        private const int LAND_COUNT = 6;

        public void Init()
        {
            if(!LoadSaveFile())
            {
                ResetAllDate();
            }
        }

        private void ResetAllDate()
        {
            landItemList = new Dictionary<ERegion, Dictionary<int, List<LandItemData>>>();
            Dictionary<int, List<LandItemData>> landItemRegion = new Dictionary<int, List<LandItemData>>();
            List<LandItemData> landItemSection = new List<LandItemData>();

            for (int i = 0; i < (int)ERegion.COUNT; ++i)
            {
                landItemRegion = new Dictionary<int, List<LandItemData>>();
                landItemList.Add((ERegion)i, landItemRegion);

                for (int j = 0; j < SECTION_COUNT; ++j)
                {
                    landItemSection = new List<LandItemData>();
                    landItemRegion.Add(j + 1, landItemSection);

                    for (int k = 0; k < LAND_COUNT; ++k)
                    {
                        LandItemData landItemData = new LandItemData(k + 1, ELandState.OCCUPIED, DateTime.MaxValue);
                        landItemSection.Add(landItemData);
                    }
                }
            }
        }

        private bool LoadSaveFile()
        {
            landItemList = new Dictionary<ERegion, Dictionary<int, List<LandItemData>>>();
            Dictionary<int, List<LandItemData>> landItemRegion = new Dictionary<int, List<LandItemData>>();
            List<LandItemData> landItemSection = new List<LandItemData>();

            if (!File.Exists(SAVE_FILE_PATH))
            {
                return false;
            }

            using (StreamReader file = new StreamReader(SAVE_FILE_PATH))
            {
                string ln;
                bool isFirstLine = true;
                ERegion lastRegion = ERegion.COUNT;
                int lastSection = -1;

                while ((ln = file.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    ERegion currentRegion = (ERegion)Enum.Parse(typeof(ERegion), ln.Substring(0, ln.IndexOf(',')), true);
                    if (currentRegion != lastRegion)
                    {
                        landItemRegion = new Dictionary<int, List<LandItemData>>();
                        landItemList.Add(currentRegion, landItemRegion);
                        lastRegion = currentRegion;
                    }

                    ln = ln.Substring(ln.IndexOf(',') + 1);
                    int currentSection = int.Parse(ln.Substring(0, ln.IndexOf(',')));
                    if (currentSection != lastSection)
                    {
                        landItemSection = new List<LandItemData>();
                        landItemRegion.Add(currentSection, landItemSection);
                        lastSection = currentSection;
                    }


                    ln = ln.Substring(ln.IndexOf(',') + 1);
                    int currentIndex = int.Parse(ln.Substring(0, ln.IndexOf(',')));
                    ln = ln.Substring(ln.IndexOf(',') + 1);
                    ELandState currentState = (ELandState)Enum.Parse(typeof(ELandState), ln.Substring(0, ln.IndexOf(',')), true);
                    ln = ln.Substring(ln.IndexOf(',') + 1);
                    DateTime currentDateTime = DateTime.Parse(ln);

                    LandItemData landItemData = new LandItemData(currentIndex, currentState, currentDateTime);
                    landItemSection.Add(landItemData);
                }
                file.Close();
            }
            return true;
        }

        public void SaveToFile()
        {
            using (var stream = System.IO.File.CreateText(SAVE_FILE_PATH))
            {
                stream.WriteLine(string.Format("Region, Section, Index, State, EmptyTime"));

                foreach (var regionPair in landItemList)
                {
                    foreach (var sectionPair in regionPair.Value)
                    {
                        for (int i = 0; i < sectionPair.Value.Count; ++i)
                        {
                            stream.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                                regionPair.Key,
                                sectionPair.Key,
                                i,
                                sectionPair.Value[i].LandState,
                                sectionPair.Value[i].EmptyTime
                                ));
                        }
                    }
                }
            }
        }


        public Dictionary<ERegion, Dictionary<int, List<LandItemData>>> GetLandItemList()
        {
            return landItemList;
        }

        // No typedef like c++
        private Dictionary<ERegion, Dictionary<int, List<LandItemData>>> landItemList;
    }
}

