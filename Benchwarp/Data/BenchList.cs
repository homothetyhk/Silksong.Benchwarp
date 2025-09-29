using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Benchwarp.Data
{
    public static class BenchList
    {
        static BenchList()
        {
            BaseBenches = new(Util.JsonUtil.Deserialize<BenchData[]>("Benchwarp.Resources.benches.json"));
            Benches = BaseBenches;
            // TODO: ordering code from HKBW
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReadOnlyCollection<BenchData> BaseBenches { get; }
        public static ReadOnlyCollection<BenchData> Benches { get; private set; }

        public static void RefreshBenchList()
        {
            //TopMenu.RebuildMenu();
            throw new NotImplementedException();
        }
    }
}
