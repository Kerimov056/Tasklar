#region fesiller

//Console.WriteLine("Bir ay daxil edin:");
//string ay = "Mart";


//if (ay == "Mart" || ay == "aprel" || ay == "may")
//{
//    Console.WriteLine("bu yaz aylarindandir");
//}
//else if (ay == "iyun" || ay == "iyul" || ay == "avqust")
//{
//    Console.WriteLine("bu yay aylarindandir");
//}
//else if (ay == "sentyabr" || ay == "oktyabr" || ay == "noyabr")
//{
//    Console.WriteLine("bu payiz aylarindandir");
//}
//else if (ay == "dekabr" || ay == "yanvar" || ay == "fevral")
//{
//    Console.WriteLine("bu qis aylarindandir");
//}
//else
//{
//    Console.WriteLine("Duzgun ay daxil edin:");
//}

#endregion
#region 3cu deyiwen olmadan deyerleri deyiwme
/*
int a = 4;
int b = 6;

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine("a nin sonraki deyeri:"+a);
Console.WriteLine("b nin sonraki deyeri:"+b);
*/
#endregion
#region facktorial

//int fack = 5;
//int son = 1;
//for (int i = 1; i <= fack; i++)
//{
//    son = son * i;
//}
//Console.WriteLine(son);

#endregion
#region  n tam ededinden m ededine qeder olan tek ededlerin cemini ekrana yazdirin

//int n = 12;
//int m = 21;
//int cem = 0;
//for (int i = n; i <= m; i++)
//{
//    if (i <= 0) continue;
//    if (i % 2 == 1)
//    {
//        cem += i;
//    }
//}
//Console.WriteLine(cem);

#endregion
#region Verilmish ededin 3-un quvveti olub-olmamasini tapin.

//int num = 243;
//if (num % 3 == 1 || num % 3 == 2 || num == 2 || num < 0)
//{
//    Console.WriteLine("bu eded 3un quvveti deyil:");
//}
//else if (num % 3 == 0)
//{
//    for (int i = num; num % 3 == 0; num /= 3)
//    {

//    }
//    if (num == 1)
//    {
//        Console.WriteLine("bu eded 3 un quvvetidir:");
//    }
//    else Console.WriteLine("bu eded 3un quvveti deyil:");

//}

#endregion
#region input:233.23 >>tamHisse:3 kesrHisse:2
/*
                      //1ci yolu
double num = 23.32;
int i = 1;
int tamSay = 0;
int j = 0;
int kesrSay = 0;
int c = -1;
if (num > 0)
{
    while (i < num)
    {
        num /= 10;
        tamSay++;
    }
    while (j < num)
    {
        num *= 10;
        if (num % 10 < 1)
        {
            break;
        }
        kesrSay++;
    }
}
if (num < 0)
{
    while (c>num)
    {
        num /=10;
        tamSay++;
    }
    while (j > num)
    {
        num *= 10;
        if (num % 10 > -1) { break; }
        kesrSay++;
    }
}
kesrSay = kesrSay - tamSay;
Console.WriteLine("ededin tam hissesinin sayi:"+tamSay);
Console.WriteLine("ededin kesr hissesinin sayi:"+kesrSay);



                    //2ci yolu
double num = 23.45;
int say = 0;
int i = 1;
while (i<num)
{
    i *= 10;
    say++;
}
Console.WriteLine("ededin tam hiseesinin sayisi"+say);
say = 0;
while (num % 1 !=0)
{
    say++;
    num*=10;
}
Console.WriteLine("ededin kesr hissesinin sayi:"+say);
#endregion
#region array max deeyri
/*
int[] arr = { 2, 32, 32,232, 12, 54 };
int maxArr = arr[0];
for (int i = 0;i< arr.Length;i++)
{
    if (arr[i] > maxArr)
    {
        maxArr= arr[i];
    }
}
    Console.WriteLine(maxArr);
*/
#endregion
#region eded sade yoxsa murekkeb oldugunu tapmaq
/*
int num = 13;
int bolen = 2;
bool yoxla=true;
while (bolen < num)
{
    if (num%bolen==0)
    {
        yoxla = false;
        Console.WriteLine("bu eded murekkebdir:");
        break;
    }
    bolen++;
}
if (yoxla == true)
{
    Console.WriteLine("bu eded sade edddir:");
}
*/
#endregion
#region input:234 >>2+3+4=9

