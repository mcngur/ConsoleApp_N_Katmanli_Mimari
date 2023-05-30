using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMemberDal:IGenericDal<Member> //Kod tekrarı olmaması için 
    {
        // IGenericDal sınıfı ekjlenmeden öncesine kadar bu şekilde kullanılması gerekiyordu. 
        // Şimdi miras alacak
        //void Insert(Member member);
        //void Update(Member member);
        //void Delete(Member member);
        //List<Member> GetList();
        //Member GetByID(int id);
    }
}
