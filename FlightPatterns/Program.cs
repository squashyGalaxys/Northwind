using FlightPatterns;

Passanger[] passangers = new Passanger[]
{
    new FirstClassPassanger {AirMiles = 1_419, Name = "Susan"},
    new FirstClassPassanger {AirMiles = 16_419, Name = "Lucy"},
    new BusinessClassPassanger {Name = "John"},
    new CoachClassPassanger {Name = "Mary", CarryOnKG = 25.5},
    new CoachClassPassanger {Name = "Tom", CarryOnKG = 0}
};

foreach (var passanger in passangers)
{
    decimal ticketPrice = passanger switch
    {
        FirstClassPassanger p => p.AirMiles switch
        {
            > 35_000    => 1_500M,
            > 15_000    => 1_750M,
            _           => 2_000M
        },
        BusinessClassPassanger p                        => 1_000M,
        CoachClassPassanger p when p.CarryOnKG < 10.0   => 500M,
        CoachClassPassanger p                           => 650M,
        _                                               => 800M
    };
    Console.WriteLine($"Flight costs {ticketPrice:C} for {passanger}");

    //Om ni vill undvika nested switch statements ni kan skriva FirstClass så här:
    //FirstClassPassanger {AirMiles: > 35000 }    => 1500M,
    //FirstClassPassanger { AirMiles: > 15000 }   => 1750M,
    //FirstClassPassanger                         => 2000M,
}