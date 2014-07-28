using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Ubl.v21;
using Gallio;
using MbUnit.Framework;
using System.IO;
using System.Xml.Linq;

namespace TestDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //InvoiceTypeTesting();
                //UtilityStatementTesting();
                ApplicationResponseTesting();
    

            }
            catch (Exception e)
            {
                
                throw e;
            }


        }

        private static void InvoiceTypeTesting()
        {
            string pathXmlUBL = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\spec\xml\UBL-Invoice-2.1-Example.xml";

            string contentUBL = File.ReadAllText(pathXmlUBL);

            var retvalue = InvoiceType.Deserialize(contentUBL);

            string pathTestFile = @"D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserializeInvoice.xml";

            retvalue.SaveToFile(pathTestFile);

            string DesSerFile = File.ReadAllText(pathTestFile);

            //checkFile

            //XElement x1 = XElement.Parse(contentUBL);
            //XElement x2 = XElement.Parse(DesSerFile);

            //    XNode xnn1=x1.AncestorsAndSelf().First();
            //    XNode xnn2 = x2.AncestorsAndSelf().First();

            //    bool res = XNode.DeepEquals(xnn1, xnn2);




            //Assert.Xml.AreEqual(contentUBL, DesSerFile);

            // Assert.AreEqual("34", retvalue.ID.ToString());
        }
    
   
        private static void UtilityStatementTesting()
        {
            string pathXmlUBL = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\src\TestDeserialize\UtilityStatement_UBL_21.xml";

            string contentUBL = File.ReadAllText(pathXmlUBL);

            var retvalue = UtilityStatementType.Deserialize(contentUBL);

            string pathTestFile = @"D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserializeUtilityStatement.xml";

            retvalue.SaveToFile(pathTestFile);  
                
        }
        
        private static void ApplicationResponseTesting()
        {
            string pathXmlUBL = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\src\TestDeserialize\ApplicationResponse_UBL_21.xml";

            string contentUBL = File.ReadAllText(pathXmlUBL);

            var retvalue = ApplicationResponseType.Deserialize(contentUBL);

            string pathTestFile = @"D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserializeAplicationResponse.xml";

            retvalue.SaveToFile(pathTestFile);  

        }

  }
}

