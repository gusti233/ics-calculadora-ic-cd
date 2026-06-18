# Escrito en lenguaje natural Gherkins 

Feature: calculadora GPA
  Para llevar el seguimiento del rendimiento de los estudiantes
  Como sistema de calificaciones
  Quiero calcular el GPA exacto basado en créditos y notas

Scenario: Calcular el GPA de Tomas Suarez
  Given un estudiante con los siguientes creditos de cursos: 3, 3, 4, 4, 3
  And el estudiante obtuvo las siguientes calificaciones: 4, 3, 3, 3, 4
  When el sistema calcula el GPA final
  Then el resultado del GPA debe ser 3.50
  