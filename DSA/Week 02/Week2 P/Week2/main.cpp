#include <iostream>
#include "main.h"
#include "List.h"
#include "Person.h"
#include <string>
using namespace std;

string menu() {
	string option;
	cout << "----------------Main Menu------------------ -\n[1] List the phone numbers\n[2] Add a new contact\n[3] Remove a contact\n[4] Search for a phone number\n[0] Exit\n----------------------------------------------\nEnter your option : ";
	cin >> option;
	return option;
}
void listPhone(List c) {
	if (c.getLength() <= 0) {
		cout << "Contact list is empty" << endl;
		return;
	}
	c.print();
}
void addContact(List* c) {
	string name;
	string tel;
	cout << "Please enter a name: ";
	cin >> name;
	cout << "Please eneter the tel number: ";
	cin >> tel;
	c->add(Person(name, tel));
}
void removeContact(List* c) {
	if (c->getLength() <= 0) {
		cout << "Contact list is empty" << endl;
		return;
	}
	string name;
	cout << "Please enter the name of the contact you want to remove: ";
	cin >> name;
	for (int i = 0; i < c->getLength(); i++) {
		if (name == c->get(i).getName()) {
			c->remove(i);
			cout << "Contact is removed" << endl;
		}
		else if (i == c->getLength()-1) {
			cout << "Error: invaild contact! Contact cannot be find" << endl;
		}
	}
}
void searchContact(List c) {
	if (c.getLength() <= 0) {
		cout << "Contact list is empty" << endl;
		return;
	}
	string name;
	cout << "Please enter the name of the contact you want to find: ";
	cin >> name;
	for (int i = 0; i < c.getLength(); i++) {
		if (name == c.get(i).getName()) {
			cout << "Contact found!\nName: " << c.get(i).getName() << " \nTelNo: " << c.get(i).getTelNo() << endl;
		}
		else if (i == c.getLength() - 1) {
			cout << "Error: invaild contact! Contact cannot be find" << endl;
		}
	}
}

int main() {
	List contact;
	while (true)
	{
		string option = menu();
		if (option == "0") {
			return false;
		}
		else if (option == "1") {
			listPhone(contact);
		}
		else if (option == "2") {
			addContact(&contact);
		}
		else if (option == "3")
		{
			removeContact(&contact);
		}
		else if (option == "4") {
			searchContact(contact);
		}
		else
		{
			cout << "Error: invaild input, pls try agian!" << endl;
		}
	}
}

