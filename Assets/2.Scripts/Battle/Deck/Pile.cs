using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pile : MonoBehaviour
{
    public List<BaseCardInfo> pile;

    protected Text pileCount;

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
