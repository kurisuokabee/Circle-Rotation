using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotationSpeed *= -1; //changes rotation direction
        }

        //rotate the object at z-axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
    
}
