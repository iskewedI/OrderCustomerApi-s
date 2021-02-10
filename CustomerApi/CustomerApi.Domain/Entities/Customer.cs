using System;
using System.Collections.Generic;
using System.Reflection;

namespace CustomerApi.Data.Entities
{
    public partial class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }

        public object GetUpdatedProperties()
        {
            Dictionary<object, object> notNullProperties = new Dictionary<object, object>();

            foreach (PropertyInfo property in typeof(Customer).GetProperties())
            {
                var value = property.GetValue(this);
                if (value != null)
                {
                    notNullProperties.Add(property, value);
                }
            }

            return notNullProperties;
        }
    }
}