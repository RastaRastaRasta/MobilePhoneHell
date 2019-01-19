using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MobilePhones
    {
        public string Name { get; set; }
        public List<PhoneParams> Params { get; set; }
        public string ProductOwner { get; set; }

    }

    public enum PhoneParams
    {
        doubleCam,
        doubleSim,
        WaterProtected,
        NoBreak,
        NFC
    }
    
}
