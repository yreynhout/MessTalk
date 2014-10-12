using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MessTalk.Models
{
    [DebuggerDisplay("{Name}: #{Commands.Count} Commands, #{CommandDataTypes.Count} CommandDataTypes, #{Events.Count} Events, #{EventDataTypes.Count} EventDataTypes, #{SharedDataTypes.Count} SharedDataTypes")]
    public class NamedModel
    {
        private string _name;

        public NamedModel()
        {
            _name = "<not_specified>";
            Commands = new List<Command>();
            CommandDataTypes = new List<DataType>();
            Events = new List<Event>();
            EventDataTypes = new List<DataType>();
            SharedDataTypes = new List<DataType>();
        }

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

        public List<Command> Commands { get; private set; }
        public List<DataType> CommandDataTypes { get; private set; }
        public List<Event> Events { get; private set; }
        public List<DataType> EventDataTypes { get; private set; }
        public List<DataType> SharedDataTypes { get; private set; }
    }
}