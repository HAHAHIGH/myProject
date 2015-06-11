using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class COrders
    {
        public string 產品名稱 { get; set; }
        public double 產品單價 { get; set; }
        public int 購買數量 { get; set; }
        public double 小計 { get; set; }
        public string 日期 { get; set; }
        public string 備註 { get; set; }

        public override string ToString()
        {
            return this.產品名稱 + "\t" + this.產品單價 + "元\t" + this.購買數量 + "個\t" + this.小計 + "元\t" + this.日期 + "\t"+this.備註 ;
        }
    }

