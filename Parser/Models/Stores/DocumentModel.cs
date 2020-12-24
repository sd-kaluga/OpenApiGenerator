using Parser.Models.TypeDefinitions;
using Parser.Parsers;
using Parser.Utils.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Parser.Models.Stores
{
    public class DocumentModel
    {
        public List<TypeDefinitionModelBase> TypesDefinitions { get; } = new List<TypeDefinitionModelBase>();
        public List<EndpointModel> Endpoints { get; } = new List<EndpointModel>();
    }
}
