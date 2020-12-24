using Parser.OpenApiData;
using System;
using System.Diagnostics;
using System.Text;

namespace Parser.Models.TypeDefinitions
{
    public abstract class TypeDefinitionModelBase
    {
        protected TypeDefinitionModelBase(OpenApiSchemaDescription schema)
        {
            Format = schema.Format;
            IsNullable = schema.Nullable ?? false;
        }

        public virtual bool IsNullable { get; }
        
        public virtual string Format { get; }
    }
}
