Algoritmo PromedioAlumno
	Definir cal1, cal2, cal3, cal4, cal5 Como Real
    Definir promedio Como Real
	
    Escribir "Ingrese la calificación 1:"
    Leer cal1
    Escribir "Ingrese la calificación 2:"
    Leer cal2
    Escribir "Ingrese la calificación 3:"
    Leer cal3
    Escribir "Ingrese la calificación 4:"
    Leer cal4
    Escribir "Ingrese la calificación 5:"
    Leer cal5
	
    promedio <- (cal1 + cal2 + cal3 + cal4 + cal5) / 5
	
    Escribir "El promedio es: ", promedio
	
    Si promedio >= 61 Entonces
        Escribir "El alumno APRUEBA"
    Sino
        Escribir "El alumno REPRUEBA"
    FinSi
FinAlgoritmo
