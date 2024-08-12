using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParenthisChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthisChecker.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ParenthesisCheckerTests
{
    [TestMethod]
    public void TestSingleTypeBrackets()
    {
        Assert.IsTrue(ParenthesisChecker.IsBalanced("()"));
        Assert.IsFalse(ParenthesisChecker.IsBalanced("("));
    }

    [TestMethod]
    public void TestMixedTypeBrackets()
    {
        Assert.IsTrue(ParenthesisChecker.IsBalanced("{[()]}"));
        Assert.IsFalse(ParenthesisChecker.IsBalanced("{[(])}"));
    }

    [TestMethod]
    public void TestBalancedScenarios()
    {
        Assert.IsTrue(ParenthesisChecker.IsBalanced("a(b)c[d]{e}"));
        Assert.IsTrue(ParenthesisChecker.IsBalanced("a + b - (c * d / {e + f})"));
    }

    [TestMethod]
    public void TestUnbalancedScenarios()
    {
        Assert.IsFalse(ParenthesisChecker.IsBalanced("a(b]c[d}e"));
        Assert.IsFalse(ParenthesisChecker.IsBalanced("({[)]}"));
    }

    [TestMethod]
    public void TestEmptyString()
    {
        Assert.IsTrue(ParenthesisChecker.IsBalanced(""));
    }
}
