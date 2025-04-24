using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Helpers;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field!.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false)
            .FirstOrDefault() as System.ComponentModel.DescriptionAttribute;
        return attribute == null ? value.ToString() : attribute.Description;
    }
}