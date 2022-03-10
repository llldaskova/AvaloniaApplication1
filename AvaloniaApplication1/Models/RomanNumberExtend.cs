using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public class RomanNumberExtend: RomanNumber
    {
        public RomanNumberExtend(ushort n) : base(n) { }
        public RomanNumberExtend(string num): base(RomanInt(num)) { }
        private static ushort value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            throw new RomanNumberException();
        }



        private static ushort RomanInt(string s)
        {
            ushort result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ushort s1 = value(s[i]);
                if (i + 1 < s.Length)
                {
                    ushort s2 = value(s[i + 1]);
                    if (s1 >= s2)
                    {
                        result = (ushort)(result + s1);
                    }
                    else if(s1<s2&&(s1==1||s1%10==0))
                    {
                        result = (ushort)(result - s1);
                    }
                    else
                    {
                        throw new RomanNumberException();
                    }
                }
                else
                {
                    result = (ushort)(result + s1);
                }
            }
            return result;
        }


    }
}
