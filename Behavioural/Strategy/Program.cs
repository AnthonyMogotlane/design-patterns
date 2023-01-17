Passenger passenger = new Passenger("Anthony");

passenger.Transportation =  new Bus();
Console.WriteLine(passenger.Transport());

passenger.Transportation =  new Taxi();
Console.WriteLine(passenger.Transport());


