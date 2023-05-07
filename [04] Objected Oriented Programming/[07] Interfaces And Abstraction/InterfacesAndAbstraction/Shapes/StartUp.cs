using Shapes;

Tesla tesla = new Tesla("wHITE", "Model x", 63);
Seat seat = new Seat("White", "Leon");

Car car = new Car("Red","BWM");
ICar asd = car;
asd.Stop();
void MyMethod(ICar car)
{
    string startResult = car.Start();
    Console.WriteLine(startResult);
}