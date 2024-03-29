using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPTracker : MonoBehaviour
{
    [SerializeField] BaseEXPtable EXPTableType;
    BaseEXPtable EXPtable;

    private void Awake()
    {
        EXPtable = ScriptableObject.Instantiate(EXPTableType);
    }

    public void AddEXP(int amount)
    {
        EXPtable.AddEXP(amount);
    }

    public void SetLevel(int level)
    {
        EXPtable.SetLevel(level);
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
