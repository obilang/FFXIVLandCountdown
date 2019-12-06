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


        public void Init()
        {
            LandItemDataList = new List<LandItemData>();

            LandItemData landItemData = new LandItemData(1, ELandState.EMPTY, DateTime.Now);
            LandItemDataList.Add(landItemData);
            landItemData = new LandItemData(2, ELandState.OCCUPIED, DateTime.Now);
            LandItemDataList.Add(landItemData);

            ERegion region = ERegion.BYX;
        }

        private void LoadSaveFile()
        {
            using (StreamReader file = new StreamReader(SAVE_FILE_PATH))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    
                }
                file.Close();
            }
        }

        public void SaveToFile()
        {
            using (var stream = System.IO.File.CreateText(SAVE_FILE_PATH))
            {
                stream.WriteLine(string.Format("Region, Section, Index, State, EmptyTime"));

            }
        }

        public List<LandItemData> LandItemDataList { get; private set; }
    }
}

