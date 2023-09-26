using System.Threading.Tasks;
using TCGPlayer.Net.IntegrationTests.Fixture;
using TCGPlayer.Net.Models;
using Xunit;

namespace TCGPlayer.Net.IntegrationTests
{
    public class ApiTests : IClassFixture<ApiServiceFixture>
    {
        // will be refactored in future release //

        readonly ApiServiceFixture ApiServiceFixture;

        public ApiTests(ApiServiceFixture fixture)
        {
            ApiServiceFixture = fixture;
        }


        [Fact]
        public async Task Should_List_All_Categories()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoriesGETRequestParams();
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategories, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Category_Details()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetCategoryDetailsGETRequestParams
            {
                CategoryIds = new string[] { "1", "24" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetCategoryDetails, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Category_Search_Manifest()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetCategorySearchManifestGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetCategorySearchManifest, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Search_Category_Products()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new SearchCategoryProductsPOSTRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.SearchCategoryProducts, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Groups()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryGroupsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryGroups, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Rarities()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryRaritiesGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryRarities, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Printings()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryPrintingsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryPrintings, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Conditions()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryConditionsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryConditions, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Languages()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryLanguagesGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryLanguages, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Category_Media()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllCategoryMediaGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllCategoryMedia, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Groups_Details()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllGroupsDetailsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllGroupsDetails, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Group_Details()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetGroupDetailsGETRequestParams
            {
                GroupIds = new string[] { "2714", "2717" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetGroupDetails, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Group_Media()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllGroupMediaGETRequestParams
            {
                GroupId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllGroupMedia, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Products()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllProductsGETRequestParams
            {
                CategoryId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllProducts, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Product_Details()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetProductDetailsGETRequestParams
            {
                ProductIds = new string[] { "87", "94" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetProductDetails, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Product_Details_By_GTIN()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetProductDetailsByGTINGETRequestParams
            {
                Gtin = "889698355100"
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetProductDetailsByGTIN, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Product_SKUs()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListProductSKUsGETRequestParams
            {
                ProductId = 152944
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListProductSKUs, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Related_Products()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListRelatedProductsGETRequestParams
            {
                ProductId = 15230
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListRelatedProducts, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_All_Product_Media_Types()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListAllProductMediaTypesGETRequestParams
            {
                ProductId = 126022
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListAllProductMediaTypes, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_SKU_Details()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetSKUdetailsGETRequestParams
            {
                SkuIds = new string[] { "2999708", "255924" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.GetSKUdetails, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Conditions()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new EmptyParameters();
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Catalog.ListConditions, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_Get_Market_Price_by_SKU()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new GetMarketPricebySKUGETRequestParams
            {
                ProductConditionId = 2999708
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.GetMarketPricebySKU, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Product_Prices_by_Group()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListProductPricesbyGroupGETRequestParams
            {
                GroupId = 2324
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListProductPricesbyGroup, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Product_Market_Prices()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListProductMarketPricesGETRequestParams
            {
                ProductIds = new string[] { "127425", "127428" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListProductMarketPrices, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_SKU_Market_Prices()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListSKUMarketPricesGETRequestParams
            {
                SkuIds = new string[] { "2883545", "1260372" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListSKUMarketPrices, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Product_Buylist_Prices()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListProductBuylistPricesGETRequestParams
            {
                ProductIds = new string[] { "83143", "6775", "15024", "7121" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListProductBuylistPrices, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_SKU_Buylist_Prices()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListSKUBuylistPricesGETRequestParams
            {
                SkuIds = new string[] { "382537", "382827" }
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListSKUBuylistPrices, @params);

            Assert.True(result.Success);
        }

        [Fact]
        public async Task Should_List_Product_Buylist_Prices_by_Group()
        {
            await ApiServiceFixture.CreateApiServiceAsync();

            var @params = new ListProductBuylistPricesbyGroupGETRequestParams
            {
                GroupId = 1
            };
            var result = await ApiServiceFixture._apiService.Execute(TcgApiUrls.Pricing.ListProductBuylistPricesbyGroup, @params);

            Assert.True(result.Success);
        }




    }
}
