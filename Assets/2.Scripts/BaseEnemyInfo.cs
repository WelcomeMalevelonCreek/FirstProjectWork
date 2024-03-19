using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemyInfo
{
    public enum ArmorType
    {
        NAKED, LIGHT_ARMOR, MEDIUM_ARMOR, HEAVY_ARMOR
    }

    public ArmorType enemyArmorType;

    public string enemyName;

    public float initHP;
    public float currenHP;

    public float initgroggyGuage;
    public float currenGroggyGuage;

    public float baseDamage;
    public float currenDamage;
    public float baseDef;
    public float currenDef;
}
