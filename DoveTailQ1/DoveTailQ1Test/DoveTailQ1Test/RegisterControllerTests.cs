namespace DoveTailQ1Test
{
    using DoveTailQ1.Controllers;
    using DoveTailQ1.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Moq;
    using Xunit;
   public class RegisterControllerTests
    {
        private readonly RegisterController _controller;
        public RegisterControllerTests()
        {
            _controller = new RegisterController();
        }
        [Fact]
        public void Index_ActionExecutes_ReturnsViewForIndex()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Create_ActionExecutes_ReturnsViewForIndex()
        {
            var mockTempData = new Mock<ITempDataDictionary>();
            _controller.TempData = mockTempData.Object;
            var registerViewModel = new RegisterViewModel() {  FirstName="Deepak", LastName="Kumar", PhoneNumber="9971368561"};
            var result = _controller.Create(registerViewModel);
            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
