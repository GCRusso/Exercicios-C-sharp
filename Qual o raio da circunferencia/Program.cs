Console.WriteLine($"Qual o raio da circunferencia?: ");
Double raio = Double.Parse(Console.ReadLine());

// para descobrir o diametro e o raio * 2
Double diametro = (2 * raio);
// math.round ele arredonda os numeros que serao apresentados 
// math.pi e a funcao que chama o numero PI, tem que ser a funcao Double para utilizar o Math.pi
Double perimetro = Math.Round(diametro * Math.PI);
// Math.pow e utilizado para potencia, essa mesma funcao poderia ser utilizada da seguinte forma:
// (raio * raio) ou se caso quisesse elevar a 3 seria (raio * raio * raio) e assim sucessivamente
Double area = Math.Round(Math.PI * Math.Pow(raio, 2));


Console.WriteLine($"O diametro da circunferencia e de {diametro} o perimetro e de {perimetro} e a area {area}! ");
