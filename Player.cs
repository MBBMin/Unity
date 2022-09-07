using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform charBody;
    [SerializeField]
    private Transform cameraArm;
    public float normalSpeed = 1f; //움직이는 속도를 5로초기화
    public float runSpeed = 7f; //뛰는 속도
    public float rotation = 360f; // 회전속도

    public float interactDiastance = 5f;
   

    CharacterController charCtrl;
    Animator anim;

    void Start() //Entry가 같이 콜 됨
    {
        charCtrl = GetComponent<CharacterController>();
        anim = charBody.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAround();
        Move();
       
      


    }

    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = cameraArm.rotation.eulerAngles;

        //추가
        float x = camAngle.x - mouseDelta.y;
        if (x < 180f)
        {
            x = Mathf.Clamp(x, -1f, 70f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 361f);
        }

        cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
    
    }
    private void Move(){

        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        Vector3 lookForward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
        Vector3 lookRight = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
        Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;
        //anim.SetBool("isMove", isMove);
        
        if (moveInput.sqrMagnitude > 0.01f)
        {
           
            charBody.forward = lookForward;
            charCtrl.Move(moveDir * normalSpeed * Time.deltaTime);
           // transform.position += moveDir * normalSpeed * Time.deltaTime;
            anim.SetFloat("Speed", charCtrl.velocity.magnitude);
                // transform.LookAt(transform.position + forward);
            }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            charCtrl.Move(moveDir * runSpeed * Time.deltaTime);
            //transform.position += moveDir * runSpeed * Time.deltaTime;
            charBody.forward = lookForward;
            anim.SetFloat("Speed", charCtrl.velocity.magnitude);
        }
        else
        {
            charBody.forward = lookForward;
            charCtrl.Move(moveDir * normalSpeed * Time.deltaTime);
            // transform.position += moveDir * normalSpeed * Time.deltaTime;
            anim.SetFloat("Speed", charCtrl.velocity.magnitude);
        }


       // if (GameObject.FindGameObjectsWithTag("Door").Length < 1)
         //   SceneManager.LoadScene("Win");

    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Key":
                Destroy(other.gameObject);
                break;
            case "Enemy":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);//실패화면 출력, LoadScene(SceneManager.GetActiveScene().name)=재시작
                break;
        }

    }

}
