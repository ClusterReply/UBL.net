using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Ubl.v21;
using Gallio;
using MbUnit.Framework;
using System.IO;

namespace TestDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pathxml21 = @"D:\Users\d.verardi.REPLYNET\Documents\GitHub\DanyHubGitRep\UBL.net\spec\xml\UBL-Invoice-2.1-Example.xml";
            
            string content = File.ReadAllText(pathxml21);

            //var retvalue = OrderType.LoadFromFile(pathxml21);

            //Assert.IsNotNull(retvalue);

            InvoiceType test1 = new InvoiceType();
            InvoiceLineType invc1 = new InvoiceLineType();
            OrderLineReferenceType ord = new OrderLineReferenceType();
              
                                      
            //test1.IssueDate.Value = Convert.ToDateTime("2014-06-10");

            //test1.SaveToFile("D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\test1.xml");

            


            var retvalue = InvoiceType.Deserialize(content);

           // Assert.AreEqual("34", retvalue.ID.ToString());

            retvalue.SaveToFile(@"D:\\Users\\d.verardi.REPLYNET\\Desktop\\TestDeserialize\\TestDeserializeInvoice.xml");


            }
            catch (Exception e)
            {
                
                throw e;
            }


        }
    }
}
