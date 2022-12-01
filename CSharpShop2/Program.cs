// See https://aka.ms/new-console-template for more information
using CSharpShop2;

Acqua Bottiglia1 = new Acqua("Sant'Anna", "Acqua Minerale", 0.20f, 22, 1.5f, 6.9f, "Sant'Anna");
Bottiglia1.Stampa();

Bottiglia1.BeviAcqua(1);
Bottiglia1.Stampa();

Bottiglia1.RiempiBottiglia(0.7f);
Bottiglia1.Stampa();

Bottiglia1.SvuotaBottiglia();
Bottiglia1.Stampa();


