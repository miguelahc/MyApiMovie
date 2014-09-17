using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApiMovie.Translator;

namespace MyApiMovie.UnitTest
{
    [TestClass]
    public class TranslatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {            
           string fromLanguage = "en";
            string toLanguage = "es";

            string ToTranslate = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world";
            string expected = "Parapléjico Marina enviado a la luna Pandora en una única misión llega a ser dividido entre siguiendo sus órdenes y protegiendo el mundo";
            Translator.Translator translator = new Translator.Translator();
            
            translator.fromLanguage=fromLanguage;
            translator.toLanguage=toLanguage;
            translator.sourceText=ToTranslate;
            string actual=translator.Translate();
            
            Assert.AreEqual(expected.ToUpper(),actual.ToUpper(),string.Format("Error en traducción: envia:{0} recibe:{1}",ToTranslate,actual));

        }
    }
}
