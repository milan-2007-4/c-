#include<iostream.h>#include<iostream.h>
#include<conio.h>
int main()
{
    int i;
    clrscr();
    for(i=1;i<=10;i++)
    {
        cout<<i<<" ";
    }
    getch();
    return 0;
}

#include<conio.h>
int main()
{
    int n,i;
    clrscr();
    cin>>n;
    int arr[100];
    for(i=0;i<n;i++)
    {
        cin>>arr[i];
    }
    for(i=0;i<n;i++)
    {
        cout<<arr[i]<<" ";
    }
    getch();
    return 0;
}
