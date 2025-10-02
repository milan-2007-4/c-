#include<iostream.h>
#include<conio.h>
class P
{
    public:
    int x;
    void show(){cout<<x;}
};
void print(P p)
{
    p.show();
}
int main()
{
    P p;
    clrscr();
    cin>>p.x;
    print(p);
    getch();
    return 0;
}
