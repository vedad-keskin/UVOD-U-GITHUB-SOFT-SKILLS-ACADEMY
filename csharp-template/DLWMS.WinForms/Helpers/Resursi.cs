using System.Reflection;
using System.Resources;

namespace DLWMS.WinForms.Helpers
{
    public class Resursi
    {
        private static ResourceManager Menadzer = new ResourceManager(Kljucevi.NazivResourceFajla, Assembly.GetExecutingAssembly());

        public static string Get(string kljuc)
        {
            return Menadzer.GetString(kljuc);
        }

    }

}
