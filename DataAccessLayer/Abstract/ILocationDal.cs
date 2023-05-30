using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ILocationDal:IGenericDal<Location>
    {
        // IGenericDal sınıfı ekjlenmeden öncesine kadar bu şekilde kullanılması gerekiyordu. 
        // Şimdi miras alacak
        //void Insert (Location location);
        //void Update (Location location);
        //void Delete (Location location);
        //List<Location> GetList ();
        //Location GetByID (int id);

    }
}
