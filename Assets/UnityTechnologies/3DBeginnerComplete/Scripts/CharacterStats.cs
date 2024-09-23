using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "Character Stats", order = 1)]
public class CharacterStats : ScriptableObject
{
    public string characterName;
    public int health;
    public int attackPower;

}
