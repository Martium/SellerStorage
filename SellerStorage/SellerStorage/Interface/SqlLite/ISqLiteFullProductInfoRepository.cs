using System.Collections.Generic;
using SellerStorage.Models;

namespace SellerStorage.Interface.SqlLite
{
    public interface ISqLiteFullProductInfoRepository
    {
        bool CreateNewProductInfo(FullProductInfoModel fullProductInfo);
        bool UpdateProductInfo(FullProductInfoModel fullProductInfo, int productId);
        FullProductInfoWithIdModel GetProductInfoById(int productId);
        IEnumerable<FullProductInfoWithIdModel> GetAllInfo(string searchPhrase = null);
    }
}
