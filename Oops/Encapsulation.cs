using System;

namespace Oops
{
    public class Encapsulation
    {
        private DateTime birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return birthdate;
        }
    }
}
