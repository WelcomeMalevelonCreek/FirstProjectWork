using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    /*
    Inventory inven;//UI_ItemArea 변수 선언


    public Transform slotHolder;
    */

    private UI_Slot[] slots;

    private List<ItemData> inventoryItemList;//소지한 아이템 리스트
    private List<ItemData> inventoryTabList;//현재 선택한 탭에 따라 다르게 보여질 아이템

    public Text Description_Text;//설명
    public string[] tabDescription;//아이템 부연 설명.

    public Transform tf;//slot 부모 객체

    public GameObject go;//인벤토리 활성화 비활성화
    public GameObject[] selectedTabImage;

    private int selectedItem;//선택된 아이템
    private int selectedTab;

    private bool activeInventory = false;//인벤토리 활성화 시
    private bool tabActivated;//탭 활성화 시
    private bool itemActivated;//아이템 활성화 시 true
    private bool stopKeyInput;//키 입력 제한.(사용시 선택문에서 입력 방지)
    private bool preventExec;//중복 실행 제한

    public GameObject inventoryPanel;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);

    
    void Start()
    {
        /*
        inven = Inventory.instance;//초기화

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