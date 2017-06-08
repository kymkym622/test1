using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicktest : MonoBehaviour {

   // public void Button_Click() {
     //   Debug.Log("ddd");
    public void MENU_ACTION_GotoPage(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
	
}
