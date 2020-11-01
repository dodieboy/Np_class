#include "Person.h"
#include <iostream>
using namespace std;

Person::Person() {}
Person::Person(ListType n, ListType t) {
	name = n;
	telNo = t;
}
void Person::setName(ListType n) {
	name = n;
}
ListType Person::getName() {
	return name;
}
void Person::setTelNo(ListType t) {
	telNo = t;
}
ListType Person::getTelNo() {
	return telNo;
}

