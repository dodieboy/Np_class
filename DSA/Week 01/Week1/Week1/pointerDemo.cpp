#include <iostream>
using namespace std;

int main() {
	int value1 = 200000;
	int value2;
	int* ptr;

	ptr = &value1;
	cout << "Ptr value : " << *ptr << endl;;

	ptr = &value2;
	cout << "Ptr value : " << *ptr << endl;;

	ptr = &value1;
	cout << "Ptr value : " << &value1 << endl;;
	cout << "Ptr value : " << &ptr << endl;;

	ptr = &value2;
	*ptr += 2000;
	cout << "Ptr value (value 2) : " << *ptr << endl;;
	ptr = &value1;
	cout << "Ptr value (value 1): " << *ptr << endl;;
}