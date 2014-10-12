using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MessTalk.Models
{
    [DebuggerDisplay("{Name}: #{Properties.Count} Properties")]
    public abstract class NamedPropertyContainer
    {
        private string _name;

        protected NamedPropertyContainer()
        {
            _name = "<not_specified>";
            Properties = new List<Property>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                _name = value;
            }
        }

        public List<Property> Properties { get; private set; }
    }
}