using UnityEngine;

public class Dropper : MonoBehaviour
{
    // 변수 선언
    Rigidbody rb;

    private void Start()
    {
        // 실제 컴포넌트를 찾아오는 코드
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    
    public void CanFalling()
    {
        rb.useGravity = true;
    }

}
