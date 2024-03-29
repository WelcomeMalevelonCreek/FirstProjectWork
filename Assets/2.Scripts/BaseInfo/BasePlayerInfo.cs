using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasePlayerInfo
{
    public enum ArmorType
    {
        NAKED, LIGHT_ARMOR, MEDIUM_ARMOR, HEAVY_ARMOR
    }

    public string name;

    //체력
    public float maxHP;
    public float curHP;
    //그로기
    public float maxGroggyGuage;
    public float curGroggyGuage;

    public int curStamina;//코스트
    public int maxstamina;

    public int curSpeed;
    public int maxSpeed;//속도 랜덤치와 최대치

    public int strength;//근력
    public int dexterity;//민첩
    public int endurance;//체력,저항
}
