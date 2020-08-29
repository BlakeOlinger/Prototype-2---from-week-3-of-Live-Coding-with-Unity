using UnityEngine;

public class DestroyPosition : MonoBehaviour
{
    public float zPosition;
    public bool isLowerBounds;

    // Update is called once per frame
    void Update()
    {
        // Destroy object on z position check out of range
        {
            if (!isLowerBounds)
            {
                if (transform.position.z > zPosition)
                    Destroy(gameObject);
            }
            else
            {
                if (transform.position.z < zPosition)
                    Destroy(gameObject);
            }
        }
    }
}
