
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    
    void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            position.x += step;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.x -= step;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            position.z += step;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.z -= step;
        }
        transform.position = position;
        
    }
}
