using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.Structures;
// <copyright file="ImageBaseRelocationsParserTest.cs">Copyright ©  2016</copyright>

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageBaseRelocationsParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageBaseRelocationsParserTest
    {
        [PexMethod]
        internal ImageBaseRelocationsParser Constructor(
            byte[] buff,
            uint offset,
            uint directorySize,
            IMAGE_SECTION_HEADER[] sectionHeaders
            )
        {
            var target
                = new ImageBaseRelocationsParser(buff, offset, directorySize, sectionHeaders);
            return target;
            // TODO: add assertions to method ImageBaseRelocationsParserTest.Constructor(Byte[], UInt32, UInt32, IMAGE_SECTION_HEADER[])
        }
    }
}