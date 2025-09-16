using MyReal09_Bridge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tao doi tuong");
        var blue_color = new Blue();
        var red_color = new Red();
        Square blue_square = new Square { color = blue_color };
        Square red_square = new Square { color = red_color };
        Circle blue_circle = new Circle { color = blue_color };
        Circle red_circle = new Circle { color = red_color };

        Console.WriteLine($"Mau hinh chu nhat xanh: {blue_square.GetColor()}");
        Console.WriteLine($"Mau hinh chu nhat đỏ: {red_square.GetColor()}");
        Console.WriteLine($"Màu hinh tron xanh: {blue_circle.GetColor()}");
        Console.WriteLine($"Màu hinh tron đỏ: {red_circle.GetColor()}");
    }
}
