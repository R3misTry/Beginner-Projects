#include <iostream>
using namespace std;

int main(){
	int a,c;
	char b='+,-,*,/';
	cout <<"Enter the first number : "<< endl;
	cin >>a;
	cout <<"\nEnter operator (+,-,*,/) : "<< endl;
	cin >>b;
	cout <<"\nEnter the second number : "<< endl;
	cin >>c;
	
	if(b=='+'){
		cout<<"Total : "<<a+c<< endl;
	}
	else if(b=='-'){
		cout<<"Total : "<<a-c<< endl;
	}
	else if(b=='*'){
		cout<<"Total : "<<a*c<< endl;
	}
	else if(b=='/'){
		cout<<"Total : "<<a/c<< endl;
	}
	else
	cout<<"Error!"<< endl;
	
	return 0;
}
