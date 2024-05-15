using ProniaBB207.Core.Models;

namespace ProniaBB207.Business.Services.Abstracts;

public interface ISliderService
{
    void RemoveSlider(int id);
    void AddSlider(Slider slider);
    void UpdateSlider(int id, Slider slider);


    Slider GetSlider(Func<Slider, bool>? func = null);
    List<Slider> GetAllSliders(Func<Slider, bool>? func = null);
}
