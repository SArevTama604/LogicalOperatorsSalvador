internal class Program
{
    private static void Main(string[] args)
    {
        bool isOver18 = true;
        bool hasMembership = true;
        bool canEnterClub = isOver18 && hasMembership;

        if (canEnterClub)
        {
            Console.WriteLine("The user can enter the club.");
        }
        else
        {
            Console.WriteLine("The user cannot enter the club.");
        }

        int num = 6;
        bool isEven = num % 2 == 0;
        bool isPositive = num > 0;
        bool isEvenAndPositive = isEven && isPositive;
        Console.WriteLine($"Is 'num' even and positive? {isEvenAndPositive}");

        string input = "moderator";
        bool isAdmin = input == "admin";
        bool isModerator = input == "moderator";
        bool isAuthorized = isAdmin || isModerator;
        Console.WriteLine($"Is the user authorized? {isAuthorized}");

        int age = 21;
        bool isAgeAtLeast18 = age >= 18;
        bool isAgeMost100 = age <= 100;
        bool isEligibleToVote = isAgeAtLeast18;
        Console.WriteLine($"Is the person eligible to vote? {isEligibleToVote}");

        bool isOnline = true;
        bool isloggedIn = true;
        bool canAccess = isOnline && isloggedIn;
        Console.WriteLine($"Can the user access? {canAccess}");

        int PlayerScore = 1200;
        bool isHighScore = PlayerScore > 1000;
        bool isLowScore = PlayerScore < 500;
        bool isHighOrLowScore = isHighScore || isLowScore;
        Console.WriteLine($"Is the player's score a high or low score? {isHighOrLowScore}");

        bool hasPaid = false;
        bool isTrialExpired = false;
        bool canAccessWithPayment = hasPaid;
        bool canAccessWithTrial = !isTrialExpired;
        bool canAccessContent = canAccessWithPayment || canAccessWithTrial;
        Console.WriteLine($"Can the user access content? {canAccessContent}");

        bool a = true;
        bool b = false;
        bool c = false;
        bool result = (a && b) || c;
        Console.WriteLine(result);

        bool hasAccessCard = true;
        bool hasBiometricScan = true;
        int securityClearanceLevel = 4;
        bool canEnter = hasAccessCard || hasBiometricScan || securityClearanceLevel >= 3;
        bool canProceedToLevel2 = hasBiometricScan;
        bool canProceedToLevel3 = securityClearanceLevel >= 3;
        Console.WriteLine("Level 1 - Can Enter: " + canEnter);
        Console.WriteLine("Level 2 - Can proceed (Biometric Scan): " + canProceedToLevel2);
        Console.WriteLine("Level 3 - Can Proceed (Security Clearance): " + canProceedToLevel3);
        

        
 