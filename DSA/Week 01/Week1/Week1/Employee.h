#pragma once
#include <string>    
using namespace std; 
class Employee {
	private:
		string firstName;
		string lastName;
		int salary;
	public:
		Employee();
		Employee(string f, string l, int s) {
			firstName = f;
			lastName = l;
			salary = s;
		}
		string GetFirstName() {
			return firstName;
		}
		string GetLastName() {
			return lastName;
		}
		int GetSalary() {
			return salary;
		}
		void SetFirstName(string f) {
			firstName = f;
		}
		void SetLastName(string l) {
			lastName = l;
		}
		void SetSalary(int s) {
			if (s <= 0) {
				salary = 0;
			}
			else {
				salary = s;
			}
		}
};