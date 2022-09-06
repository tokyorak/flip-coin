
using Microsoft.Extensions.Logging;

namespace console_flipcoin.Model;

public class Coin
{
    private readonly ILogger<Coin> _logger;
    private readonly Random _rng;

    public CoinState State { get; set; }

    public Coin(ILogger<Coin> logger)
    {
        _logger = logger;
        _rng = new Random();
    }

    public CoinState FlipCoin()
    {
        var res = _rng.Next(0,2);

        _logger.LogInformation("{res}", res);

        State = (res == 0)? CoinState.HEAD : CoinState.TAIL;

        return State;
    }
}

public enum CoinState
{
    HEAD,
    TAIL
}