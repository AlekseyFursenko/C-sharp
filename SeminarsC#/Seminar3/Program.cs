/*
int FindQuard(int x, int y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;

    return -1;
}

int result = FindQuard(-2,0);
if (result == -1) 
{
    Console.WriteLine("Данная точка находится на осях");

}
else
{
    Console.WriteLine($"Точка находится в {result} четверти");
}
*/
void FindCoord(int q)
{
    if(q == 1 ) Console.WriteLine("x>0 and y>0");
    if(q == 2 ) Console.WriteLine("x<0 and y>0");
    if(q == 3 ) Console.WriteLine("x<0 and y<0");
    if(q == 4 ) Console.WriteLine("x>0 and y<0");
    if (q<0 ^ q> 4) Console.WriteLine("wrong quater number");
}

FindCoord(5);

void Sqrt(int n)
{
    int count = 1;
    while(count <=n)
    {
        Console.Write(count*count + " ");
        count ++;
    }
}

Sqrt(10);
