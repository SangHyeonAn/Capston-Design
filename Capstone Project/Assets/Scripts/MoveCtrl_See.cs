using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl_See : MonoBehaviour
{

    public enum MoveType
    {
        WAY_POINT,
        LOOK_AT,
        DAYDREAM

    }
    //이동 방식
    public MoveType moveType = MoveType.WAY_POINT;
    //이동 속도
    public float speed = 1.0f;
    //회전 시 회전 속도를 조절할 계수
    public float damping = 3.0f;

    private Transform tr;
    private Transform camTr;
    private CharacterController cc;

    //웨이포인트를 저장할 배열
    private Transform[] points;
    //다음에 이동해야 할 위치 인덱스 변수
    private int nextIdx = 1;


    // Use this for initialization
    void Start()
    {
        //컴포넌트 변수에 할당 처리
        tr = GetComponent<Transform>();
        camTr = Camera.main.GetComponent<Transform>();
        cc = GetComponent<CharacterController>();

        //WayPointGroup 게임오브젝트 아래에 있는 모든 point의 Transform 컴포넌트를 추출
        points = GameObject.Find("WayPointGroup").GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (moveType)
        {
            case MoveType.WAY_POINT:
                MoveWayPoint();
                break;
            case MoveType.LOOK_AT:
                MoveLookAt();
                break;
            case MoveType.DAYDREAM:
                break;
        }
    }
    void MoveWayPoint()
    {
        Vector3 direction = points[nextIdx].position - tr.position;
        Quaternion rot = Quaternion.LookRotation(direction);
        //현재 각도에서 회전해야 할 각도까지 부드럽게 회전 처리
        tr.rotation = Quaternion.Slerp(tr.rotation, rot, Time.deltaTime * damping);
        //전진 방향으로 이동 처리
        tr.Translate(Vector3.forward * Time.deltaTime * speed);
         
    }
    void MoveLookAt()
    {
        Vector3 dir = camTr.TransformDirection(Vector3.forward);
        //dir 백터의 방향으로 초당 speed 만큼 씩 이동
        cc.SimpleMove(dir * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WAY_POINT"))
        {
            nextIdx = (++nextIdx >= points.Length) ? 1 : nextIdx;
        }
    }
}
