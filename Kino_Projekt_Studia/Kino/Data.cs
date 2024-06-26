using System;

namespace Kino
{
    public class Data
    {
        public virtual string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
