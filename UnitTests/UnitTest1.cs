using System;
using Xunit;
using UnityProject;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new Microwave();

            Assert.False(x.IsDoorOpen, "Asserting the door is closed by default");
            Assert.False(x.IsLightOn, "Asserting the light is off by default");
        }
    }
}
