namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnTicketBookningResultWithRequestValues()
        {
            // Arrange
            var processor = new TicketBookingRequestProcessor();

            var request = new TicketBookingRequest
            {
                FirstName = "Nevena",
                LastName = "Kicanovic",
                Email = "nevena@gmail.com"
            };

            // Act
            TicketBookingResponse response = processor.Book(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(request.FirstName, response.FirstName);
            Assert.Equal(request.LastName, response.LastName);
            Assert.Equal(request.Email, response.Email);
        }
    }
}