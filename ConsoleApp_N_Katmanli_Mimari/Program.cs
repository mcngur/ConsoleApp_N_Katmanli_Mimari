using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_N_Katmanli_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N Katmanlı Mimaride Listeleme İşlemi

            // Lokasyon Listeleme
            //Context c = new Context();
            //LocationManager locationManager = new LocationManager(new EfLocationDal());
            //var values = locationManager.TGetList();

            //void Listele()
            //{
            //    foreach (var value in values)
            //    {
            //        Console.WriteLine(value.LocationName);
            //        Console.WriteLine("------------------");
            //    }
            //}

            // N Katmanlı Mimaride Ekleme İşlemi

            // Location location = new Location();
            //location.LocationName = "Rotterdam";
            //locationManager.TInsert(location);
            //Listele();

            //var locationValue = locationManager.TGetById(4);
            //locationManager.TDelete(locationValue);

            // N Katmanlı Mimaride Güncelleme İşlemi

            //var locationValue = locationManager.TGetById(2);
            //locationValue.LocationName = "Çanakkale";
            //locationManager.TUpdate(locationValue);

            //Console.WriteLine("güncelleme yapıldı");

            // MemberCrud İşlemleri

            //MemberManager memberManager = new MemberManager(new EfMemberDal());
            //var values = memberManager.TGetList();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.MemberName + " " + value.MemberSurName);
            //    Console.WriteLine("------------------------");
            //}
            //Member member = new Member();
            //member.MemberName = "Test";
            //member.MemberSurName = "TestB";
            //memberManager.TInsert(member);
            //var valueMember = memberManager.TGetById(9);
            //memberManager.TDelete(valueMember);
            //foreach (var item in valueMember)
            //{
            //    Console.WriteLine(item.);
            //}

            //valueMember.MemberName = "Name";
            //valueMember.MemberSurName = "ValueTest";
            //memberManager.TUpdate(valueMember);
            //Console.WriteLine("İşlem Yapıldı");

            //İlişkili Tablo Comment 

            //CommentManager commentManager = new CommentManager(new EfCommentDal());

            //var values = commentManager.TGetList();
            //foreach (var value in values)
            //{
            //    Console.WriteLine("" + value.CommentID + "-" + value.Location.LocationName + "|" + value.Member.MemberName + " " + value.Member.MemberSurName );
            //    Console.WriteLine("---------------------");
            //}

            //Mimari Üzerinden ekleme işlemi
            //CommentManager commentManager = new CommentManager(new EfCommentDal());
            //commentManager.TCommentListWithLocationAndMember();


            // Fluent Validation 
            MemberManager memberManager = new MemberManager(new EfMemberDal());

            Member member = new Member();
            member.MemberName = "a";
            member.MemberSurName = "b";
            MemberValidator ValidationRules = new MemberValidator();
            ValidationResult results = ValidationRules.Validate(member);
            if (results.IsValid)
            {
                memberManager.TInsert(member);
                Console.WriteLine("Üye başarılı bir şekilde eklendi");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }


            Console.ReadLine();
        }
    }
}
