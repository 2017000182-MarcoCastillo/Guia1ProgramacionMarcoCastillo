Algoritmo sin_titulo
	Definir a, b, c Como Real
	
    Escribir "Ingrese el primer ángulo:"
    Leer a
    Escribir "Ingrese el segundo ángulo:"
    Leer b
    Escribir "Ingrese el tercer ángulo:"
    Leer c
	
    Si (a + b + c <> 180) Entonces
        Escribir "No es un triángulo válido"
    Sino
        Si (a = b Y b = c) Entonces
            Escribir "Triángulo equilátero"
        Sino
            Si (a = b O a = c O b = c) Entonces
                Escribir "Triángulo isósceles"
            Sino
                Escribir "Triángulo escaleno"
            FinSi
        FinSi
    FinSi
FinAlgoritmo
