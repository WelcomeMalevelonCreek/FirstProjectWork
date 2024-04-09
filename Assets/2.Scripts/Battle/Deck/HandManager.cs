using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    public DeckManager deckManager;

    public GameObject cardPrefabs;
    public Transform handTransform;

    public float fanSpread = 0f;
    public float cardSpace = 100f;
    public float verticalSpacing = 0f;

    public int handCardSizeMax = 12;

    public List<GameObject> handCards = new List<GameObject>();

    private void Start()
    {
        
    }

    public void AddCardToHand(BaseCardInfo cardData)
    {
        if (handCards.Count < handCardSizeMax)
        {
            GameObject newCard = Instantiate(cardPrefabs, handTransform.position, Quaternion.identity, handTransform);
            handCards.Add(newCard);

            newCard.GetComponent<CardDisplay>().CardData = cardData;
        }
        UpdateHandVisuals();
    }

    private void Update()
    {
        //UpdateHandVisuals();
    }

    private void UpdateHandVisuals()
    {
        int cardCount = handCards.Count;
        
        if (cardCount == 1)
        {
            handCards[0].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            handCards[0].transform.localPosition = new Vector3(0f, 0f, 0f);
            return;
        }
        
        for(int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            handCards[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

            float horizontalOffset = (cardSpace * (i - (cardCount - 1) / 2f));

            float normalizedPosition = (2f * i / (cardCount - 1) / 2f);

            float verticalOffset = verticalSpacing * (i - normalizedPosition * normalizedPosition);

            handCards[i].transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0f);
        }
    }
}
