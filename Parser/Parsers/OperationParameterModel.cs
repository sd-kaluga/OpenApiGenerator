using Parser.Models.TypeDefinitions;
using Parser.OpenApiData;
using System.Collections.Generic;

namespace Parser.Parsers
{
    public class OperationParameterModel
    {
        public string Name { get; set; }

        public TypeDefinitionModelBase Definition { get; set; }
        public ParameterLocation Location { get; set; }
    }

}


