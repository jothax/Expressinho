using System.Runtime.Intrinsics.Arm;
using Expressinho.Domain.Commands;

namespace Expressinho.Tests.Commands
{
    [TestClass]
    public class CreateCarCommandTest
    {
        private readonly CreateCarCommand _command = new CreateCarCommand("Modelo","year","plate", Guid.NewGuid());
        
        [TestMethod]
        [TestCategory("Commands")]
        public void Dado_um_valor_nulo_ou_vazio_deve_falhar()
        {
            var command = new CreateCarCommand(string.Empty, _command.Year, _command.Plate, _command.IdMotorist); 
            command.Validate();
            Assert.AreEqual(false, command.IsValid);  
        }

        [TestMethod]
        [TestCategory("Commands")]
        public void Dado_todos_os_parametros_corretos_deve_passar()
        {
            var command = new CreateCarCommand(_command.Model, _command.Year, _command.Plate, Guid.Empty); 
            command.Validate();
            Assert.AreEqual(true, command.IsValid);  
        }
    }
}