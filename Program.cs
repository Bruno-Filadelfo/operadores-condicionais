Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a") {
    Console.WriteLine("vogal");
}

else if (letra == "e") {
    Console.WriteLine("vogal");
}

else if (letra == "i") {
    Console.WriteLine("vogal");
}

else if (letra == "o") {
    Console.WriteLine("vogal");
}

else if (letra == "u") {
    Console.WriteLine("vogal");
}

else {
    Console.WriteLine("Não é vogal!");
}

////

Console.WriteLine("Digite uma letra!");
string letraa = Console.ReadLine();

if (letraa == "a" ||
    letraa == "e" ||
    letraa == "i" ||
    letraa == "o" ||
    letraa == "u") {
        Console.WriteLine("vogal");
    }

else {
    Console.WriteLine("Não é vogal");
}   


////

switch (letra) {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("vogal");
    break;

    default:
    Console.WriteLine("Não é vogal");
    break;
}





