namespace ClubInterface
{
    internal interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string FullName();
    }
    /*

4. Add at least 3 public fields or properties to your new structure or class.

4. Add a default constructor and a parameterized constructor. NOTE: If you are creating a structure, do NOT add a default constructor (C# will do that for you!)

5. Create methods to display your new fields (it can be one method that displays everything or multiple methods, it is up to you).

6. In the Main method, create an object or structure variable. Add data to the fields or properties. Use the display methods to display the information in a Console.WriteLine statement.

7. Once you have the program working correctly, make sure you save all your changes.

8. Follow the directions to push your project to GitHub and add a link to your repository to the dropbox
     */
    public class Member : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public string MembershipTier { get; set; }
        public double MonthlyPayment { get; set; }

        //default constructor
        public Member()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        //paramaterized constructor
        public Member(int id, string firstName, string lastName, string membershipTier, double monthlyPayment)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MembershipTier = membershipTier;
            MonthlyPayment = monthlyPayment;
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual double Dues()
        {
            double cost = 0;
            switch (MembershipTier)
            {
                case "Basic":
                    cost = MonthlyPayment * 1;
                    break;
                case "Standard":
                    cost = MonthlyPayment * 2;
                    break;
                case "Premium":
                    cost = MonthlyPayment * 3;
                    break;
                default:
                    Console.WriteLine("invalid membership tier.");
                    break;
            }
            return cost;
        }

        private static void Main(string[] args)
        {
            //Member object
            Member holly = new(3, "Holly", "ByGolly", "Premium", 20);
            Console.WriteLine($"Member {holly.FullName()}'s monthly dues: {holly.Dues()}");

        }
    }
}


