using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM
{
    public class Global
    {
        private static whatsAppDataSet _db;

        public static whatsAppDataSet DB
        {
            get
            {
                if (_db == null)
                    _db = new whatsAppDataSet();
                return _db;
            }

        }
        

    }
}
