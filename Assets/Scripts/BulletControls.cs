using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControls : MonoBehaviour
{
    public GameObject cube;
    public GameObject capsule;
    public GameObject sphere;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedWall")
        {
            Destroy(gameObject);

            GameObject explosion1 = Instantiate(cube, transform.position, Quaternion.identity);
            GameObject explosion2 = Instantiate(sphere, transform.position, Quaternion.identity);
            GameObject explosion3 = Instantiate(capsule, transform.position, Quaternion.identity);

            Destroy(explosion1, 2f);
            Destroy(explosion2, 2f);
            Destroy(explosion3, 2f);

        }
    }
}