//int num = 234;
//int cem = 0;
//int i = 1;
//int say = 0;
//int n;
//while (i < num)
//{
//    i *= 10;
//    say++;
//}
//for (int j = 0; j < say; j++)
//{
//    n = num % 10;
//    cem = cem + n;
//    num /= 10;
//}
//Console.WriteLine(cem);

#endregion
#region 7ye bolur bolmurse en yaxin bolenneri:
/*
int num = 53;
int m;
if (num % 7 == 0)
{
    Console.WriteLine("bu eded 7'e bolunur ve cavabi:" + num / 7);
}
else {
  m= num%7;
 if (m < 4)
    {
        num = num - m;
        Console.WriteLine(num);
    }
    else if (m == 4)
    {
        num = num - m;
        Console.WriteLine(num);
        num +=7;
        Console.WriteLine(num);
    }
    else if (m > 4)
    {
        m = 7 - m;
        num = num + m;
        Console.WriteLine(num);
    }
}
*/
#endregion
#region ededin sayinin hasili

//int num = 0;
//int say = 0;
//int i = 1;
//int a = 0;
//int hasil = 1;
//while (i < num)
//{
//    i *= 10;
//    say++;
//}
//for (int j = 0; j < say; j++)
//{
//    a = num % 10;
//    hasil = hasil * a;                                    
//    num /= 10;
//}
//Console.WriteLine(hasil);

#endregion
#region 3 və ya 5-in qatları
/*
int num = 10;
int cem = 0;
    for (int i =0; i<num;i++)
    {
       for (int j = i; j%3==0||j%5==0; j++)
       {
          cem += j;
          break;
       }
    }
          Console.WriteLine(cem);
*/
#endregion
#region fibanocii

//int num=10;
//int n1 = 0;
//int n2 = 1;
//int n3;
//for (int i = 2; i < num; i++)
//{
//    n3 = n1 + n2;
//    Console.WriteLine(n3);
//    n1= n2;
//    n2= n3;
//}

#endregion
#region 1 ve 10 arasi ededlerin kvadrat cemi ve ceminin kvadrati
/*
int num = 10;
int kvadrati = 1;
int cemKvadrat = 0;
int cem = 0;
int tamCem = 0;
for (int i = 1; i <= num; i++)
{
    kvadrati = i * i;
    cemKvadrat = cemKvadrat + kvadrati;
}

for (int i = 0; i <= num; i++)
{
    cem += i;
}
cem *= cem;
tamCem = cem - cemKvadrat;
Console.WriteLine(tamCem);
*/
#endregion
#region ededin eveline 3 daxil et 529 >>3529

//int num = 529;
//int i = 1;
//int say = 0;
//int n = 1;
//int son = 3;
//while (i < num)
//{
//    i *= 10;
//    say++;
//}
//for (int j = 0; j < say; j++)
//{
//    n *= 10;
//}
//son *= n;
//son += num;
//Console.WriteLine(son);

#endregion
#region ededin en boyuk sade bolenin tap
/*
int num = 144;
int maxSadeKesr = 0;
for (int i = 2; i<=num; i++)
{
    while (num % 2 == 0)
    {
     break;
    }  
    if (num % i == 0)
    {
        num /= i;
        maxSadeKesr = i;
    }
}
        Console.WriteLine(maxSadeKesr);
//*/
#endregion
#region sade yoxsa murekkeb eded
/*
int num = 24;
int bolen = 2;
bool yoxvar = true;
while (num>bolen)
{
    if (num%bolen==0)
    {
        yoxvar = false;
        Console.WriteLine("MUREKKEBDIR:");
        break;
    }
    bolen++;
}
if (yoxvar==true)
{
    Console.WriteLine("SADEDIR");
}
*/
#endregion
#region eddin icinde 2 reqemin hasilinin en boyuyun tap

