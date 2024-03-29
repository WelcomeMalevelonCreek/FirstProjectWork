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

    //ü��
    public float maxHP;
    public float curHP;
    //�׷α�
    public float maxGroggyGuage;
    public float curGroggyGuage;

    public int curStamina;//�ڽ�Ʈ
    public int maxstamina;

    public int curSpeed;
    public int maxSpeed;//�ӵ� ����ġ�� �ִ�ġ

    public int strength;//�ٷ�
    public int dexterity;//��ø
    public int endurance;//ü��,����
}
