﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Account
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Account()
    {
        this.Player = new HashSet<Player>();
    }

    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Player> Player { get; set; }
}

public partial class Player
{
    public int Id { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Gold { get; set; }
    public int AccountId { get; set; }
    public string Name { get; set; }

    public virtual Account Account { get; set; }
}

public partial class Stat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}