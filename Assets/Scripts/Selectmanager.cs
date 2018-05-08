using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectmanager : MonoBehaviour
{
    public static bool btn1 = false;
    public static bool btn2 = false;
    public static bool btn3 = false;

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;

    public void Btn1()
    {
       
            b1.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
        
    }
    public void Btn2()
    {
        
            b1.SetActive(false);
            b2.SetActive(true);
            b3.SetActive(false);
       
    }
    public void Btn3()
    {
       
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(true);
        
    }

    void Start ()
    {
        b1.SetActive(true);
        b2.SetActive(false);
        b3.SetActive(false);
    }
	
	
	void Update ()
    {
		
	}
}
