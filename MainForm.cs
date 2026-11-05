namespace RoketOOP;

public class MainForm : Form
{
    private readonly ComboBox roketSecimi;
    private readonly NumericUpDown hizArtis;
    private readonly Label durumEtiketi;
    private readonly TextBox ciktiKutusu;
    private readonly Button hizArtirButonu;
    private readonly Button tankBosaltButonu;

    private readonly Roket[] roketler =
    {
        new Roket("SpaceX Falcon", 2010, 40000),
        new Roket("NASA Saturn V", 1967, 40000)
    };

    public MainForm()
    {
        Text = "Roket OOP Simülasyonu";
        Width = 560;
        Height = 430;
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        var baslik = new Label
        {
            Text = "ROKET SİMÜLASYONU",
            Left = 20,
            Top = 20,
            Width = 490,
            Height = 35,
            Font = new Font("Segoe UI", 16, FontStyle.Bold)
        };

        var roketEtiketi = new Label
        {
            Text = "Roket seç:",
            Left = 22,
            Top = 78,
            Width = 100
        };

        roketSecimi = new ComboBox
        {
            Left = 130,
            Top = 74,
            Width = 350,
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        roketSecimi.Items.AddRange(roketler.Select(r => $"{r.Model} ({r.UretimYili})").ToArray());
        roketSecimi.SelectedIndex = 0;
        roketSecimi.SelectedIndexChanged += (_, _) => DurumuGuncelle();

        var artisEtiketi = new Label
        {
            Text = "Hız artışı (km/sa):",
            Left = 22,
            Top = 123,
            Width = 110
        };

        hizArtis = new NumericUpDown
        {
            Left = 130,
            Top = 119,
            Width = 120,
            Minimum = 1,
            Maximum = 40000,
            Value = 1000,
            Increment = 500
        };

        hizArtirButonu = new Button
        {
            Text = "Hızı Artır",
            Left = 270,
            Top = 117,
            Width = 100,
            Height = 30
        };
        hizArtirButonu.Click += (_, _) => HizArtir();

        tankBosaltButonu = new Button
        {
            Text = "Tankı Boşalt",
            Left = 380,
            Top = 117,
            Width = 100,
            Height = 30
        };
        tankBosaltButonu.Click += (_, _) => TankiBosalt();

        durumEtiketi = new Label
        {
            Text = "Roket durumu:",
            Left = 22,
            Top = 170,
            Width = 450,
            Height = 25,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        ciktiKutusu = new TextBox
        {
            Left = 22,
            Top = 202,
            Width = 458,
            Height = 145,
            Multiline = true,
            ReadOnly = true,
            Font = new Font("Consolas", 11),
            ScrollBars = ScrollBars.Vertical
        };

        Controls.AddRange(new Control[]
        {
            baslik, roketEtiketi, roketSecimi, artisEtiketi,
            hizArtis, hizArtirButonu, tankBosaltButonu,
            durumEtiketi, ciktiKutusu
        });

        DurumuGuncelle();
    }

    private Roket SeciliRoket => roketler[roketSecimi.SelectedIndex];

    private void HizArtir()
    {
        string mesaj = SeciliRoket.HizArtir((int)hizArtis.Value);
        MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DurumuGuncelle();
    }

    private void TankiBosalt()
    {
        SeciliRoket.TankiBosalt();
        MessageBox.Show("Yakıt deposu boşaltıldı.", "Bilgi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        DurumuGuncelle();
    }

    private void DurumuGuncelle()
    {
        if (roketSecimi.SelectedIndex < 0)
        {
            return;
        }

        ciktiKutusu.Text = SeciliRoket.ToString();
        durumEtiketi.Text = $"{SeciliRoket.Model} - Güncel Durum";
        hizArtirButonu.Enabled = !SeciliRoket.TankBosaltildiMi;
        tankBosaltButonu.Enabled = !SeciliRoket.TankBosaltildiMi;
    }
}
