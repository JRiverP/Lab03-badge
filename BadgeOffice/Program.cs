
using System.Globalization;
using System.Runtime.Intrinsics.X86;

System.Console.WriteLine("Provide your Full name: ");
string fullName = Console.ReadLine();

fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);


char firstInitial = Convert.ToChar(fullName.Substring(0, 1));

char lastInitial = Convert.ToChar(fullName.Substring(4, 1));

// int lastInitialPosition = fullName.IndexOf("4");
// string lastInitial = fullName.Substring(lastInitialPosition, 4);

int CharacterCount = Convert.ToInt32(lastName.Length) ; 


System.Console.WriteLine("Name on badge: " + fullName.ToUpper() );

System.Console.WriteLine("Username: " + firstInitial + lastName.ToLower());

System.Console.WriteLine("Initials: " + Convert.ToString(firstInitial).ToUpper() + "." + Convert.ToString(lastInitial).ToUpper() + "." );

System.Console.WriteLine("Letters in last name: " + CharacterCount );

//moving onto Part 2 

Random rng = new Random(); 

int StudentID = Convert.ToInt32(rng.Next(100000, 1000000));

int LockerNumber = Convert.ToInt32(rng.Next(1, 501));

System.Console.WriteLine("Student ID: " + StudentID );
System.Console.WriteLine("Locker: " + LockerNumber);

//Moving onto Part 3 

System.Console.WriteLine("What is the Dorms (x)? ");
int DormX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("What is the Dorms (Y)? ");
int DormY = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("What is the classrooms (X)? ");
int ClassroomX = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("What is the classrooms (Y)? ");
int ClassroomY = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("What is the Students Walking speed? ");
Double WalkingSpeed = Convert.ToDouble(Console.ReadLine());

Double Distance = Math.Sqrt(Math.Pow((ClassroomX - DormX), 2) + Math.Pow((ClassroomY - DormY), 2));

Double WalkingTime = (Distance / WalkingSpeed) ;  
Double WalkingFinalTime = Math.Floor(WalkingTime / 60) ; 

int WalkingRemainder = Convert.ToInt32(WalkingTime % 60) ;



System.Console.WriteLine("Distance: " + Distance.ToString("F1"));

System.Console.WriteLine("Walking time: " + WalkingFinalTime + " minutes " + WalkingRemainder + " seconds"); 

// Move onto Part 4 

int CheckDigit = StudentID % 9; 

System.Console.WriteLine("==================================");
System.Console.WriteLine(("ETSU STUDENT BADGE").PadLeft(26) );
System.Console.WriteLine("==================================");
System.Console.WriteLine("Name " + Convert.ToString(fullName.ToUpper()).PadLeft(17) );

System.Console.WriteLine("USERNAME " + Convert.ToString(firstInitial).PadLeft(2) + lastName.ToLower());

System.Console.WriteLine("ID " + Convert.ToString(StudentID).PadLeft(13) + "-" + CheckDigit );
//System.Console.WriteLine("ID " + StudentID + "-" + StudentID % 9 );
System.Console.WriteLine("LOCKER " + Convert.ToString(LockerNumber).PadLeft(6));

System.Console.WriteLine("Walk: " + Convert.ToString(WalkingFinalTime).PadLeft(5) + " min " + WalkingRemainder + " sec");
System.Console.WriteLine("==================================");