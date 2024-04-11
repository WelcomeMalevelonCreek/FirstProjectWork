using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pile : MonoBehaviour
{
    [SerializeField] public List<BaseCardInfo> pile = new List<BaseCardInfo>();

    public TextMeshProUGUI pileCount;

    //public int pileCount;

    public void AddToPile(BaseCardInfo cardInfo)
    {
        BaseCardInfo card = new BaseCardInfo();
        card = cardInfo;
        pile.Add(card);
        pileCount.text = pile.Count.ToString();
    }

    public BaseCardInfo TakeOutOfPile(int index)
    {
        BaseCardInfo temp = pile[index];
        pile.RemoveAt(index);
        pileCount.text = pile.Count.ToString();
        return temp;
    }
}
