float nh, sh, y, salarybonus, salary;
//nh=number of hours sh=salary per hour salarybonus or salarybasic
const int yl = 10;
// minimum time for salarybonus 35TDN = 10 years
Console.WriteLine("Enter your number of hours");
 nh = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your Salary per Hour");
sh = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your worked years");
y = float.Parse(Console.ReadLine());
salary = nh * sh;
salarybonus = nh * sh + 35;
if (y <= yl) Console.WriteLine("Your salary without bonus is" + salary);
else if (y > yl) Console.WriteLine("Your salary with bonus is" + salarybonus); 

