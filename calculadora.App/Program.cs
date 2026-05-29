using calculadora.Core;

class Ejecutable
{
    static void Main(string[] args)
    {
        //Estudiante y cursos 
        string estudiante = "Tomas Suarez";
        string curso1 = "Ingles 101";
        string curso2 = "Algebra 101";
        string curso3 = "Biologia 101";
        string curso4 = "Cs de la computacion";
        string curso5 = "Psicologia 101";

        // Creditos de cada curso
        int creditoC1 = 3;
        int creditoC2 = 3;
        int creditoC3 = 4;
        int creditoC4 = 4;
        int creditoC5 = 3;

        // Asignacion de grades 
        int gradeA = 4; 
        int gradeB = 3; 

        int gradoC1 = gradeA; 
        int gradoC2 = gradeB;
        int gradoC3 = gradeB; 
        int gradoC4 = gradeB; 
        int gradoC5 = gradeA; 

        Console.WriteLine($"Student: {estudiante}\n"); 
        Console.WriteLine("Course \t\t\t Grade \t\t Credit Hours"); 
        Console.WriteLine($"{curso1}  \t\t {gradoC1} \t\t\t {creditoC1}"); 
        Console.WriteLine($"{curso2}  \t\t {gradoC2} \t\t\t {creditoC2}"); 
        Console.WriteLine($"{curso3}  \t\t {gradoC3} \t\t\t {creditoC3}"); 
        Console.WriteLine($"{curso4}  \t {gradoC4} \t\t\t {creditoC4}"); 
        Console.WriteLine($"{curso5}  \t {gradoC5}  \t\t\t {creditoC5}");  

        // Agrupamos los datos para enviarlos a nuestra librería lógica
        int[] creditos = { creditoC1, creditoC2, creditoC3, creditoC4, creditoC5 };
        int[] grades = { gradoC1, gradoC2, gradoC3, gradoC4, gradoC5 };

        // Instancio la clase creada en el Core
        var calculadora = new calculadoraGPA(); 
        decimal prom_GP = calculadora.calcularGPA(creditos, grades);

        // Mantengo la logica de sumatoria visual para la consola
        int totalGP = (creditoC1*gradoC1) + (creditoC2*gradoC2) + (creditoC3*gradoC3) + (creditoC4*gradoC4) + (creditoC5*gradoC5); 
        int totalCH = creditoC1 + creditoC2 + creditoC3 + creditoC4 + creditoC5;

        Console.WriteLine($"\nTotal: \t\t\t {totalGP}\t\t\t{totalCH}");

        // Obtengo el digito entero, y primer y segundo decimal para truncar el resultado de GPA. 
        int leadingDigit = (int)prom_GP;  
        int firstDigit = (int)(prom_GP * 10) % 10; 
        int secondDigit = (int)(prom_GP * 100) % 10; 

        Console.Write($"\nFinal GPA: {leadingDigit}.{firstDigit}{secondDigit}\n");
    }
}
