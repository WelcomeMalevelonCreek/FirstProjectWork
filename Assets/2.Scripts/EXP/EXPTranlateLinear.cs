using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RPG/XP Linear", fileName = "EXP_Linear")]
public class EXPTranlateLinear : BaseEXPtable
{
    [SerializeField] int Offset = 100;
    [SerializeField] float Slope = 50;
    [SerializeField] int LevelCap = 25;

    protected int EXPforLevel(int level)
    {
        return Mathf.FloorToInt((Mathf.Min(LevelCap, level) - 1) * Slope + Offset);
    }

    public override bool AddEXP(int amount)
    {
        if (atLevelCap)
        {
            return false;
        }
        curEXP += amount;

        int newLevel = Mathf.Min(Mathf.FloorToInt((curEXP - Offset) / Slope) + 1, LevelCap);
        bool levelledUp = newLevel != curLevel;

        curLevel = newLevel;
        atLevelCap = curLevel == LevelCap;

        return levelledUp;
    }

    public override void SetLevel(int level)
    {
        AddEXP(EXPforLevel(level));
    }

    protected override int GetRequiredEXP()
    {
        if (atLevelCap)
        {
            return int.MaxValue;
        }
        return EXPforLevel(curLevel + 1) - curEXP;
    }
}
