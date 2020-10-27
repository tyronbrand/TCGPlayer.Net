using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TCGPlayer.Net.Models
{
    public partial class ListAllCategoriesGETRequestParams : QueryStringParams
    {
        [DisplayName("offset")]
        public int Offset { get; set; }

        [DisplayName("limit")]
        public int Limit { get; set; }

        [DisplayName("sortOrder")]
        public string SortOrder { get; set; }

        [DisplayName("sortDesc")]
        public bool SortDesc { get; set; }
    }

    public partial class GetCategoryDetailsGETRequestParams : QueryStringParams
    {
        [DisplayName("categoryIds")]
        public string[] CategoryIds { get; set; }
    }

    public abstract partial class CategoryIdRequestParams : QueryStringParams
    {
        [DisplayName("categoryId")]
        public int CategoryId { get; set; }
    }

    public partial class GetCategorySearchManifestGETRequestParams : CategoryIdRequestParams { }

    public partial class ListAllCategoryRaritiesGETRequestParams : CategoryIdRequestParams { }

    public partial class ListAllCategoryPrintingsGETRequestParams : CategoryIdRequestParams { }

    public partial class ListAllCategoryConditionsGETRequestParams : CategoryIdRequestParams { }

    public partial class ListAllCategoryLanguagesGETRequestParams : CategoryIdRequestParams { }

    public partial class ListAllCategoryMediaGETRequestParams : CategoryIdRequestParams { }

    public partial class SearchCategoryProductsPOSTRequestParams : QueryJsonParams
    {
        [DisplayName("categoryId")]
        public int CategoryId { get; set; }

        [DisplayName("offset")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public int? Offset { get; set; }

        [DisplayName("limit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        [DisplayName("sort")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        [DisplayName("includeAggregates")]
        public bool IncludeAggregates { get; set; }

        [DisplayName("filters")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SearchCategoryProductsFilterGETRequestParams[] Filters { get; set; }
    }

    public partial class SearchCategoryProductsFilterGETRequestParams : QueryStringParams
    {
        [DisplayName("name")]
        public string Name { get; set; }

        [DisplayName("values")]
        public string[] Values { get; set; }
    }

    public partial class ListAllCategoryGroupsGETRequestParams : CategoryIdRequestParams
    {
        [DisplayName("offset")]
        public int Offset { get; set; }

        [DisplayName("limit")]
        public int Limit { get; set; }
    }

    public partial class ListAllGroupsDetailsGETRequestParams : QueryStringParams
    {
        [DisplayName("categoryId")]
        public int CategoryId { get; set; }

        [DisplayName("categoryName")]
        public string CategoryName { get; set; }

        [DisplayName("isSupplemental")]
        public bool IsSupplemental { get; set; }

        [DisplayName("hasSealed")]
        public bool HasSealed { get; set; }        

        [DisplayName("sortOrder")]
        public string SortOrder { get; set; }

        [DisplayName("sortDesc")]
        public bool SortDesc { get; set; }

        [DisplayName("offset")]
        public int Offset { get; set; }

        [DisplayName("limit")]
        public int Limit { get; set; }        
    }

    public partial class GetGroupDetailsGETRequestParams : QueryStringParams
    {
        [DisplayName("groupIds")]
        public string[] GroupIds { get; set; }
    }

    public partial class ListAllGroupMediaGETRequestParams : QueryStringParams
    {
        [DisplayName("groupId")]
        public int GroupId { get; set; }
    }
    
    public partial class ListAllProductsGETRequestParams : QueryStringParams
    {
        [DisplayName("categoryId")]
        public int CategoryId { get; set; }

        [DisplayName("categoryName")]
        public string CategoryName { get; set; }

        [DisplayName("groupId")]
        public int GroupId { get; set; }

        [DisplayName("groupName")]
        public string GroupName { get; set; }

        [DisplayName("productName")]
        public string ProductName { get; set; }

        [DisplayName("getExtendedFields")]
        public bool GetExtendedFields { get; set; }

        [DisplayName("productTypes")]
        public string ProductTypes { get; set; }

        [DisplayName("offset")]
        public int Offset { get; set; }

        [DisplayName("limit")]
        public int Limit { get; set; }

        [DisplayName("includeSkus")]
        public bool IncludeSkus { get; set; }        
    }

    public partial class GetProductDetailsGETRequestParams : QueryStringParams
    {
        [DisplayName("productIds")]
        public string[] ProductIds { get; set; }

        [DisplayName("getExtendedFields")]
        public bool GetExtendedFields { get; set; }

        [DisplayName("includeSkus")]
        public bool IncludeSkus { get; set; }
    }

    public partial class GetProductDetailsByGTINGETRequestParams : QueryStringParams
    {
        [DisplayName("gtin")]
        public string Gtin { get; set; }

        [DisplayName("getExtendedFields")]
        public bool GetExtendedFields { get; set; }

        [DisplayName("includeSkus")]
        public bool IncludeSkus { get; set; }
    }

    public abstract partial class ProductIdRequestParams : QueryStringParams
    {
        [DisplayName("productId")]
        public long ProductId { get; set; }
    }

    public partial class ListProductSKUsGETRequestParams : ProductIdRequestParams { }

    public partial class ListAllProductMediaTypesGETRequestParams : ProductIdRequestParams { }

    public partial class ListRelatedProductsGETRequestParams : ProductIdRequestParams
    {
        [DisplayName("offset")]
        public int Offset { get; set; }

        [DisplayName("limit")]
        public int Limit { get; set; }
    }

    public partial class GetSKUdetailsGETRequestParams : QueryStringParams
    {
        [DisplayName("skuIds")]
        public string[] SkuIds { get; set; }
    }
    
    public partial class GetProductListByIdGETRequestParams : QueryStringParams
    {
        [DisplayName("productListId")]
        public long ProductListId { get; set; }
    }

    public partial class GetProductListByKeyGETRequestParams : QueryStringParams
    {
        [DisplayName("productListKey")]
        public string ProductListKey { get; set; }
    }

    public partial class CreateProductListPOSTRequestParams : QueryJsonParams
    {
        [DisplayName("quantity")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        [DisplayName("productConditionId")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? ProductConditionId { get; set; }
    }
    
    public partial class GetMarketPricebySKUGETRequestParams : QueryStringParams
    {
        [DisplayName("productconditionId")]
        public long ProductConditionId { get; set; }
    }
    
    public partial class ListProductPricesbyGroupGETRequestParams : QueryStringParams
    {
        [DisplayName("groupId")]
        public int GroupId { get; set; }
    }

    public partial class ListProductMarketPricesGETRequestParams : QueryStringParams
    {
        [DisplayName("productIds")]
        public string[] ProductIds { get; set; }
    }

    public partial class ListSKUMarketPricesGETRequestParams : QueryStringParams
    {
        [DisplayName("skuIds")]
        public string[] SkuIds { get; set; }
    }
    
    public partial class ListProductBuylistPricesGETRequestParams : QueryStringParams
    {
        [DisplayName("productIds")]
        public string[] ProductIds { get; set; }
    }

    public partial class ListSKUBuylistPricesGETRequestParams : QueryStringParams
    {
        [DisplayName("skuIds")]
        public string[] SkuIds { get; set; }
    }

    public partial class ListProductBuylistPricesbyGroupGETRequestParams : QueryStringParams
    {
        [DisplayName("groupId")]
        public int GroupId { get; set; }
    }

}
