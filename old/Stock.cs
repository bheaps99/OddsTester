using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First7
{
    public class MASTER_STOCK_DATA
    {
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }

        public DateTime Date { get; set; }

        public string Symbol { get; set; }

        //last comes from csv file

        //output open to close, close to close, MFE, MAE
        //% close to close
        //% open to close
    }
}
