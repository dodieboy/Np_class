#pragma once
#include <iostream>
using namespace std;

typedef string ListType;

class Person
{
	private:
		ListType name;
		ListType telNo;
	public:
		Person();
		Person(ListType n, ListType t);
		void setName(ListType n);
		ListType getName();
		void setTelNo(ListType t);
		ListType getTelNo();
};

