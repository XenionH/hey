class Timing
{
    public double fun (double x, double y)
    {
        if (y <= 1)
        {
            return x;
        }
        else if (y > 1)
        {
           return fun( x, y - 1) * fun( x, y - 1);
        }
        return x;
    }


    static void Main(string[] args)
    {   
        this.x = 1.0000001;
        for(int y = 1; y < 33; y++)
        {
            Console.WriteLine(fun(x, y));
        }
    }
}