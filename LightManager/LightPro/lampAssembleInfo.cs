using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightManager
{
    public class lampAssembleInfo
    {
        public int lampAssembleId { get; set; }
        public string lampAssembleName { get; set; }
        public int airportId { get; set; }

        //灯组
        public List<lampGroupInfo> lampGroupInfo { get; set; }
    }
}
