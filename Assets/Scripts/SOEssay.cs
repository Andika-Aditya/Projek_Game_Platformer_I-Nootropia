using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Essay", order = 1)]
public class SOEssay : ScriptableObject
{
    public string essay;
    public List<string> answer;
}
