using System;

namespace zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();

            var stRole = new STRole();
            var devRole = new DEVRole();
            var ceoRole = new CEORole();
            var dsnRole = new DSNRRole();
            var pmRole = new PMRole();

            storage.Add(stRole);
            storage.Add(devRole);
            storage.Add(ceoRole);
            storage.Add(dsnRole);
            storage.Add(pmRole);

            storage.Remove(stRole);
            storage.Remove(devRole);
            storage.Remove(ceoRole);
            storage.Remove(dsnRole);
            storage.Remove(pmRole);
        }
    }

}
