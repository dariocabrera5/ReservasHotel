using System.Collections.Generic;
using Docs.Models;

namespace Docs.Models.Data
{
    public interface IRepositorioHoteles
    {

         IEnumerable<Hoteles> GetAllArbitros();

         Hoteles AddArbitro(Hoteles Hotel);

         Hoteles UpdateArbitro(Hoteles Hotel);

         void DeleteArbitro(int Id);

         Hoteles GetArbitro(int Id);

    }
}