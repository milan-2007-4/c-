#include<iostream.h>
#include<conio.h>
class E
{
    public:
    void set(int v){x=v;}
    void show(){cout<<x;}
    private:int x;
};
int main()
{
    E e;
    void (E::*pm)(int)=&E::set;
    void (E::*ps)()=&E::show;
    clrscr();
    (e.*pm)(7);
    (e.*ps)();
    getch();
    return 0;
}
