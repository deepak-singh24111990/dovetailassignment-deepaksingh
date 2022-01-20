namespace DoveTailQuestion2And3Test
{
    using DoveTailQuestion2And3.Utilities;
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;


    public class TempTrackerTest
    {
        TempTracker objAnagram = new TempTracker();

        [Fact]
        public void InsertTemprature_Should_Return_Empty_Array_When_Input_Params_Is_Null()
        {
            var result = objAnagram.InsertTemprature(null);
            result.Should().BeEmpty();
        }
        [Fact]
        public void InsertTemprature_Should_Return_Array_When_Input_Params_Is_Comma_SeparatedNumber()
        {
            var result = objAnagram.InsertTemprature("10,15,12,13,14,41");
            result.Should().NotBeEmpty();
        }
        [Fact]
        public void InsertTemprature_Should_Return_Array_When_Input_Params_Is_Not_Comma_SeparatedNumber()
        {
            var result = objAnagram.InsertTemprature("10,$,10,13,14,41");
            result.Should().BeEmpty();
        }

        [Fact]
        public void GetMinimumTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = objAnagram.GetMinimumTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMinimumTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            int[] temp = { };
            var result = objAnagram.GetMinimumTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMinimumTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            int[] temp = { 10, 15, 12, 30, 20 };
            var result = objAnagram.GetMinimumTemprature(temp);
            result.Should().Be(10);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = objAnagram.GetMaximumTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            int[] temp = { };
            var result = objAnagram.GetMaximumTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMaximumTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            int[] temp = { 10, 15, 12, 30, 20 };
            var result = objAnagram.GetMaximumTemprature(temp);
            result.Should().Be(30);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = objAnagram.GetMeanTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            int[] temp = { };
            var result = objAnagram.GetMeanTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetMeanTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            int[] temp = { 10, 15, 12, 30, 20 };
            var result = objAnagram.GetMeanTemprature(temp);
            result.Should().Be(17);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Zero_When_Input_Params_Is_Null()
        {
            var result = objAnagram.GetModeTemprature(null);
            result.Should().Be(0);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Zero_When_Array_Is_Empty()
        {
            int[] temp = { };
            var result = objAnagram.GetModeTemprature(temp);
            result.Should().Be(0);
        }
        [Fact]
        public void GetModeTemprature_Should_Return_Minumum_When_Array_Is_Not_Empty()
        {
            int[] temp = { 10, 15, 12, 30, 20, 12, 11 };
            var result = objAnagram.GetModeTemprature(temp);
            result.Should().Be(12);
        }
    }
}
