using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public int itemID;//�ߺ� �Ұ��� ID��
    public string itemName;//�ߺ� ���� �̸� ��
    public string itemDes;//������ ����
    public int itemCount;//���� ��
    public Sprite itemIcon;//������ ������


    public enum ItemType
    {
        USE, EQUIP, QUEST, ETC
    }
    public ItemType itemType;

    public enum Rarerity
    {
        COMMON, UNCOMMON, RARE, UNIQUE, LEGENDARY, RELICS
    }
    public Rarerity rarerity;

    public ItemData(int _itemID, string _itemName, string _itemDes, ItemType _itemType, Rarerity _rarerity, int _ItemCount = 1)
    {
        itemID = _itemID;
        itemName = _itemName;
        itemDes = _itemDes;
        itemType = _itemType;
        rarerity = _rarerity;
        itemCount = _ItemCount;
        itemIcon = Resources.Load("ItemIcon/" + itemID.ToString(), typeof(Sprite)) as Sprite;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
