namespace DoveTailQuestion2And3Test
{
    using DoveTailQuestion2And3.Utilities;
    using FluentAssertions;
    using Xunit;
    public class TempTrackerTest
    {
        [Fact]
        public void InsertTemprature_Should_Return_Empty_Array_When_Input_Params_Is_Null()
        {
            var result = TempTracker.InsertTemprature(null);
            result.Should().BeEmpty();
        }
        [Fact]
        public void InsertTemprature_Should_Return_Array_When_Input_Params_Is_Comma_SeparatedNumber()
        {
            var result = TempTracker.InsertTemprature("10,15,12,13,14,41");
            result.Should().NotBeEmpty();
        }
        [Fact]
        public void InsertTemprature_Should_Return_Array_When_Input_Params_Is_Not_Comma_SeparatedNumber()
        {
            var result = TempTracker.InsertTemprature("10,$,10,13,14,41");
            result.Should().BeEmpty();
        }
        [Fact]
        public void GetMinimumTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = TempTracker.GetMinimumTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMinimumTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            var temp = new int[] { };
            var result = TempTracker.GetMinimumTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMinimumTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            var temp = new int[] { 10, 15, 12, 30, 20 };
            var result = TempTracker.GetMinimumTemprature(temp);
            result.Should().Be(10);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = TempTracker.GetMaximumTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            var temp = new int[] { };
            var result = TempTracker.GetMaximumTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            var temp = new int[] { 10, 15, 12, 30, 20 };
            var result = TempTracker.GetMaximumTemprature(temp);
            result.Should().Be(30);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = TempTracker.GetMeanTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            var temp = new int[]{ };
            var result = TempTracker.GetMeanTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            var temp = new int[] { 10, 15, 12, 30, 20 };
            var result = TempTracker.GetMeanTemprature(temp);
            result.Should().BeGreaterThan(17);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = TempTracker.GetModeTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            var temp = new int[] { };
            var result = TempTracker.GetModeTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            var temp = new int[] { 10, 15, 12, 30, 20, 12, 11 };
            var result = TempTracker.GetModeTemprature(temp);
            result.Should().Be(12);
        }
    }
}
