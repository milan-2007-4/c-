#include<iostream.h>
#include<conio.h>
class Count
{
    public:
    static int cnt;
    Count(){cnt++;}
};
int Count::cnt=0;
int main()
{
    Count a,b;
    clrscr();
    cout<<Count::cnt;
    getch();
    return 0;
}
