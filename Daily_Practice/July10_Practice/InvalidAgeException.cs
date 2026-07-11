//Om Prashant Gond IT SSGMCE July 10
using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException() : base("Invalid age provided.")
    {
    }

    public InvalidAgeException(string message) : base(message)
    {
    }

    public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}