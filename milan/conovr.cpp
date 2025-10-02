#include<iostream.h>
#include<conio.h>
class O
{
    int x;
    public:
    O(){x=0;}
    O(int v){x=v;}
    int get(){return x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    O a;
    O b(v);
    cout<<a.get()<<" "<<b.get();
    getch();
    return 0;
}
