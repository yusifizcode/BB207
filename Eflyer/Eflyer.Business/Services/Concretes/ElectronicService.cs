using Eflyer.Business.Exceptions;
using Eflyer.Business.Extensions;
using Eflyer.Business.Services.Abstracts;
using Eflyer.Core.Models;
using Eflyer.Core.RepositoryAbstracts;
using Microsoft.AspNetCore.Hosting;

namespace Eflyer.Business.Services.Concretes;

public class ElectronicService : IElectronicService
{
    private readonly IElectronicRepository _electronicRepository;
    private readonly IWebHostEnvironment _env;
    public ElectronicService(IElectronicRepository electronicRepository, IWebHostEnvironment env)
    {
        _electronicRepository = electronicRepository;
        _env = env;
    }

    public void AddElectronic(Electronic electronic)
    {
        if (electronic.ImageFile == null)
            throw new ImageFileRequiredException(nameof(electronic.ImageFile), "ImageFile is required!");
        electronic.ImageUrl = Helper.SaveFile(_env.WebRootPath, @"uploads\electronics", electronic.ImageFile);

        _electronicRepository.Add(electronic);
        _electronicRepository.Commit();
    }

    public List<Electronic> GetAllElectronics(int page = 1, Func<Electronic, bool>? func = null)
    {
        return _electronicRepository.GetAll(page, func);
    }

    public Electronic GetElectronic(Func<Electronic, bool>? func = null)
    {
        return _electronicRepository.Get(func);
    }

    public void RemoveElectronic(int id)
    {
        var existElectronic = _electronicRepository.Get(x => x.Id == id);
        if (existElectronic == null)
            throw new EntityNotFoundException("", "Entity not found!");

        if (existElectronic.ImageUrl != null)
            Helper.DeleteFile(_env.WebRootPath, @"uploads\electronics", existElectronic.ImageUrl);

        _electronicRepository.Delete(existElectronic);
        _electronicRepository.Commit();
    }

    public void UpdateElectronic(Electronic electronic)
    {
        var existElectronic = _electronicRepository.Get(x => x.Id == electronic.Id);
        if (existElectronic == null)
            throw new EntityNotFoundException("", "Entity not found!");

        if (electronic.ImageFile != null)
        {
            if (existElectronic.ImageUrl != null)
                Helper.DeleteFile(_env.WebRootPath, @"uploads\electronics", existElectronic.ImageUrl);

            existElectronic.ImageUrl = Helper.SaveFile(_env.WebRootPath, @"uploads\electronics", electronic.ImageFile);
        }

        existElectronic.Title = electronic.Title;
        existElectronic.Price = electronic.Price;
        _electronicRepository.Commit();
    }
}
