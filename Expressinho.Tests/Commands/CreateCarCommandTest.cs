using System.Runtime.Intrinsics.Arm;
using Expressinho.Domain.Commands;
using Expressinho.Domain.Entities;

    /* [TestClass]
    public class CreateCarCommandTest
    {
        private readonly CreateCarCommand _command = new CreateCarCommand("Modelo","year","plate", new Motorist());
        
        [TestMethod]
        [TestCategory("Commands")]
        public void Dado_um_valor_nulo_ou_vazio_deve_falhar()
        {
            var commandEmpty = new CreateCarCommand(string.Empty, _command.Year, _command.Plate, _command.IdMotorist);
            var commandNull = new CreateCarCommand(null, _command.Year, _command.Plate, _command.IdMotorist); 
            commandEmpty.Validate();
            commandNull.Validate();
            Assert.AreEqual(false, commandNull.IsValid);
            Assert.AreEqual(false, commandEmpty.IsValid);  
        }

        [TestMethod]
        [TestCategory("Commands")]
        public void Dado_todos_os_parametros_corretos_deve_passar()
        {
            var command = new CreateCarCommand(_command.Model, _command.Year, _command.Plate, Guid.Empty); 
            command.Validate();
            Assert.AreEqual(true, command.IsValid);  
        }
    } */
