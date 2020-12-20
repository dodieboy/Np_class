#include <iostream>
#include "List.h"

using namespace std;
int main()
{
	// List can be pointer-based or array-based
	List aList;

	// create a list 10 -> 20 -> 30 -> 40 -> 50 -> 60
	for (int i = 10; i <= 60; i += 10)
		aList.add(i);

	cout << "Given list\n";
	// output should be 10 20 30 40 50 60
	aList.print();

	aList.rotate(4);

	cout << "Rotated list\n";
	// output should be 50 60 10 20 30 40
	aList.print();

	return 0;
}
