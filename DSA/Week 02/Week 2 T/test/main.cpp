
#include <iostream>
#include "List.h"
using namespace std; 

int main() {
	List test;
	test.add(20);
	test.print();
	test.add(0, 30);
	test.print();
	test.add(10);
	test.print();
	test.add(2, 50);
	test.print();
	test.add(1, 40);
	test.print();
	test.remove(1);
	test.print();
	test.remove(2);
	test.print();
}