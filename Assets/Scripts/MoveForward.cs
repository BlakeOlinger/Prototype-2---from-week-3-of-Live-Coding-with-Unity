using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // translate position based on speed
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
