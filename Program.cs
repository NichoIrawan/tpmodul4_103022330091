
using tpmodul4_103022330091;

//Soal Kode pos
KodePos[] listKodePos = new KodePos[11];

listKodePos[0] = new KodePos("Batununggal", "40266");
listKodePos[1] = new KodePos("Kujangsari", "40287");
listKodePos[2] = new KodePos("Mengger", "40267");
listKodePos[3] = new KodePos("Wates", "40256");
listKodePos[4] = new KodePos("Cijaura", "40287");
listKodePos[5] = new KodePos("Jatisari", "40286");
listKodePos[6] = new KodePos("Margasari", "40286");
listKodePos[7] = new KodePos("Sekejati", "40286");
listKodePos[8] = new KodePos("Kebonwaru", "40272");
listKodePos[9] = new KodePos("Maleer", "40274");
listKodePos[10] = new KodePos("Samoja", "40273");

Console.WriteLine("Kelurahan\t| Kode Pos");
Console.WriteLine("----------------|----------");

foreach (KodePos kodePos in listKodePos)
{
    if (kodePos.kelurahan.Length > 7)
    {
        Console.WriteLine(kodePos.kelurahan + "\t| " + kodePos.getKodePos());
    }
    else
    {
        Console.WriteLine(kodePos.kelurahan + "\t\t| " + kodePos.getKodePos());
    }
}

Console.WriteLine("\n");

//Soal state based
DoorMachine doorMachine = new DoorMachine();

doorMachine.reaksi();
doorMachine.putarKunci();
doorMachine.reaksi();
