#pragma once
#include <iostream>
#include "List.h"
using namespace std;

class main
{
public:
	main();
	int menu();
	void listPhone(List c);
	void addContact(List* c);
	void removeContact();
	void searchContact();
};