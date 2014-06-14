using MbUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Oasis.Ubl.v21;

namespace ubl.net.test
{
    [TestFixture] 
    public class Validation
    {

        //[Test]
        //public void ValidateXmlNET()
        //{
        //   string pathxml21 = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\spec\xml\UBL-Order-2.1-Example.xml";
            
        //    string content = File.ReadAllText(pathxml21);

        //    var retvalue = Deserialize<OrderType>(content, new XmlReaderSettings());
        //    Assert.IsNotNull(retvalue);
            

        //    Assert.AreEqual("34", retvalue.ID.ToString());

        //    retvalue.SaveToFile("D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserialize.xml");


        //}

         [Test]
        public void ValidateInvoiceXml()
        {
            string pathxml21 = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\spec\xml\UBL-Invoice-2.1-Example.xml";
            
            string content = File.ReadAllText(pathxml21);

            var retvalue = InvoiceType.Deserialize(content);

             //inserire condition per controllare il file prodotto
                    Assert.IsNotNull(retvalue);
                    Assert.AreEqual("34", retvalue.ID.ToString());

            retvalue.SaveToFile(@"D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserializeInvoice.xml");

          

        }

         private T Deserialize<T>(string xml, XmlReaderSettings settings)
        {

            if (string.IsNullOrEmpty(xml))
            {
                return default(T);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }

         private XmlReaderSettings DefaultXmlWriterSettings()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            //possibilità di variare i settings
            
            return settings;
        }

    }
}
