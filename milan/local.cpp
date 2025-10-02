#include<iostream.h>
#include<conio.h>
int main()
{
    class Local
    {
        public:
        int x;
        void set(int v){x=v;}
        void show(){cout<<x;}
    };
    Local o;
    int v;
    clrscr();
    cin>>v;
    o.set(v);
    o.show();
    getch();
    return 0;
}
