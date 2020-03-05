using System.Collections.Generic;
using NUnit.Framework;

namespace Project1
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private static readonly Dictionary<int, string> ScoreDic = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" }
        };

        public Tennis()
        {
        }

        public string Score()
        {
            if (_firstPlayerScore == _secondPlayerScore)
            {
                if (_firstPlayerScore > 3)
                {
                    return "Deuce";
                }
                else if (_firstPlayerScore != 0)
                {
                    return $"{ScoreDic[_firstPlayerScore]} All";
                }

                return "Love All";
            }

            return _firstPlayerScore > 3 || _secondPlayerScore > 3
                ? _firstPlayerScore > _secondPlayerScore
                    ? $"Rainy Adv" : $"Korone Adv"
                : $"{ScoreDic[_firstPlayerScore]} {ScoreDic[_secondPlayerScore]}";
            }

        public void SetFirstPlayerScore(int i)
        {
            _firstPlayerScore = i;
        }

        public void SetSecondPlayerScore(int i)
        {
            _secondPlayerScore = i;
        }
    }
}