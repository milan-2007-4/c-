#include<iostream.h>
#include<conio.h>
struct Student
{
    int id;
    char name[20];
};
int main()
{
    Student s;
    clrscr();
    cin>>s.id>>s.name;
    cout<<s.id<<" "<<s.name;
    getch();
    return 0;
}
