using CoinfFinder.Business.Abstract;
using CoinFinder.DataAccess.Abstract;
using CoinFinder.DataAccess.Concrete;
using CoinFinder.Entities;
using System;
using System.Collections.Generic;

namespace CoinfFinder.Business
{
    public class CoinManager : ICoinService
    {
        private ICoinRepository _coinRepository;

        public CoinManager(ICoinRepository coinRepository)
        {
            _coinRepository = coinRepository;
        }

        public Coin CrateCoin(Coin coin)
        {
            return _coinRepository.CrateCoin(coin);
        }

        public void DeleteCoin(int id)
        {
            _coinRepository.DeleteCoin(id);
        }

        public List<Coin> GetAllCoins()
        {
            return _coinRepository.GetAllCoins();
        }

        public Coin GetCoinById(int id)
        {
            if(id > 0)
            {
                return _coinRepository.GetCoinById(id);
            }

            throw new Exception("Id can not be less than 1");
        }

        public Coin UpdateCoin(Coin coin)
        {
            return _coinRepository.UpdateCoin(coin);
        }
    }
}
