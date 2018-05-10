﻿using System;
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

        [Fact(DisplayName = "OpenText Path file Return String file")]
        public void OpenText_WhenPathFile_ReturnsStringFile()
        {
            //arrange
            var name = @"../Files/teste.txt";

            var file = FileUtils.OpenText(name);

            Assert.NotNull(file);
        }

        [Fact(DisplayName = "OpenText Path file not exists Return null")]
        public void OpenText_WhenPathFile_ReturnsNull()
        {
            //arrange
            var name = @"../Files/teste1.txt";

            var file = FileUtils.OpenText(name);

            Assert.Null(file);
        }

        [Fact(DisplayName = "OpenText name file not exists Return null")]
        public void OpenText_WhenNameFile_ReturnsNull()
        {
            //arrange
            var name = "teste14.txt";

            var file = FileUtils.OpenText(name);

            Assert.Null(file);
        }

        [Fact(DisplayName = "OpenText name file exist Return file string correct")]
        public void OpenText_WhenNameFile_ReturnsStringFileCorrect()
        {
            //arrange
            var name = "teste14.txt";

            var file = FileUtils.OpenText(name);

            Assert.Equal("Test File exists name correct", file.ReadToEnd());
        }

    }
}
