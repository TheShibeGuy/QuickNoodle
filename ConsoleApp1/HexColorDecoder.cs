using System;
using System.Collections.Generic;
using System.Linq;

class HexColorDecoder
{
    public static int[] DecodeHexColor(string hexColor)
    {
        hexColor = hexColor.Replace("#", string.Empty);
        IEnumerable<string> bytes = hexColor.SplitInParts(2);
        int[] bytesAsInts = bytes.ToArray().Select(x => Convert.ToInt32(x, 16)).ToArray();
        return bytesAsInts;
    }
}