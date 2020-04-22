using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerKlasser
{
    public interface IManage<T>
    {
        List<T> GetAll();
        T GetFromId(int objectNr);
        void Create(T obj);
        void Update(T obj, int objectNr);
        void Delete(int objectNr);
    }
}
