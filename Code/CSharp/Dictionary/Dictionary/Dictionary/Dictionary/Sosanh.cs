using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;
namespace Dictionary
{
    class SoSanh : IComparer
    {
        CompareInfo ci;
        public SoSanh(CompareInfo a)
        {
            ci = a;
        }
        int IComparer.Compare(Object x, Object y)
        {
            return ci.Compare((string)x, (string)y, CompareOptions.StringSort);
        }
    }
}
