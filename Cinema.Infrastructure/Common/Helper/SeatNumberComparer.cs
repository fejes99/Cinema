using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Helper;

public class SeatNumberComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x == y)
            return 0;

        var xStr = x.ToString();
        var yStr = y.ToString();

        if (xStr.Length == yStr.Length)
            return x.CompareTo(y);

        return xStr.Length.CompareTo(yStr.Length);
    }
}
