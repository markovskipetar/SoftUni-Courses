using Animals;

List<Animal> animals = new List<Animal>();

while (true)
{
    string animalType = Console.ReadLine();

    if (animalType == "Beast!")
    {
        break;
    }

    string[] animalData = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string name = animalData[0];
    int age = int.Parse(animalData[1]);
    string gender = animalData[2];

    switch (animalType)
    {
        case "Dog":
            Dog doggo = new Dog(name, age, gender);
            animals.Add(doggo);
            break;

        case "Frog":
            Frog froggo = new Frog(name, age, gender);
            animals.Add(froggo);
            break;

        case "Cat":
            Cat catto = new Cat(name, age, gender);
            animals.Add(catto);
            break;

        case "Tomcat":
            Tomcat tom = new Tomcat(name, age);
            animals.Add(tom);
            break;

        case "Kitten":
            Kitten kitto = new Kitten(name, age);
            animals.Add(kitto);
            break;
    }
}

foreach (var animal in animals)
{
    Console.WriteLine(animal.ToString());
}