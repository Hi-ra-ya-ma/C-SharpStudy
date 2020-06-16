// 商品クラス
public class Product
{
    public int Code { get; set; } // 商品コード
    public string Name { get; set; } // 商品名
    public int Price { get; set; } // 商品価格

    // 消費税額を求める（消費税率は8%）
    public int GetTax()
    {
        return (int)(Price * 0.08);
    }

    // 税込み価格を求める
    public int GetPriceIncludingTax()
    {
        return Price + GetTax();
    }
}