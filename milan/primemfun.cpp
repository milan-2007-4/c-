#include<iostream.h>
#include<conio.h>
class emp
{
    private:
    void priv(){cout<<"private";}
    public:
    void call(){priv();}
};
int main()
{
    emp a;
    clrscr();
    a.call();
    getch();
    return 0;
}
