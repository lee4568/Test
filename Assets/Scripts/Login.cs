using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniJSON;
using SimpleJSON;

public class Login : MonoBehaviour {

    public string LoginURL = "http://ehtls489.cafe24.com/rpgserver/select.php"; // 로그인용 URL
    public string SigninURL = "http://ehtls489.cafe24.com/rpgserver/insert.php"; // 아이디 생성 URL

    public GameObject loginBtn; // 로그인 버튼

   public void LoginBtn()
    {
        StartCoroutine(LoginCoroutine());
    }

   IEnumerator LoginCoroutine()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", PlayerPrefs.GetInt("UserID"));
        form.AddField("UserPass", SystemInfo.deviceUniqueIdentifier);
        WWW www = new WWW(LoginURL);
        yield return www;
        Debug.Log(www.text);
    }
}
