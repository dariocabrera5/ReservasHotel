using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Docs.Models;

namespace Docs.Models.Data
{
    public class RepositorioHoteles : IRepositorioHoteles
    {
        private readonly DataContext _appContext = new DataContext();

        public RepositorioHoteles()
        {
        }

        public RepositorioHoteles (DataContext appContext)
        {
            _appContext=appContext;
        }

        Hoteles IRepositorioHoteles.AddHotel (Hoteles Hotel)
        {
            var HotelAñadido = _appContext.hoteles.Add(Hotel);
            _appContext.SaveChanges();
            return HotelAñadido.Entity;
        }
        void IRepositorioHoteles.DeleteHotel (int Hotelid)
        {
            var HotelEncontrado = _appContext.hoteles.FirstOrDefault(a => a.Id == Hotelid);
            if (HotelEncontrado == null)
                return;
            _appContext.hoteles.Remove(HotelEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Hoteles> IRepositorioHoteles.GetAllHoteles ()
        {
            return _appContext.hoteles;
        }

        Hoteles IRepositorioHoteles.GetHotel(int Hotelid)
        {
            return _appContext.hoteles.FirstOrDefault(a => a.Id == Hotelid);
        }

        Hoteles IRepositorioHoteles.UpdateHotel(Hoteles Hotel)
        {
            var HotelEncontrado = _appContext.hoteles.FirstOrDefault(a => a.Id == Hotel.Id);
            if (HotelEncontrado != null)
            {
                HotelEncontrado.Ciudad = Hotel.Ciudad;
                HotelEncontrado.CupoHabitacion = Hotel.CupoHabitacion;
                HotelEncontrado.HabitacionPremium = Hotel.HabitacionPremium;
                HotelEncontrado.HabitacionStandar = Hotel.HabitacionStandar;

                _appContext.SaveChanges();
            }
            return HotelEncontrado;
        }
    }
}