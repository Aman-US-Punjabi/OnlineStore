using System;
using OnlineStore.Core.Entities.EntityValidations;
using Xunit;

namespace OnlineStore.Core.Tests
{
    public class DateInFutureAttributeTests
    {
        public DateInFutureAttributeTests()
        {
        }

        [Theory]
        [InlineData(100, true)]
        [InlineData(-100, false)]
        public void DateValidator_InputexpectedDateRange_DateValidity(int addTime, bool expectedResult)
        {
            DateInFutureAttribute dateInFutureAttribute = new(() => DateTime.Now);

            var result = dateInFutureAttribute.IsValid(DateTime.Now.AddSeconds(addTime));

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DateValidator_NotValidDate_ReturnErrorMessage()
        {
            var result = new DateInFutureAttribute();

            Assert.Equal("Date must be in the future", result.ErrorMessage);
        }
    }
}
