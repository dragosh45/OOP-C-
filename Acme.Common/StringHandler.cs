﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpace(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result;
        }
    }
}
