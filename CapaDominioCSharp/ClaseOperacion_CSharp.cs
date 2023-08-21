namespace CapaDominioCSharp
{
    public class ClaseOperacion_CSharp
    {

        public double Calcular( object[] arg)
        {
            double result = 0, 
                   num1 = double.Parse(arg[0].ToString()!), 
                   num2 = double.Parse(arg[1].ToString()!);
            string operation = arg[2].ToString()!;

            switch (operation)
            {
                case "Sumar":
                    result = num1 + num2;
                    break;
                case "Restar":
                    result = num1 - num2;
                    break;
                case "Multiplicar":
                    result = num1 * num2;
                    break;
                case "Dividir":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}