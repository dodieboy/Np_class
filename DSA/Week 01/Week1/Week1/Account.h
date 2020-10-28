#pragma once
#include <string>
#include <iostream>
using namespace std;
class Account {
	private:
		double balance;
	public:
		Account();
		Account(double b) {
			if (b <= 0) {
				balance = 0;
				cout << "Invalid balance, setting current account balance to 0" << endl;
			}
			else {
				balance = b;
			}
		}
		double getBalance() {
			return balance;
		}
		void Credit(double b) {
			balance += b;
		}
		void Debit(double b) {
			if (balance <= b) {
				cout << "Debit amount exceeded account balance" << endl;
			}
			else {
				balance -= b;
			}
		}

};
