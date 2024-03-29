using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public int itemID;//중복 불가능 ID값
    public string itemName;//중복 가능 이름 값
    public string itemDes;//아이템 설명
    public int itemCount;//소지 수
    public Sprite itemIcon;//아이템 아이콘


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
