#include<iostream.h>
#include<conio.h>
void swapv(int &a,int &b)
{
    int t=a;
    a=b;
    b=t;
}
int main()
{
    int a,b;
    clrscr();
    cin>>a>>b;
    swapv(a,b);
    cout<<a<<" "<<b;
    getch();
    return 0;
}
