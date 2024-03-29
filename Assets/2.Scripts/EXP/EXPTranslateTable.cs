using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EXPTranlateTableEntry
{
    public int Level;
    public int EXPRequired;
}

[CreateAssetMenu(menuName = "RPG/XP Table", fileName = "EXP_Table")]

public class EXPTranslateTable : BaseEXPtable
{
    [SerializeField] List<EXPTranlateTableEntry> Table;

    public override bool AddEXP(int amount)
    {
        if (atLevelCap)
        {
            return false;
        }
        curEXP += amount;
        foreach(var entry in Table)
        {
            if (curEXP >= entry.EXPRequired)
            {
                if (entry.Level != curLevel)
                {
                    curLevel = entry.Level;
                    atLevelCap = Table[^1].Level == curLevel;

                    return true;
                }//·¹º§¾÷
                break;
            }
        }
        return false;
    }

    public override void SetLevel(int level)
    {
        foreach(var entry in Table)
        {
            if(entry.Level == level)
            {
                AddEXP(entry.EXPRequired);

                return;
            }
        }

        throw new System.ArgumentOutOfRangeException($"Could not find any entry for level {level}");
    }

    protected override int GetRequiredEXP()
    {
        if (atLevelCap)
        {
            return int.MaxValue;
        }

        for(int index = 0; index < Table.Count; ++index)
        {
            var entry = Table[index];

            if (Table[index].Level == curLevel)
            {
                return Table[index + 1].EXPRequired - curEXP;
            }
        }

        throw new System.ArgumentOutOfRangeException($"Could not find any entry for level {curLevel}");
    }
}
