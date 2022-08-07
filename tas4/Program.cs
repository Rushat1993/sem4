
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = 0;
 
while (numberN >=10){
     sum=sum+numberN%10;
     
      numberN = numberN/10;
}
  sum = sum + numberN;
Console.WriteLine("Сумма цифр с учетом: " + sum);