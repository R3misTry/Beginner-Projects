#include "stdio.h"

int main(){
	float first,second;
	char oper;
	
	printf("Enter your first number : ");
	scanf("%f",&first);
	printf("Enter your operator : ");
	scanf("%s",&oper);
	printf("Enter your second number : ");
	scanf("%f",&second);
	
	switch(oper){
		case '+':
			printf("Result : %.4f",first+second);
			break;
		case '-':
			printf("Result : %.4f",first-second);
			break;
		case '/':
			printf("Result : %.4f",first/second);
			break;
		case '*':
			printf("Result : %.4f",first*second);
			break;
		default:
			printf("Error!");
			break;
	}
}
