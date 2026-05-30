using TechTalk.SpecFlow;
using calculadora.Core; // separacion de la logica del negocio para probar la funcionalidad 
using Xunit;

namespace calculadora.Tests.Steps;

[Binding]
public class calculadoraGPASteps
{
    private int[] _creditos = Array.Empty<int>();
    private int[] _grades = Array.Empty<int>();
    private decimal _resultGpa;
    
    private readonly calculadoraGPA _calculadora = new calculadoraGPA();

    [Given(@"un estudiante con los siguientes creditos de cursos: (.*)")]
    public void GivenUnEstudianteConLosSiguientesCreditos(string creditosStr)   // transforma los creditos de los cursos especificados en ..gpafeature.cs a int
    {
        _creditos = creditosStr.Split(',').Select(c => int.Parse(c.Trim())).ToArray(); 
    }

    [Given(@"el estudiante obtuvo las siguientes calificaciones: (.*)")]
    public void GivenElEstudianteObtuvoLasSiguientesCalificaciones(string notasStr) // transforma los grados de los cursos especificados en ..gpafeature.cs a int 
    {
        _grades = notasStr.Split(',').Select(n => int.Parse(n.Trim())).ToArray(); // arreglo de enteros 
    }

    [When(@"el sistema calcula el GPA final")]
    public void WhenElSistemaCalculaElGpaFinal()
    {
        _resultGpa = _calculadora.calcularGPA(_creditos, _grades);
    }

    [Then(@"el resultado del GPA debe ser (.*)")]
    public void ThenElResultadoDelGpaDebeSer(decimal expectedGpa)
    {
        // Validamos que el resultado de la lógica coincida con el esperado (redondeado a 2 decimales)
        Assert.Equal(expectedGpa, Math.Round(_resultGpa, 2));
    }
}