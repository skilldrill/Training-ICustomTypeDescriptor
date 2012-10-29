// -----------------------------------------------------------------------
// <copyright file="DictionaryPropertyGridAdapter.cs" company="">
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
    /// This is the adapter class for the custom type description.
    /// </summary>
    public class DictionaryPropertyGridAdapter : ICustomTypeDescriptor
    {
        IDictionary _dictionary;
        public DictionaryPropertyGridAdapter(IDictionary d)
        {
            _dictionary = d;
        }

        public DictionaryPropertyGridAdapter()
        {
            _dictionary = new Hashtable();
        }
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return null;
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            ArrayList properties = new ArrayList();
            foreach (DictionaryEntry e in _dictionary)
            {
                properties.Add(new DictionaryPropertyDescriptor(_dictionary, e.Key));
            }

            PropertyDescriptor[] props =
                (PropertyDescriptor[])properties.ToArray(typeof(PropertyDescriptor));

            return new PropertyDescriptorCollection(props);
        }

        public PropertyDescriptorCollection GetProperties()
        {
            return ((ICustomTypeDescriptor)this).GetProperties(new Attribute[0]);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return _dictionary;
        }

        public void AddProperty(object key, object value)
        {
            _dictionary.Add(key, value);
        }
    }
}
