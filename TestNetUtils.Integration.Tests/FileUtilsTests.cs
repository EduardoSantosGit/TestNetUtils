using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestNetUtils.Integration.Tests
{
    [Trait("Integration Tests", "FileUtilsTests")]
    public class FileUtilsTests
    {

        [Fact(DisplayName = "OpenText Name File Return String file")]
        public void OpenText_WhenNameFile_ReturnsStringFile()
        {
            //arrange
            var name = "NameFile.txt";

            var file = FileUtils.OpenText(name);

            Assert.NotNull(file);
        }

    }
}
