public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a+b;
    }
    public int Multiplicar(int a, int b)
    {
        return a*b;
    }
    public double Delta(double a, double b, double c)
    {
        return Math.Pow(b, 2.0) - (4.0 * a * c);
    }

}