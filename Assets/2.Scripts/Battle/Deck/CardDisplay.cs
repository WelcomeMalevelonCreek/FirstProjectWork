using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public BaseCardInfo CardData;

    public Image cardImage;
    public TMP_Text _name;
    public TMP_Text _cost;
    public TMP_Text _des;
    public TMP_Text _damage;
    public TMP_Text _groggy;
    public TMP_Text _defend;
    public Image[] _cardTypeImage;

    private void Start()
    {
        UpdateCardDisplay();
    }

    private void UpdateCardDisplay()
    {
        if (CardData == null)
        {
            return;
        }

        _name.text = CardData.cardName;
        _cost.text = CardData.costNum.ToString();
        _des.text = CardData.desText;
        _damage.text = CardData.damageNum.ToString();
        _groggy.text = CardData.groggyNum.ToString();
        _defend.text = CardData.defendNum.ToString();
    }
}
