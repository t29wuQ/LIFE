﻿using System;
using System.Linq;

namespace LIFE
{
    class Poker
    {
        public int[] HandOutCards()
        {
            int[] cards = new int[5];
            int[] allCards = new int[52];

            int seed = Environment.TickCount;

            for (int i = 0; i < allCards.Length; i++)
            {
                allCards[i] = i;
            }

            int[] shuffledCards = allCards.OrderBy(i => Guid.NewGuid()).ToArray();

            for (int i = 0; i < 5; i++)
            {
                cards[i] = shuffledCards[i];
            }

            return cards;
        }

        public string Judge(int[] cards)
        {
            if (IsRoyalStraightFlush(cards)) return "Royal Straight Flush";
            else if (IsStraightFlush(cards)) return "Straight Flush";
            else if (Is4cards(cards)) return "Four Cards";
            else if (IsFullHouse(cards)) return "Full House";
            else if (IsFlush(cards)) return "Flush";
            else if (IsStraight(cards)) return "Straight";
            else if (Is3Cards(cards)) return "Three Crads";
            else if (Is2Pair(cards)) return "Two Pair";
            else if (Is1Pair(cards)) return "One Pair";
            else return "No Pair";
        }

        static bool IsRoyalStraightFlush(int[] cards)
        {
            if (IsStraightFlush(cards)
                && cards[0] == 1
                && cards[4] == 13
                && cards[1] - cards[0] == 9)
                return true;

            return false;
        }

        static bool IsStraightFlush(int[] cards)
        {
            return IsFlush(cards) && IsStraight(cards);
        }

        static bool Is4cards(int[] cards)
        {
            return IsAnyCards(cards, 4, 0);
        }

        static bool IsFullHouse(int[] cards)
        {
            return Is3Cards(cards) && Is2Pair(cards);
        }

        static bool IsFlush(int[] cards)
        {
            int[] check = new int[5];
            Array.Copy(cards, 0, check, 0, 5);

            for (int i = 0; i < 5; i++)
            {
                check[i] = check[i] % 4;
            }

            if (check[0] == check[1]
                && check[0] == check[2]
                && check[0] == check[3]
                && check[0] == check[4])
                return true;

            return false;
        }

        static bool IsStraight(int[] cards)
        {
            if (IsAnyCards(cards, 2, 0) || IsAnyCards(cards, 3, 0))
                return false;

            cards = ChangeToNumber(cards);
            cards = SortCards(cards);

            if (cards[4] - cards[0] == 5)
                return true;

            return false;
        }

        static bool Is3Cards(int[] cards)
        {
            return IsAnyCards(cards, 3, 0);
        }

        static bool Is2Pair(int[] cards)
        {
            return IsAnyCards(cards, 2, 1);
        }

        static bool Is1Pair(int[] cards)
        {
            return IsAnyCards(cards, 2, 0);
        }

        // mode = 0 で2or3or4枚あったら即終了, 1 でPairを出来る限り探す
        static bool IsAnyCards(int[] cards, int any, int mode)
        {
            int[] countExistNumber = new int[13];
            int countPair = new int();
            int[] check = new int[5];

            check = ChangeToNumber(cards);

            for (int i = 0; i < 5; i++)
            {
                countExistNumber[check[i] - 1]++;
            }

            foreach (int i in countExistNumber)
            {
                if (any == i && mode == 0)
                    return true;

                else if (any == i && mode == 1)
                    countPair++;
            }

            if (mode == 1 && countPair == 2)
                return true;

            return false;
        }

        static int[] SortCards(int[] cards)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    if (cards[j - 1] > cards[j])
                    {
                        int tmp = cards[j];
                        cards[j] = cards[j - 1];
                        cards[j - 1] = tmp;
                    }
                }
            }
            return cards;
        }

        // 絵柄関係なく数字に変換
        static int[] ChangeToNumber(int[] cards)
        {
            int[] check = new int[5];
            Array.Copy(cards, 0, check, 0, 5);
            for (int i = 0; i < 5; i++)
            {
                check[i] = (check[i] - check[i] % 4) / 4 + 1;
            }
            return check;
        }
    }
}
