using EasyBill.Business.Dtos.BillType;
using EasyBill.Business.Dtos.Provider;
using EasyBill.Entities.Results;

namespace EasyBill.Business.Abstract
{
    public interface IBillTypeService
    {

        Result<IEnumerable<BillTypeDto>> GetAllBillTypes(); // Fatura türlerini döner
        Result<BillTypeDto> GetBillTypeById(int id); // Belirli ID'ye göre fatura türü döner
        Result<BillTypeDto> GetBillTypeByName(string name); // Belirli isme göre fatura türü döner
        Result AddBillType(BillTypeCreateDto billTypeCreateDto); // Yeni fatura türü ekler
        Result UpdateBillType(BillTypeUpdateDto billTypeUpdateDto); // Fatura türü günceller
        Result DeleteBillType(int id); // Fatura türünü siler
        Result<IEnumerable<ProviderDto>> GetProvidersByBillTypeId(int billTypeId); // Fatura türüne göre sağlayıcıları döner
    }
}
