namespace calculadora.Core;

public class calculadoraGPA  
{
    public decimal calcularGPA(int[] creditosH, int[] gradeP) // horas de credito - puntos de grado 
    {
        int total_gp = 0;
        int total_ch = 0;

        for (int i = 0; i < creditosH.Length; i++)
        {
            total_gp += creditosH[i] * gradeP[i];
            total_ch += creditosH[i];
        }
        
        if (total_ch == 0) return 0;

        return (decimal)total_gp / total_ch;
    }
}
