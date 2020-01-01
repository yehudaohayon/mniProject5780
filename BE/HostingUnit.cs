using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// this class represent a Hosting unit (of the host man)
    /// </summary>
    public class HostingUnit
    {

        public Host Owner;
        public string HostingUnitName;
        public static bool[,] Diary = new bool[12,31];
    public int HostingUnitKey = Configuration.getHostingUnitKeyTempPlusOne();


    public Host GetHost() { return Owner; }



    public override string ToString() { return null; }

    /// <summary>
    /// The function receives date and days of vacation, and returns if the unit is available.
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="days"></param>
    /// <returns></returns>
    public bool AvailableOnDate(DateTime dateTime, int days)
    {
        int startIndexInDiary = dateTime.Day - 1 + (dateTime.Month - 1) * 31;
        int endIndexInDiary = startIndexInDiary + days;

        for (int i = startIndexInDiary; i < endIndexInDiary; i++)
            if (Diary[i / 12, i % 31]) return false;
        return true;
    }

    public Location location { get; set; }

        public virtual bool Equals(HostingUnit hostingUnit)
        {
               return ( HostingUnitKey == hostingUnit.HostingUnitKey&&
                Owner == hostingUnit.Owner&&
                HostingUnitName == hostingUnit.HostingUnitName&&
                Diary == hostingUnit.Diary);
        }


}
}
