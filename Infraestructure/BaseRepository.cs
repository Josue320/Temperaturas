using Dominio.Entities;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class BaseRepository : IBase<Temperatura>
    {
        private List<Temperatura> data;
        public BaseRepository()
        {
            data = new List<Temperatura>();
        }
        public void Create(Temperatura t)
        {
            data.Add(t);
        }

        public List<Temperatura> GetAll(Predicate<Temperatura> predicate)
        {
            return data.FindAll(predicate);
        }
    }
}
