using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Teacher : People
    {
        private int _experience;
        private int _lvl;
        public static int MROT = 22400;

        public Teacher(string name, int age, int experience, int lvl)
            : base(name, age)
        {
            _experience = experience;
            _lvl = lvl;
        }

        public double GetSalary()
        {
            return MROT + (_experience * 500) + (_lvl * 900);
        }

        public override string Info()
        {
            string lvlSTR = _lvl == 1 ? "Кондидат в доктора наук" : "Доктор наук";
            return $"{base.Info()}, стаж: {_experience}, уровень квалификации: {lvlSTR}, зарплата: {GetSalary()}\n";
        }
    }
}
