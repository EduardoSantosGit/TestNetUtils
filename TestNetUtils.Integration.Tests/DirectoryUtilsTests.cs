using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestNetUtils.Integration.Tests
{
    [Trait("Integration Tests", "DirectoryUtilsTests")]
    public class DirectoryUtilsTests
    {

        [Fact(DisplayName = "Send Name directory Returns Path Directory")]
        public void CreateDirectory_WhenNameFile_ReturnsPathDirectory()
        {
            
        }

        [Fact(DisplayName = "Remove directory with name ok")]
        public void RemoveDirectory_SendNameDirectory_DirectoryRemoved()
        {
            
        }

        [Fact(DisplayName = "Clear Directory All Files ok")]
        public void ClearDirectory_SendNameDirectory_ClearAllItemsDirectory()
        {
            
        }

        [Fact(DisplayName = "Create SubDirectory with name and subname return path ok")]
        public void CreateSubDirectory_SendNameDirectories_ReturnsPathComplete()
        {
            
        }

         [Fact(DisplayName = "MoveDirectory with name and new name path Return new Path")]
        public void MoveDirectory_SendNameAndNewNamePath_ReturnsNewPathComplete()
        {
            
        }

        [Fact(DisplayName = "AllItemsDirectory with name Returns All Items Directory")]
        public void AllItemsDirectory_SendNameDirectory_ReturnsAllItemsDirectory()
        {
            
        } 

        [Fact(DisplayName = "ListAllDirectory with name Returns All SubDirectories")]
        public void ListAllDirectory_SendNameDirectory_ReturnsAllDirectories()
        {
            
        } 

        [Fact(DisplayName = "DirectoryExists with name Returns Bool exists true")]
        public void DirectoryExists_SendNameDirectory_ReturnsExistsTrue()
        {
            
        } 

        [Fact(DisplayName = "CountDirectory with name Returns int count directories")]
        public void CountDirectory_SendNameDirectory_ReturnsCountSubDirectories()
        {
            
        } 
    }    
}