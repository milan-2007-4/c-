#include<iostream.h>
#include<conio.h>
class Param
{
    int x;
    public:
    Param(int v){x=v;}
    int get(){return x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    Param p(v);
    cout<<p.get();
    getch();
    return 0;
}
