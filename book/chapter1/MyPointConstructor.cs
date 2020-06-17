class MyPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    // コンストラクタ
    public MyPoint(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

class Test
{
    public void Main(string[] args)
    {
        MyPoint a = new MyPoint(10, 20);
        MyPoint b = a;

        Console.WriteLine("a: ({0}, {1})", a.X, a.Y); // a: (10, 20)
        Console.WriteLine("b: ({0}, {1})", b.X, b.Y); // b: (10, 20)

        a.X = 80;

        Console.WriteLine("a: ({0}, {1})", a.X, a.Y); // a: (80, 20)
        Console.WriteLine("b: ({0}, {1})", b.X, b.Y); // b: (80, 20)
    }
}