int x = 1;
int y = 0;

int quarternum = 0;
if (x > 0 && y > 0) quarternum = 1;
if (x < 0 && y > 0) quarternum = 2;
if (x < 0 && y < 0) quarternum = 3;
if (x > 0 && y < 0) quarternum = 4;
Console.WriteLine(quarternum);