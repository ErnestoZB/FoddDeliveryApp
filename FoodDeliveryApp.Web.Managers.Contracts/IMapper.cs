using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FoodDeliveryApp.Web.Managers.Contracts
{
    public interface IMapper
    {
        TDest Map<TSource, TDest>(TSource source);
    }
}
