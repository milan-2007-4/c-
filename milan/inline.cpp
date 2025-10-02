#include<iostream.h>
#include<conio.h>
inline int sq(int x)
{
    return x*x;
}
int main()
{
    int a;
    clrscr();
    cin>>a;
    cout<<sq(a);
    getch();
    return 0;
}
