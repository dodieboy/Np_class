#include "list.h"


int main() {
	//part a
	List a;
	int aa[7] = { 0,2,3,4,6,8,9 };
	for (int i = 0; i < 7; i++) {
		a.add(aa[i]);
	}

	a.sortedInsert(5);
	a.print();


	//part b
	List b;
	int bb[5] = { 24,25,70,80,90 };
	for (int i = 0; i < 5; i++) {
		b.add(bb[i]);
	}
	List c;
	int cc[5] = { 20,24,70,85,90 };
	for (int i = 0; i < 5; i++) {
		c.add(cc[i]);
	}

	List d;
	d.sortedMerge(b, c);
	d.print();


	return -1;
}