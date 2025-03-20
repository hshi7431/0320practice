using System.Security.Cryptography;
using NUnit.Framework;
using UnityEngine;

public class CsharpPracticeTests
{
    [Test(Description = "兩個數字相加的驗證")]
    [TestCase(2, 2, 4)]
    [TestCase(3, 3, 6)]
    [TestCase(4, 4, 8)]
    [TestCase(-4, 6, 2, Description = "負數加正數")]

public void Add_Two_Number(int a, int b, int expected)
    {
        CsharpPractice csharpPracticeTests = new CsharpPractice();

        int result = csharpPracticeTests.Add(a, b);
        
        Assert.AreEqual( expected, actual: result);
    }
}
