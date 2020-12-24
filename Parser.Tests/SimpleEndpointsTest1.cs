using Parser.Models.Stores;
using Parser.Models.TypeDefinitions;
using Parser.Models.TypeDefinitions.Collections;
using Parser.OpenApiData;
using Parser.Tests.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Parser.Tests
{
    public class SimpleEndpointsTest1 : ParserTestBase
    {
        public SimpleEndpointsTest1() : base(SchemasList.Test2Schema)
        {
        }

        //[Fact(DisplayName = "Endpoints count")]
        //public void ParseStringTestModel1()
        //{
        //    Assert.Equal(2, DocumentModel.Endpoints.Count());
        //    }

        [Fact(DisplayName = "Test GetAction")]
        public void ParseStringTestModel2()
        {
            var getEndpoint = DocumentModel.Endpoints.FirstOrDefault(ep => ep.Path.LastOrDefault()?.Value == "GetAction");
            Assert.NotNull(getEndpoint);
            Assert.Single(getEndpoint.Operations);

            var action = getEndpoint.Operations.Single();
            Assert.Equal(HttpAction.Get, action.HttpAction);
            Assert.Equal(2, action.OperationParameters.Count());

            Assert.Equal(ParameterLocation.Query, action.OperationParameters.First().Location);
        }

        [Fact(DisplayName = "Test GetAction Responses")]
        public void TestGetActionResponses()
        {
            var getEndpoint = DocumentModel.Endpoints.FirstOrDefault(ep => ep.Path.LastOrDefault()?.Value == "GetAction");
            

            var operaion = getEndpoint.Operations.Single();
            Assert.Equal(2, operaion.Responses.Count());
            var resp200 = operaion.Responses.FirstOrDefault(r => r.Code == 200);
            Assert.NotNull(resp200);

            var resp500 = operaion.Responses.FirstOrDefault(r => r.Code == 500);
            Assert.NotNull(resp500);
        }

        [Fact(DisplayName = "Test PostAction")]
        public void TesPostActionResponses()
        {
            var postEndpoint = DocumentModel.Endpoints.FirstOrDefault(ep => ep.Path.LastOrDefault()?.Value == "PostAction");
            Assert.NotNull(postEndpoint);
            Assert.Single(postEndpoint.Operations);

            var operaion = postEndpoint.Operations.Single();
            Assert.Equal(HttpAction.Post, operaion.HttpAction);

            Assert.Empty(operaion.OperationParameters);

            Assert.NotNull(operaion.Body);
            Assert.Equal("application/json", operaion.Body.ContentType);
            Assert.IsType<ObjectTypeDefinition>(operaion.Body.TypeDefinition);
            Assert.Equal("RequestModel", ((ObjectTypeDefinition)operaion.Body.TypeDefinition).Name);

            Assert.Equal(2, operaion.Responses.Count());
            var resp200 = operaion.Responses.FirstOrDefault(r => r.Code == 200);
            Assert.NotNull(resp200);
            Assert.Equal("application/json", resp200.ContentType);
            Assert.IsType<ObjectTypeDefinition>(resp200.TypeDefinition);
            Assert.Equal("ResponseModel", ((ObjectTypeDefinition)resp200.TypeDefinition).Name);
            
            var resp500 = operaion.Responses.FirstOrDefault(r => r.Code == 500);
            Assert.NotNull(resp500);
            Assert.Equal("application/json", resp500.ContentType);
            Assert.IsType<ObjectTypeDefinition>(resp500.TypeDefinition);
            Assert.Equal("BusinesError", ((ObjectTypeDefinition)resp500.TypeDefinition).Name);
        }



    }
}
