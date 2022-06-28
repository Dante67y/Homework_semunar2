int h, a, b, t, h1;
h = 10;
a = 3;
b = 2;
h1 = 0;
t = 0;
while (h1 < h){
    t++;
    h1 = h1 + a;
    if (h1 == h)
    break;
    h1 = h1 -b;
}
Console.WriteLine(t);
