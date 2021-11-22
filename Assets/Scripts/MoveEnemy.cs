using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    public float EnemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Ylim‰‰r‰inen kommentti githubia varten
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * EnemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Debug.Log("Osuu");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Score.score++;
        }
    }
}
