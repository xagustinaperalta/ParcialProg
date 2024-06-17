using BibliotecaDeClases.Exceptions;

namespace BibliotecaDeClases
{
    public static class Funciones
    {
        private static int CalcularDigitoCuit(string cuit)
        {
            try
            {
                int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                char[] nums = cuit.ToCharArray();
                int total = 0;

                for (int i = 0; i < mult.Length; i++)
                {
                    total += int.Parse(nums[i].ToString()) * mult[i];
                }

                var resto = total % 11;
                return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void ValidaCuit(string cuit)
        {
            try
            {
                if (string.IsNullOrEmpty(cuit))
                {
                    throw new CuitException("Cuit no valido");
                }

                cuit = cuit.Replace("-", string.Empty);
                if (cuit.Length != 11)
                {
                    throw new CuitException("Cuit no valido");
                }
                else
                {
                    int calculado = CalcularDigitoCuit(cuit);
                    int digito = int.Parse(cuit.Substring(10));

                    if (calculado != digito)
                    {
                       throw new CuitException("Cuit no valido");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
