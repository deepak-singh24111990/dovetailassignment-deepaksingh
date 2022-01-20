namespace DoveTailQuestion2And3Test
{
    using DoveTailQuestion2And3.Utilities;
    using FluentAssertions;
    using Xunit;
    public class AnagramTests
    {
        [Fact]
        public void CheckAnagram_Should_Return_False_When_Both_Params_Are_Null()
        {
            var result = Anagram.CheckForAnagram(null, null);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_False_When_Anyone_Params_Is_Null()
        {
            var result = Anagram.CheckForAnagram(string.Empty, null);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_False_When_Both_Params_Are_Empty()
        {
            var result = Anagram.CheckForAnagram(string.Empty, string.Empty);
            result.Should().BeFalse();
        }
        [Fact]
        public void CheckAnagram_Should_Return_True_When_Both_Params_Are_Anagram()
        {
            var result = Anagram.CheckForAnagram("recall", "caller");
            result.Should().BeTrue();
        }
        [Fact]
        public void CheckAnagram_Should_Return_True_When_Both_Params_Are_Not_Anagram()
        {
            var result = Anagram.CheckForAnagram("recall", "Test");
            result.Should().BeFalse();
        }
    }
}
