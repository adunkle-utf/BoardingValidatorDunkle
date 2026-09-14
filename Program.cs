// Week 3: Animal Boarding Validator
// Validate animal boarding requests using control structures

using System;

// Title
Console.WriteLine("=== Animal Boarding System ===");

// Request animal name
Console.Write("Enter an animal name: ");
string nameInput = Console.ReadLine();

// Request animal size
Console.Write("Enter an animal size (small/medium/large): ");
string sizeInput = Console.ReadLine().ToLower();

// Request eating habits data
Console.Write("Is this animal a carnivore? (yes/no): ");
string habitsInput = Console.ReadLine().ToLower();

// Request boarding count
Console.Write("How many are boarding: ");
int countInput = Convert.ToInt32(Console.ReadLine());

// Boarding data output title
Console.WriteLine("\n=== Boarding Decision ===");

// Declare status strings
string status = string.Empty;
string floorStatus = string.Empty;
string carnivoreStatus = string.Empty;
string rejectionMessage = string.Empty;

// Handle logic for animal rejection
if (sizeInput == "large" && countInput >= 3) {

    // Status data
    status = "REJECTED";
    // Prepare rejection message
    rejectionMessage = $"Maximum 2 large animals allowed.  You requested {countInput}";

} else if (sizeInput == "large" && countInput <= 2) {
    
    // Status data
    floorStatus = "Floor 1";
    status = "APPROVED";

} else if (sizeInput == "medium" && countInput >= 11) {

    // Status data
    status = "REJECTED";
    // Prepare rejection message
    rejectionMessage = $"Maximum 10 medium animals allowed.  You requested {countInput}";

} else if (sizeInput == "medium" && countInput <= 10) {

    // Status data
    floorStatus = "Floor 2";
    status = "APPROVED";

} else if (sizeInput == "small" && countInput >= 51) {

    // Status data
    status = "REJECTED";
    // Prepare rejection message
    rejectionMessage = $"Maximum 10 medium animals allowed.  You requested {countInput}";

} else if (sizeInput == "small" && countInput <= 50) {

    // Status data
    floorStatus = "Floor 3";
    status = "APPROVED";

}

// Display animal name
Console.WriteLine($"Animal: {nameInput}");

// Display animal status
Console.WriteLine($"Status: {status}");

// Display IF approved
if (status == "APPROVED") {

    // Display floor assingment
    Console.WriteLine($"Floor Assignment: {floorStatus}");

    // Display warning for carnivores
    if (habitsInput == "yes") {
        Console.WriteLine("WARNING: Carnivore - requires seperate housing from prey animals");
    }

} else {

    // Display rejection message
    Console.WriteLine($"Reason: {rejectionMessage}");
    
}
