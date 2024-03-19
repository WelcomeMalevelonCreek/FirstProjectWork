using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData",fileName = "New Skill")]

public class BaseCardInfo : ScriptableObject
{
    public enum DamageType
    {
        SLASH, BLOW, PIERCING 
    }
    public enum CardType
    {
        MELEE, RANGE, EVADE, DEPEND
    }

    public DamageType damageType;
    public CardType cardType;

    public string cardName;

    public float damageNum;
    public float defendNum;
}
