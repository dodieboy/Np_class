#include <iostream>
#include "Employee.h"
using namespace std;

int main() {
	Employee e1("Alan", "Tan", 1000);
	cout << e1.GetFirstName() << " " << e1.GetLastName() << " yearly salary is: $" << e1.GetSalary() * 12 << endl;;
	Employee e2("Sam", "Tan", 1200);
	cout << e2.GetFirstName() << " " << e2.GetLastName() << " yearly salary is: $" << e2.GetSalary() * 12 << endl;;

	cout << "\nAdding 10% salary raise..." << endl;
	e1.SetSalary(e1.GetSalary() * 1.1);
	e2.SetSalary(e2.GetSalary() * 1.1);
	cout << e1.GetFirstName() << " " << e1.GetLastName() << " yearly salary is: $" << e1.GetSalary() * 12 << endl;
	cout << e2.GetFirstName() << " " << e2.GetLastName() << " yearly salary is: $" << e2.GetSalary() * 12 << endl;
}