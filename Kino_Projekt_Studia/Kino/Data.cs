using System;

namespace Kino
{
    public class Data
    {
        // Metoda zwracająca aktualną datę i godzinę
        public virtual string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
