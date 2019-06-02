using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicBack : MonoBehaviour {

    public GameObject closerUI, startUI;

    public void ToggleUI()
    {
        closerUI.SetActive(!closerUI.activeSelf);
        startUI.SetActive(!startUI.activeSelf);
    }
}
