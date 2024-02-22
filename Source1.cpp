//q:write a script that takes the height of students in a class and gives the tallest,shortest and average height of the class.
//a:
#include<iostream>	
using namespace std;
int main()
{
	int n,i;
	float h[100],tallest,shortest,average,sum=0;
	cout<<"Enter the number of students in the class: ";
	cin>>n;
	cout<<"Enter the height of the students in the class: ";
	for (i = 0; i < n; i++)
	{
		cin>>h[i];
	}
	tallest=h[0];
	shortest=h[0];
	for (i = 0; i < n; i++)
	{
		if (h[i] > tallest)
		{
			tallest=h[i];
		}
		if (h[i] < shortest)
		{
			shortest=h[i];
		}
		sum=sum+h[i];
	}
	average=sum/n;
	cout<<"The tallest student is "<<tallest<<" cm tall."<<endl;
	cout<<"The shortest student is "<<shortest<<" cm tall."<<endl;
	cout<<"The average height of the class is "<<average<<" cm."<<endl;
	return 0;
}
