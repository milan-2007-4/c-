#include<iostream.h>
#include<conio.h>
class F
{
    private:
    int x;
    public:
    F(int v){x=v;}
    friend void show(F &f);
};
void show(F &f)
{
    cout<<f.x;
}
int main()
{
    int v;
    clrscr();
    cin>>v;
    F f(v);
    show(f);
    getch();
    return 0;
}
