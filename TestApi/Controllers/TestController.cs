using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [ProducesResponseType(typeof(BusinesError), 500)]
    public class ControllerBase : Controller
    {
    }

    public class BusinesError
    {
        [MaxLength(255)]
        public string SameText { get; set; }

        [MinLength(3)]
        public string SameText1 { get; set; }

        [RegularExpression("^.*$")]
        public string SameText2 { get; set; }
    }

    [ApiController]
    //[Route("/api/v1/[controller]")]
    [Route("/")]
    public class TestController : ControllerBase
    {
        private Random Random = new Random();
        private int RandomVal => Random.Next(1, 3000);
        public TestController()
        {

        }

        private TestModel GeneratModel()
        {
            return new TestModel();
            //return new TestModel
            //{
            //    Id = RandomVal,
            //    EnumVal = RandomVal switch
            //    {
            //        int i when i <= 1000 => SomeEnum.Val1,
            //        int i when i <= 2000 => SomeEnum.Val2,
            //        int i when i <= 3000 => SomeEnum.Val3
            //    },
            //    Value = $"Some text {RandomVal}"
            //};
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseModel), 200)]
        [Route("api/segment/test")]
        public IActionResult MultipleMethod1([FromQuery] int d)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseModel), 200)]
        public IActionResult WithoutRoute([FromQuery] int qwe)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseModel), 200)]
        [Route("")]
        public IActionResult EmptyRoute([FromQuery] int qwe)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [Route("api/segment/test")]
        public IActionResult MultipleMethod2([FromQuery] int d)
        {
            throw new NotImplementedException();
        }


        [HttpGet("[action]/{id}")]
        [ProducesResponseType(typeof(ResponseModel), 200)]
        public IActionResult AllParams([FromQuery] RequestModel model, [FromRoute] int id, [FromHeader(Name = "HeaderParam")]string header)
        {
            return Ok(new ResponseModel() { Details = new ResponseDetails { DictInt = new Dictionary<int, string> { { 1, "qwe" } } } });
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(ResponseModel), 200)]
        public IActionResult PostAction(RequestModel model)
        {
            return Ok(new ResponseModel());
        }


        //[HttpGet("[action]")]
        //public string GetString()
        //{
        //    return $"Some val {RandomVal}";
        //}

        //[HttpGet("[action]")]
        //public TestModel Get()
        //{
        //    return GeneratModel();
        //}

        //[HttpGet("[action]")]
        //public IEnumerable<TestModel> GetMultiple([FromQuery] MultipleRequest request)
        //{
        //    return Enumerable.Range(1, request.Count).Select(_ => GeneratModel());
        //}

        //[HttpPost("[action]")]
        //public IActionResult TestPost1([FromBody] MultipleRequest request)
        //{
        //    return Ok();
        //}

        //[HttpPost("[action]")]
        //public IActionResult TestPost2([FromQuery] MultipleRequest request)
        //{
        //    return Ok();
        //}
        //[HttpPost("[action]")]
        //public IActionResult TestPost11([FromQuery] MultipleRequest1 request)
        //{
        //    return Ok();
        //}

        //[HttpPost("[action]")]
        //public IActionResult TestPost3([FromForm] MultipleRequest request)
        //{
        //    return Ok();
        //}

        //[HttpPost("[action]")]
        //public IActionResult TestPost4([FromHeader] MultipleRequest request)
        //{
        //    return Ok();
        //}
        //[HttpPost("[action]/{request}")]
        //public IActionResult TestPost5([FromRoute] MultipleRequest request)
        //{
        //    return Ok();
        //}

    }

    public class RequestModel
    {
        public int RequestProperty { get; set; }
        public string RequestProperty1 { get; set; }
    }

    public class TestModel
    {
        public string StringProp1 { get; set; }
        public string StringProp2 { get; set; }
        public string StringProp3Required { get; set; }

        public string StringProp4Phone { get; set; }
        public string StringProp5Email { get; set; }
        public string StringProp6Regex { get; set; }
    }

    public class ResponseDetails
    {
        public class ResponseNested
        {
            [Range(1, 8)]
            public int IntProp { get; set; }
            [StringLength(10, MinimumLength = 4)]

            public string StringProp { get; set; }
            public long LongProp { get; set; }
            public decimal DecimalProp { get; set; }
            public float FloatProp { get; set; }
            public short ShortProp { get; set; }
            public byte ByteProp { get; set; }
            public char CharProp { get; set; }

            public TimeSpan TimeSpanProp { get; set; }
            public DateTime DateTimeProp { get; set; }

            public bool BoolProp { get; set; }
        }

        public int Value { get; set; }

        [MinLength(5)]
        public Dictionary<int, string> DictInt { get; set; }

        public Dictionary<string, string> DictStr { get; set; }

        [MinLength(6)]
        public int[] IntArr { get; set; }

        public string[] StringArr { get; set; }

        public (int IntVal, string StrVal) TupleProp { get; set; }

        public List<ResponseNested> ListOfResponseNested { get; set; }
    }

    public class ResponseModel
    {
        public int ResponseProperty { get; set; }
        [Required]
        public string ResponseProperty1 { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Range(1.2, 23.3)]
        public double DoubleProp { get; set; }
        public DateTime DateTimeProp { get; set; }
        public SomeEnum SomeEnumProp { get; set; }
        public OtherEnum OtherEnumProp { get; set; }

        public ResponseDetails Details { get; set; }

    }


    //public class MultipleRequestBase
    //{
    //    public string Unused { get; set; }
    //}

    //public class MultipleRequest : MultipleRequestBase
    //{
    //    public int Count { get; set; }
    //}

    //public class MultipleRequest1 : MultipleRequestBase
    //{
    //    [BindPropertyAttribute]
    //    public int Count { get; set; }
    //}
}
