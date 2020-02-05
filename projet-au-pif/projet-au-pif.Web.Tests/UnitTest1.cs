using System;
using Xunit;

namespace projet_au_pif.Web.Tests
{
    public class BasicTests
    {
        [Fact]
        public void This_Test_Is_Absolutely_Right()
        {
            Assert.True(true);
        }

        [Fact]
        public void This_Test_Is_Absolutely_Wrong()
        {
            Assert.False(false);
        }
    }
}
