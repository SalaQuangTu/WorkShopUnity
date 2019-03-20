using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interactable", menuName = "NewInteractable", order = 100)]
public class InteracStats : ScriptableObject
{
    [TextArea]
    new public string name = string.Empty;
    [TextArea]
    public string type = "Card, Item or Monster";
    [TextArea]
    public string infoOrStats = string.Empty;
    [TextArea]
    public string Description = string.Empty;
    [TextArea]
    public string action = string.Empty;
}
