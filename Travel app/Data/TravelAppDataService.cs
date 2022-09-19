using System.Net.Http.Json;

namespace Travel_app.TravelAppData
{
    public class TravelAppDataService
    {
        private readonly HttpClient http;

        public TravelAppDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<SelectedArticlesType[]?> GetSelectedArticles()
        {
            return await http.GetFromJsonAsync<SelectedArticlesType[]>("/static-data/travel-app-data-selected-articles.json");
        }

        public async Task<DestinationsType[]?> GetDestinations()
        {
            return await http.GetFromJsonAsync<DestinationsType[]>("/static-data/travel-app-data-destinations.json");
        }

        public async Task<ImageSet1Type[]?> GetImageSet1()
        {
            return await http.GetFromJsonAsync<ImageSet1Type[]>("/static-data/travel-app-data-image-set-1.json");
        }

        public async Task<ImageSet2Type[]?> GetImageSet2()
        {
            return await http.GetFromJsonAsync<ImageSet2Type[]>("/static-data/travel-app-data-image-set-2.json");
        }

        public async Task<ArticlesSource1Type[]?> GetArticlesSource1()
        {
            return await http.GetFromJsonAsync<ArticlesSource1Type[]>("/static-data/travel-app-data-articles-source-1.json");
        }

        public async Task<ArticlesSource2Type[]?> GetArticlesSource2()
        {
            return await http.GetFromJsonAsync<ArticlesSource2Type[]>("/static-data/travel-app-data-articles-source-2.json");
        }

        public async Task<ArticlesSource3Type[]?> GetArticlesSource3()
        {
            return await http.GetFromJsonAsync<ArticlesSource3Type[]>("/static-data/travel-app-data-articles-source-3.json");
        }

        public async Task<ArticlesSource4Type[]?> GetArticlesSource4()
        {
            return await http.GetFromJsonAsync<ArticlesSource4Type[]>("/static-data/travel-app-data-articles-source-4.json");
        }
    }
}