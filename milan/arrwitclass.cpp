#include<iostream.h>
#include<conio.h>
class Arr
{
    int a[5];
    public:
    void set()
    {
        for(int i=0;i<5;i++)
        {
            cin>>a[i];
        }
    }
    void show()
    {
        for(int i=0;i<5;i++)
        {
            cout<<a[i]<<" ";
        }
    }
};
int main()
{
    Arr A;
    clrscr();
    A.set();
    A.show();
    getch();
    return 0;
}
