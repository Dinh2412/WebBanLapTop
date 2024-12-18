
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
    
public partial class Product
{

    public Product()
    {

        this.Favorites_list = new HashSet<Favorites_list>();

        this.Product_Color = new HashSet<Product_Color>();

        this.Product_Image = new HashSet<Product_Image>();

    }


    public int ID { get; set; }

    public string Name { get; set; }

    public Nullable<int> ID_Brand { get; set; }

    public string Group_Pro { get; set; }

    public string Description { get; set; }

    public Nullable<decimal> Price { get; set; }

    public Nullable<decimal> Promotion_Price { get; set; }

    public string Image { get; set; }

    public string CPU { get; set; }

    public string GPU { get; set; }

    public string RAM { get; set; }

    public string ROM { get; set; }

    public string Monitor { get; set; }

    public string Operating { get; set; }

    public string Warranty { get; set; }

    public Nullable<System.DateTime> created_at { get; set; }

    public Nullable<System.DateTime> updated_at { get; set; }

    public string Pin { get; set; }

    public string Size { get; set; }

    public string Weight { get; set; }



    public virtual Brand Brand { get; set; }

    public virtual ICollection<Favorites_list> Favorites_list { get; set; }

    public virtual ICollection<Product_Color> Product_Color { get; set; }

    public virtual ICollection<Product_Image> Product_Image { get; set; }

}

}
