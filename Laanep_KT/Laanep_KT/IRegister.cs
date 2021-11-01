using System;
namespace Laanep_KT
{
    public interface IRegister
    {
        public void AddCoin(decimal amount);
        public void AddCash(decimal amount);
        public void MakeInventory();
        public void PrintTotalMoney();
        public void PrintLastEnteredAmount();
    }
}
