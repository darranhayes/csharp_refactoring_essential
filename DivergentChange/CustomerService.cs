namespace DivergentChange;

using System;
using System.Text.RegularExpressions;

public class EmailValidator
{
    public bool IsValidEmail(string email)
    {
        if (email == null)
        {
            return false;
        }

        return Regex.IsMatch(
            email,
            @"^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+$");
    }
}

public class CustomerDisplayFormatter
{
    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }
}

public class LoyaltyService
{
    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return numberOfPurchases * 10;
    }
}

public class CustomerService
{
    private readonly EmailValidator _emailValidator = new EmailValidator();
    private readonly CustomerDisplayFormatter _customerDisplayFormatter = new CustomerDisplayFormatter();
    private readonly LoyaltyService _loyaltyService = new LoyaltyService();

    public bool IsValidEmail(string email)
    {
        return _emailValidator.IsValidEmail(email);
    }

    public string FormatDisplayName(string firstName, string lastName)
    {
        return _customerDisplayFormatter.FormatDisplayName(firstName, lastName);
    }

    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return _loyaltyService.CalculateLoyaltyPoints(numberOfPurchases);
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        if (daysSinceLastLogin > 365)
        {
            return "INACTIVE";
        }
        else if (daysSinceLastLogin > 30)
        {
            return "DORMANT";
        }

        return "ACTIVE";
    }
}