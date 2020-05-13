using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SalesApp.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocate(CultureInfo ci);

    }
}
