using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KHJ : MonoBehaviour {

    // Use this for initialization
    public GameObject ExitPanel;
    public GameObject SettingPanel;
    public GameObject LanguagePanel;
    public GameObject Manualpanel1;
    public GameObject Manualpanel2;
    public GameObject Manualpanel3;
    public GameObject Manualpanel4;
    public GameObject Manualpanel5;
    public GameObject ProducerPanel;
    

    public GameObject SettingButton;
   
    bool ExitWindow = false;
    bool SettingWindow = false;
    int Manualpage = 0;

    void Start () {
        ExitPanel.SetActive(ExitWindow);
        SettingPanel.SetActive(SettingWindow);
        LanguagePanel.SetActive(false);
        Manualpanel1.SetActive(false);
        Manualpanel2.SetActive(false);
        Manualpanel3.SetActive(false);
        Manualpanel4.SetActive(false);
        Manualpanel5.SetActive(false);
        ProducerPanel.SetActive(false);
}
	
	void Update () {
        
            if (Input.GetKeyDown(KeyCode.Escape)){ //뒤로가기 터치이벤트
                //종료물음창이 떠있다면
                if (ExitWindow == true){
                    ExitWindow = false;
                    ExitPanel.SetActive(ExitWindow);
                }
            //환경설정창이 떠있다면
            else if (SettingWindow == true) {
                SettingWindow = false;
                SettingPanel.SetActive(SettingWindow);
                SettingButton.SetActive(true);
            }
            // 아무것도 안떠있다면 종료물음창을 띄운다.
            else
            {
                ExitWindow = true;
                ExitPanel.SetActive(ExitWindow);
            }
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void NoBtnAct()
    {
        ExitWindow = false;
        ExitPanel.SetActive(ExitWindow);
    }

    public void nextBtn() {
        if (Manualpage == 1) {
            Manualpanel1.SetActive(false);
            Manualpanel2.SetActive(true);
            Manualpage = 2;
        }
        else if (Manualpage == 2)
        {
            Manualpanel2.SetActive(false);
            Manualpanel3.SetActive(true);
            Manualpage = 3;
        }
        else if (Manualpage == 3)
        {
            Manualpanel3.SetActive(false);
            Manualpanel4.SetActive(true);
            Manualpage = 4;
        }
        else if (Manualpage == 4)
        {
            Manualpanel4.SetActive(false);
            Manualpanel5.SetActive(true);
            Manualpage = 5;
        }
    }
    public void prevBtn()
    {
        if (Manualpage == 2){
            Manualpanel2.SetActive(false);
            Manualpanel1.SetActive(true);
            Manualpage = 1;
        }
        else if (Manualpage == 3) {
            Manualpanel3.SetActive(false);
            Manualpanel2.SetActive(true);
            Manualpage = 2;
        }
        else if (Manualpage == 4)
        {
            Manualpanel4.SetActive(false);
            Manualpanel3.SetActive(true);
            Manualpage = 3;
        }
        else if (Manualpage == 5)
        {
            Manualpanel5.SetActive(false);
            Manualpanel4.SetActive(true);
            Manualpage = 4;
        }
    }

    public void ManualCancel() {
        Manualpanel1.SetActive(false);
        Manualpanel2.SetActive(false);
        Manualpanel3.SetActive(false);
        Manualpanel4.SetActive(false);
        Manualpanel5.SetActive(false);
    }

    public void ProducerCancel()
    {
        ProducerPanel.SetActive(false);
    }

    public void SettingBtn() {
        SettingWindow = true;
        SettingPanel.SetActive(SettingWindow);
        SettingButton.SetActive(false);
    }

    public void SettingCancelBtn()
    {
        SettingWindow = false;
        SettingPanel.SetActive(SettingWindow);
        SettingButton.SetActive(true);
    }

    public void LanguageBtn() {
        LanguagePanel.SetActive(true);
        SettingWindow = false;
        SettingPanel.SetActive(SettingWindow);
    }
    public void LanguageCancelBtn()
    {
        LanguagePanel.SetActive(false);
        SettingBtn();
    }

    public void ManualBtn(){
        Manualpage = 1;
        Manualpanel1.SetActive(true);
    }

    public void ProducerBtn() {
        ProducerPanel.SetActive(true);
    }
       
    }
