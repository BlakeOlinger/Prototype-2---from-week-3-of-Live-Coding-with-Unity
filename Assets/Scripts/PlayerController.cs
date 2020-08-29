using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float playerBounds;

    private float horizontalInput;
    private Transform tempTransform;

    // Called before first frame update
    private void Start()
    {
        // init temp transform
        {
            tempTransform = new GameObject().transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Move player right/left
         * 
         * Constraints: resulting translate must be within editor-defined bounds
         * 
         * Tests resulting translate on a test-only Transform object and applies
         *  only if result would be in-bounds
         */
        {
            horizontalInput = Input.GetAxis("Horizontal");
            tempTransform.position = transform.position;
            tempTransform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
            if (tempTransform.position.x > -playerBounds &&
                tempTransform.position.x < playerBounds)
            {
                transform.position = tempTransform.position;
            }
        }
    }
}
