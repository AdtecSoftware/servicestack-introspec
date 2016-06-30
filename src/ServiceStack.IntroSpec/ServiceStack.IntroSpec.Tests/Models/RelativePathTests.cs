﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this 
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

namespace ServiceStack.IntroSpec.Tests.Models
{
    using FluentAssertions;
    using IntroSpec.Models;
    using Xunit;

    public class RelativePathTests
    {
        [Fact]
        public void ImplicitFromStringCast_SetsPath()
        {
            const string path = "/api/foo";

            RelativePath relativePath = path;
            relativePath.Path.Should().Be(path);
        }

        [Fact]
        public void ImplicitToStringCast_ReturnsPath()
        {
            const string path = "/api/foo";

            var relativePath = new RelativePath { Path = path };
            string actual = relativePath;

            actual.Should().Be(path);
        }
    }
}