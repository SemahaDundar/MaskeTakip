using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class PttManager:ISupplierService
    {
        private IApplicantServe _applicantServe;




        public PttManager(IApplicantServe applicantServe)// NEW YAPILDIĞINDA  CONTRUCTOR ÇALIŞIR
        {
            _applicantServe = applicantServe;


        }
        public void GiveMask(Person person)
        {

            if (_applicantServe.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi ");
            }
            else
            {
                Console.WriteLine("Maske Verilemedi");
            }
        }

    }
}
