#include <iostream>
#include <string>  
#include "Account.h"
using namespace std;

int main() {
	Account a1(500);
	cout << "a1 have $" << a1.getBalance() << endl;

	Account a2(-1);
	cout << "a2 have $" << a2.getBalance() << endl;

	cout << "\nAdding $200 to a2" << endl;
	a2.Credit(200);
	cout << "a2 have $" << a2.getBalance() << endl;

	cout << "Removing $200 from a1" << endl;
	a1.Debit(200);
	cout << "a1 have $" << a1.getBalance() << endl;
}