#include<iostream.h>
#include<conio.h>
class Boss
{
    public:
    void f(){cout<<"f";}
    void g(){f();}
};
int main()
{
    Boss b;
    clrscr();
    b.g();
    getch();
    return 0;
}
