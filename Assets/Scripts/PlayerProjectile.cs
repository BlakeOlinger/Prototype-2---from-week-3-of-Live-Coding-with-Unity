using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject projectile;
    public KeyCode fireKey;
    public float zOffset;
    public float delay;
    public bool rapidFire;
    private float delayReset;
    private float curDelay;
    private bool canFire = true;

    // Called before first frame update
    private void Start()
    {
        delayReset = delay;
        curDelay = delay;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Fire speed delay
         */
        {
            // so the countdown is happening when the player can already fire
            // if so this leads to firing off-tempo for the first shot
            if (!canFire)
                curDelay -= Time.deltaTime;

            if (curDelay <= 0)
            {
                canFire = true;
                curDelay = delayReset;
            }
        }

        /*
         * On key down spawn and launch projectile
         */
        {
            if (rapidFire)
            {
                if (Input.GetKey(fireKey) && canFire)
                {
                    projectile.transform.position = new Vector3(transform.position.x,
                       transform.position.y, transform.position.z + zOffset);
                    Instantiate(projectile);

                    canFire = false;
                }
            }
            else
            {
                if (Input.GetKeyDown(fireKey) && canFire)
                {
                    projectile.transform.position = new Vector3(transform.position.x,
                      transform.position.y, transform.position.z + zOffset);  
                    Instantiate(projectile);

                    canFire = false;
                }
            }
        }
    }
}
