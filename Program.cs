using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Монстр\tСила\tЗдоровье");
            List<Certificate> certificates = new List<Certificate>()
            {
                new Certificate(new Monster("Ужастик"), new Power("10"),Health.Тридцать),
                new Certificate(new Monster("Пугалка"), new Power("10"),Health.Тридцать),
                new Certificate(new Monster("Жутик"), new Power("20"),Health.Пятьдесят),
                new Certificate(new Monster("Чудак"), new Power("30"),Health.Шестьдесят),
                new Certificate(new Monster("Страшила"), new Power("30"),Health.Семьдесят)
            };

            var certificatesPeople = certificates.Where(u => u.health == Health.Шестьдесят || u.health == Health.Семьдесят).Select(u => u).ToList();
            var notcertificatesPeople = certificatesPeople.Where(u => u.health == Health.Тридцать || u.health == Health.Пятьдесят).Select(u => u).ToList();

            certificatesPeople.ForEach(u => Console.WriteLine($"{u.monster.Name}      {u.power.Name}     {u.health}"));
            Console.ReadKey();
        }
    }
}
