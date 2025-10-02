#include<iostream.h>
#include<conio.h>
int add(int a,int b=5)
{
    return a+b;
}
int main()
{
    int a;
    clrscr();
    cin>>a;
    cout<<add(a);
    getch();
    return 0;
}
