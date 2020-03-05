using System;
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
            if (Score_Same())
            {
                if (SomeoneAdv())
                {
                    return "Deuce";
                }
                else if (ScoreIsNotZero())
                {
                    return $"{ScoreDic[_firstPlayerScore]} All";
                }

                return "Love All";
            }

            if (SomeoneAdv())
            {
                if (SomeoneWin())
                {
                    return Someone()
                        ? "Rainy Win"
                        : "Korone Win";
                }

                return Someone()
                    ? $"Rainy Adv"
                    : $"Korone Adv";
            }

            return $"{ScoreDic[_firstPlayerScore]} {ScoreDic[_secondPlayerScore]}";
        }

        private bool ScoreIsNotZero()
        {
            return _firstPlayerScore != 0;
        }

        private bool Score_Same()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }

        private bool Someone()
        {
            return _firstPlayerScore > _secondPlayerScore;
        }

        private bool SomeoneWin()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) > 1;
        }

        private bool SomeoneAdv()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
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