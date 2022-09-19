using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Travel_app.PagesIn_App;
using Travel_app.TravelAppData;

namespace TestTravel_app
{
	public class TestArticles
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new TravelAppDataService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Articles>();
			Assert.NotNull(componentUnderTest);
		}
	}
}