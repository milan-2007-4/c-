#include<iostream.h>
#include<conio.h>
class C
{
    int x;
    public:
    void setx(int v);
    void show();
};
void C::setx(int v)
{
    x=v;
}
void C::show()
{
    cout<<x;
}
int main()
{
    C c;
    int v;
    clrscr();
    cin>>v;
    c.setx(v);
    c.show();
    getch();
    return 0;
}
