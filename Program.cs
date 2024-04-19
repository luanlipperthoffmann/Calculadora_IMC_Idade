int idade;                                   // Aqui são decladas a variável  do tipo inteiro para receber a idade informada;
float peso, imc, altura;                    // Aqui é declarada 3 variaveis do tipo float para receber os dados  de peso, altura e posteriormente o calculo do imc da pessoa;
string nome, repetir;                       // Aqui as variaveis recebem o nome da pessoal e a variavel repetir que vai definir se o programa vai ou nao sari do loop;

do          //loop do while para que o susario possa verificar multiplos imc's e pessoas
{
    System.Console.WriteLine("CALCULADORA IMC & IDADE");  //neste bloco até a linha 19 temos as entradas de nome, idade, peso, altura

    System.Console.WriteLine("Informe seu nome:");
    nome = Console.ReadLine();

    System.Console.WriteLine("Informe sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Informe seu peso em Kg:");
    peso = float.Parse(Console.ReadLine()); //Conversão Explicita

    System.Console.WriteLine("Informe sua altura em metros:");
    altura = float.Parse(Console.ReadLine()); //Conversão Explicita

    imc = peso / (altura*altura); //calculo do imc

    System.Console.WriteLine($"\n{nome} seu imc é de: {Math.Round(imc, 2)};"); //nesta linha linha ele printa o relário com as informações de nome e imc. O Math.Round(2) vai definir que na hora do print só havera duas casas devimais apos a virgula
    if (imc < 18.5)             //neste bloco ate a linha 42 ele vai fazer a verificação do imc e em qual categoria de sáude se enciaxa, 
    {
        System.Console.WriteLine("Voçê está abaixo do peso;");
    }
    else 
    {
        if (imc >= 18.5 && imc <= 24.9)
        {
            System.Console.WriteLine("Voçê está no peso normal;");
        }
        else if (imc >=25 && imc <=29.9)
        {
            System.Console.WriteLine("Voçê está acima do peso desejado;");
        }
        else if (imc >= 30)
        {
            System.Console.WriteLine("Voçê está obeso;");
        }
    }

    System.Console.WriteLine("Sua idade é de: " + idade + " anos;");  //aqui irá imprimir o relátorio com a idade do usuário
    if (idade <= 12)  //neste bloco até a linha 63 ele irá veiricar a idade e em qual faixa etária o usuário se encaixa
    {
        System.Console.WriteLine("Voçê é criança!");
    }
    else
    {
        if(idade >=13 && idade <=19)
        {
            System.Console.WriteLine("Voçê é jovem!");
        }
        else if (idade >=20 && idade <= 59)
        {
            System.Console.WriteLine("Voçê é adulto!");
        }
        else if( idade >=60)
        {
            System.Console.WriteLine("Voçê é idoso!");
        }
    }
    
    System.Console.WriteLine("\nDesejas calcular seu IMC e idade novamente? (S/N)");  //aqui ele irá solicitar ao usuário de ele deseja inserir novos dados
    repetir = Console.ReadLine().ToUpper();  //aqui colocqui  ToUpper() para tranformar oque foi digitado pelo usuário em maiúsculo
}
while (repetir == "S");  //Aqui se u susario inserir S de sim na linha 65 o programa irá voltar ao lopp na linha 5