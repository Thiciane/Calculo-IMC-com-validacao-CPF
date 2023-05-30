public class Pessoa
{
    private string nome;
    public string Nome 
    {
        get { return nome; }
        set { nome = value; }
    }
    private string cpf;
    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }
    private int idade;
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }
    private string sexo;
    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }
    private double peso;
    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    private double altura;
    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public Pessoa(string nome, string cpf, int idade, string sexo, double peso, double altura)
    {
        
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public (double, string, string) ImcCal()
    {
        double imc = peso/ (altura * altura);
        if(imc < 18.5)
        {
            return (imc, "MAGREZA", "0");
        }
        else if(imc > 18.5 && imc < 24.9)
        {
            return (imc, "NORMAL", "0");
        }
        else if(imc > 25.0 && imc < 29.9)
        {
            return (imc, "SOBREPESO", "I");
        }
        else if(imc > 30.0 && imc < 39.9)
        {
            return (imc, "OBESIDADE", "II");
        }
        else if(imc > 40.0)
        {
            return (imc, "OBESIDADE GRAVE", "III");
        }
        else
        {
            return (imc, "OBESIDADE GRAVISSIMA ", "III");
        }
    }
}