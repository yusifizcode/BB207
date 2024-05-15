using Microsoft.AspNetCore.Hosting;
using ProniaBB207.Business.Exceptions;
using ProniaBB207.Business.Services.Abstracts;
using ProniaBB207.Core.Models;
using ProniaBB207.Core.RepositoryAbstracts;

namespace ProniaBB207.Business.Services.Concretes;

public class SliderService : ISliderService
{
    private readonly ISliderRepository _sliderRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public SliderService(ISliderRepository sliderRepository, IWebHostEnvironment webHostEnvironment)
    {
        _sliderRepository = sliderRepository;
        _webHostEnvironment = webHostEnvironment;
    }

    public void AddSlider(Slider slider)
    {
        if (slider.ImageFile == null) throw new FileNullReferenceException("ImageFile", "file is required!");


        if (!slider.ImageFile.ContentType.Contains("image/"))
            throw new FileContentTypeException("ImageFile", "File content type error!");

        if (slider.ImageFile.Length > 2097152)
            throw new FileSizeException("ImageFile", "File size error!");


        //string fileName = Guid.NewGuid().ToString() + Path.GetExtension(slider.ImageFile.FileName);
        string path = _webHostEnvironment.WebRootPath + @"\uploads\sliders\" + slider.ImageFile.FileName;

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            slider.ImageFile.CopyTo(stream);
        }


        slider.ImageUrl = slider.ImageFile.FileName;

        _sliderRepository.Add(slider);
        _sliderRepository.Commit();
    }

    public Slider GetSlider(Func<Slider, bool>? func = null)
    {
        return _sliderRepository.Get(func);

    }
    public List<Slider> GetAllSliders(Func<Slider, bool>? func = null)
    {
        return _sliderRepository.GetAll(func);
    }

    public void RemoveSlider(int id)
    {

        var existSlider = _sliderRepository.Get(x => x.Id == id);
        if (existSlider == null) throw new EntityNotFoundException("", "slider not found!");

        string path = _webHostEnvironment.WebRootPath + @"\uploads\sliders\" + existSlider.ImageFile.FileName;

        if (!File.Exists(path))
            throw new Exceptions.FileNotFoundException("ImageFile", "File not found!");

        File.Delete(path);

        _sliderRepository.Delete(existSlider);
        _sliderRepository.Commit();
    }

    public void UpdateSlider(int id, Slider slider)
    {
        var oldSilder = _sliderRepository.Get(x => x.Id == id);
        if (oldSilder == null) throw new EntityNotFoundException("", "entity not found!");

        if (slider.ImageFile != null)
        {
            if (!slider.ImageFile.ContentType.Contains("image/"))
                throw new FileContentTypeException("ImageFile", "File content type error!");

            if (slider.ImageFile.Length > 2097152)
                throw new FileSizeException("ImageFile", "File size error!");


            //string fileName = Guid.NewGuid().ToString() + Path.GetExtension(slider.ImageFile.FileName);
            string path = _webHostEnvironment.WebRootPath + @"\uploads\sliders\" + slider.ImageFile.FileName;

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                slider.ImageFile.CopyTo(stream);
            }

            oldSilder.ImageUrl = slider.ImageFile.FileName;
        }

        oldSilder.Title = slider.Title;
        oldSilder.Subtitle = slider.Subtitle;
        oldSilder.Description = slider.Description;

        _sliderRepository.Commit();

    }

}
