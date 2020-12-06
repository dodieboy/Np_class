#include<string>
#include<iostream>
using namespace std;

//Calculates the value of a given integer raised to the power of a second integer  
//param a – the base integer (to be raised to a power).
//param n – the power
//pre: a > 0
//post: return the value of a raised to the nth power.

long power(int a, int n) {
	if (n < 1)
		return 1;
	return a * power(a, n - 1);
}

//print the numbers in an array in the backward manner
//param array – the array in concern
//param n – number of elements in the array

void printBackward(int array[], int n) {
	if (n < 1)
		return;
	cout << array[n - 1] <<endl;
	printBackward(array, n - 1);
}

//return the maximum value in an array of integers
//param array – the array in concern
//param start – start index of the array
//param end   – last index of the array

int maxArray(int array[], int start, int end) {
	if (array[start] > array[0])
		array[0] = array[start];
	if (start == end)
		return array[0];
	maxArray(array, start + 1, end);
}


int main() {
	cout << power(2, 0) << endl;
	cout << power(2, 1) << endl;
	cout << power(2, 2) << endl;
	cout << power(2, 3) << endl;

	cout << "========================" << endl;
	int a[5] = { 1, 2, 3, 4, 5 };
	int b[4] = { 9, 8, 7, 6 };
	int c[1] = { 8 };
	printBackward(a, 5);
	cout << "========================" << endl;
	
	printBackward(b, 4);
	cout << "========================" << endl;
	cout << maxArray(a, 0, 4) << endl;;
	cout << "========================" << endl;
	cout << maxArray(b, 0, 3) << endl;;
	cout << "========================" << endl;
	cout << maxArray(c, 0, 0) << endl;;
	return -1;
}