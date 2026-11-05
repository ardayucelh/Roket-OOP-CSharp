namespace RoketOOP;

/// <summary>
/// OOP çalışması için roket bilgilerini ve temel davranışlarını temsil eder.
/// </summary>
public class Roket
{
    public string Model { get; private set; }
    public int UretimYili { get; private set; }
    public int Hiz { get; private set; }
    public int MaxHiz { get; private set; }
    public bool TankBosaltildiMi { get; private set; }

    public Roket(string model, int uretimYili, int maxHiz)
    {
        Model = model;
        UretimYili = uretimYili;
        Hiz = 0;
        MaxHiz = maxHiz;
        TankBosaltildiMi = false;
    }

    public string HizArtir(int artisMiktari)
    {
        if (TankBosaltildiMi)
        {
            return "Yakıt deposu boşaltıldığı için roketin hızı artırılamaz.";
        }

        if (artisMiktari <= 0)
        {
            return "Hız artış miktarı sıfırdan büyük olmalıdır.";
        }

        Hiz = Hiz + artisMiktari;

        if (Hiz > MaxHiz)
        {
            Hiz = MaxHiz;
        }

        return "Roket hızı güncellendi.";
    }

    public void TankiBosalt()
    {
        TankBosaltildiMi = true;
    }

    public override string ToString()
    {
        string tankDurumu = TankBosaltildiMi ? "Boşaltıldı" : "Dolu";
        return $"Model: {Model} ({UretimYili})\nHız: {Hiz} km/sa\nMaksimum hız: {MaxHiz} km/sa\nYakıt deposu: {tankDurumu}";
    }
}
