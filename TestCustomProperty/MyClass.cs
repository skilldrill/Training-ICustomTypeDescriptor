// -----------------------------------------------------------------------
// <copyright file="MyClass.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestCustomProperty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using System.Collections;
    using System.Reflection;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class MyClass : DictionaryPropertyGridAdapter
    {
        public string Name { get; set; }
        public int Nr { get; set; }
        public MyClass(IDictionary d) : base(d)
        {
            Name = "sss";
            Nr = 1;
            foreach (PropertyInfo pi in typeof(MyClass).GetProperties())
            {
                d.Add(pi.Name, pi.GetValue(this, null));
            } 
        }

        public MyClass():base()
        {
            Name = "sss";
            foreach (PropertyInfo pi in typeof(MyClass).GetProperties())
            {
                this.AddProperty(pi.Name, pi.GetValue(this, null));
            }
            Nr = 1;
        }
        

    }
}
