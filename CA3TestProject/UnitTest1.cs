using NUnit.Framework;
using EAD_Ca3.Pages;
using Bunit;
using xs = Xunit;
using Microsoft.AspNetCore.Components;
using sy = System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RichardSzalay.MockHttp;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http;
using EAD_Ca3.Data;
using System.Collections.Generic;

namespace CA3TestProject
{
    public class Tests
    {
        private Bunit.TestContext ?testContext;
        private readonly HttpClient ?Http;
        public List<Photo> p1 = new List<Photo>();

        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();

        }
        [TearDown]
        public void Teardown()
        {
            testContext.Dispose();
        }

        [Test]
        public void TestPageLoad()
        {

            var component = testContext.RenderComponent<Index>();
            Assert.IsTrue(component.Markup.Contains("<h1>Welcome</h1>"));
        }

        [Test]
        public void TestHasInputField()
        {
            var sut = testContext.RenderComponent<Convert>();


            var inputField = sut.Find("input");
            

            Assert.IsNotNull(inputField);

        

        }


        [Test]
        public void Testcalc()
        {
            var cut = testContext.RenderComponent<Convert>();

            cut.Instance.eYears = 10;

            cut.Instance.ConvertYears();

            Assert.AreEqual(18.809, cut.Instance.mYears);
        }

       

        [Test]
        public async Task TestApiCall()
        {
            var cut = testContext.RenderComponent<FetchData>();
            cut.Instance.q1.RoverName = EAD_Ca3.Data.RoverNames.Curiosity;
            cut.Instance.q1.solDay = "10";

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(await Http.GetStringAsync("https://api.nasa.gov/mars-photos/api/v1/rovers/Curiosity/photos?sol=10&api_key=vT5CQ2aqemBmK4jfX3ceTtFpbmu8bM62ft2YwywO"));
            p1 = myDeserializedClass.photos;

            var test = p1[0]; //possible null

            int id = test.id;

            Assert.NotZero(id);
        }
        [Test]
        public void TestInvalidApiCall()
        {

            
            var cut = testContext.RenderComponent<FetchData>();

            cut.Instance.q1.RoverName = EAD_Ca3.Data.RoverNames.Curiosity;

            cut.Instance.q1.solDay = "1015";
            
            cut.WaitForAssertion(() => Assert.IsEmpty(cut.Instance.p1));

        }




    }

}