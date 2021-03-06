﻿using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace Microsoft.Azure.CosmosRepositoryTests.Extensions
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddCosmosRepositoryThrowsWithNullServiceCollection() =>
            Assert.Throws<ArgumentNullException>(
                () => (null as IServiceCollection).AddCosmosRepository(
                    new Mock<IConfiguration>().Object));

        [Fact]
        public void AddCosmosRepositoryThrowsWithNullConfiguration() =>
            Assert.Throws<ArgumentNullException>(
                () => new Mock<IServiceCollection>().Object.AddCosmosRepository(null));


    }
}