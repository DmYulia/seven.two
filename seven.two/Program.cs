using static System.Console;

namespace _seven.two
{
    class Program
    {
        static void Main(string[] args)
        {
            double VCube(double a)
            {
                try
                {
                    if (a > 0) return (a * a * a);
                    else throw new Exception("Error intput data!\nCode ");
                }
                catch (Exception e)
                {
                    Write(e.Message);
                    return 0;
                }
            }
            double SCube(double a)
            {
                try
                {
                    if (a > 0) return (a * a * 6);
                    else throw new Exception("Error intput data!\nCode ");
                }
                catch (Exception e)
                {
                    Write(e.Message);
                    return 0;
                }
            }
            double a = 1;
            Write("Write a: ");
        Mm: try
            {
                a = Convert.ToDouble(ReadLine());
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
                WriteLine("Try again..");
                goto Mm;
            }
            WriteLine(VCube(a));
            WriteLine(SCube(a));
            ReadKey();
        }
    }
}