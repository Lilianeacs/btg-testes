﻿using btg_testes_auto.Notification;
using FluentAssertions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace btg_test.NotificationEmailTest
{
    public class NotificationServiceTest
    {
        private readonly IEmailService _mockEmailService;
        private NotificationService _service; 

        public NotificationServiceTest()
        {
            _mockEmailService = Substitute.For<IEmailService>();
            _service = new(_mockEmailService);
        }

        [Fact]
        public void SendNotification_MessageNull_ReturnFalse()
        {
            //Arrange
            string recipient = "email@email.com";
            string message = null;

            //Act
            bool result = _service.SendNotification(recipient, message);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void SendNotification_MessageEmpty_ReturnFalse()
        {
            //Arrange
            string recipient = "email@email.com";
            string message = " ";

            //Act
            bool result = _service.SendNotification(recipient, message);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void SendNotification_SendEmail_ReturnTrue()
        {
            //Arrange
            string recipient = "email@email.com";
            string message = "message";

            _mockEmailService.SendEmail(recipient, "Notification", message)
                .Returns(true);

            //Act
            bool result = _service.SendNotification(recipient, message);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void SendNotification_SendEmail_ReturFalse()
        {
            //Arrange
            string recipient = "email@email.com";
            string message = "message";

            _mockEmailService.SendEmail(recipient, "Notification", message)
                .Returns(false);

            //Act
            bool result = _service.SendNotification(recipient, message);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void SendNotification_Exception_ReturnFalse()
        {
            //Arrange
            string recipient = "email@email.com";
            string message = "message";

            _mockEmailService.SendEmail(recipient, "Notification", message)
                .Throws(new Exception());

            //Act
            bool result = _service.SendNotification(recipient, message);

            //Assert
            result.Should().BeFalse();
        }

    }
}
