#include "ListApp.h"
#include "List.h"
int main() {
	List nameList;
	nameList.add("Annie");
	nameList.add("Jacky");
	nameList.add("Wendy");
	nameList.print();
	nameList.add(1,"Brenda");
	nameList.print();
	nameList.remove(3);
	nameList.print();
	nameList.remove(1);
	nameList.print();
}