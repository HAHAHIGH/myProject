using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
    public  class DrinkFactory
    {
        public List<CDrink>  drinkList = new List<CDrink>();

        public DrinkFactory() 
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = @"Data Source=NTHIGH\SQLEXPRESS;Initial Catalog=Drinkdb;Integrated Security=True";
            sds.SelectCommand = "SELECT * FROM products";
            DataView dv = sds.Select(DataSourceSelectArguments.Empty) as DataView;

            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    CDrink drink = new CDrink();
                    drink.商品名稱 = dv.Table.Rows[i]["pName"].ToString();
                    drink.照片 = dv.Table.Rows[i]["pPhoto"].ToString();
                    drink.商品單價 = dv.Table.Rows[i]["pPrice"].ToString();
                    drink.商品成本 = dv.Table.Rows[i]["pCost"].ToString();
                    drinkList.Add(drink);
                }

            }
        }
        
        public List<string> getAllpname() 
        {
            List<string> a = new List<string>();
            for (int i = 0; i < drinkList.Count;i++ )
            {
                a.Add(drinkList[i].商品名稱);
            }
            return a;
        }
        public List<CDrink> getAll()
        {
            return drinkList;
        }
        public CDrink getOne(int i)
        {
            return drinkList[i];
        }
        public string getPrice(string s) 
        {
            try {
                for (int i = 0; i < drinkList.Count;i++ )
                {
                    if(s == drinkList[i].商品名稱)
                    {
                        return drinkList[i].商品單價;
                    } 
                }
                return "";
            }catch{ return""; }
        }
        
    }

