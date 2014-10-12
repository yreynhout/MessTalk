using System;
using MessTalk.Models;
using YamlDotNet.RepresentationModel;

namespace MessTalk
{
    public class ComposeNamedModelVisitor : YamlVisitor
    {
        enum State
        {
            None,
            Commands,
            CommandDataTypes,
            Events,
            EventDataTypes,
            SharedDataTypes
        }

        private readonly NamedModel _model;

        private int _mappingIndentation;
        private State _state;
        private int _scalarCount;
        private NamedPropertyContainer _current;

        public ComposeNamedModelVisitor()
        {
            _model = new NamedModel();
        }

        public NamedModel Model
        {
            get { return _model; }
        }

        protected override void Visit(YamlDocument document)
        {
            _mappingIndentation = 0;
            _scalarCount = 0;
        }

        protected override void Visit(YamlScalarNode scalar)
        {
            switch (_mappingIndentation)
            {
                case 1:
                    Model.Name = scalar.Value;
                    break;
                case 2:
                {
                    State parsed;
                    _state = !Enum.TryParse(scalar.Value, out parsed) ? State.None : parsed;
                }
                    break;
                case 3:
                    switch (_state)
                    {
                        case State.Commands:
                            _model.Commands.Add(new Command { Name = scalar.Value });
                            _current = _model.Commands[_model.Commands.Count - 1];
                            break;
                        case State.CommandDataTypes:
                            _model.CommandDataTypes.Add(new DataType { Name = scalar.Value });
                            _current = _model.CommandDataTypes[_model.CommandDataTypes.Count - 1];
                            break;
                        case State.Events:
                            _model.Events.Add(new Event { Name = scalar.Value });
                            _current = _model.Events[_model.Events.Count - 1];
                            break;
                        case State.EventDataTypes:
                            _model.EventDataTypes.Add(new DataType { Name = scalar.Value });
                            _current = _model.EventDataTypes[_model.EventDataTypes.Count - 1];
                            break;
                        case State.SharedDataTypes:
                            _model.SharedDataTypes.Add(new DataType { Name = scalar.Value });
                            _current = _model.SharedDataTypes[_model.SharedDataTypes.Count - 1];
                            break;
                    }
                    break;
                case 4:
                    switch ((_scalarCount % 2))
                    {
                        case 0:
                            _current.Properties.Add(new Property { Name = scalar.Value });
                            break;
                        case 1:
                            _current.Properties[_current.Properties.Count - 1].DataType = scalar.Value;
                            break;
                    }
                    _scalarCount++;
                    break;
            }
        }

        protected override void Visit(YamlMappingNode mapping)
        {
            _mappingIndentation += 1;
            _scalarCount = 0;
        }

        protected override void Visited(YamlMappingNode mapping)
        {
            _mappingIndentation -= 1;
            _scalarCount = 0;
        }
    }
}