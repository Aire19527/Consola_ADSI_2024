namespace AppConsola.Helpers
{
    public static class Helper
    {
        public static string ValidarSexo(int numero)
        {
            string sexo = string.Empty;
            double result = numero % 2;
            if (result == 0)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femino";
            }

            return sexo;
        }
    }
}
