using System;
namespace SalesSummaryProgram
{
    public class Sale
    {
        // 店舗名
        public string ShopName { get; set; }

        // 商品カテゴリ
        public string ProductCategory { get; set; }

        // 売上高
        public int Amount { get; set; }
    }
}
