using System;
using _09._06._14.Exeption;

namespace _09._06._14
{
    class Employer : Human
    {
        protected Boolean isWorking;

        public Employer(): base() { }

        public Employer(String firstName, String lastName)
            : base(firstName, lastName) { }

        public Employer(String firstName, String lastName , DateTime birthday)
            : base(firstName, lastName , birthday) { }

        //public new void Work()
        //{
        //    //Do something
        //}


        public override void Work()
        {

            if (this.isWorking)
            {
                throw new EmployeeBusyExeption(
                    "Employer is busy");
            }
            else
            {
                if (VerificationResourses())
                {
                    try
                    {
                        this.isWorking = true;
                        base.Work();

                        //do somethisng

                        this.isWorking = false;
                    }
                    catch (Exception ex)
                    {
                        throw new ForceMajeureExeption(
                            "Force-Majeure EXEPTION", ex
                            );
                    }

                }
                else
                {
                    throw new Crunch("Verification resourses failed ha-ha");
                }
            }
            //base.Work();
           
        }

        private Boolean VerificationResourses()
        {
            Boolean verificationResourses = true;

            // verific

            return verificationResourses;
        }

    }

    
}
