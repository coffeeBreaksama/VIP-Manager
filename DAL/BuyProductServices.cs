using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SysCard.Models;

namespace SysCard.DAL
{
    public class BuyProductServices
    {
        public static List<ProductInfo> GetAllProduct()
        {
            string sql = "select * from product_info";
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<ProductInfo> list = new List<ProductInfo>();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ProductInfo product = new ProductInfo();
                    product.Productid = int.Parse(dr[0].ToString());
                    product.Productname = dr[1].ToString();
                    product.Productprice = float.Parse(dr[2].ToString());
                    product.Productnum = dr[3].ToString();
                    product.Producttype = dr[4].ToString();
                    product.Productpprice = float.Parse(dr[5].ToString());
                    product.Productaddr = dr[6].ToString();
                    product.Productpd = dr[7].ToString();
                    product.Productstata = dr[8].ToString();
                    product.Productpristata = dr[9].ToString();
                    product.Productdru = dr[10].ToString();
                    list.Add(product);

                }
            }
            return list;
        }
        public static int DelProduct(int productid)
        {
            string sql = string.Format("delete from product_info where product_id = {0}",productid);
            return Dbhelper.ExecuteNonQuery(sql);
 
        }
        public static List<ProductInfo> GetProductBy(string productname)
        {
            string sql = string.Format("select * from product_info  where product_name like('%{0}%')", productname);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<ProductInfo> list = new List<ProductInfo>();
            while (dr.Read())
            {
                ProductInfo product = new ProductInfo();
                product.Productid = int.Parse(dr[0].ToString());
                product.Productname = dr[1].ToString();
                product.Productprice = float.Parse(dr[2].ToString());
                product.Productnum = dr[3].ToString();
                product.Producttype = dr[4].ToString();
                product.Productpprice = float.Parse(dr[5].ToString());
                product.Productaddr = dr[6].ToString();
                product.Productpd = dr[7].ToString();
                product.Productstata = dr[8].ToString();
                product.Productpristata = dr[9].ToString();
                product.Productdru = dr[10].ToString();
                list.Add(product);

            }
            return list;
        }
        public static List<ProductInfo> GetProductByNum(string productnum)
        {
            string sql = string.Format("select * from product_info  where Product_num = '{0}'", productnum);
            OleDbDataReader dr = Dbhelper.ExecuteReader(sql);
            List<ProductInfo> list = new List<ProductInfo>();
            while (dr.Read())
            {
                ProductInfo product = new ProductInfo();
                product.Productid = int.Parse(dr[0].ToString());
                product.Productname = dr[1].ToString();
                product.Productprice = float.Parse(dr[2].ToString());
                product.Productnum = dr[3].ToString();
                product.Producttype = dr[4].ToString();
                product.Productpprice = float.Parse(dr[5].ToString());
                product.Productaddr = dr[6].ToString();
                product.Productpd = dr[7].ToString();
                product.Productstata = dr[8].ToString();
                product.Productpristata = dr[9].ToString();
                product.Productdru = dr[10].ToString();
                list.Add(product);

            }
            return list;
        }                                                                                                                                                                                                                                                                      

        /// <summary>
        /// 添加销售记录
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>

        public static int AddProduct(BuyProduct product)
        {
            string sql = string.Format("insert into product_info (Product_name,Product_price,Product_num,Product_type,Product_pprice,Product_addr,Product_pd,Product_stata,Product_pristata,Product_dru,buy_time,buy_from) values('{0}',{1},'{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}')",product.Productname,product.Productprice,product.Productnum,product.Producttype,product.Productpprice,product.Productaddr,product.Productaddr,product.Productpd,product.Productstata,product.Productpristata,product.Productdru,product.BuyTime,product.BuyForm);
            return Dbhelper.ExecuteNonQuery(sql);
        }

    }
    
}
