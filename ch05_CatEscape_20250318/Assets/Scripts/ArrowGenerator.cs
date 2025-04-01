using Mono.Cecil;
using UnityEngine;

/*
 화살 오브젝트를 1초에 한 개씩 생성하는 알고리즘
  -update 메서드는 프레임마다 실행되고 앞프레임과 현재 프레임 사이의 시간차이는 Time.deltaTime에 대입
  -프레임과 프레임 사이의 시간 차이를 대나무 통(delta변수)에 모으고(합계) 1초 이상이 되면 대나무 통을 비움
  -대나무 통을 비우는 시점인 1초에 한번씩 화살이 생성됨
  
  - instantidate 매서드 
   --게임을 실행하는 도중에 게임오브젝트를 생성할 수 있음
   -- 화살 프리팹을 이용하여 ,화살 인스턴스를 생성하는 매서드
  -Random.Range 매서드 :랜덤 값을 쉽게 생성할 수 있는 방법 
   --Random클래스는 흔히 요구되는 다양한 타입의 랜덤 값을 쉽게 생성할 수 있는 방법을 제공
   --사용자가 제공한 최솟값과 최댓값 사이의 임의의 숫자를 제공함 
     -- 첫 번째 매개변수보다 크거나 같고, 두 번째 매개변수보다 작은 범위에서 무작위 수를 랜덤하게 반환 
 
    -화살 프리팹을 이용하여, 화살 인스턴스를 생성하는 매서드
    -intantiate 메서드를 사용하면 게임을 실행하는 도중에 게임오브젝트를 생성할 수 있음
    
    -instantiate(GameObject original,vector3 position,Quaternion rotation)
      --GameObject original:생성하고자 하는 게임오브젝트명,현재 씬에 있는 게임오브젝트나 prefab으로 선언된 객체를 의미함
      --vector3 position:vector3으로 생성될 위치를 설정함.
      --Quaternion rotation:생성될 게임오브젝트의 회전값을 지정
      
      Random.Range 매서드 :사용자가 제공한 최솟값과 최댓값 사이의 임의의 숫자를 제공함.
 */


public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab = null; //화살 prefab을 넣은 빈 오브젝트 상자 선언 (중요)

    private GameObject aArrowInstance = null;// 화살 인스턴스 저장 변수
    private float fArrowCreateSpan = 1.0f; // 화살 생성 변수 : 화살을 1초마다 생성 변수
    private float fDeltaTime = 0; // 앞 프레임과 현재 프레임 사이의 시간 차이를 저장하는 변수

    private int nArrowPositionRange = 0; // 화살의 x 좌표 Range 저장 변수
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.fDeltaTime += Time.deltaTime;
        if(this.fDeltaTime >this.fArrowCreateSpan)
        {
            this.fDeltaTime = 0.0f;
            aArrowInstance = Instantiate(arrowPrefab);
            nArrowPositionRange = Random.Range(-6, 7);
            aArrowInstance.transform.position = new Vector3(nArrowPositionRange, 7, 0);
        }
    }
}
