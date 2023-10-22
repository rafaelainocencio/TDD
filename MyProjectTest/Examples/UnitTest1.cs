namespace MyProjectTest.Exemples;

public class UnitTest1
{
    // Arrange, Act, Assert
    public void EstruturaAAA()
    {
        //Arrange - Preparar informação
        var cpf = "111.111.111.00";
        var expected = false;
        //Act - Agir a partir da informação preparada
        var resultado = true; //ValidaCpf(cpf);

        //Assert - Validar
        Assert.False(resultado);
        Assert.Equal(expected, resultado);
    }

    //Teste de 4 passos SEVT (Setup, Exercise, Verify, TearDown)
    public void Estrutura4Passos()
    {
        //Setup - Preparar informação
        var cpf = "111.111.111.00";
        var expected = false;
        //Exercise - Agir a partir da informação preparada
        var resultado = true;//ValidaCpf(cpf);

        //Verify - Validar
        Assert.False(resultado);
        Assert.Equal(expected, resultado);

        //TearDown - Tirar massa de testes
        cpf = null;
    }

    //Teste de 5 passos SAAAT ( Setup - preparar geral,
    //Arrange - preparar específico,
    //Act,
    //Assert,
    //TearDown)




    //TDD - Test Driven Development (Red(Falhar) - O que você deve testar
    //Green(Corrigir) - Como deve ser,
    //Refactor(Melhorar) - Revisar código)

}