using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour {

    public GameObject[] Btn;
	
    public void StartBtn()
    {
        Application.LoadLevel(1);
    }

    public void MenuBtn()
    {
        Btn[0].SetActive(true);
    }

    public void SelectBtn()
    {
        Btn[1].SetActive(true);
    }

    public void CharacterBtn()
    {
        Application.LoadLevel(2);
    }


    //public void SoundBtn()
    //{

    //}

    //public void MusicBtn()
    //{

    //}

    public void ExitBtn()
    {
        Application.Quit();
        Debug.Log("게임 종료");
    }

}
