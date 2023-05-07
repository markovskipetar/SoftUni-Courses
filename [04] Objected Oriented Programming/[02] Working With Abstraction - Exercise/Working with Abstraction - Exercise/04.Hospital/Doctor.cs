using System.Collections.Generic;

namespace _04.Hospital
{
    public class Doctor
    {
        private readonly List<Patient> patients;

        private Doctor()
        {
            this.patients = new List<Patient>();
        }
        public Doctor(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string FullName => this.Name + this.LastName;

        public IReadOnlyCollection<Patient> Patients => this.patients;
        public void AddPatient(Patient patient)
        {
            this.patients.Add(patient);
        }
    }
}
