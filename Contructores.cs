
using System;

public class Contructores 
{

    public void Update()
    {
        static void Main(string[] args)
        {

            EjConstructor obj = new EjConstructor(10, 20);
            Console.WriteLine("La suma es: " + obj.Suma());
            Console.WriteLine("La resta es: " + obj.resta());
            Console.ReadKey();
            //Debug.Log("la suma es" + obj.Suma());
            //Debug.Log("la resta es" + obj.resta());
        }
    }
    class EjConstructor
    {
        int a;
        int b;
        public EjConstructor(int x, int y)
        {
            a = x;
            b = y;
        }
        public int Suma()
        {
            return a + b;
        }

        public int resta()
        {
            return a - b;
        }
    }
    class Principal
    {
        static void Main(string[] args)
        {
            
            EjConstructor obj = new EjConstructor(10, 20);
            Console.WriteLine("La suma es: " + obj.Suma());
            Console.WriteLine("La resta es: " + obj.resta());
            Console.ReadKey();
          
        }
    }
}

