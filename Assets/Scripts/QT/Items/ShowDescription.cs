using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDescription : MonoBehaviour
{
    public GameObject descriptionTemplate;

    public Text myName;
    public Text myType;
    public Text myInfo;
    public Text myDescription;
    public Text myAction;

    public void DescriptionGiver(Interactable newInteraction)
    {
        descriptionTemplate.SetActive(true);
        SetInfo(newInteraction.info.name, newInteraction.info.type, newInteraction.info.infoOrStats, newInteraction.info.Description, newInteraction.info.action);
    }

    public void SetInfo(string newName, string newType, string newInfo, string newDescription, string newAction)
    {
        myName.text = newName;
        myType.text = newType;
        myInfo.text = newInfo;
        myDescription.text = newDescription;
        myAction.text = newAction;
    }

    public void DestroyPannel()
    {
        descriptionTemplate.SetActive(false);
    }
}
