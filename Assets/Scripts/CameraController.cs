using UnityEngine;

public class CameraCOntroller : MonoBehaviour
{
    public Transform target;

    
    private void FixedUpdate()
    {
        transform.LookAt(target);       
    }



}
