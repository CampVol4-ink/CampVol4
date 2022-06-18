using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Dragon")]
public class DragonStatus : ScriptableObject
{
    public string name = "Dragon";
    public int hp = 20;
}