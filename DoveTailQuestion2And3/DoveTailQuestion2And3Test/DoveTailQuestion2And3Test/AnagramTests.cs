namespace DoveTailQuestion2And3Test
{
    using DoveTailQuestion2And3.Utilities;
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class AnagramTests
    {
        Anagram objAnagram = new Anagram();

        [Fact]
        public void CheckAnagram_Should_Return_False_When_Both_Params_Are_Null()
        {
            var result = objAnagram.CheckAnagram(null, null);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_False_When_Anyone_Params_Is_Null()
        {
            var result = objAnagram.CheckAnagram(string.Empty, null);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_False_When_Both_Params_Are_Empty()
        {
            var result = objAnagram.CheckAnagram(string.Empty, string.Empty);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_True_When_Both_Params_Are_Anagram()
        {
            var result = objAnagram.CheckAnagram("recall", "caller");
            result.Should().BeTrue();
        }
        [Fact]
        public void CheckAnagram_Should_Return_True_When_Both_Params_Are_Not_Anagram()
        {
            var result = objAnagram.CheckAnagram("recall", "Test");
            result.Should().BeFalse();
        }
    }
}
