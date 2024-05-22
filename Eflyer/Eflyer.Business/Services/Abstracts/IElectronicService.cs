using Eflyer.Core.Models;

namespace Eflyer.Business.Services.Abstracts;

public interface IElectronicService
{
    void RemoveElectronic(int id);
    void AddElectronic(Electronic electronic);
    void UpdateElectronic(Electronic electronic);

    Electronic GetElectronic(Func<Electronic, bool>? func = null);
    List<Electronic> GetAllElectronics(int page = 1, Func<Electronic, bool>? func = null);
}
