using System;
using Xunit;

namespace Functions.Tests
{
    public class TestSin
    {
        [Fact]
        public void Test(){
            Assert.Equal(0.0, Functions.sin(0.0));
        }
    }
}
