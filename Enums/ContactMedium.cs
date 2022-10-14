using System;
using System.ComponentModel;

namespace myspace.Enums;

public enum ContactMedium
{
    Text,
    Email,
    Phone,
    Internet,
    [Description("In Person")]
    InPerson,
    Other
}

