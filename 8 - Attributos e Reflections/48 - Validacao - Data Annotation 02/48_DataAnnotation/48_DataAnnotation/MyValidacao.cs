using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _48_DataAnnotation
{
    class MyValidacao : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(((string)value).Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
