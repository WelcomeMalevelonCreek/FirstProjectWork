using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData",fileName = "New Skill")]

public class BaseCardInfo : ScriptableObject
{

    public string cardName;

    public List<CardType> cardTypes;

    public float costNum;
    public float damageNum;
    public float groggyNum;
    public float defendNum;
    public string desText;

    public Sprite cardSprite;
       
    public enum CardType
    {
        SLASH, BLOW, PIERCING, EVADE, DEPEND
    }


}
