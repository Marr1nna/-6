using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ6
{
    public enum Health
    {
        Тридцать,
        Пятьдесят,
        Шестьдесят,
        Семьдесят
    }
    class Certificate
    {
        private Monster _monster;
        private Power _power;
        private Health _health;
        public Certificate(Monster monster, Power power, Health health)
        {
            _monster = monster;
            _power = power;
            _health = health;
        }
        public Health health
        {
            get => _health;
        }
        public Monster monster
        {
            get => _monster;
        }
        public Power power
        {
            get => _power;
        }
        public Monster getMonster()
        {
            return _monster;
        }
        public Power getPower()
        {
            return _power;
        }
        public Health getHealth()
        {
            return _health;
        }
    }
}
