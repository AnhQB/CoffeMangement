using System;
using System.Collections.Generic;

namespace CoffeeBook.Models;

public partial class Account
{
    public string UserName { get; set; }

    public string DisplayName { get; set; }

    public string PassWord { get; set; }

    public int Type { get; set; }
}
