using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    /*
    Inventory inven;//UI_ItemArea ���� ����


    public Transform slotHolder;
    */

    private UI_Slot[] slots;

    private List<ItemData> inventoryItemList;//������ ������ ����Ʈ
    private List<ItemData> inventoryTabList;//���� ������ �ǿ� ���� �ٸ��� ������ ������

    public Text Description_Text;//����
    public string[] tabDescription;//������ �ο� ����.

    public Transform tf;//slot �θ� ��ü

    public GameObject go;//�κ��丮 Ȱ��ȭ ��Ȱ��ȭ
    public GameObject[] selectedTabImage;

    private int selectedItem;//���õ� ������
    private int selectedTab;

    private bool activeInventory = false;//�κ��丮 Ȱ��ȭ ��
    private bool tabActivated;//�� Ȱ��ȭ ��
    private bool itemActivated;//������ Ȱ��ȭ �� true
    private bool stopKeyInput;//Ű �Է� ����.(���� ���ù����� �Է� ����)
    private bool preventExec;//�ߺ� ���� ����

    public GameObject inventoryPanel;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);

    
    void Start()
    {
        /*
        inven = Inventory.instance;//�ʱ�ȭ

        slots = slotHolder.GetComponentsInChildren<UI_Slot>();
        inven.onSlotCountChange += SlotChange;
        inventoryPanel.SetActive(activeInventory);
        */
        inventoryItemList = new List<ItemData>();
        inventoryTabList = new List<ItemData>();
        slots = tf.GetComponentsInChildren<UI_Slot>();
    }
    

    /*
    private void SlotChange(int val)
    {
        for(int i=0;i<slots.Length; i++)
        {
            if (i < inven.SlotCount)
            {
                slots[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;

            }
        }
    }
    */
    public void ShowTab()
    {
        RemoveSlot();
        SelectedTab();
    }

    public void RemoveSlot()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slots[i].RemoveItem();
            slots[i].gameObject.SetActive(false);
        }
    }
    public void SelectedTab()
    {
        StopAllCoroutines();
        Color color = selectedTabImage[selectedTab].GetComponent<Image>().color;
        color.a = 0f;
        for(int i=0; i < selectedTabImage.Length; i++)
        {
            selectedTabImage[i].GetComponent<Image>().color = color;
        }
        Description_Text.text = tabDescription[selectedTab];
        StartCoroutine(SelectedTabEffectCoroutine());
    }

    IEnumerator SelectedTabEffectCoroutine()
    {
        while (tabActivated)
        {
            Color color = selectedTabImage[0].GetComponent<Image>().color;
            while (color.a < 0.5f)
            {
                color.a += 0.03f;
                selectedTabImage[selectedTab].GetComponent<Image>().color = color;
                yield return waitTime;            
            }
            while (color.a > 0.5f)
            {
                color.a -= 0.03f;
                selectedTabImage[selectedTab].GetComponent<Image>().color = color;
                yield return waitTime;
            }

            yield return new WaitForSeconds(0.3f);
        }
    }
    void Update()
    {
        if (!stopKeyInput)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                activeInventory = !activeInventory;
                inventoryPanel.SetActive(activeInventory);
                if (itemActivated)
                {
                    go.SetActive(true);
                    selectedTab = 0;
                    tabActivated = true;
                    itemActivated = false;
                    ShowTab();
                }
                else
                {
                    StopAllCoroutines();
                    go.SetActive(false);
                    tabActivated = false;
                    itemActivated = false;
                    //theOrder.Move();
                }
            }
        }
    }
    
    /*
    public void AddSlot()
    {
        inven.SlotCount++;
    }
    */
}