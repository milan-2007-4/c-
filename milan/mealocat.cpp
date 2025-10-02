#include<iostream.h>
#include<conio.h>
class Obj
{
    public:
    int x;
    Obj(int v){x=v;}
    void show(){cout<<x;}
};
int main()
{
    int v;
    clrscr();
    cin>>v;
    Obj *p=new Obj(v);
    p->show();
    delete p;
    getch();
    return 0;
}
