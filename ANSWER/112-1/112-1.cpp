#include <iostream>  
#include <string>  
#include <algorithm>  

void f(std::string n, int round);  

int main()  
{  
   std::string n;
   std::cout << "¿é¤Jx1=";
   std::cin >> n;
   n = std::to_string(std::stoi(n));
   f(n, 2);
   std::cout << std::endl;
   system("pause");
   return 0;
}  

void f(std::string n, int round) {  
   std::string now_num = n;  
   std::sort(n.begin(), n.end());  
   std::string max_num = n;  
   std::reverse(max_num.begin(), max_num.end());  
   std::string min_num = n;  

   int diff = std::stoi(max_num) - std::stoi(min_num);  


   if (std::stoi(now_num) != diff) {

       if (round != 2) printf("\n");
       printf("x%d=%s-%s=%d¡A", round, max_num.c_str(), min_num.c_str(), diff);
       f(std::to_string(diff), round + 1);  
   } else {  
       printf("¶Â¬}¼Æ=%d", diff);  
       return;  
   } 
}