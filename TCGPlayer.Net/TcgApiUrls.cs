using System.Collections.Generic;
using TCGPlayer.Net.Dtos;
using TCGPlayer.Net.Models;

namespace TCGPlayer.Net
{
    public partial class TcgApiUrls
    {
        /// <summary>
        /// Catalog
        /// </summary>
        public static partial class Catalog
        {
            public static ApiActionAttributes<ListAllCategoriesGETRequestParams, List<CategoryDto>> ListAllCategories = new ApiActionAttributes<ListAllCategoriesGETRequestParams, List<CategoryDto>>("catalog/categories", HttpMethods.GET);
            public static ApiActionAttributes<GetCategoryDetailsGETRequestParams, List<CategoryDto>> GetCategoryDetails = new ApiActionAttributes<GetCategoryDetailsGETRequestParams, List<CategoryDto>>("catalog/categories/{categoryIds}", HttpMethods.GET);
            public static ApiActionAttributes<GetCategorySearchManifestGETRequestParams, List<CategorySearchManifestDto>> GetCategorySearchManifest = new ApiActionAttributes<GetCategorySearchManifestGETRequestParams, List<CategorySearchManifestDto>>("catalog/categories/{categoryId}/search/manifest", HttpMethods.GET);
            public static ApiActionAttributes<SearchCategoryProductsPOSTRequestParams, List<int>> SearchCategoryProducts = new ApiActionAttributes<SearchCategoryProductsPOSTRequestParams, List<int>>("catalog/categories/{categoryId}/search", HttpMethods.POST);
            public static ApiActionAttributes<ListAllCategoryGroupsGETRequestParams, List<CategoryGroupDto>> ListAllCategoryGroups = new ApiActionAttributes<ListAllCategoryGroupsGETRequestParams, List<CategoryGroupDto>>("catalog/categories/{categoryId}/groups", HttpMethods.GET);
            public static ApiActionAttributes<ListAllCategoryRaritiesGETRequestParams, List<CategoryRaritiesDto>> ListAllCategoryRarities = new ApiActionAttributes<ListAllCategoryRaritiesGETRequestParams, List<CategoryRaritiesDto>>("catalog/categories/{categoryId}/rarities", HttpMethods.GET);
            public static ApiActionAttributes<ListAllCategoryPrintingsGETRequestParams, List<CategoryPrintingDto>> ListAllCategoryPrintings = new ApiActionAttributes<ListAllCategoryPrintingsGETRequestParams, List<CategoryPrintingDto>>("catalog/categories/{categoryId}/printings", HttpMethods.GET);
            public static ApiActionAttributes<ListAllCategoryConditionsGETRequestParams, List<CategoryConditionDto>> ListAllCategoryConditions = new ApiActionAttributes<ListAllCategoryConditionsGETRequestParams, List<CategoryConditionDto>>("catalog/categories/{categoryId}/conditions", HttpMethods.GET);
            public static ApiActionAttributes<ListAllCategoryLanguagesGETRequestParams, List<CategoryLanguageDto>> ListAllCategoryLanguages = new ApiActionAttributes<ListAllCategoryLanguagesGETRequestParams, List<CategoryLanguageDto>>("catalog/categories/{categoryId}/languages", HttpMethods.GET);
            public static ApiActionAttributes<ListAllCategoryMediaGETRequestParams, List<CategoryMediaDto>> ListAllCategoryMedia = new ApiActionAttributes<ListAllCategoryMediaGETRequestParams, List<CategoryMediaDto>>("catalog/categories/{categoryId}/media", HttpMethods.GET);
            public static ApiActionAttributes<ListAllGroupsDetailsGETRequestParams, List<GroupDetailsDto>> ListAllGroupsDetails = new ApiActionAttributes<ListAllGroupsDetailsGETRequestParams, List<GroupDetailsDto>>("catalog/groups", HttpMethods.GET);
            public static ApiActionAttributes<GetGroupDetailsGETRequestParams, List<GroupDetailsDto>> GetGroupDetails = new ApiActionAttributes<GetGroupDetailsGETRequestParams, List<GroupDetailsDto>>("catalog/groups/{groupIds}", HttpMethods.GET);
            public static ApiActionAttributes<ListAllGroupMediaGETRequestParams, List<GroupMediaDto>> ListAllGroupMedia = new ApiActionAttributes<ListAllGroupMediaGETRequestParams, List<GroupMediaDto>>("catalog/groups/{groupId}/media", HttpMethods.GET);
            public static ApiActionAttributes<ListAllProductsGETRequestParams, List<ProductDto>> ListAllProducts = new ApiActionAttributes<ListAllProductsGETRequestParams, List<ProductDto>>("catalog/products", HttpMethods.GET);
            public static ApiActionAttributes<GetProductDetailsGETRequestParams, List<ProductDto>> GetProductDetails = new ApiActionAttributes<GetProductDetailsGETRequestParams, List<ProductDto>>("catalog/products/{productIds}", HttpMethods.GET);
            public static ApiActionAttributes<GetProductDetailsByGTINGETRequestParams, List<ProductDto>> GetProductDetailsByGTIN = new ApiActionAttributes<GetProductDetailsByGTINGETRequestParams, List<ProductDto>>("catalog/products/gtin/{gtin}", HttpMethods.GET);
            public static ApiActionAttributes<ListProductSKUsGETRequestParams, List<ProductSkuDto>> ListProductSKUs = new ApiActionAttributes<ListProductSKUsGETRequestParams, List<ProductSkuDto>>("catalog/products/{productId}/skus", HttpMethods.GET);
            public static ApiActionAttributes<ListRelatedProductsGETRequestParams, List<RelatedProductsDto>> ListRelatedProducts = new ApiActionAttributes<ListRelatedProductsGETRequestParams, List<RelatedProductsDto>>("catalog/products/{productId}/productsalsopurchased", HttpMethods.GET);
            public static ApiActionAttributes<ListAllProductMediaTypesGETRequestParams, List<ProductMediaTypeDto>> ListAllProductMediaTypes = new ApiActionAttributes<ListAllProductMediaTypesGETRequestParams, List<ProductMediaTypeDto>>("catalog/products/{productId}/media", HttpMethods.GET);
            public static ApiActionAttributes<GetSKUdetailsGETRequestParams, List<ProductSkuDto>> GetSKUdetails = new ApiActionAttributes<GetSKUdetailsGETRequestParams, List<ProductSkuDto>>("catalog/skus/{skuIds}", HttpMethods.GET);
            public static ApiActionAttributes<EmptyParameters, List<ConditionDto>> ListConditions = new ApiActionAttributes<EmptyParameters, List<ConditionDto>>("catalog/conditions", HttpMethods.GET);
        }

