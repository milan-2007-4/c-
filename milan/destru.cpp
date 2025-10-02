#include<iostream.h>
#include<conio.h>
class Des
{
    public:
    Des()
    {
        cout<<"constructed";
    }
    ~Des()
    {
        cout<<"destructed";
    }
};
int main()
{
    clrscr();
    Des d;
    getch();
    return 0;
}
