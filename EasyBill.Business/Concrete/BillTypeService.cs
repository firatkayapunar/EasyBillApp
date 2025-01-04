using AutoMapper;
using EasyBill.Business.Abstract;
using EasyBill.Business.Dtos.BillType;
using EasyBill.Business.Dtos.Provider;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.Entities;
using EasyBill.Entities.Results;

namespace EasyBill.Business.Concrete
{
    public class BillTypeService : IBillTypeService
    {
        private readonly IBillTypeRepository _billTypeRepository;
        private readonly IMapper _mapper;

        public BillTypeService(IBillTypeRepository billTypeRepository, IMapper mapper)
        {
            _billTypeRepository = billTypeRepository;
            _mapper = mapper;
        }

        // Tüm fatura türlerini getirir.
        public Result<IEnumerable<BillTypeDto>> GetAllBillTypes()
        {
            try
            {
                var billTypes = _billTypeRepository.GetAll();
                if (!billTypes.Any())
                    return Result<IEnumerable<BillTypeDto>>.FailureResult("Hiç fatura türü bulunamadı.", new List<string> { "Sonuç boş döndü." });

                var result = _mapper.Map<IEnumerable<BillTypeDto>>(billTypes);
                return Result<IEnumerable<BillTypeDto>>.SuccessResult(result, "Fatura türleri başarıyla getirildi.");
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<BillTypeDto>>.FailureResult("Fatura türleri alınırken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // ID'ye göre fatura türünü getirir.
        public Result<BillTypeDto> GetBillTypeById(int id)
        {
            try
            {
                var billType = _billTypeRepository.GetById(id);
                if (billType == null)
                {
                    return Result<BillTypeDto>.FailureResult("Fatura türü bulunamadı.", new List<string> { "Geçersiz ID." });
                }

                var result = _mapper.Map<BillTypeDto>(billType);
                return Result<BillTypeDto>.SuccessResult(result, "Fatura türü başarıyla getirildi.");
            }
            catch (Exception ex)
            {
                return Result<BillTypeDto>.FailureResult("Fatura türü alınırken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // İsme göre fatura türünü getirir.
        public Result<BillTypeDto> GetBillTypeByName(string name)
        {
            try
            {
                var billType = _billTypeRepository.GetByName(name);
                if (billType == null)
                    return Result<BillTypeDto>.FailureResult($"'{name}' adlı fatura türü bulunamadı.", new List<string> { "Geçersiz fatura türü adı." });

                var result = _mapper.Map<BillTypeDto>(billType);
                return Result<BillTypeDto>.SuccessResult(result, "Fatura türü başarıyla getirildi.");
            }
            catch (Exception ex)
            {
                return Result<BillTypeDto>.FailureResult("Fatura türü alınırken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // Yeni bir fatura türü ekler.
        public Result AddBillType(BillTypeCreateDto billTypeCreateDto)
        {
            try
            {
                var existingBillType = _billTypeRepository.GetByName(billTypeCreateDto.Name);
                if (existingBillType != null)
                    return Result.FailureResult("Bu adla zaten bir fatura türü mevcut.", new List<string> { "Fatura türü adı benzersiz olmalıdır." });

                var billType = _mapper.Map<BillType>(billTypeCreateDto);
                _billTypeRepository.Add(billType);
                _billTypeRepository.Save();

                return Result.SuccessResult("Fatura türü başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                return Result.FailureResult("Fatura türü eklenirken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // Var olan bir fatura türünü günceller.
        public Result UpdateBillType(BillTypeUpdateDto billTypeUpdateDto)
        {
            try
            {
                var existingBillType = _billTypeRepository.GetById(billTypeUpdateDto.ID);
                if (existingBillType == null)
                {
                    return Result.FailureResult("Güncellenecek fatura türü bulunamadı.", new List<string> { "Fatura türü ID geçersiz." });
                }

                var duplicateBillType = _billTypeRepository.GetByName(billTypeUpdateDto.Name);
                if (duplicateBillType != null && duplicateBillType.ID != billTypeUpdateDto.ID)
                {
                    return Result.FailureResult("Bu adla başka bir fatura türü zaten mevcut.", new List<string> { "Fatura türü adı benzersiz olmalıdır." });
                }

                _mapper.Map(billTypeUpdateDto, existingBillType);
                _billTypeRepository.Update(existingBillType);
                _billTypeRepository.Save();

                return Result.SuccessResult("Fatura türü başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                return Result.FailureResult("Fatura türü güncellenirken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // Belirli bir ID'ye sahip fatura türünü siler.
        public Result DeleteBillType(int id)
        {
            try
            {
                var billType = _billTypeRepository.GetById(id);
                if (billType == null)
                {
                    return Result.FailureResult("Silinecek fatura türü bulunamadı.", new List<string> { "Geçersiz ID." });
                }

                _billTypeRepository.Delete(billType);
                _billTypeRepository.Save();

                return Result.SuccessResult("Fatura türü başarıyla silindi.");
            }
            catch (Exception ex)
            {
                return Result.FailureResult("Fatura türü silinirken bir hata oluştu.", new List<string> { ex.Message });
            }
        }

        // Fatura türüne bağlı sağlayıcıları getirir.
        public Result<IEnumerable<ProviderDto>> GetProvidersByBillTypeId(int billTypeId)
        {
            try
            {
                var providers = _billTypeRepository.GetProvidersByBillTypeId(billTypeId);
                if (!providers.Any())
                {
                    return Result<IEnumerable<ProviderDto>>.FailureResult("Bu fatura türüne ait sağlayıcı bulunamadı.", new List<string> { "Boş bir sonuç döndü." });
                }

                var result = _mapper.Map<IEnumerable<ProviderDto>>(providers);
                return Result<IEnumerable<ProviderDto>>.SuccessResult(result, "Sağlayıcılar başarıyla getirildi.");
            }
            catch (Exception ex)
            {
                return Result<IEnumerable<ProviderDto>>.FailureResult("Sağlayıcılar alınırken bir hata oluştu.", new List<string> { ex.Message });
            }
        }
    }
}
