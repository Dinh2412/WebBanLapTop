
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Laptop.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Customer
{

    public Customer()
    {

        this.Bills = new HashSet<Bill>();

        this.Carts = new HashSet<Cart>();

        this.Favorites_list = new HashSet<Favorites_list>();

    }


    public int ID { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }

    public string Address { get; set; }

    public string Phone_Number { get; set; }

    public string Note { get; set; }

    public string Status { get; set; }

    public Nullable<System.DateTime> created_at { get; set; }

    public Nullable<System.DateTime> updated_at { get; set; }



    public virtual ICollection<Bill> Bills { get; set; }

    public virtual ICollection<Cart> Carts { get; set; }

    public virtual ICollection<Favorites_list> Favorites_list { get; set; }

}

}
