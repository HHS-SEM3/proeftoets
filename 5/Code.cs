
class HotelKamer {
    public List<Gast> BezetDoorGasten;
    public int Verdieping;
    public int Nummer;
}

class Gast {
    public HotelKamer BezetKamer;
    public List<HotelKamer> GeinteresseerdIn;
    public string Naam;
}
