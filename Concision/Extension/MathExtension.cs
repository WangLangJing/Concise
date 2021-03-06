﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concision
{
    public static class MathExtension
    {
        /// <summary>
        /// 将<see cref="Double"/>类型四舍五入为<see cref="Int32"/>
        /// </summary>
        public static Int32 RoundToInt32(this Double source)
        {
            Int32 integer = (Int32)source;
            Double dValue = source - integer;
            if (dValue * 10 >= 5)
            {
                return integer + 1;
            }
            else
            {
                return integer;
            }
        }
        /// <summary>
        /// 将<see cref="Double"/>类型四舍五入为<see cref="Int64"/>
        /// </summary>
        public static Int64 RoundToInt64(this Double source)
        {
            Int64 integer = (Int64)source;
            Double dValue = source - integer;
            if (dValue * 10 >= 5)
            {
                return integer + 1;
            }
            else
            {
                return integer;
            }
        }
        public static Int32 RoundToInt32(this Single source)
        {
            Int32 integer = (Int32)source;
            Double dValue = source - integer;
            if (dValue * 10 >= 5)
            {
                return integer + 1;
            }
            else
            {
                return integer;
            }
        }
    }
}
