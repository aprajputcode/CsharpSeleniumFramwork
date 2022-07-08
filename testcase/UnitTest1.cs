using demo.driver;
using demo.PageObject;
using demo.readdata;
using Newtonsoft.Json;

namespace demo.testcase
{
    public class Tests :BaseClass
    {
        //public void  values()
        //{
        //    StreamReader r = new StreamReader("file.json");
        //    string jsonString = r.ReadToEnd();
        //    data m = JsonConvert.DeserializeObject<data>(jsonString);
            
        //}
        static string[] listcards =
          {
            

            "Lava Hound","Electro Giant"
        };
        [Test]
        [TestCaseSource(nameof(listcards))]
        [Parallelizable(ParallelScope.Children)]


        public void test2(string cardname)
        {
            WebPage wp = new WebPage(Driver.Current);
            wp.Url("https://statsroyale.com");
            Thread.Sleep(3000);
            wp.cards().Click();
            Thread.Sleep(3000);
            Assert.AreEqual(wp.cards().Text, wp.headerMedium_name());
            wp.CardName(cardname).Click();
            Assert.AreEqual(cardname, wp.CardNameText());

        }


    }
}