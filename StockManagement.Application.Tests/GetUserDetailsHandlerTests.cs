using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using StockManagement.Applications.Queries.GetUserDetails;
using StockManagement.Models;
using StockManagement.Repositories;

namespace StockManagement.Application.Tests
{
    public class GetUserDetailsHandlerTests
    {
        private readonly Mock<IUserRepository> userRepositoryMock;        
        public GetUserDetailsHandlerTests()
        {
            userRepositoryMock = new Mock<IUserRepository>();
        }
        [Fact]
        public async Task Handle_Always_ReturnsUserDetails()
        {
            // Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            var query = new GetUserDetailsQuery() { IsActive = true };
            var userDetails = Fakers.UserDetail.Generate(10);
            userRepositoryMock.Setup(x => x.GetUserDetails(query.IsActive.Value))
            .Returns(Task.FromResult(userDetails));

            //Act
            var handler = new GetUserDetailsHandler(userRepositoryMock.Object);
            var result = await handler.Handle(query, CancellationToken.None);

            //Assert
            userRepositoryMock
                .Verify(r => r.GetUserDetails(query.IsActive.Value), Times.Once);

            result.Should().NotBeNull();
        }
    }
}