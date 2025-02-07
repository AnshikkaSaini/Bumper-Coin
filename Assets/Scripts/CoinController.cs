using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float rotateSpeed;
    
        private void FixedUpdate()
    {
        transform.Rotate(rotateSpeed, 0, 0 );  
    }
}
