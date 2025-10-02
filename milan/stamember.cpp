#include<iostream.h>
#include<conio.h>
class S
{
    public:
    static int cnt;
    static int get(){return cnt;}
};
int S::cnt=5;
int main()
{
    clrscr();
    cout<<S::get();
    getch();
    return 0;
}
