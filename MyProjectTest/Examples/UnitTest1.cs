namespace MyProjectTest.Exemples;

public class UnitTest1
{
    // Arrange, Act, Assert
    public void EstruturaAAA()
    {
        //Arrange - Preparar informa��o
        var cpf = "111.111.111.00";
        var expected = false;
        //Act - Agir a partir da informa��o preparada
        var resultado = true; //ValidaCpf(cpf);

        //Assert - Validar
        Assert.False(resultado);
        Assert.Equal(expected, resultado);
    }

    //Teste de 4 passos SEVT (Setup, Exercise, Verify, TearDown)
    public void Estrutura4Passos()
    {
        //Setup - Preparar informa��o
        var cpf = "111.111.111.00";
        var expected = false;
        //Exercise - Agir a partir da informa��o preparada
        var resultado = true;//ValidaCpf(cpf);

        //Verify - Validar
        Assert.False(resultado);
        Assert.Equal(expected, resultado);

        //TearDown - Tirar massa de testes
        cpf = null;
    }

    //Teste de 5 passos SAAAT ( Setup - preparar geral,
    //Arrange - preparar espec�fico,
    //Act,
    //Assert,
    //TearDown)




    //TDD - Test Driven Development (Red(Falhar) - O que voc� deve testar
    //Green(Corrigir) - Como deve ser,
    //Refactor(Melhorar) - Revisar c�digo)

}