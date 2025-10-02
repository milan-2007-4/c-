#include<iostream.h>
#include<conio.h>
class ConstC
{
    int x;
    public:
    ConstC(int v){x=v;}
    int get() const {return x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    ConstC c(v);
    cout<<c.get();
    getch();
    return 0;
}
