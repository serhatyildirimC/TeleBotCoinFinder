using CoinFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFinder.DataAccess.Abstract
{
    public interface ICoinRepository
    {
        List<Coin> GetAllCoins();

        Coin GetCoinById(int id);

        Coin CrateCoin(Coin coin);

        Coin UpdateCoin(Coin coin);

        void DeleteCoin(int id);
    }
}