        /// <summary>
        /// Inventory
        /// </summary>
        public static partial class Inventory
        {
            public static ApiActionAttributes<GetProductListByIdGETRequestParams, List<ProductListDto>> GetProductListById = new ApiActionAttributes<GetProductListByIdGETRequestParams, List<ProductListDto>>("inventory/productlists/{productListId}", HttpMethods.GET);
            public static ApiActionAttributes<GetProductListByKeyGETRequestParams, List<ProductListDto>> GetProductListByKey = new ApiActionAttributes<GetProductListByKeyGETRequestParams, List<ProductListDto>>("inventory/productlists/{productListKey}", HttpMethods.GET);
            public static ApiActionAttributes<EmptyParameters, List<ProductListDto>> ListAllProductLists = new ApiActionAttributes<EmptyParameters, List<ProductListDto>>("inventory/productLists", HttpMethods.GET);
            public static ApiActionAttributes<CreateProductListPOSTRequestParams, CreateProductListResponse> CreateProductList = new ApiActionAttributes<CreateProductListPOSTRequestParams, CreateProductListResponse>("inventory/productLists", HttpMethods.POST);                        
        }

        /// <summary>
        /// Pricing
        /// </summary>
        public static partial class Pricing
        {
            public static ApiActionAttributes<GetMarketPricebySKUGETRequestParams, List<MarketPriceDto>> GetMarketPricebySKU = new ApiActionAttributes<GetMarketPricebySKUGETRequestParams, List<MarketPriceDto>>("pricing/marketprices/{productconditionId}", HttpMethods.GET);
            public static ApiActionAttributes<ListProductPricesbyGroupGETRequestParams, List<ProductPriceDto>> ListProductPricesbyGroup = new ApiActionAttributes<ListProductPricesbyGroupGETRequestParams, List<ProductPriceDto>>("pricing/group/{groupId}", HttpMethods.GET);
            public static ApiActionAttributes<ListProductMarketPricesGETRequestParams, List<ProductPriceDto>> ListProductMarketPrices = new ApiActionAttributes<ListProductMarketPricesGETRequestParams, List<ProductPriceDto>>("pricing/product/{productIds}", HttpMethods.GET);
            public static ApiActionAttributes<ListSKUMarketPricesGETRequestParams, List<SKUMarketPriceDto>> ListSKUMarketPrices = new ApiActionAttributes<ListSKUMarketPricesGETRequestParams, List<SKUMarketPriceDto>>("pricing/sku/{skuIds}", HttpMethods.GET);
            public static ApiActionAttributes<ListProductBuylistPricesGETRequestParams, List<ProductBuylistDto>> ListProductBuylistPrices = new ApiActionAttributes<ListProductBuylistPricesGETRequestParams, List<ProductBuylistDto>>("pricing/buy/product/{productIds}", HttpMethods.GET);
            public static ApiActionAttributes<ListSKUBuylistPricesGETRequestParams, List<SKUBuylistPriceDto>> ListSKUBuylistPrices = new ApiActionAttributes<ListSKUBuylistPricesGETRequestParams, List<SKUBuylistPriceDto>>("pricing/buy/sku/{skuIds}", HttpMethods.GET);
            public static ApiActionAttributes<ListProductBuylistPricesbyGroupGETRequestParams, List<ProductBuylistDto>> ListProductBuylistPricesbyGroup = new ApiActionAttributes<ListProductBuylistPricesbyGroupGETRequestParams, List<ProductBuylistDto>>("pricing/buy/group/{groupId}", HttpMethods.GET);
        }
    }

    public class ApiActionAttributes<TParams, TResult>
    {
        public string Action { get; }
        public HttpMethods Method { get; }

        public ApiActionAttributes(string action, HttpMethods method)
        {
            Action = action;
            Method = method;
        }
    }
}
