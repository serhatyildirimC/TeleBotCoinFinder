using TeleBot.Abstract;
using CoinFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeleBot;

namespace TeleBot.Concrete
{
    public class CoinRepository : ICoinRepository
    {
        public Coin CrateCoin(Coin coin)
        {
            using (var coinDbContext = new CoinDbContext())
            {
                coinDbContext.Coins.Add(coin);
                coinDbContext.SaveChanges();
                return coin;
            }

        }

        public void DeleteCoin(int id)
        {
            using (var coinDbContext = new CoinDbContext())
            {
                var deletedCoin = GetCoinById(id);
                coinDbContext.Coins.Remove(deletedCoin);
                coinDbContext.SaveChanges();
            }
        }

        public List<Coin> GetAllCoins()
        {
            using (var coinDbContext = new CoinDbContext())
            {
                return coinDbContext.Coins.ToList();
            }
        }

        public Coin GetCoinById(int id)
        {
            using (var coinDbContext = new CoinDbContext())
            {
                return coinDbContext.Coins.Find(id);
            }

        }

        public Coin UpdateCoin(Coin coin)
        {
            using (var coinDbContext = new CoinDbContext())
            {
                coinDbContext.Coins.Update(coin);
                coinDbContext.SaveChanges();
                return coin;
            }

        }
    }
}
