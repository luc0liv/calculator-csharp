namespace Calculadora
{
    public class Calculadora
    { 
        public int valor1;
        public int valor2;

        public Calculadora(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public int sum() { return valor1 + valor2; }
        public int sub() { return valor1 - valor2; }
        public int divide() { return valor1 / valor2; }
        public int multiply() { return valor1 * valor2; }
    }
}
