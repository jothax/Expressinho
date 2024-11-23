namespace Expressinho.Domain.Commands.Contracts
{
    public interface ICommand 
    {
        bool Validate();
    }
}