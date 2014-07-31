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

        private XmlDiff xmldiff = new XmlDiff(XmlDiffOptions.IgnoreChildOrder |
                              XmlDiffOptions.IgnorePrefixes | XmlDiffOptions.IgnoreNamespaces |
                               XmlDiffOptions.IgnoreXmlDecl);
        [Test]
        private void Test_InvoiceType()
        {
            string inputUBLfile = @"..\..\InputXML\UBL-Invoice-2.1-Example.xml";
             
             string outputFile = @"..\..\OutputXML\TestDeserialize_Invoice.xml";
            //You can set different xml diff options 
            DeserializeGeneric<InvoiceType>(inputUBLfile, outputFile, xmldiff);

        }

        
         [Test]
         private void Test_UtilityStatement()
         {
             string inputUBLfile = @"..\..\InputXML\UtilityStatement_UBL_21.xml";
             string outputFile = @"..\..\OutputXML\TestDeserialize_UtilityStatement.xml";
             //You can set different xml diff options
             DeserializeGeneric<UtilityStatementType>(inputUBLfile, outputFile, xmldiff);

         }

         [Test]
         private void Test_ApplicationResponse()
         {
             string inputUBLfile = @"..\..\InputXML\ApplicationResponse_UBL_21.xml";
             string outputFile = @"..\..\OutputXML\TestDeserializeAplicationResponse.xml";
             //You can set different xml diff options
             DeserializeGeneric<ApplicationResponseType>(inputUBLfile, outputFile, xmldiff);

         }

         private void DeserializeGeneric<T>(string inputUBLfile, string outputFile, XmlDiff xmldiff) 
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

             

             StringBuilder output = new StringBuilder();
             XmlWriter diffgramWriter = XmlWriter.Create(output);

             bool bIdentical = xmldiff.Compare(inputUBLfile, outputFile, true, diffgramWriter);

             diffgramWriter.Close();



             //********* realizzazione report html in cartella di Output con evidenze visive colorate

             string diffFile = @"..\..\OutputXML\" + Guid.NewGuid() + ".out";
             XmlTextWriter twriter = new XmlTextWriter(new StreamWriter(diffFile));
             twriter.Formatting = Formatting.Indented;

             bool bIdentical2 = xmldiff.Compare(inputUBLfile, outputFile, true, twriter);
             twriter.Close();

             string statusreport= (bIdentical.Equals(true)) ? "Identical Xml Files" : "Different Xml Files";

             //Different files: XmlDiffView.
             XmlDiffView diffview = new XmlDiffView();

             //Load the original file again and the diff file.
             XmlTextReader originFile = new XmlTextReader(inputUBLfile);
             XmlTextReader diffGram = new XmlTextReader(diffFile);
             diffview.Load(originFile, diffGram);

             //Wrap HTML file

             string tempFile = @"..\..\OutputXML\" +"diff_" + Guid.NewGuid() + ".htm";
             StreamWriter swriter = new StreamWriter(tempFile);


             swriter.Write("<html><body><table width='100%'>");
             // Legend.
             swriter.Write("<tr><td colspan='2' align='center'><h1>XML Comparison Report: "+statusreport+"</h1><\br/><b>Legend:</b> <font style='background-color: yellow'" +
                 " color='black'>added</font>&nbsp;&nbsp;<font style='background-color: red'" +
                 " color='black'>removed</font>&nbsp;&nbsp;<font style='background-color: " +
                 "lightgreen' color='black'>changed</font>&nbsp;&nbsp;" +
                 "<font style='background-color: red' color='blue'>moved from</font>" +
                 "&nbsp;&nbsp;<font style='background-color: yellow' color='blue'>moved to" +
                 "</font>&nbsp;&nbsp;<font style='background-color: white' color='#AAAAAA'>" +
                 "ignored</font></td></tr>");


             swriter.Write("<tr><td><b> File Name : ");
             swriter.Write(inputUBLfile);
             swriter.Write("</b></td><td><b> File Name : ");
             swriter.Write(outputFile);
             swriter.Write("</b></td></tr>");

             //Difference in HTML table
             diffview.GetHtml(swriter);

             //conmplete file HTML
             swriter.Write("</table></body></html>");

             swriter.Close();
             diffview = null;
             originFile.Close();
             diffGram.Close();
             File.Delete(diffFile);

             if (bIdentical)
             {
                 Console.WriteLine(String.Format("Identical XML File \n\n Src file: {0} \n Trgt file: {1}",inputUBLfile,outputFile));
                 Assert.IsTrue(bIdentical, "XML Deserialized comparison: {0}", output);
             }
             else
             {
                 Console.WriteLine("HTML report difference: " + tempFile);
                 Assert.Fail("XML Deserialized NOT EQUAL! Below comparison details:\n\n {0}", output);
             }
                         
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
