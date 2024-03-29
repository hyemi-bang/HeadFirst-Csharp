using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    internal class CardPicker {

        static Random random = new Random();
        public static string[] PickSomeCard(int numberOfCards) // 주어진 개수만큼의 카드를 선택하여 배열로 반환한다.
        {
            string[] pickedCards = new string[numberOfCards]; // 선택된 카드를 저장할 배열을 생성
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
                // 임의의 값을 선택하여 무늬와 숫자를 조합하여 카드를 생성한다.
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //throw new NotImplementedException();
            int value = random.Next(1,5);  // 1부터 4 사이의 임의의 숫자를 선택하여 무늬를 결정
            if (value == 1) return "♤";
            if (value == 2) return "♥";
            if (value == 3) return "♣";
            return "◇";
        }

        private static string RandomValue()
        {
            //throw new NotImplementedException();
            int value = random.Next(1, 14); // 1부터 13 사이의 임의의 숫자 선택
                                            // 임의의 값에 따라 카드 값으로 변환하여 반환한다.

            /*
              switch (value)
          {
              case 1:
                  return "Ace";
              case 11:
                  return "Jack";
              case 12:
                  return "Queen";
              case 13:
                  return "King";
              default:
                  return value.ToString();
          }
           */
            return value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => value.ToString(),
            };
          
        }
    }
}