//string num = "20912";
//int maxDeyerr = num[0];
//for (int i = 0;i < num.Length; i++)
//{
//      if (num[i]>maxDeyerr)
//      {
//          maxDeyerr = num[i];
//      }
//}
//int say = Int32.Parse(maxDeyerr);
//Console.WriteLine(maxDeyerr);
#endregion
#region 5 array girn ve hamisni artan sira ile duzun
/*
int[] arr= new int[5];
for (int i = 0;i < arr.Length; i++)
{
    Console.WriteLine("arreyin ededini daxil edin:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0;j< arr.Length; j++)
{
    for (int e = j+1; e < arr.Length; e++)
    {
        if (arr[j] > arr[e])
        {

            arr[j] = arr[e] + arr[j];
            arr[e] = arr[j] - arr[e];
            arr[j] = arr[j] - arr[e];
        }
    }
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}
*/
#endregion
#region 5 telebenin 2 quzi bir final imtahanin balinin sinif ortalamsi..
/*
int[,] arr = new int[5, 3];
float ortalama = 0;
for (int i = 0;i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Telebenin ballarini daxil edin:" + (i + 1, j + 1));
        arr[i, j]=Convert.ToInt32(Console.ReadLine());
    }
    ortalama += arr[i, 0] * 0.2f + arr[i, 1] * 0.2f + arr[i, 2] * 0.6f;
}
ortalama /= 5;
Console.WriteLine("sinifin ortalamasi:"+ortalama);
*/
#endregion
#region arreydeki en boyuk reqemi tapin:
/*
int[] num = { 23, 32, 33, 43, 40, 99, -123,-1230123 };
int max = num[0];
for (int i = 1; i < num.Length; i++)
{
    if (max < num[i])
    {
        max = num[i];
    }
}
Console.WriteLine(max);

*/
#endregion
#region ucbucaqin terflerine gore tipini muyen edin:
/*
int a, b, c;

Console.WriteLine("ucbucagin a terefini girin:");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ucbucagin b terefini girin:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ucbucagin c terefini girin:");
c = Convert.ToInt32(Console.ReadLine());


if(c> a + b || b > a + c || a >  c + b)
{
    Console.WriteLine("bele ucbucaq mumkun deyil:");
}
else if(a==b && b==c)
{
    Console.WriteLine("beraber terefli ucbucaq:");
}
else if((a==b && a!=c) || (a==c && a!=b) || (c==b && c!=a))
{
    Console.WriteLine("beraber yanli ucbucaq:");
}
else if(a + b > c || a + c > b || c + b > a)
{
    if (a!=b && b!=c )
    {
        Console.WriteLine("muxtelif terefli ucbucaq:");
    }
}
else if(c*c == a * a + b * b || a*a == c * c + b * b || b*b == a * a + c * c)
{
    Console.WriteLine("duzbucaqli ucbucaq:");
}
*/
#endregion
#region ATM'Den cekilen 200,100,50,20,10,5 sekilinde megblegi vermek
/*
Console.WriteLine("Cekmek isdeiyiniz meblegi daxil edin:");
int pul=Convert.ToInt32(Console.ReadLine());
int ikiyuz = 0, yuz = 0, elli = 0, iyirmi = 0, on = 0, bew = 0;

do
{
    if (pul % 5 != 0)
    {
        Console.WriteLine("sizzze yalniz 5lik  say sisteminden para vere bileriz");
    }
} while (pul%5!=0);

while (pul>200)
{
    pul -= 200;
    ikiyuz++;
}
while (pul > 100)
{
    pul -= 100;
    yuz++;
}
while (pul > 50)
{
    pul -= 50;
    elli++;
}
while (pul > 20)
{
    pul -= 20;
    iyirmi++;
}
while (pul > 10)
{
    pul -= 10;
    on++;
}
while (pul>=5)
{
    pul -= 5;
    bew++;
}
Console.WriteLine("bu kadar 200luk: " + ikiyuz);
            Console.WriteLine("bu kadar 100luk: " + yuz);
            Console.WriteLine("bu kadar 50lik: "  + elli);
            Console.WriteLine("bu kadar 20lik: "  + iyirmi);
            Console.WriteLine("bu kadar 10luq: "  + on);
            Console.WriteLine("bu kadar 5lik: "   + bew);
           
*/
#endregion
//#region fibanoci again

