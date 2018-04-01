using System;
namespace Interfaces
{
    public interface IAnimal
    {
        void Describe();

        string Name
        {
            get;
            set;
        }
    }
}
