using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEXPtable : ScriptableObject
{
    public int curEXP { get; protected set; } = 0;
    public int curLevel { get; protected set; } = 1;
    public int requiredEXP => GetRequiredEXP();
    public bool atLevelCap { get; protected set; } = false;
    public abstract bool AddEXP(int amount);
    public abstract void SetLevel(int level);

    protected abstract int GetRequiredEXP();
}
