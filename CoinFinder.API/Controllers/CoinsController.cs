using CoinfFinder.Business;
using CoinfFinder.Business.Abstract;
using CoinFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoinFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinsController : ControllerBase
    {
        private ICoinService _coinService;

        public CoinsController(ICoinService coinService)
        {
            _coinService = coinService;

        }



        [HttpGet]
        public IActionResult Get()
        {
            var coins = _coinService.GetAllCoins();
            return Ok(coins);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var coin = _coinService.GetCoinById(id);
            if (coin != null)
            {
                
                return Ok(coin);

            }
            
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_coinService.GetCoinById(id) != null)
            {
                _coinService.DeleteCoin(id);
                return Ok();
            }
            return NotFound();
            
        }
        [HttpPost]
        public IActionResult Post([FromBody]Coin coin)
        {
            var createdCoin= _coinService.CrateCoin(coin);
            return CreatedAtAction("Get",new {id =createdCoin.Id},createdCoin);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Coin coin)
        {
            if (_coinService.GetCoinById(coin.Id) != null)
            {
                return Ok(_coinService.UpdateCoin(coin));
            }
            return NotFound();
        }
    }
}
