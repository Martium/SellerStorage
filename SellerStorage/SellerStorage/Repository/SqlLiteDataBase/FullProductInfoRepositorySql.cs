using System.Collections;
using System.Collections.Generic;
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

        public bool UpdateFullProductInfo(int productId, FullProductInfoModel productInfo)
        {
            bool isSuccess = _fullProductInfoRepository.UpdateProductInfo(productInfo, productId);
            return isSuccess;
        }

        public FullProductInfoModel GetProductInfoById(int productId)
        {
            FullProductInfoModel getProductInfoById = _fullProductInfoRepository.GetProductInfoById(productId);
            return getProductInfoById;
        }

        public IEnumerable<FullProductInfoWithIdModel> GetAllProductInfo(string searchPhrase = null)
        {
            IEnumerable<FullProductInfoWithIdModel> getAllInfo = _fullProductInfoRepository.GetAllInfo(searchPhrase);
            return getAllInfo;
        }
    }
}
