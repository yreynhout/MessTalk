using System;
using System.Diagnostics;

namespace MessTalk.Models
{
    [DebuggerDisplay("{Name}:{DataType}")]
    public class Property
    {
        public Property()
        {
            _name = "<not_specified>";
            _dataType = "<not_specified>";
        }

        private string _name;
        private string _dataType;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                _name = value;
            }
        }

        public string DataType
        {
            get { return _dataType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                _dataType = value;
            }
        }
    }
}