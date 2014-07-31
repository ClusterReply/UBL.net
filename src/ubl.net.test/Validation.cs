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
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using System.Diagnostics;

namespace ubl.net.test
{
    [TestFixture] 
    public class Validation
    {
        [Test]
        private void Test_InvoiceType()
        {
            string inputUBLfile = @"..\..\InputXML\UBL-Invoice-2.1-Example.xml";
             
             string outputFile = @"..\..\OutputXML\TestDeserialize_Invoice.xml";
             DeserializeGeneric<InvoiceType>(inputUBLfile, outputFile);

        }

        
         [Test]
         private void Test_UtilityStatement()
         {
             string inputUBLfile = @"..\..\InputXML\UtilityStatement_UBL_21.xml";
             string outputFile = @"..\..\OutputXML\TestDeserialize_UtilityStatement.xml";

             DeserializeGeneric<UtilityStatementType>(inputUBLfile, outputFile);

         }

         [Test]
         private void Test_ApplicationResponse()
         {
             string inputUBLfile = @"..\..\InputXML\ApplicationResponse_UBL_21.xml";
             string outputFile = @"..\..\OutputXML\TestDeserializeAplicationResponse.xml";
             DeserializeGeneric<ApplicationResponseType>(inputUBLfile, outputFile);

         }

         private void DeserializeGeneric<T>(string inputUBLfile, string outputFile) 
         {
             
             string contentUBL = File.ReadAllText(inputUBLfile);
             
             dynamic retvalue = null;

             try
             {
                 retvalue = Assert.XmlDeserialize<T>(contentUBL);
             }
             catch (Exception e)
             {

                 throw e;
             }

             var document = RemoveEmptyNodes(retvalue.Serialize());
             document.Save(outputFile);

             //Not possible to set others XmlDiffOptions
             //Assert.Xml.AreEqual(contentUBL, document.ToString(), XmlOptions.Loose);

             XmlDiff xmldiff = new XmlDiff(XmlDiffOptions.IgnoreChildOrder |
                                           XmlDiffOptions.IgnorePrefixes | XmlDiffOptions.IgnoreNamespaces |
                                            XmlDiffOptions.IgnoreXmlDecl);

             StringBuilder output = new StringBuilder();
             XmlWriter diffgramWriter = XmlWriter.Create(output);

             bool bIdentical = xmldiff.Compare(inputUBLfile, outputFile, true, diffgramWriter);

             diffgramWriter.Close();

             if (bIdentical)
                 Assert.IsTrue(bIdentical, "XML Deserialized comparison: {0}", output);
             else
                 Assert.Fail("XML Deserialized NOT EQUAL! Below comparison details:\n\n {0}", output);

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


         private XDocument RemoveEmptyNodes(string inputXML )
         {
             var document = XDocument.Parse(inputXML);
             document.Descendants()
                     .Where(e => e.IsEmpty || String.IsNullOrWhiteSpace(e.Value))
                     .Remove();

             return document;
             

         }

    }
}
