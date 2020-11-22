#include "Queue.h"
#include "Customer.h"
#include <random>
#include <time.h>

int main() {
	int k;
	int t = 0;
	double ct = 0;
	Queue q;
	srand((unsigned) time(0));
	while (true)
	{
		k = rand() % 4;
		if (k == 1) {
			string name;
			cout << "Enter customer name :";
			cin >> name;
			Customer tmp(name, t);
			q.enqueue(tmp);
		}
		else if (k == 2) {
			string name;
			cout << "Enter customer name :";
			cin >> name;
			Customer tmp(name, t);
			q.enqueue(tmp);
			cout << "Enter customer name :";
			cin >> name;
			Customer tmp2(name, t);
			q.enqueue(tmp2);
		}
		t++;
		if (!q.isEmpty()) {
			Customer tmp;
			q.dequeue(tmp);
			cout << "Customer " << tmp.getName() << " was served in " << t - tmp.getQueueNum() << "min(s)" << endl;
			ct += (t - tmp.getQueueNum());
		}
		if (t == 10) {
			cout << "In the 10-min period, the average time to be served: " << ct / 10 << " mins" << endl;
			return false;
		}
	}
}