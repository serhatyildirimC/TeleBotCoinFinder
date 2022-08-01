using CoinFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinfFinder.Business.Abstract
{
    public interface ICoinService
    {
        
        List<Coin> GetAllCoins();

        Coin GetCoinById(int id);

        Coin CrateCoin(Coin coin);

        Coin UpdateCoin(Coin coin);

        void DeleteCoin(int id);
         
    }
}
