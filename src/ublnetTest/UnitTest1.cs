using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using MbUnit.Framework;

namespace ublnetTest
{
    
     [TestFixture] 
    public class Validation
    {
       
        [Test] 
        public void SuccessTest() 
        { 
        int expected = 0; 
        int actual = 0; 
        Assert.AreEqual(expected, actual); 
        } 


        [Test] 
        public void FailureTest() 
        { 
        int expected = 0; 
        int actual = 1; 
        Assert.AreEqual(expected, actual); 
        } 
}
 }
