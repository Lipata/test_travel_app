using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app.Shared;

namespace TestTravel_app
{
	public class TestInApp
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule));
			var componentUnderTest = ctx.RenderComponent<InApp>();
			Assert.NotNull(componentUnderTest);
		}
	}
}