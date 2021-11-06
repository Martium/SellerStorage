using SellerStorage.Interface.SqlLite;
using SellerStorage.Models;

namespace SellerStorage.Repository.SqlLiteDataBase
{
    public class FullProductInfoRepositorySql
    {
        private readonly ISqLiteFullProductInfoRepository _fullProductInfoRepository;

        public FullProductInfoRepositorySql(ISqLiteFullProductInfoRepository fullProductInfoRepository)
        {
            _fullProductInfoRepository = fullProductInfoRepository;
        }

        public bool CreateNewFullProductInfo(FullProductInfoModel productInfo)
        {
            bool isSuccess = _fullProductInfoRepository.CreateNewProductInfo(productInfo);
            return isSuccess;
        }
    }
}
