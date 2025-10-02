#include<iostream.h>
#include<conio.h>
class Outer
{
    public:
    class Inner
    {
        public:
        int x;
        void show(){cout<<x;}
    };
};
int main()
{
    Outer::Inner in;
    clrscr();
    cin>>in.x;
    in.show();
    getch();
    return 0;
}
