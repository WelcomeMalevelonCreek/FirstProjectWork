using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public List<BaseCardInfo> allCards = new List<BaseCardInfo>();

    private int currentIndex = 0;

    private void Start()
    {
        BaseCardInfo[] cards = Resources.LoadAll<BaseCardInfo>("Cards");

        allCards.AddRange(cards);
        
        HandManager hand = FindObjectOfType<HandManager>();
        for(int i = 0; i < 0; i++)
        {
            DrawCard(hand);
        }
        
    }

    public void DrawCard(HandManager handManager)
    {
        if (allCards.Count == 0)
        {
            return;
        }

        BaseCardInfo nextCard = allCards[currentIndex];
        handManager.AddCardToHand(nextCard);
        currentIndex = (currentIndex + 1) % allCards.Count;
    }
}
