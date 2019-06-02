using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicCloser : MonoBehaviour


	{
	public GameObject rulesUI, closerUI;

    public void ToggleUI()
    {
        rulesUI.SetActive(!rulesUI.activeSelf);
        closerUI.SetActive(!closerUI.activeSelf);
    }
}
