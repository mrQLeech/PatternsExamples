using DifficultLibrary;
using System;

namespace FacadeObject
{
    public class Facade
    {
        private DifficultObjectA _objectA;
        private DifficultObjectB _objectB;


        public Facade(DifficultObjectA object1, DifficultObjectB object2)
        {
            _objectA = object1;
            _objectB = object2;
        }


        public void Operate()
        {
            Console.WriteLine("Facade operating");
            _objectA.OperationA();
            _objectB.OperationB();
        }
    }
}
