#include<iostream.h>
#include<conio.h>
class D
{
    public:
    int x;
};
int main()
{
    D obj;
    int D::*pm=&D::x;
    clrscr();
    obj.*pm=10;
    cout<<obj.x;
    getch();
    return 0;
}
