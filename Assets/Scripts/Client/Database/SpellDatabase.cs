﻿using System.Collections.Generic;
using UnityEngine;

public class SpellDatabase : MonoBehaviour
{
    public static SpellDatabase getInstance;
    void Awake() { getInstance = this; }

    [SerializeField] Spell[] spells;

    public Spell getSpell(int ID)
    {
        for (int i = 0; i < spells.Length; i++)
            if (spells[i].ID == ID)
                return spells[i];

        return null;
    }
}