#include<iostream.h>
#include<conio.h>
class A1
{
    public:
    int a;
    A1(int v=0){a=v;}
};
class B1
{
    public:
    int b;
    B1(int v=0){b=v;}
};
class C1:public A1,public B1
{
    public:
    C1(int x,int y):A1(x),B1(y){}
};
int main()
{
    int x,y;
    clrscr();
    cin>>x>>y;
    C1 c(x,y);
    cout<<c.a<<" "<<c.b;
    getch();
    return 0;
}
