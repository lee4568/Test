using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform target; // 찾아야할 대상

    public float dist = 10f; // 카메라의 거리
    public float height = 5f; // 카메라 높이
    public float dampRotate = 5f; // 회전

    private Transform tr;
	
    void Awake()
    {
        tr = GetComponent<Transform>();
    }

	void Start ()
    {
      
	}
	

	void Update ()
    {
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, dampRotate * Time.deltaTime);
        //카메라 Y 축을 타겟의 y 축 회전각도로 부드럽게 회전한다.
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);
        tr.LookAt(target);
        // 카메라 위치 설정 후 타겟을 바라보게 하기
    }
}
