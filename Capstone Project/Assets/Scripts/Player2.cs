using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{

    public float speed;      // 캐릭터 움직임 스피드.
    public float jumpSpeedF; // 캐릭터 점프 힘.
    public float gravity;    // 캐릭터에게 작용하는 중력.
    public GameObject gameObject1;
    public GameObject gameObject2;

   // public Text main_text_str;//메인 텍스트

    public float rotSpeed = 3.0f;
    public Camera fpsCam; //카메라 줌
    private CharacterController controller; // 현재 캐릭터가 가지고있는 캐릭터 컨트롤러 콜라이더.
    private Vector3 MoveDir;                // 캐릭터의 움직이는 방향.
    private Animation Doorani;

    void Start()
    {
        speed = 2.0f;
        jumpSpeedF = 14.0f;
        gravity = 20.0f;

        MoveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
    //    main_text_str.text = null;
    }

    void Update()
    {
        Keyboard();
        RotCtrl();
        // 현재 캐릭터가 땅에 있는가?
        if (controller.isGrounded)
        {
            // 위, 아래 움직임 셋팅. 
            MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // 벡터를 로컬 좌표계 기준에서 월드 좌표계 기준으로 변환한다.
            MoveDir = transform.TransformDirection(MoveDir);

            // 스피드 증가.
            MoveDir *= speed;

            // 캐릭터 점프
            if (Input.GetButton("Jump"))
                MoveDir.y = jumpSpeedF;

        }

        // 캐릭터에 중력 적용.
        MoveDir.y -= gravity * Time.deltaTime;

        // 캐릭터 움직임.
        controller.Move(MoveDir * Time.deltaTime);
    }
    void RotCtrl()
    {
        if (this.CompareTag("player2"))
        {
            float rotX = Input.GetAxis("Mouse Y") * rotSpeed;
            float rotY = Input.GetAxis("Mouse X") * rotSpeed;

            this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
            fpsCam.transform.localRotation *= Quaternion.Euler(-rotX, 0, 0);
        }
    }
    void Keyboard()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15.0f;
        }
        else
        {
            speed = 2.0f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
   
    }
    private void OnCollisionExit(Collision collision)
    {
      

    }
 

}
