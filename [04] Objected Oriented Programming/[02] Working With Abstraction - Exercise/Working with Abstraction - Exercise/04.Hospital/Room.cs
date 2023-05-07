using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Hospital
{
    public class Room
    {
        private readonly List<Patient> patients;
        private const int MAX_CAPACITY = 3;

        private Room()
        {
            this.patients = new List<Patient>();
        }
        public Room(byte number) : this()
        {
            this.Number = number;
        }
        public byte Number { get; }
        public int Count => this.Patients.Count;
        public IReadOnlyCollection<Patient> Patients
        {
            get
            {
                return this.patients;
            }
        }
        public void AddPatient(Patient patient)
        {
            if (this.Count < MAX_CAPACITY)
            {
                this.patients.Add(patient);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in this.patients)
            {
                sb.AppendLine(patient.ToString());
            }

            return sb.ToString();
        }
    }
}
