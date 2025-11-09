using DesignPattens.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Student
{
    internal class StudentService : IStudentService
    {
        public Logger _logger;
        public StudentService(Logger? log) => _logger = log;
        public void Add()
        {
            Console.WriteLine("Öğrenci sisteme eklendi");
            _logger.Log("Kullanıcı sisteme öğrenci eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Ögrenci sistemden silindi");
            _logger.Log("Kullanıcı sisteme öğrençi silindi");
        }

        public void List()
        {
            Console.WriteLine("Ögrenci sisteme listelendi");
            _logger.Log("Kullanci siteme ögrenci sisteme listelendi");
           
        }

        public void Update()
        {
            Console.WriteLine("Öğrenci siteme güncellendi");
            _logger.Log("Kullanıcı sıstemi ögrenci sistemi guncellendi");
        }
    }
}
