using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    //CastDataRowStrategy
    interface CDRStrategy
    {
        public object castDataRow(DataRow dataRow);
    }
}
