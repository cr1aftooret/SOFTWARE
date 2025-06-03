#include <iostream>
#include <string>

int main()
{
    long long int n;
    std::cout << "¿é¤Jn=";
    std::cin >> n;

	long long int a = 1, b = 1, c = 1, d = 0;
	long long int e = 1, f = 1, g = 1, h = 0;

    for (int i = 1; i < n; i++) {
		long long int tmp_a = a * e + b * g;
		long long int tmp_b = a * f + b * h;
		long long int tmp_c = c * e + d * g;
		long long int tmp_d = c * f + d * h;
		a = tmp_a;
		b = tmp_b;
		c = tmp_c;
		d = tmp_d;
    }

	std::string tabs = "\t";
	for (int i = 0; i < n/15; i++) {
		tabs += "\t";
	}


	std::cout << " " << n << "\t " << a << "\t" << b << std::endl;
	std::cout << "A   =\t[" + tabs +"  ]\n";
	std::cout << "\t " << c << "\t" << d << std::endl;
	system("pause");
	return 0;
}