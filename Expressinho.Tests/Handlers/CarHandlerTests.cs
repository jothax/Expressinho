
using Expressinho.Domain.Commands;
using Expressinho.Domain.Handlers;
using Expressinho.Tests.Repositories;
using Expressinho.Viagem.Domain.Commands;

/* [TestClass]
public class CarHandlerTests
{
    public static readonly Guid _validIdMotorist = Guid.NewGuid();
    private readonly CreateCarCommand _validCommand = new CreateCarCommand("modelo","2001","11111",_validIdMotorist);
    private readonly CreateCarCommand _invalidCommand = new CreateCarCommand(string.Empty,string.Empty,string.Empty,_validIdMotorist);
    private  CarHandler _handler = new CarHandler(new FakeCarRepository());
    private  GenericCommandResult _result = new GenericCommandResult();

    public CarHandlerTests()
    {

    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void Dado_um_command_invalido_o_carro_nao_deve_ser_criado()
    {
        _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
        
        Assert.AreEqual(_result.Sucess, false);
    } 
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void Dado_um_command_valido_o_carro_deve_ser_criado()
    {
        _result = (GenericCommandResult)_handler.Handle(_validCommand);
        Assert.AreEqual(_result.Sucess, true);
    }
} */