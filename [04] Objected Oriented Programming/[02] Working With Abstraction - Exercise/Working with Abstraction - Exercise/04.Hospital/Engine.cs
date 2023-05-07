using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Hospital
{
    public class Engine
    {
        private const int MAX_CAPACITY = 3;
        private readonly List<Department> departments;
        private readonly List<Doctor> doctors;

        public Engine()
        {
            this.departments = new List<Department>();
            this.doctors = new List<Doctor>();
        }
        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();

                string departamentName = tokens[0];
                string doctorFirstName = tokens[1];
                string doctorLastName = tokens[2];
                string doctorFullName = doctorFirstName + doctorLastName;

                string patientName = tokens[3];

                if (!DoctorExist(doctorFullName))
                {
                    this.doctors.Add(new Doctor(doctorFirstName, doctorLastName));
                }
                if (!DepartmentExist(departamentName))
                {
                    this.departments.Add(new Department(departamentName));
                }

                Department department = this.departments.FirstOrDefault(d => d.Name == departamentName);
                Doctor doctor = this.doctors.FirstOrDefault(d => d.FullName == doctorFullName);
                bool isThereFreePlace = department.Rooms.Any(r => r.Count < MAX_CAPACITY);


                if (isThereFreePlace)
                {
                    Room firstFreeRoom = department.GetFirstFreeRoom();

                    Patient patient = new Patient(patientName);

                    firstFreeRoom.AddPatient(patient);
                    doctor.AddPatient(patient);
                }

                command = Console.ReadLine();

                while (command != "End")
                {
                    string[] args = command.Split();

                    if (args.Length == 1)
                    {
                        Room[] rooms = (Room[])this.departments.FirstOrDefault(d => d.Name == command).Rooms;

                        foreach (var room in rooms)
                        {
                            Console.WriteLine(room);
                        }
                    }
                    else if (args.Length == 2 && int.TryParse(args[1], out int roomNum))
                    {
                        Room room = this.departments.FirstOrDefault(d => d.Name == command).Rooms.FirstOrDefault(r => r.Number == roomNum);

                        string[] output = room.ToString().Split(Environment.NewLine).OrderBy(r => r).ToArray();

                        foreach (var pat in output)
                        {
                            Console.WriteLine(pat);
                        }
                    }
                    else
                    {
                        string fullname = args[0] + args[1];
                        Doctor currDoctor = doctors.FirstOrDefault(d => d.FullName == fullname);

                        foreach (var patient in doctor.Patients)
                        {
                            Console.WriteLine(patient);
                        }

                    }
                    command = Console.ReadLine();
                }
            }
        }
        private bool DoctorExist(string name)
        {
            return this.doctors.Any(d => d.FullName == name);
        }
        private bool DepartmentExist(string name)
        {
            return this.departments.Any(d => d.Name == name);
        }
    }
}
