int FindQuarter(int a, int b)
{
    int x = a;
    int y = b;

    int quarternum = 0;

    if (x > 0 && y > 0) quarternum = 1;
    if (x < 0 && y > 0) quarternum = 2;
    if (x < 0 && y < 0) quarternum = 3;
    if (x > 0 && y < 0) quarternum = 4;

    return quarternum;
}

int x = -1;
int y = 1;

Console.WriteLine(FindQuarter(x, y));