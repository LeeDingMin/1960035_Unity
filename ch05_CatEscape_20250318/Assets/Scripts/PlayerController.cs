using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float fMaxPositionX = 10f;// 플레이어가 좌,우 이동시 게임창을 벗어나지 않도록 vector 최댓값 설정 변수
    private float fMinPositionX =-10f; // 플레이어가 좌,우 이동시 게임창을 벗어나지 않도록  vector 최솟값 설정 변수
    private float fPositionX = 0.0f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 화살표가 눌렸을때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0); //왼쪽으로 '1'움직인다.
        }
        
        // 오른쪽 화살표가 눌렸을때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0); //오른쪽으로 '1움직인다.
        }
        
        //범위를 -10 ~10로 제한
        //Mathf.Clamp :좌표 이동과 제한을 한 번에 처리하는 메소드 
        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);
    }
}
