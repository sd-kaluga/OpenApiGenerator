using Parser.Models.Stores;
using Parser.Models.TypeDefinitions;
using Parser.Models.TypeDefinitions.Collections;
using Parser.Tests.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Parser.Tests
{
    public class TypesDefinitionsTest1 : ParserTestBase
    {
        public TypesDefinitionsTest1() : base(SchemasList.Test1Schema)
        {
        }

        [Fact(DisplayName = "Check string properties")]
        public void ParseStringTestModel()
        {
            var definition = CheckObjectDefinition("StringTestModel");
            var prop1 = CheckPropertyOfObject<StringDefinition>(definition, "prop1", false);
           
            
             CheckStringDefinition(prop1, nullable: true);

            var prop2 = CheckPropertyOfObject<StringDefinition>(definition, "prop2",false);
            CheckStringDefinition(prop2,
                maxLength: 255,
                minLength: 3,
                format: "format-value",
                pattern: "^.*$",
                nullable: true);
        }

        [Fact(DisplayName = "Check numeric properties")]
        public void ParseNumbersTestModel()
        {
            var definition = CheckObjectDefinition("NumbersTestModel");

            var nullableInt32prop = CheckPropertyOfObject<IntegerDefinition>(definition, "nullableInt32prop",false);
            CheckNumericProperty(nullableInt32prop, nullable: true);

            var int32prop = CheckPropertyOfObject<IntegerDefinition>(definition, "int32prop", true);
            CheckNumericProperty(int32prop,
                format: "int32",
                minimum: 1,
                maximum: 20);

            var int64prop = CheckPropertyOfObject<BigIntegerDefinition>(definition, "int64prop", false);
            CheckNumericProperty(int64prop,
                format: "int64",
                minimum: 1111,
                maximum: 2000);

            var doubleProp = CheckPropertyOfObject<DoubleDefinition>(definition, "doubleProp", false);
            CheckNumericProperty(doubleProp,
                format: "double",
                minimum: 1.1111,
                maximum: 20.1111);

            var floatProp = CheckPropertyOfObject<FloatDefinition>(definition, "floatProp", false);
            CheckNumericProperty(floatProp,
                format: "float",
                minimum: 1.1f,
                maximum: 20.1f);
        }

        [Fact(DisplayName = "Check enum types")]
        public void TestEnums()
        {
            var iDefinition = CheckEnumDefinition<IntegerEnumDefinition>("SomeEnum");
            Assert.True(iDefinition.Values.SequenceEqual(new int[] { 0, 1, 2 }));

            var sDefinition = CheckEnumDefinition<StringEnumDefinition>("OtherEnum");
            Assert.True(sDefinition.Values.SequenceEqual(new string[] { "ValOne", "ValTwo", "ValThree" }));
        }

        [Fact(DisplayName = "Check props with ref")]
        public void TestPropertiesWithRefDefinition()
        {
            var definition = CheckObjectDefinition("RefPropertiesTestModel");
            Assert.NotNull(definition);
            
            var someEnumPropDef = CheckPropertyOfObject<IntegerEnumDefinition>(definition, "someEnumProp", false);
            Assert.NotNull(someEnumPropDef);
            
            var someEnumDefinition = CheckEnumDefinition<IntegerEnumDefinition>("SomeEnum");
            Assert.NotNull(someEnumDefinition);

            Assert.Equal(someEnumDefinition, someEnumPropDef);

            var detailsPropDef = CheckPropertyOfObject<ObjectTypeDefinition>(definition, "details", false);
            Assert.NotNull(detailsPropDef);

            var detailsDefinition = CheckObjectDefinition("TestInnerModel");
            Assert.NotNull(detailsDefinition);

            Assert.Equal(detailsDefinition, detailsPropDef);
        }

        [Fact(DisplayName = "Test collections definition")]
        public void TestCollectionsDefinition()
        {
            var definition = CheckObjectDefinition("CollectionsPropertiesModel");

            var dictInt = CheckPropertyOfObject<DictionaryDefinition>(definition, "dictInt", false);
            Assert.IsType<IntegerDefinition>(dictInt.ElementDefinition);

            var dictStr = CheckPropertyOfObject<DictionaryDefinition>(definition, "dictStr", false);
            Assert.IsType<StringDefinition>(dictStr.ElementDefinition);

            var intArr = CheckPropertyOfObject<ArrayDefinition>(definition, "intArr", false);
            Assert.IsType<IntegerDefinition>(intArr.ElementDefinition);

            var requiredIntArr = CheckPropertyOfObject<ArrayDefinition>(definition, "requiredIntArr", true);
            Assert.True(requiredIntArr.IsNullable);
            Assert.IsType<IntegerDefinition>(requiredIntArr.ElementDefinition);

            var stringArr = CheckPropertyOfObject<ArrayDefinition>(definition, "stringArr", false);
            Assert.IsType<StringDefinition>(stringArr.ElementDefinition);

            var listOfTestInnerModel = CheckPropertyOfObject<ArrayDefinition>(definition, "listOfTestInnerModel", false);
            Assert.IsType<ObjectTypeDefinition>(listOfTestInnerModel.ElementDefinition);
            
            var definitionTestInnerModel = CheckObjectDefinition("TestInnerModel");
            Assert.Equal(definitionTestInnerModel, listOfTestInnerModel.ElementDefinition);

        }

        [Fact(DisplayName = "Test date time definition")]
        public void TestDateTimeDefinition()
        {
            var definition = CheckObjectDefinition("DateTimePropertiesModel");
            var dateTimeProp = CheckPropertyOfObject<DateTimeDefinition>(definition, "dateTimeProp", false);
        }

        [Fact(DisplayName = "Test bool definition")]
        public void TestBoolDefinition()
        {
            var definition = CheckObjectDefinition("BooleanPropertiesModel");
            var boolProp = CheckPropertyOfObject<BooleanDefinition>(definition, "boolProp", false);
        }

        private ObjectTypeDefinition CheckObjectDefinition(string name)
        {
            var def = DocumentModel.TypesDefinitions.FirstOrDefault(d => d is ObjectTypeDefinition e && e.Name == name);
            Assert.NotNull(def);
            return (ObjectTypeDefinition)Convert.ChangeType(def, typeof(ObjectTypeDefinition));
        }

        private TPropDefinition CheckPropertyOfObject<TPropDefinition>(
            ObjectTypeDefinition objectDefinition, 
            string propertyName,
            bool isRequired)
            where TPropDefinition : TypeDefinitionModelBase
        {
            var propDef = (objectDefinition ?? throw new ArgumentNullException(nameof(objectDefinition)))
                .Properties
                .FirstOrDefault(p => p.Name == propertyName);
            Assert.NotNull(propDef);

            Assert.Equal(isRequired, propDef.IsRequired);

            Assert.NotNull(propDef.TypeDefinition);
            Assert.IsType<TPropDefinition>(propDef.TypeDefinition);
            return (TPropDefinition)Convert.ChangeType(propDef.TypeDefinition, typeof(TPropDefinition));
        }
        
        private TEnumDefinition CheckEnumDefinition<TEnumDefinition>(string name)
            where TEnumDefinition : EnumDefinitionBase
        {
            var def =  DocumentModel.TypesDefinitions.FirstOrDefault(d => d is TEnumDefinition e && e.Name == name);
            Assert.NotNull(def);
            return (TEnumDefinition)Convert.ChangeType(def, typeof(TEnumDefinition));
        }

        private void CheckDefinitionBase(
            TypeDefinitionModelBase definition, 
            bool? nullable = null,
            string format = null)
        {
            CheckIfHasVal(nullable, definition.IsNullable);
            CheckIfHasVal(format, definition.Format);
        }

        private void CheckIfHasVal<T>(T expected, T actual)
        {
            if (!EqualityComparer<T>.Default.Equals(expected, default(T)))
            {
                Assert.Equal(expected, actual);
            }
        }

        private void CheckLength(IPropertyLengthConditions property, int? minLength = null, int? maxLength = null)
        {
            if (minLength.HasValue)
            {
                Assert.Equal(minLength, property.MinLength);
                Assert.Equal(maxLength, property.MaxLength);
            }
        }

        private void CheckStringDefinition(StringDefinition definition,
            bool? nullable = null,
            string format = null,
            int? minLength = null,
            int? maxLength = null,
            string pattern = null)
        {
            CheckDefinitionBase(definition, nullable, format);
            CheckLength(definition, minLength, maxLength);
            CheckIfHasVal(pattern, definition.Pattern);
        }

        private void CheckNumericProperty<TValue>(
            NumericTypeDefinitionBase<TValue> definition,
            bool? nullable = null,
            string format = null,
            TValue? minimum = default(TValue?),
            TValue? maximum = default(TValue?)) where TValue : struct
        {
            CheckDefinitionBase(definition, nullable, format);
            CheckIfHasVal(minimum, definition.Minimum);
            CheckIfHasVal(maximum, definition.Maximum);
        }
    }
}
