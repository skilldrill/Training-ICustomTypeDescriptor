// -----------------------------------------------------------------------
// <copyright file="DictionaryPropertyDescriptor.cs" company="">
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

    /// <summary>
    /// This is a custom Property Descriptor class that manages how properties are set and retrieved
    /// </summary>
    public class DictionaryPropertyDescriptor : PropertyDescriptor
    {
        IDictionary _dictionary;
        object _key;

        internal DictionaryPropertyDescriptor(IDictionary d, object key)
            : base(key.ToString(), null)
        {
            _dictionary = d;
            _key = key;
        }
        public override Type PropertyType
        {
            get { return _dictionary[_key].GetType(); }
        }

        public override void SetValue(object component, object value)
        {
            _dictionary[_key] = value;
        }

        public override object GetValue(object component)
        {
            return _dictionary[_key];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type ComponentType
        {
            get { return null; }
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
