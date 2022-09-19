using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app.PagesHome;

namespace TestTravel_app
{
	public class TestResetPassword
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<ResetPassword>();
			Assert.NotNull(componentUnderTest);
		}
	}
}