//long num = 8;
//long num1 = 0;
//long num2 = 1;
//long num3;


//for (int i = 2; i < num; i++)
//{
//    num3 = num1 + num2;
//    num1 = num2;
//    num2 = num3;
//    Console.WriteLine(num3);
//}

//#endregion
#region arreyi artan sira ile duzun
/*
int[] arr = {3,24,23,4,1,41,249};
for (int i = 0; i < arr.Length; i++)
{
    for (int j =i+1; j <arr.Length; j++)
    {
        if (arr[j] > arr[i])
        {
            arr[j] = arr[j] + arr[i];
            arr[i] = arr[j] - arr[i];
            arr[j]= arr[j] - arr[i];
        }
    }
}
*/
#endregion
#region Ededlerin Tersine Cevirme
//int number = -231;
//int tersNumber = 0;

//if (number > 0)
//{
//    while (number > 0)
//    {
//        int onluqNumbers = number % 10;
//        tersNumber = tersNumber * 10 + onluqNumbers;
//        number /= 10;
//    }
//}
//else
//{
//    while (number < 0)
//    {
//        int onluqNumbers = number % 10;
//        tersNumber = tersNumber * 10 + onluqNumbers;
//        number /= 10;
//    }
//}
//
//Console.WriteLine(tersNumber);

#endregion
#region Sinifde qalib qalmama 

//Console.WriteLine("Testlerin bal'ini yazin:");
//int test = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Final bal'ini yazin:");
//int final = Convert.ToInt32(Console.ReadLine());

//if (test < 0 || test > 100 || final < 0 || final > 100)
//{
//    Console.WriteLine("Duzgun bal daxil etmediniz. Zehmet olmasa 0 ile 100 arasin bir bal daxil edin!!!");
//}
//else
//{
//    if (test < 40)
//    {
//        Console.WriteLine("Test baliniz 40'tan az olduğuna gore sinifde qaldiniz.");
//    }
//    else
//    {
//        double ortalama = (test * 0.4) + (final * 0.6);

//        if (ortalama >= 60)
//        {
//            Console.WriteLine($"Ortalamanız {ortalama} ve sinifi kecdiniz!");
//        }
//        else
//        {
//            Console.WriteLine($"Ortalamanız {ortalama} ve sinide qaldiniz.");
//        }
//    }
//}

#endregion




//1ci gun
#region Task 1 Ucus Bileti

//int yas, km, tip;
//double fiyat;
//double km_parasi = 12.10;

//int count = 0;

//do
//{
//    if (count != 0) Console.WriteLine("Inputlari duzgun daxil edin");

//    Console.WriteLine("Yasinizi girin:");
//    yas = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Nece Km yol qet edeceksiniz:");
//    km = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("1 - Yalniz gedis\n2 - Gedis ve Donus:");
//    tip = Convert.ToInt32(Console.ReadLine());
//    count++;
//}
//while ((yas < 0 || km < 0) || (tip != 1 && tip != 2));


//fiyat = km * km_parasi;
//if (yas < 12)
//{
//    fiyat -= (fiyat * 0.5);
//}
//else if (yas > 12 && yas < 24)
//{
//    fiyat -= (fiyat * 0.1);
//}
//else if (yas > 65)
//{
//    fiyat -= (fiyat * 0.3);
//}

