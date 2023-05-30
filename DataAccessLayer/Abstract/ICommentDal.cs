using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        // IGenericDal sınıfı ekjlenmeden öncesine kadar bu şekilde kullanılması gerekiyordu. 
        // Şimdi miras alacak
        //void Insert(Comment comment);
        //void Update(Comment comment);
        //void Delete(Comment comment);
        //List<Comment> GetList();
        //Comment GetById(int id);

        void CommentListWithLocationAndMember();
    }
}
