using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    class MyCastObject
    {
        
        public CDRStrategy CastDRtrategy
        {
            get;set;
        }
        public MyCastObject()
        {
            
        }
        
        public void setCDRStrategy(CDRStrategy castDRtrategy){
            CastDRtrategy = castDRtrategy;
        }

        public object CastDataRowToObject(DataRow dataRow)
        {
            return CastDRtrategy.castDataRow(dataRow);
        }
    }
}