//if (tip == 2) fiyat -= (fiyat * 0.2);

//Console.WriteLine($"Bilet Paraniz -- {fiyat}");

#endregion

#region Task 2 Vurma Cedveli
//for (int i = 1; i <= 10; i++)
//{
//    for (int a = 1; a <= 10; a++)
//    {
//        Console.WriteLine($"{i} * {a} = " + i * a);
//    }
//    Console.WriteLine("-------------------");
//}
#endregion

#region Task 3 //ucgen
//yari cugen
//int n = 5;

//for (int i = 1; i <= n; i++)
//{
//    Console.Write("*");
//    for (int k = 1; k <= 1 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//Tam Ucgen
//int n = 5; 

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= n - i; j++)
//    {
//        Console.Write(" ");
//    }

//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine(); 
//}

#endregion

#region Task 4 Amstrong
//153 = (1*1*1) + (5*5*5) + (3*3*3)
//371 = (3*3*3) + (7*7*7) + (1*1*1)

//int teklik, onluq, yuzluk, cem;
//for (int i = 100; i <= 999; i++)
//{
//    int fakeI = i;

//    teklik = fakeI % 10;
//    fakeI /= 10;

//    onluq = fakeI % 10;
//    fakeI /= 10;

//    yuzluk = fakeI % 10;
//    fakeI /= 10;

//    cem = (teklik * teklik * teklik) + (onluq * onluq * onluq) + (yuzluk * yuzluk * yuzluk);
//    if (cem == i)
//    {
//        Console.WriteLine($"Amstrong Reqemler : {i}");
//    }
//}
#endregion

#region Task 5 ATM
//string UserName = "Ker1mof";
//string Password = "Parol123";
//double balans = 123.2;

//Console.WriteLine("UserName daxil edin:");
//string? userName = Console.ReadLine();
//Console.WriteLine("Parolunuz'u daxil edin:");
//string? password = Console.ReadLine();

//bool prosess = true;

//while (prosess == true)
//{
//    Console.WriteLine();
//    Console.WriteLine();
//    Console.WriteLine("Her vaxtiniz xeyir xos gelmisiniz :)");

//    Console.WriteLine("1) Balansinizi artirin");
//    Console.WriteLine("2) Balansiniz'dan pul cekin");
//    Console.WriteLine("3) Balansiniz'a baxin");
//    Console.WriteLine("4) Cixis edin");
//    Console.WriteLine();
//    Console.WriteLine("Isdediyiz bir prosesi sece bilersiniz");
//    int islem = Convert.ToInt32(Console.ReadLine());

//    switch (islem)
//    {
//        case 1:
//            Console.WriteLine("Ne qeder pul daxil edeceksiniz");
//            int balansArtir = Convert.ToInt32(Console.ReadLine());
//            balans += balansArtir;
//            break;
//        case 2:
//            Console.WriteLine("Ne qeder pul cekmek isdeyirsiniz");
//            int pulCek = Convert.ToInt32(Console.ReadLine());
//            balans -= pulCek;
//            break;
//        case 3:
//            Console.WriteLine($"Balans : {balans}");
//            break;
//        case 4:
//            prosess = false;
//            break;
//        default:
//            Console.WriteLine("Duzgun islem secin");
//            break;
//    }

//}
//if(UserName!=userName || Password!=password) Console.WriteLine("UserName ve ya Password yalnisdir!!!");
#endregion

#region isPalindrom
//bool isPalindrom(int number)
//{
//    int temp, mertebe;
//    temp = number;

//    int fakePalindrom = 0;
//    while (temp != 0)
//    {
//        mertebe = temp % 10;
//        fakePalindrom = fakePalindrom * 10 + mertebe;
//        temp /= 10;
//    }
//    if (fakePalindrom == number) return true;
//    return false;
//}

//Console.WriteLine(isPalindrom(121));
#endregion
