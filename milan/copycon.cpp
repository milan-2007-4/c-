#include<iostream.h>
#include<conio.h>
class Copy
{
    int x;
    public:
    Copy(int v=0){x=v;}
    Copy(const Copy &c){x=c.x;}
    int get(){return x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    Copy a(v);
    Copy b=a;
    cout<<b.get();
    getch();
    return 0;
}
