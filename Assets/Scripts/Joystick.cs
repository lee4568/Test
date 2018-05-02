using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour
{
    public Transform Player;       //플레이어
    public Transform Stick;        //조이스틱

    private Vector3 StickFirstPos; //조이스틱의 처음 위치(가운데)
    private Vector3 JoyVec;        //조이스틱의 벡터(방향)
    private float Radius;          //조이스틱 배경의 반지름;
    private bool MoveFlag;         //플레이어 움직임 스위치

    public float movespeed;
    public GameObject player;
    
    
	
	void Start ()
    {
        Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickFirstPos = Stick.transform.position;

        //캔버스 크기에 대한 반지름 조절
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;

        MoveFlag = false;
	}
	
	//드래그
    public void Drag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;

        //조이스틱을 이동시킬 방향을 구함
        JoyVec = (Pos - StickFirstPos).normalized;

        //조이스틱의 처음 위치와 내가 터치 하고있는 거리의 위치를 구한다
        float Dis = Vector3.Distance(Pos, StickFirstPos);

        //거리가 반지름보다 작으면 조이스틱을 현재 터치하고 있는곳으로 이동
        if (Dis < Radius)
        {
            Stick.position = StickFirstPos + JoyVec * Dis;
        }
        //거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼으로 이동(조이스틱이 원밖으로 나가지 않도록)
        else
            Stick.position = StickFirstPos + JoyVec * Radius;

        Player.eulerAngles = new Vector3(0, Mathf.Atan2(JoyVec.x, JoyVec.y) * Mathf.Rad2Deg, 0);

        player.transform.Translate(0, 0, movespeed * Time.deltaTime); //플레이어 이동
    }

    //드래그 끝
    public void DragEnd()
    {
        Stick.position = StickFirstPos;  //스틱을 원래 위치로 이동
        JoyVec = Vector3.zero;           //방향을 0으로

        MoveFlag = false;
    }
	void Update ()
    {
		if(MoveFlag)
        {
            Player.transform.Translate(Vector3.forward * Time.deltaTime * 10f);
        }
	}
}
