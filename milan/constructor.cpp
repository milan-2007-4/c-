#include<iostream.h>
#include<conio.h>
class Ex
{
    int x;
    public:
    explicit Ex(int v){x=v;}
    int get(){return x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    Ex e(v);
    cout<<e.get();
    getch();
    return 0;
}
