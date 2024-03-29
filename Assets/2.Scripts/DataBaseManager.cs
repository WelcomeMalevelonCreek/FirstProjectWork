using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class DataBaseManager : MonoBehaviour
{
    static public DataBaseManager Instance;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;

    public List<ItemData> itemList = new List<ItemData>();

    void Start()
    {
        //ex))
        //itemList.Add(new ItemData(10001,"아이템 이름","아이템 설명",ItemData.ItemType.USE,ItemData.Rarerity.COMMON));
    }
}
