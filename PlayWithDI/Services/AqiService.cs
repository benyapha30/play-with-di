using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayWithDI.Services
{
    public class AqiService : IAqiService
    {
        public int GetAQI(string place, DateTime dateTime)
        {
            return 78;
        }
    }
}
