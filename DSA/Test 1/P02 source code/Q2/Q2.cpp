#include <iostream>
#include "PQueue.h"
int main()
{
	PQueue q;
	q.enqueue("A", 10);
	q.enqueue("B", 4);
	q.enqueue("C", 6);
	q.enqueue("D", 3);
	q.enqueue("E", 5);
	q.print();
}
